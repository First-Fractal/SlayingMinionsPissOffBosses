using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace SlayingMinionsPissOffBosses
{
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
            caller.Reply(message, Color.SeaGreen);
        }
    }

    //the same thing as the previous command, but the trigger is aberration
    internal class bossaberrationCommand : bossAbbrCommand
    {
        public override string Command => "aberration";
    }

    internal class BossEnrageCommand : ModCommand
    {
        //make the command run on all sides, since it's client side
        public override CommandType Type => CommandType.Chat;

        //the start of the command
        public override string Command => "enrage";

        //explain on what the command does
        public override string Description => Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.desc", Command);

        //explain on how to use the command
        public override string Usage => Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.usage", Command);

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            //check if the boss argument is missing
            if (args.Length == 0)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.no_boss"));

            //check if the action argument is missing
            if (args.Length == 1)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.no_action"));

            //check if there is too many arguments
            if (args.Length > 2)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.many_commands"));

            //get all of the arguments
            string bossName = args[0].ToLower().Trim();
            string action = args[1].ToLower().Trim();

            //get the boss ready
            PissedOffBoss boss = null;

            //loop through all of the bosses
            foreach (PissedOffBoss bossCheck in BossMinionTracker.allBosses)
            {
                //ignore the current boss if it dosent exist
                if (bossCheck == null)
                    continue;

                //save the boss if the boss name match the current boss name or aberration
                if (bossName == bossCheck.name.Replace(" ", "_").ToLower().Trim() || bossName == bossCheck.abbr.ToLower().Trim())
                    boss = bossCheck;
            }

            //if no boss was found, then throw an error
            if (boss == null)
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.invalid_boss", bossName));


            //check if the action command match the info action
            if (action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_info").ToLower().Trim() || 
                action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_stat").ToLower().Trim() ||
                action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_stats").ToLower().Trim())
            {
                //create a dummy npc from the boss type
                NPC npc = new NPC();
                npc.SetDefaults_ForNetId(boss.type, 0);

                //calculate it's new life and damage
                int enrageHP = npc.lifeMax + MinionSlayPissOff.EnrangeHPFormula(boss.enrage, npc.lifeMax);
                int enrageDam = npc.damage + MinionSlayPissOff.EnrangeDamageFormula(boss.enrage, npc.damage);

                //prepare the message to send back
                string message = string.Format(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.stats", 
                                    npc.FullName, enrageHP, enrageDam));

                //send the message to the player
                caller.Reply(message, Color.LightGreen);
            } 
            else if (action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_kill").ToLower().Trim() ||
                action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_count").ToLower().Trim() ||
                action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_kill_count").ToLower().Trim() ||
                action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_killCount").ToLower().Trim())
            {
                //create a dummy npc from the boss type
                NPC npc = new NPC();
                npc.SetDefaults_ForNetId(boss.type, 0);

                //prepare the message to send back
                string message = string.Format(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.kill",
                                    boss.killCount, npc.FullName));

                //send the message to the player
                caller.Reply(message, Color.LightGreen);
            }
            else if (action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_minion").ToLower().Trim() ||
                     action == Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.action_minions").ToLower().Trim())
            {
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

                    //send the message to the player
                    caller.Reply(line, Color.LawnGreen);
                }
            } else
            {
                throw new UsageException(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.command.invalid_action", action));
            }
        }
    }


    //the same thing as the previous command, but the trigger is boss
    internal class BossBossCommand : BossEnrageCommand
    {
        public override string Command => "boss";
    }
}
