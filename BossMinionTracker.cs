using Ionic.Zlib;
using System.IO.Pipelines;
using Terraria.GameContent.RGB;
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



        //store a list of all of the minions for the Queen Slime
        PissedOffBoss QueenSlime = new PissedOffBoss(NPCID.QueenSlimeBoss);
        void defineQueenSlimeMinions(ref PissedOffBoss QueenSlime)
        {
            QueenSlime.minions.Add([0.1, NPCID.QueenSlimeMinionBlue, 
                        NPCID.QueenSlimeMinionPink, NPCID.QueenSlimeMinionPurple]);

            QueenSlime.minions.Add([0.2, NPCID.SlimeSpiked]);

            QueenSlime.minions.Add([0.25, NPCID.GreenSlime, NPCID.BlueSlime, NPCID.RedSlime, NPCID.PurpleSlime, NPCID.YellowSlime,
                NPCID.BlackSlime]);

            QueenSlime.minions.Add([0.5, NPCID.IceSlime, NPCID.SpikedIceSlime, NPCID.SandSlime,
                        NPCID.JungleSlime, NPCID.JungleSlime, NPCID.MotherSlime, NPCID.BabySlime, NPCID.LavaSlime, NPCID.ShimmerSlime,
                        NPCID.BigSlimedZombie, NPCID.SmallSlimedZombie, NPCID.SlimedZombie, NPCID.SlimeMasked]);

            QueenSlime.minions.Add([0.75, NPCID.DungeonSlime, NPCID.UmbrellaSlime]);

            QueenSlime.minions.Add([1.0, NPCID.CorruptSlime, NPCID.Slimeling, NPCID.Slimer, NPCID.Slimer2, NPCID.BigCrimslime, 
                        NPCID.LittleCrimslime, NPCID.ToxicSludge]);

            QueenSlime.minions.Add([1.1, NPCID.Gastropod, NPCID.IlluminantSlime]);

            QueenSlime.minions.Add([1.2, NPCID.Pinky, NPCID.GoldenSlime, NPCID.RainbowSlime]);
        }


        //store a list of all of the minions for The Twins
        PissedOffBoss Retinazer = new PissedOffBoss(NPCID.Retinazer);
        PissedOffBoss Spazmatism = new PissedOffBoss(NPCID.Spazmatism);
        void defineTwinsMinions(ref PissedOffBoss Twins)
        {
            Twins.minions.Add([0.2, NPCID.ServantofCthulhu]);

            Twins.minions.Add([0.5, NPCID.DemonEye2, NPCID.PurpleEye2, NPCID.GreenEye2, NPCID.DialatedEye2, NPCID.SleepyEye2, 
                NPCID.CataractEye2, NPCID.DemonEye, NPCID.CataractEye, NPCID.SleepyEye, NPCID.GreenEye, NPCID.PurpleEye, NPCID.DialatedEye, 
                NPCID.DemonEyeOwl, NPCID.DemonEyeSpaceship]);

            Twins.minions.Add([1, NPCID.Mimic, NPCID.PossessedArmor, NPCID.CrimsonAxe, NPCID.CursedHammer, NPCID.EnchantedSword, 
                NPCID.PresentMimic, NPCID.WanderingEye]);

            Twins.minions.Add([1.5, NPCID.BigMimicCorruption, NPCID.BigMimicCrimson, NPCID.BigMimicHallow, NPCID.BigMimicJungle]);
        }


        //store a list of all of the minions for The Destroyer
        PissedOffBoss DestroyerHead = new PissedOffBoss(NPCID.TheDestroyer, Worm:true);
        PissedOffBoss DestroyerBody = new PissedOffBoss(NPCID.TheDestroyerBody, Worm:true);
        PissedOffBoss DestroyerTail = new PissedOffBoss(NPCID.TheDestroyerTail, Worm:true);
        PissedOffBoss Probe = new PissedOffBoss(NPCID.Probe, Parts:true);
        void defineDestroyerMinions(ref PissedOffBoss Destroyer)
        {
            Destroyer.minions.Add([0.1, NPCID.Probe, NPCID.Creeper]);

            Destroyer.minions.Add([0.5, NPCID.BigEater, NPCID.LittleEater, NPCID.EaterofSouls, NPCID.DevourerHead, NPCID.DevourerBody, 
                NPCID.DevourerTail, NPCID.BigCrimera, NPCID.LittleCrimera, NPCID.BloodCrawler, NPCID.BloodCrawlerWall, NPCID.FaceMonster]);

            Destroyer.minions.Add([1.0, NPCID.Mimic, NPCID.PossessedArmor, NPCID.CrimsonAxe, NPCID.CursedHammer, NPCID.EnchantedSword, 
                NPCID.PresentMimic, NPCID.Corruptor, NPCID.SeekerHead, NPCID.SeekerBody, NPCID.SeekerTail, NPCID.Clinger, 
                NPCID.CorruptSlime, NPCID.Slimeling, NPCID.Slimer, NPCID.Slimer2, NPCID.FloatyGross, NPCID.Crimslime, NPCID.Herpling, 
                NPCID.IchorSticker]);

            Destroyer.minions.Add([1.25,
                NPCID.CorruptGoldfish, NPCID.DarkMummy, NPCID.CursedHammer, NPCID.CorruptBunny, NPCID.SandsharkCorrupt, 
                NPCID.PigronCorruption, NPCID.BloodFeeder, NPCID.BigMimicCrimson, NPCID.BloodMummy, NPCID.CrimsonAxe, 
                NPCID.PigronCrimson, NPCID.SandsharkCrimson]);

            Destroyer.minions.Add([1.5, NPCID.BigMimicCorruption, NPCID.BigMimicCrimson, NPCID.BigMimicHallow, NPCID.BigMimicJungle]);
        }


        //store a list of all of the minions for Skeletron Prime
        PissedOffBoss SkeletronPrime = new PissedOffBoss(NPCID.SkeletronPrime);
        PissedOffBoss SkeletronPrimeCannon = new PissedOffBoss(NPCID.PrimeCannon, Parts:true);
        PissedOffBoss SkeletronPrimeSaw = new PissedOffBoss(NPCID.PrimeSaw, Parts:true);
        PissedOffBoss SkeletronPrimeVice = new PissedOffBoss(NPCID.PrimeVice, Parts:true);
        PissedOffBoss SkeletronPrimeLaser = new PissedOffBoss(NPCID.PrimeLaser, Parts:true);
        void defineSkeletronPrimeMinions(ref PissedOffBoss SkeletronPrime)
        {
            SkeletronPrime.minions.Add([0.35, NPCID.PrimeCannon, NPCID.PrimeSaw, NPCID.PrimeVice, NPCID.PrimeLaser]);

            SkeletronPrime.minions.Add([0.5, NPCID.BigPantlessSkeleton, NPCID.SmallPantlessSkeleton, NPCID.BigMisassembledSkeleton,
                NPCID.SmallMisassembledSkeleton, NPCID.BigHeadacheSkeleton, NPCID.SmallHeadacheSkeleton, NPCID.BigSkeleton,
                NPCID.SmallSkeleton, NPCID.HeavySkeleton, NPCID.Skeleton, NPCID.UndeadMiner, NPCID.HeadacheSkeleton, 
                NPCID.MisassembledSkeleton, NPCID.PantlessSkeleton, NPCID.BoneThrowingSkeleton, NPCID.BoneThrowingSkeleton2, 
                NPCID.BoneThrowingSkeleton3, NPCID.BoneThrowingSkeleton, NPCID.SkeletronHand, NPCID.SkeletonAstonaut, 
                NPCID.SkeletonAlien, NPCID.SkeletonTopHat]);

            SkeletronPrime.minions.Add([1.0, NPCID.Mimic, NPCID.PossessedArmor, NPCID.CrimsonAxe, NPCID.CursedHammer, NPCID.EnchantedSword, 
                NPCID.PresentMimic, NPCID.BigBoned, NPCID.ShortBones, NPCID.AngryBones, NPCID.DarkCaster, NPCID.CursedSkull, 
                NPCID.AngryBonesBig, NPCID.AngryBonesBigMuscle, NPCID.AngryBonesBigHelmet, NPCID.GreekSkeleton]);

            SkeletronPrime.minions.Add([1.25,  NPCID.Tim, NPCID.RuneWizard, NPCID.ArmoredSkeleton, NPCID.SkeletonArcher]);

            SkeletronPrime.minions.Add([1.5, NPCID.BigMimicCorruption, NPCID.BigMimicCrimson, NPCID.BigMimicHallow, NPCID.BigMimicJungle]);

            SkeletronPrime.minions.Add([1000, NPCID.DungeonGuardian]);
        }


        //store a list of all of the minions for Plantera
        PissedOffBoss Plantera = new PissedOffBoss(NPCID.Plantera);
        void definePlanteraMinions(ref PissedOffBoss Plantera)
        {
            Plantera.minions.Add([0.2, NPCID.Bee, NPCID.BeeSmall]);

            Plantera.minions.Add([0.5, NPCID.BigHornetStingy, NPCID.LittleHornetStingy, NPCID.BigHornetSpikey, NPCID.LittleHornetSpikey, 
                NPCID.BigHornetLeafy, NPCID.LittleHornetLeafy, NPCID.BigHornetHoney, NPCID.LittleHornetHoney, NPCID.BigHornetFatty, 
                NPCID.LittleHornetFatty, NPCID.BigStinger, NPCID.LittleStinger, NPCID.HornetFatty, NPCID.HornetHoney, NPCID.HornetLeafy,
                NPCID.HornetSpikey, NPCID.HornetStingy, NPCID.Piranha, NPCID.JungleBat, NPCID.JungleSlime, NPCID.SpikedJungleSlime, 
                NPCID.ManEater]);

            Plantera.minions.Add([1.0, NPCID.JungleCreeper, NPCID.JungleCreeperWall, NPCID.AngryTrapper, NPCID.Arapaima, NPCID.GiantTortoise, 
                NPCID.GiantFlyingFox, NPCID.Snatcher, NPCID.Derpling]);

            Plantera.minions.Add([1.25, NPCID.DoctorBones, NPCID.Moth]);
        }


        //store a list of all of the minions for Golem
        PissedOffBoss Golem = new PissedOffBoss(NPCID.Golem);
        PissedOffBoss GolemFistLeft = new PissedOffBoss(NPCID.GolemFistLeft, Parts:true);
        PissedOffBoss GolemFistRight = new PissedOffBoss(NPCID.GolemFistRight, Parts:true);
        PissedOffBoss GolemHead = new PissedOffBoss(NPCID.GolemHead, Parts:true);
        PissedOffBoss GolemHeadFree = new PissedOffBoss(NPCID.GolemHeadFree, Parts:true);
        void defineGolemMinions(ref PissedOffBoss Golem)
        {
            Golem.minions.Add([1, NPCID.GolemHead, NPCID.GolemHeadFree, NPCID.GolemFistLeft, NPCID.GolemFistRight]);
            Golem.minions.Add([1.25, NPCID.Lihzahrd, NPCID.LihzahrdCrawler, NPCID.FlyingSnake]);
        }


        //store a list of all of the minions for Duke Fishron
        PissedOffBoss DukeFishron = new PissedOffBoss(NPCID.DukeFishron);
        void defineDukeFishronMinions(ref PissedOffBoss DukeFishron)
        {
            DukeFishron.minions.Add([0.3, NPCID.Sharkron, NPCID.Sharkron2]);

            DukeFishron.minions.Add([1, NPCID.BlueJellyfish, NPCID.PinkJellyfish, NPCID.Crab, NPCID.AngryNimbus, 
                NPCID.FlyingFish, NPCID.EyeballFlyingFish, NPCID.ZombieMerman]);

            DukeFishron.minions.Add([1.25,  NPCID.BloodJelly, NPCID.BloodFeeder, NPCID.GoldfishWalker, NPCID.SeaSnail, NPCID.Duck, 
                NPCID.Duck2, NPCID.DuckWhite, NPCID.DuckWhite2, NPCID.Dolphin, NPCID.Seagull, NPCID.Seagull2, NPCID.SeaTurtle, 
                NPCID.Seahorse, NPCID.BloodSquid, NPCID.GoblinShark, NPCID.BloodEelHead, NPCID.BloodEelBody, NPCID.BloodEelTail]);

            DukeFishron.minions.Add([1.5,  NPCID.Shark, NPCID.PigronCrimson, NPCID.PigronCorruption, NPCID.PigronHallow]);

            DukeFishron.minions.Add([1.75, NPCID.TruffleWorm, NPCID.TruffleWormDigger, NPCID.Angler, NPCID.SleepingAngler, NPCID.Squid, 
                NPCID.GoldSeahorse, NPCID.BloodNautilus]);
        }


        //store a list of all of the minions for Empress of Light
        PissedOffBoss EoL = new PissedOffBoss(NPCID.HallowBoss);
        void defineEmpressofLightMinions(ref PissedOffBoss EoL)
        {
            EoL.minions.Add([0.5, NPCID.EmpressButterfly]);

            EoL.minions.Add([1, NPCID.Unicorn, NPCID.ChaosElemental, NPCID.Pixie, NPCID.Gastropod, NPCID.IlluminantBat, NPCID.IlluminantSlime]);

            EoL.minions.Add([1.25, NPCID.LightMummy, NPCID.EnchantedSword, NPCID.LightningBug, NPCID.Firefly]);

            EoL.minions.Add([1.5, NPCID.BigMimicHallow, NPCID.SandsharkHallow, NPCID.RainbowSlime]);

            EoL.minions.Add([1.75, NPCID.FairyCritterPink, NPCID.FairyCritterGreen, NPCID.FairyCritterBlue, NPCID.Butterfly]);
        }


        //store a list of all of the minions for Lunatic Cultist
        PissedOffBoss LunaticCultist = new PissedOffBoss(NPCID.CultistBoss);
        PissedOffBoss LunaticCultistClone = new PissedOffBoss(NPCID.CultistBossClone, Parts:true);
        void defineLunaticCultistMinions(ref PissedOffBoss Cultist)
        {
            Cultist.minions.Add([0.25, NPCID.BigBoned, NPCID.ShortBones, NPCID.AngryBones, NPCID.DarkCaster, NPCID.CursedSkull, 
                NPCID.AngryBonesBig, NPCID.AngryBonesBigMuscle, NPCID.AngryBonesBigHelmet]);

            Cultist.minions.Add([0.5,  NPCID.RustyArmoredBonesAxe, NPCID.RustyArmoredBonesFlail, NPCID.RustyArmoredBonesSword, 
                NPCID.RustyArmoredBonesSwordNoArmor, NPCID.BlueArmoredBones, NPCID.BlueArmoredBonesMace, NPCID.BlueArmoredBonesNoPants, 
                NPCID.BlueArmoredBonesSword, NPCID.HellArmoredBones, NPCID.HellArmoredBonesSpikeShield, NPCID.HellArmoredBonesMace, 
                NPCID.HellArmoredBonesSword, NPCID.RaggedCaster, NPCID.RaggedCasterOpenCoat, NPCID.Necromancer, NPCID.NecromancerArmored, 
                NPCID.DiabolistRed, NPCID.DiabolistWhite, NPCID.DungeonSpirit, NPCID.GiantCursedSkull]);

            Cultist.minions.Add([0.75, NPCID.Paladin, NPCID.BoneLee, NPCID.SkeletonCommando, NPCID.TacticalSkeleton, NPCID.SkeletonSniper]);

            Cultist.minions.Add([1, NPCID.CultistArcherBlue, NPCID.CultistArcherWhite, NPCID.CultistDevote]);
        }
        


        PissedOffBoss MoonLord = new PissedOffBoss(NPCID.MoonLordCore);
        PissedOffBoss MoonLordFreeEye = new PissedOffBoss(NPCID.MoonLordFreeEye, Parts:true);
        PissedOffBoss MoonLordHand = new PissedOffBoss(NPCID.MoonLordHand, Parts: true);
        PissedOffBoss MoonLordHead = new PissedOffBoss(NPCID.MoonLordHead, Parts: true);
        void defineMoonLordMinions(ref PissedOffBoss MoonLord)
        {
            MoonLord.minions.Add([0.01, NPCID.BrainScrambler, NPCID.RayGunner, NPCID.MartianOfficer, NPCID.GrayGrunt, 
                NPCID.MartianEngineer, NPCID.MartianTurret, NPCID.MartianDrone, NPCID.GigaZapper, NPCID.ScutlixRider, NPCID.Scutlix, 
                NPCID.MartianSaucer, NPCID.MartianSaucerCore, NPCID.StardustWormHead, NPCID.StardustWormBody, NPCID.StardustWormTail, 
                NPCID.StardustCellBig, NPCID.StardustCellSmall, NPCID.StardustJellyfishBig, NPCID.StardustSpiderBig, 
                NPCID.StardustSpiderSmall, NPCID.StardustSoldier, NPCID.SolarCrawltipedeHead, NPCID.SolarCrawltipedeBody, 
                NPCID.SolarCrawltipedeTail, NPCID.SolarDrakomire, NPCID.SolarDrakomireRider, NPCID.SolarSroller, NPCID.SolarCorite, 
                NPCID.SolarSolenian, NPCID.NebulaBrain, NPCID.NebulaHeadcrab, NPCID.NebulaBeast, NPCID.NebulaSoldier, NPCID.VortexRifleman, 
                NPCID.VortexHornetQueen, NPCID.VortexHornet, NPCID.VortexLarva, NPCID.VortexSoldier, NPCID.SolarSpearman]);
        }

        //variable for storing the list of bosses
        public static PissedOffBoss[] allBosses = new PissedOffBoss[50];

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


            defineQueenBeeMinions(ref QueenSlime);
            allBosses[12] = QueenSlime;

            defineTwinsMinions(ref Retinazer);
            defineTwinsMinions(ref Spazmatism);
            allBosses[13] = Retinazer;
            allBosses[14] = Spazmatism;

            defineDestroyerMinions(ref DestroyerHead);
            defineDestroyerMinions(ref DestroyerBody);
            defineDestroyerMinions(ref DestroyerTail);
            defineDestroyerMinions(ref Probe);
            allBosses[15] = DestroyerHead; 
            allBosses[16] = DestroyerBody; 
            allBosses[17] = DestroyerTail; 
            allBosses[18] = Probe;

            defineSkeletronPrimeMinions(ref SkeletronPrime);
            defineSkeletronPrimeMinions(ref SkeletronPrimeCannon);
            defineSkeletronPrimeMinions(ref SkeletronPrimeSaw);
            defineSkeletronPrimeMinions(ref SkeletronPrimeVice);
            defineSkeletronPrimeMinions(ref SkeletronPrimeLaser);
            allBosses[19] = SkeletronPrime;
            allBosses[20] = SkeletronPrimeCannon;
            allBosses[21] = SkeletronPrimeSaw;
            allBosses[22] = SkeletronPrimeVice;
            allBosses[23] = SkeletronPrimeLaser;

            definePlanteraMinions(ref Plantera);
            allBosses[24] = Plantera;

            defineGolemMinions(ref Golem);
            defineGolemMinions(ref GolemFistLeft);
            defineGolemMinions(ref GolemFistRight);
            defineGolemMinions(ref GolemHead);
            defineGolemMinions(ref GolemHeadFree);
            allBosses[25] = Golem;
            allBosses[26] = GolemFistLeft;
            allBosses[27] = GolemFistRight;
            allBosses[28] = GolemHead;
            allBosses[29] = GolemHeadFree;

            defineDukeFishronMinions(ref DukeFishron);
            allBosses[30] = DukeFishron;

            defineEmpressofLightMinions(ref EoL);
            allBosses[31] = EoL;

            defineLunaticCultistMinions(ref LunaticCultist);
            defineLunaticCultistMinions(ref LunaticCultistClone);
            allBosses[32] = LunaticCultist;
            allBosses[33] = LunaticCultistClone;

            defineMoonLordMinions(ref MoonLord);
            defineMoonLordMinions(ref MoonLordFreeEye);
            defineMoonLordMinions(ref MoonLordHand);
            defineMoonLordMinions(ref MoonLordHead);
            allBosses[34] = MoonLord;
            allBosses[35] = MoonLordFreeEye;
            allBosses[36] = MoonLordHand;
            allBosses[37] = MoonLordHead;

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

            QueenSlime = null;
            Retinazer = null;
            Spazmatism = null;
            DestroyerHead = null;
            DestroyerBody = null;
            DestroyerTail = null;
            Probe = null;
            SkeletronPrime = null;
            SkeletronPrimeCannon = null;
            SkeletronPrimeSaw = null;
            SkeletronPrimeVice = null;
            SkeletronPrimeLaser = null;
            Plantera = null;
            Golem = null;
            GolemFistLeft = null;
            GolemFistRight = null;
            GolemHead = null;
            GolemHeadFree = null;
            DukeFishron = null;
            EoL = null;
            LunaticCultist = null;
            LunaticCultistClone = null;
            MoonLord = null;
            MoonLordFreeEye = null;
            MoonLordHand = null;
            MoonLordHead = null;

            allBosses = null;
        }
    }
}
