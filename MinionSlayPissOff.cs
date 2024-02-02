using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlayingMinionsPissOffBosses
{
    internal class MinionSlayPissOff : GlobalNPC
    {
        //formula for caculating the amount of hp to increase
        int EnrangeHPFormula(int enrage, int HP)
        {
            //get 1% of the health
            HP = (int) (HP * 0.01);

            //take the enrage factor, times it by 2.2, and then raise it to the power of 2
            int enrangeMulti = (int) Math.Pow(2.2 * enrage, 2);

            //combine the enrange multi with the hp
            return HP + enrangeMulti;
        }

        //formula for caculating the amount of damage to increase
        int EnrangeDamageFormula(int enrage, int damage)
        {
            //take 10% of the damage
            int dam = (int)(damage * 0.1);

            // multiply the damage by the enrange amount, and then divide it by 100
            dam = (int)((dam * enrage) / 100);

            //raise the new damage to the power of 2, and then round it down
            return (int) Math.Ceiling(Math.Pow(dam, 2));
        }

        //list of bosses to keep track of the enrange factor
        public static int[,] bossPissedOff = {
            { NPCID.KingSlime, 0}, { NPCID.EyeofCthulhu, 0}, { NPCID.EaterofWorldsHead, 0}, { NPCID.BrainofCthulhu, 0}, { NPCID.QueenBee, 0},
            { NPCID.SkeletronHead, 0}, { NPCID.Deerclops, 0}, { NPCID.WallofFlesh, 0}, { NPCID.QueenSlimeBoss, 0}, { NPCID.Spazmatism, 0},
            { NPCID.TheDestroyer, 0}, { NPCID.SkeletronPrime, 0}, { NPCID.Plantera, 0}, { NPCID.Golem, 0}, { NPCID.DukeFishron, 0},
            { NPCID.DukeFishron, 0}, { NPCID.HallowBoss, 0}, { NPCID.CultistBoss, 0}, { NPCID.MoonLordCore, 0}
        };

        //runs whenever an npc spawn in
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            //loop through each entry in the list
            for (int i = 0; i < bossPissedOff.GetLength(0); i++)
            {
                //check if the npc is a part of that list
                if (bossPissedOff[i, 0] == npc.type)
                {
                    ffFunc.Talk("Found a boss", Colors.RarityOrange);
                    int hpBefore = npc.lifeMax;
                    int damageBefore = npc.damage;

                    //get the enrage factor
                    int enrange = bossPissedOff[i, 1];

                    //increase it's max hp
                    npc.lifeMax += EnrangeHPFormula(enrange, npc.lifeMax);
                    npc.life = npc.lifeMax;

                    //increase it's max damage
                    npc.damage += EnrangeDamageFormula(enrange, npc.damage);

                    ffFunc.Talk($"HP BEFORE: {hpBefore}, HP AFTER: {npc.lifeMax}", Colors.RarityOrange);
                    ffFunc.Talk($"DAMAGE BEFORE: {damageBefore}, DAMAGE AFTER: {npc.damage}", Colors.RarityOrange);
                }
            }
            base.OnSpawn(npc, source);
        }

        //runs whenever a npc dies
        public override void OnKill(NPC npc)
        {
            //get each type of slime in the list
            foreach (int slime in ffVar.slimes.allSlimes)
            {
                //check if the current npc is a slime
                if (npc.type == slime)
                {
                    //increase the engrage factor
                    bossPissedOff[0, 1] += 1;
                    ffFunc.Talk("Kill Count for King Slime: " + bossPissedOff[0, 1].ToString(), Colors.RarityRed);
                    return;
                }
            }

            base.OnKill(npc);
        }
    }
}
