using Terraria.ID;
using Terraria.ModLoader;

namespace SlayingMinionsPissOffBosses
{
    internal class BossMinionTracker : ModSystem
    {
        //store a list of all of the minions for King Slime
        PissedOffBoss KingSlime = new PissedOffBoss(NPCID.KingSlime);
        void defineKingSlimeMinions(ref PissedOffBoss KingSlime)
        {
            KingSlime.minions.Add([0.1, NPCID.SlimeSpiked]);

            KingSlime.minions.Add([0.5, NPCID.GreenSlime, NPCID.BlueSlime, NPCID.RedSlime, NPCID.PurpleSlime, NPCID.YellowSlime, 
                NPCID.BlackSlime, NPCID.BabySlime]);

            KingSlime.minions.Add([1.0, NPCID.IceSlime, NPCID.SpikedIceSlime, NPCID.SandSlime,
                        NPCID.JungleSlime, NPCID.JungleSlime, NPCID.MotherSlime, NPCID.BabySlime, NPCID.LavaSlime, NPCID.ShimmerSlime,
                        NPCID.BigSlimedZombie, NPCID.SmallSlimedZombie, NPCID.SlimedZombie, NPCID.SlimeMasked]);

            KingSlime.minions.Add([1.1, NPCID.CorruptSlime, NPCID.Slimeling, NPCID.Slimer, NPCID.Slimer2, NPCID.BigCrimslime, 
                        NPCID.LittleCrimslime, NPCID.ToxicSludge,NPCID.Gastropod, NPCID.IlluminantSlime, NPCID.QueenSlimeMinionBlue, 
                        NPCID.QueenSlimeMinionPink, NPCID.QueenSlimeMinionPurple]);

            KingSlime.minions.Add([1.2, NPCID.DungeonSlime, NPCID.UmbrellaSlime]);

            KingSlime.minions.Add([1.3, NPCID.Pinky, NPCID.GoldenSlime, NPCID.RainbowSlime]);

        }


        //store a list of all of the minions for Eye of Cthulhu
        PissedOffBoss EoC = new PissedOffBoss(NPCID.EyeofCthulhu);
        void defineEoCMinions(ref PissedOffBoss EoC)
        {
            EoC.minions.Add([0.1, NPCID.ServantofCthulhu]);

            EoC.minions.Add([1.0,
                NPCID.DemonEye2, NPCID.PurpleEye2, NPCID.GreenEye2, NPCID.DialatedEye2, NPCID.SleepyEye2, NPCID.CataractEye2, 
                NPCID.DemonEye, NPCID.CataractEye, NPCID.SleepyEye, NPCID.GreenEye, NPCID.PurpleEye, NPCID.DialatedEye, 
                NPCID.DemonEyeOwl, NPCID.DemonEyeSpaceship]);

            EoC.minions.Add([1.25, NPCID.WanderingEye]);
        }


        //store a list of all of the minions for Eater of Worlds
        PissedOffBoss EoWHead = new PissedOffBoss(NPCID.EaterofWorldsHead, Worm:true);
        PissedOffBoss EoWBody = new PissedOffBoss(NPCID.EaterofWorldsBody, Worm:true);
        PissedOffBoss EoWTail = new PissedOffBoss(NPCID.EaterofWorldsTail, Worm:true);
        void defineEoWMinions(ref PissedOffBoss EoW)
        {
            EoW.minions.Add([0.3,
                NPCID.DevourerHead, NPCID.DevourerBody, NPCID.DevourerTail]);

            EoW.minions.Add([1.0,
                NPCID.BigEater, NPCID.LittleEater, NPCID.EaterofSouls]);

            EoW.minions.Add([1.05,
                NPCID.SeekerHead, NPCID.SeekerBody, NPCID.SeekerTail]);

            EoW.minions.Add([1.15,
                NPCID.Corruptor, NPCID.Clinger, NPCID.CorruptSlime, NPCID.Slimeling, NPCID.Slimer, NPCID.Slimer2]);

            EoW.minions.Add([1.25,
                NPCID.CorruptGoldfish, NPCID.BigMimicCorruption, NPCID.DarkMummy, NPCID.CursedHammer, NPCID.CorruptBunny, 
                NPCID.SandsharkCorrupt, NPCID.PigronCorruption]);
        }


