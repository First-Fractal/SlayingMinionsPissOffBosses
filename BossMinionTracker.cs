using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace SlayingMinionsPissOffBosses
{
    internal class BossMinionTracker : ModSystem
    {
        PissedOffBoss KingSlime = new PissedOffBoss(NPCID.KingSlime);
        void defineKingSlimeMinions(ref PissedOffBoss KingSlime)
        {
            KingSlime.minions.Add([0.5, NPCID.GreenSlime, NPCID.BlueSlime, NPCID.RedSlime, NPCID.PurpleSlime, NPCID.YellowSlime, 
                NPCID.BlackSlime, NPCID.SlimeSpiked, NPCID.BabySlime]);

            KingSlime.minions.Add([1.0, NPCID.IceSlime, NPCID.SpikedIceSlime, NPCID.SandSlime,
                        NPCID.JungleSlime, NPCID.JungleSlime, NPCID.MotherSlime, NPCID.BabySlime, NPCID.LavaSlime, NPCID.ShimmerSlime,
                        NPCID.BigSlimedZombie, NPCID.SmallSlimedZombie, NPCID.SlimedZombie, NPCID.SlimeMasked]);

            KingSlime.minions.Add([1.1, NPCID.CorruptSlime, NPCID.Slimeling, NPCID.Slimer, NPCID.Slimer2, NPCID.BigCrimslime, 
                        NPCID.LittleCrimslime, NPCID.ToxicSludge,NPCID.Gastropod, NPCID.IlluminantSlime, NPCID.QueenSlimeMinionBlue, 
                        NPCID.QueenSlimeMinionPink, NPCID.QueenSlimeMinionPurple]);

            KingSlime.minions.Add([1.2, NPCID.DungeonSlime, NPCID.UmbrellaSlime]);

            KingSlime.minions.Add([1.3, NPCID.Pinky, NPCID.GoldenSlime, NPCID.RainbowSlime]);

        }

        public static PissedOffBoss[] allBosses = new PissedOffBoss[30];

        public override void Load()
        {
            defineKingSlimeMinions(ref KingSlime);

            allBosses[0] = KingSlime;
        }

        public override void Unload()
        {
            KingSlime = null;

            allBosses = null;
        }
    }
}
