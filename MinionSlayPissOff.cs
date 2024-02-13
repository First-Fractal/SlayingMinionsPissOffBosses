using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SlayingMinionsPissOffBosses
{
    internal class MinionSlayPissOff : GlobalNPC
    {
        //formula for caculating the amount of hp to increase
        public static int EnrangeHPFormula(double enrage, int HP)
        {
            //get 1% of the health
            HP = (int) (HP * 0.01);

            //take the enrage factor, times it by 2.2, and then raise it to the power of 2
            int enrangeMulti = (int)Math.Pow(2.2 * enrage, 2);

            //combine the enrange multi with the hp
            return HP + enrangeMulti;
        }

        //formula for caculating the amount of damage to increase
        public static int EnrangeDamageFormula(double enrage, int damage)
        {
            //take 10% of the damage
            int dam = (int)(damage * 0.1);

            // multiply the damage by the enrange amount, and then divide it by 100
            dam = (int)((dam * enrage) / 100);

            //raise the new damage to the power of 2, and then round it down
            return (int)Math.Ceiling(Math.Pow(dam, 2));
        }

        //runs whenever an npc spawn in
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            //loop through all of the bosses stored
            foreach (PissedOffBoss boss in BossMinionTracker.allBosses)
            {
                //check if the boss exists
                if (boss != null)
                {
                    //check if the current npc is a boss
                    if (npc.type == boss.type)
                    {
                        //increase it's max hp
                        int moreLife = EnrangeHPFormula(boss.enrage, npc.lifeMax);

                        //decrease it if it's a worm part
                        if (boss.worm)
                            moreLife = (int)(moreLife*boss.wormModifier);

                        //apply the new life to the boss
                        npc.lifeMax += moreLife;
                        npc.life = npc.lifeMax;

                        //increase it's max damage
                        int moreDamage = EnrangeDamageFormula(boss.enrage, npc.damage);

                        //decrease it if it's a worm part
                        if (boss.worm)
                            moreDamage = (int)(moreDamage*boss.wormModifier);

                        //apply the new damage to the boss
                        npc.damage += moreDamage;
                    }
                }
            }

            base.OnSpawn(npc, source);
        }

        //runs whenever a npc dies
        public override void OnKill(NPC npc)
        {
            base.OnKill(npc);

            //loop through all of the bosses stored
            foreach (PissedOffBoss boss in BossMinionTracker.allBosses)
            {
                //check if the current boss exists
                if (boss != null)
                {
                    //loop through each level of minions in the boss
                    boss.minions.ForEach(level =>
                    {
                        //loop through each minion, but skips 0 cause that's where the multipiler's at
                        for (int i = 1; i < level.Length; i++)
                        {
                            //check if the current npc is on the list
                            if (npc.type == (short)level[i])
                            {
                                //increase the current boss enrage and kill count
                                boss.enrage += (double)level[0];
                                boss.killCount++;

                                //tell the server to update the info to all of the clients
                                if (Main.netMode == NetmodeID.Server)
                                    NetMessage.SendData(MessageID.WorldData);

                                //send a warning message for every 10'th minion kill
                                if (boss.killCount % 10 == 0)
                                {
                                    //get the npc
                                    NPC npc = new NPC();
                                    npc.SetDefaults_ForNetId(boss.type, 0);

                                    //send the warning to everyone
                                    ffFunc.Talk(Language.GetTextValue("Mods.SlayingMinionsPissOffBosses.warning", npc.FullName), Color.OrangeRed);
                                }
                                
                                //break the loop
                                break;
                            }
                        }
                    });
                }
            }
        }
    }
}