        //store a list of all of the minions for Brain of Cthulhu
        PissedOffBoss BoC = new PissedOffBoss(NPCID.BrainofCthulhu);
        PissedOffBoss Creeper = new PissedOffBoss(NPCID.Creeper, Parts:true);
        void defineBoCMinions(ref PissedOffBoss BoC)
        {
            BoC.minions.Add([0.1, NPCID.Creeper]);

            BoC.minions.Add([1.0, NPCID.BigCrimera, NPCID.LittleCrimera, NPCID.BloodCrawler, NPCID.BloodCrawlerWall, NPCID.FaceMonster]);

            BoC.minions.Add([1.25, NPCID.FloatyGross, NPCID.Crimslime, NPCID.Herpling, NPCID.IchorSticker]);

            BoC.minions.Add([1.5, NPCID.BloodFeeder, NPCID.BigMimicCrimson, NPCID.BloodMummy, NPCID.CrimsonAxe, NPCID.PigronCrimson, 
                NPCID.SandsharkCrimson]);
        }


        //store a list of all of the minions for Queen Bee
        PissedOffBoss QueenBee = new PissedOffBoss(NPCID.QueenBee);
        void defineQueenBeeMinions(ref PissedOffBoss QueenBee)
        {
            QueenBee.minions.Add([0.1, NPCID.Bee, NPCID.BeeSmall]);

            QueenBee.minions.Add([1, NPCID.BigHornetStingy, NPCID.LittleHornetStingy, NPCID.BigHornetSpikey, NPCID.LittleHornetSpikey, 
                NPCID.BigHornetLeafy, NPCID.LittleHornetLeafy, NPCID.BigHornetHoney, NPCID.LittleHornetHoney, NPCID.BigHornetFatty, 
                NPCID.LittleHornetFatty, NPCID.BigStinger, NPCID.LittleStinger, NPCID.HornetFatty, NPCID.HornetHoney, NPCID.HornetLeafy, 
                NPCID.HornetSpikey, NPCID.HornetStingy]);

            QueenBee.minions.Add([1.25, NPCID.GiantMossHornet, NPCID.BigMossHornet, NPCID.LittleMossHornet, NPCID.TinyMossHornet, NPCID.MossHornet]);
        }


        //store a list of all of the minions for Skeletron
        PissedOffBoss Skeletron = new PissedOffBoss(NPCID.Skeleton);
        PissedOffBoss SkeletronHand = new PissedOffBoss(NPCID.Skeleton, Parts: true);
        void defineSkeletronMinions(ref PissedOffBoss Skeletron)
        {
            Skeletron.minions.Add([0.4, NPCID.Skeleton]);

            Skeletron.minions.Add([1.15, NPCID.BigPantlessSkeleton, NPCID.SmallPantlessSkeleton, NPCID.BigMisassembledSkeleton, 
                NPCID.SmallMisassembledSkeleton, NPCID.BigHeadacheSkeleton, NPCID.SmallHeadacheSkeleton, NPCID.BigSkeleton, 
                NPCID.SmallSkeleton, NPCID.HeavySkeleton, NPCID.Skeleton, NPCID.UndeadMiner, NPCID.HeadacheSkeleton, 
                NPCID.MisassembledSkeleton, NPCID.PantlessSkeleton, NPCID.BoneThrowingSkeleton, NPCID.BoneThrowingSkeleton2, 
                NPCID.BoneThrowingSkeleton3, NPCID.BoneThrowingSkeleton4]);

            Skeletron.minions.Add([1.25,NPCID.BigBoned, NPCID.ShortBones, NPCID.AngryBones, NPCID.DarkCaster, NPCID.CursedSkull, 
                NPCID.AngryBonesBig, NPCID.AngryBonesBigMuscle, NPCID.AngryBonesBigHelmet, NPCID.GreekSkeleton]);

            Skeletron.minions.Add([1.5,NPCID.Tim, NPCID.RuneWizard, NPCID.ArmoredSkeleton, NPCID.SkeletonArcher, NPCID.SkeletonAstonaut, 
                NPCID.SkeletonAlien, NPCID.SkeletonTopHat]);

            Skeletron.minions.Add([1000,NPCID.DungeonGuardian]);
        }


