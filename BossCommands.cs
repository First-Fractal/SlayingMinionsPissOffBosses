using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace SlayingMinionsPissOffBosses
{
    internal class BossMinionsCommand : ModCommand
    {
        //make the command run on all sides, since it's client side
        public override CommandType Type => CommandType.Chat;

        //the start of the command
        public override string Command => "minions";

        //explain on what the command does
        public override string Description => Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.minions.desc");

        //explain on how to use the command
        public override string Usage => Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.minions.usage", Command);


        //the trigger for the command
        public override void Action(CommandCaller caller, string input, string[] args)
        {
            //throw an error if the command is missing the boss
            if (args.Length < 1)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.minions.no_boss"));

            //throw an error if the command has too many arguments
            if (args.Length > 1)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.minions.too_much_parms"));

            //grab and format the boss command
            string bossCommand = args[0].Replace(" ", "_").ToLower().Trim();
            PissedOffBoss boss = null;

            //loop through all of the bosses
            foreach (PissedOffBoss enrageBoss in BossMinionTracker.allBosses)
            {
                //skip the current boss if it's empty
                if (enrageBoss == null)
                    continue;

                //get the boss name and format it 
                string bossName = enrageBoss.name.Replace(" ", "_").ToLower().Trim();

                //check if the boss command fits the name or the abbr
                if (bossCommand == bossName || bossCommand == enrageBoss.abbr.ToLower().Trim())
                    boss = enrageBoss;
            }

            //throw an error if no boss is founded
            if (boss == null)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.minions.invalid_boss", bossCommand));

            //get the message ready to send
            string message = "";

            //loop through all levels of the boss minions
            foreach (object[] level in boss.minions)
            {
                //get the message ready for each level
                string line = "";
                List<int> minions = new List<int>();

                //loop through all of the contents in the level
                for (int j = 0; j < level.Length; j++)
                {
                    //the first content is the modifier
                    if (j == 0)
                        line += level[j].ToString() + "x: ";
                    else
                    {
                        //get the npc from the npc id
                        NPC npc = new NPC();
                        npc.SetDefaults_ForNetId((short)level[j], 0);

                        //add the minion to the list
                        line += NPCID.Search.GetName((short)level[j]);

                        //if it's not the last minion, then dont add in a comma
                        if (level[j] != level.Last())
                            line += ", ";
                    }
                }

                //add the line to the message
                message += line + "\n";
            }

            caller.Reply(message, Color.Green);
        }

    }

    //the same thing as the previous command, but the trigger is minion
    internal class bossMinionCommand : BossMinionsCommand
    {
        public override string Command => "minion";
    }

    internal class bossAbbrCommand : ModCommand
    {
        //make the command run on all sides, since it's client side
        public override CommandType Type => CommandType.Chat;

        //the start of the command
        public override string Command => "abbr";

        //explain on what the command does
        public override string Description => Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.abbr.desc");


        //the trigger for the command
        public override void Action(CommandCaller caller, string input, string[] args)
        {
            //setup a blank message
            string message = "";
            
            //loop through each boss
            foreach(PissedOffBoss boss in BossMinionTracker.allBosses)
            {
                //ignore the boss if it dosent exist
                if (boss == null)
                    continue;

                //append the boss with it's aberration
                message += string.Format("{0}:{1}\n", boss.name, boss.abbr);
            }

            //reply to the player with the aberration
            caller.Reply(message, Color.ForestGreen);
        }
    }

    //the same thing as the previous command, but the trigger is aberration
    internal class bossaberrationCommand : bossAbbrCommand
    {
        public override string Command => "aberration";
    }

}