        //store a list of all of the minions for Deerclops
        PissedOffBoss Deerclops = new PissedOffBoss(NPCID.Deerclops);
        void defineDeerclopsMinions(ref PissedOffBoss Deerclops)
        {
            Deerclops.minions.Add([1, NPCID.IceSlime, NPCID.Penguin, NPCID.IceBat, NPCID.SnowFlinx, NPCID.SpikedIceSlime, NPCID.ArmoredViking, 
                NPCID.ZombieEskimo, NPCID.IceSlime, NPCID.Penguin, NPCID.ZombieEskimo, NPCID.UndeadViking]);

            Deerclops.minions.Add([1.25,
                NPCID.IceElemental, NPCID.IceMimic, NPCID.Wolf, NPCID.IceTortoise, NPCID.IcyMerman, NPCID.SnowmanGangsta, 
                NPCID.MisterStabby, NPCID.SnowBalla, NPCID.IceTortoise, NPCID.Wolf]);

            Deerclops.minions.Add([1.5,
                NPCID.CorruptPenguin, NPCID.CrimsonPenguin, NPCID.PigronCorruption, NPCID.PigronCrimson, NPCID.PigronHallow, NPCID.IceGolem]);
        }


        //store a list of all of the minions for the Wall of Flesh
        PissedOffBoss WoF = new PissedOffBoss(NPCID.WallofFlesh);
        PissedOffBoss WoFEye = new PissedOffBoss(NPCID.WallofFleshEye, Parts: true);
        void defineWallOfFleshMinions(ref PissedOffBoss WoF)
        {
            WoF.minions.Add([0.1, NPCID.TheHungry, NPCID.TheHungryII, NPCID.LeechHead, NPCID.LeechBody, NPCID.LeechTail]);
            WoF.minions.Add([1, NPCID.FireImp, NPCID.BoneSerpentHead, NPCID.BoneSerpentBody, NPCID.BoneSerpentTail, NPCID.Hellbat, 
                NPCID.Demon, NPCID.VoodooDemon, NPCID.LavaSlime]);

            WoF.minions.Add([1.5, NPCID.RedDevil]);
        }


        //variable for storing the list of bosses
        public static PissedOffBoss[] allBosses = new PissedOffBoss[30];

        //define all of the minions and the list of bosses
        public override void Load()
        {
            defineKingSlimeMinions(ref KingSlime);
            allBosses[0] = KingSlime;

            defineEoCMinions(ref EoC);
            allBosses[1] = EoC;

            defineEoWMinions(ref EoWHead);
            allBosses[2] = EoWHead;
            defineEoWMinions(ref EoWBody);
            allBosses[3] = EoWBody;
            defineEoWMinions(ref EoWTail);
            allBosses[4] = EoWTail;

            defineBoCMinions(ref BoC);
            defineBoCMinions(ref Creeper);
            allBosses[5] = BoC;
            allBosses[6] = Creeper;

            defineQueenBeeMinions(ref QueenBee);
            allBosses[7] = QueenBee;

            defineSkeletronMinions(ref Skeletron);
            allBosses[8] = Skeletron;

            defineDeerclopsMinions(ref Deerclops);
            allBosses[9] = Deerclops;

            defineDeerclopsMinions(ref WoF);
            defineWallOfFleshMinions(ref WoFEye);
            allBosses[10] = WoF;
            allBosses[11] = WoFEye;
        }

        //remove the definition for all of the bosses
        public override void Unload()
        {
            KingSlime = null;
            EoC = null;
            EoWHead = null;
            EoWBody = null;
            EoWTail = null;
            BoC = null;
            Creeper = null;
            QueenBee = null;
            Skeletron = null;
            SkeletronHand = null;
            Deerclops = null;
            WoF = null;
            WoFEye = null;

            allBosses = null;
        }
    }
}
