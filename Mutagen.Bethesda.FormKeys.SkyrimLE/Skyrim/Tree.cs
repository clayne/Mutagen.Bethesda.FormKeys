using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Tree
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITreeGetter> TreeReachTree01Winterhold => Construct(0x109716);
            public static FormLink<ITreeGetter> TreeReachTree01Magic => Construct(0xf64bf);
            public static FormLink<ITreeGetter> TreePineForestSnow01Dead => Construct(0xef5a5);
            public static FormLink<ITreeGetter> TreePineForestSnow02Dead => Construct(0xef5a4);
            public static FormLink<ITreeGetter> TreePineForestSnow03Dead => Construct(0xef5a3);
            public static FormLink<ITreeGetter> TreePineForestSnow04Dead => Construct(0xef5a2);
            public static FormLink<ITreeGetter> TreePineForestSnow05Dead => Construct(0xef5a1);
            public static FormLink<ITreeGetter> TreePineForestSnowL01Dead => Construct(0xef5a0);
            public static FormLink<ITreeGetter> TreePineForestSnowL02Dead => Construct(0xef59f);
            public static FormLink<ITreeGetter> TreePineForestSnowL03Dead => Construct(0xef59e);
            public static FormLink<ITreeGetter> TreePineForestSnowL04Dead => Construct(0xef59d);
            public static FormLink<ITreeGetter> TreePineForestSnowL05Dead => Construct(0xef59c);
            public static FormLink<ITreeGetter> TreeReachMntMossCover05 => Construct(0xe9626);
            public static FormLink<ITreeGetter> TreeReachMntMossCover04 => Construct(0xe9625);
            public static FormLink<ITreeGetter> TreeReachMntMossCover03 => Construct(0xe9624);
            public static FormLink<ITreeGetter> TreeReachMntMossCover02 => Construct(0xe9623);
            public static FormLink<ITreeGetter> TreeReachMntMossCover01 => Construct(0xe9622);
            public static FormLink<ITreeGetter> TreeWRTempleSapling01 => Construct(0x461d7);
            public static FormLink<ITreeGetter> TreeWRTemple02 => Construct(0x461c9);
            public static FormLink<ITreeGetter> TreeWRTemple01 => Construct(0x23611);
            public static FormLink<ITreeGetter> TreeBlackReachFern02 => Construct(0xe1ece);
            public static FormLink<ITreeGetter> TreeBlackReachFern01 => Construct(0xe1ecd);
            public static FormLink<ITreeGetter> TreeFloraSnowberry02 => Construct(0xdf015);
            public static FormLink<ITreeGetter> BlackreachBush02 => Construct(0xce102);
            public static FormLink<ITreeGetter> BlackreachBush01 => Construct(0xce101);
            public static FormLink<ITreeGetter> TreeFloraNightshade02 => Construct(0xc43b6);
            public static FormLink<ITreeGetter> TreeFloraNightshade01 => Construct(0xc43b0);
            public static FormLink<ITreeGetter> TestTreeFloraMountainFlower01Blue => Construct(0x8b5c4);
            public static FormLink<ITreeGetter> TreeReachTree01Snow => Construct(0x6b1b8);
            public static FormLink<ITreeGetter> TreeAspen04 => Construct(0x5fada);
            public static FormLink<ITreeGetter> TreeFloraLavender01 => Construct(0x1bb3d);
            public static FormLink<ITreeGetter> TreeGourdCluster01 => Construct(0xbe3e6);
            public static FormLink<ITreeGetter> TreeFloraSpikyGrass02 => Construct(0xbe3e1);
            public static FormLink<ITreeGetter> TreeFloraSpikyGrass01 => Construct(0xbe3e0);
            public static FormLink<ITreeGetter> TreeFloraCabbage01 => Construct(0xbcf48);
            public static FormLink<ITreeGetter> TreeFloraPotatoPlant01 => Construct(0xbcf47);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower02Blue => Construct(0xbcf3f);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower02Red => Construct(0xbcf3e);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower01Blue => Construct(0xbcf3d);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower01Red => Construct(0xbcf3c);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower01Purple => Construct(0xbcf3a);
            public static FormLink<ITreeGetter> TreeFloraSnowberry01Snow => Construct(0xbcf34);
            public static FormLink<ITreeGetter> TreeFloraSnowberry01 => Construct(0xbcf33);
            public static FormLink<ITreeGetter> FalmerDripAnim06 => Construct(0xbcca7);
            public static FormLink<ITreeGetter> FalmerDripAnim05 => Construct(0xbcca6);
            public static FormLink<ITreeGetter> FalmerDripAnim04 => Construct(0xbcca5);
            public static FormLink<ITreeGetter> FalmerDripAnim03 => Construct(0xbcca4);
            public static FormLink<ITreeGetter> FalmerDripAnim02 => Construct(0xbcca3);
            public static FormLink<ITreeGetter> FalmerDripAnim01 => Construct(0xbcca1);
            public static FormLink<ITreeGetter> TreeFloraWheat01 => Construct(0xbb953);
            public static FormLink<ITreeGetter> TreeFloraLeek01 => Construct(0xbb952);
            public static FormLink<ITreeGetter> TreeFloraHangingMoss03 => Construct(0xbb951);
            public static FormLink<ITreeGetter> TreeFloraHangingMoss02 => Construct(0xbb950);
            public static FormLink<ITreeGetter> TreeFloraHangingMoss01 => Construct(0xbb94f);
            public static FormLink<ITreeGetter> TreeFloraDragonsTongue02 => Construct(0xbb94e);
            public static FormLink<ITreeGetter> TreeFloraDragonsTongue01 => Construct(0xbb94d);
            public static FormLink<ITreeGetter> TreeFloraDeathBell02 => Construct(0xbb94c);
            public static FormLink<ITreeGetter> TreeFloraDeathBell01 => Construct(0xbb94b);
            public static FormLink<ITreeGetter> TreeFloraCanisRoot01 => Construct(0xbb94a);
            public static FormLink<ITreeGetter> TreeFloraJazBay01 => Construct(0xbb949);
            public static FormLink<ITreeGetter> TreeFloraJuniper01 => Construct(0xbb948);
            public static FormLink<ITreeGetter> TreeFloraTundraCotton01 => Construct(0xbb947);
            public static FormLink<ITreeGetter> TreePineForest05Dead => Construct(0xb927e);
            public static FormLink<ITreeGetter> TreePineForest04Dead => Construct(0xb927d);
            public static FormLink<ITreeGetter> TreePineForest03Dead => Construct(0xb927c);
            public static FormLink<ITreeGetter> TreePineForest02Dead => Construct(0xb927b);
            public static FormLink<ITreeGetter> TreePineForest01Dead => Construct(0xb927a);
            public static FormLink<ITreeGetter> TreeFloraMountainFlower02Purple => Construct(0xb91f8);
            public static FormLink<ITreeGetter> TreeFloraThistle01 => Construct(0xb91f0);
            public static FormLink<ITreeGetter> TreeTundraDriftWoodTree01 => Construct(0xb8f53);
            public static FormLink<ITreeGetter> TreeReachCliffTree02 => Construct(0xb8a77);
            public static FormLink<ITreeGetter> TreeReachCliffTree01 => Construct(0xb8a76);
            public static FormLink<ITreeGetter> TreeReachTreeStump01 => Construct(0xb8a75);
            public static FormLink<ITreeGetter> TreeReachTree02 => Construct(0xb8a74);
            public static FormLink<ITreeGetter> TreeReachTree01 => Construct(0xb8a73);
            public static FormLink<ITreeGetter> TreeKelpTallStatic01 => Construct(0xb8a72);
            public static FormLink<ITreeGetter> TreeKelpShortStatic01 => Construct(0xb8a71);
            public static FormLink<ITreeGetter> TreeReachFern03 => Construct(0xb8a70);
            public static FormLink<ITreeGetter> TreeReachFern02 => Construct(0xb8a6f);
            public static FormLink<ITreeGetter> TreeReachFern01 => Construct(0xb8a6e);
            public static FormLink<ITreeGetter> TreeFallForestFernCluster04 => Construct(0xb8a6d);
            public static FormLink<ITreeGetter> TreeFallForestFernCluster03 => Construct(0xb8a6c);
            public static FormLink<ITreeGetter> TreeFallForestFernCluster02 => Construct(0xb8a6b);
            public static FormLink<ITreeGetter> TreeFallForestFernCluster01 => Construct(0xb8a6a);
            public static FormLink<ITreeGetter> TreeReachBush02 => Construct(0xb8a69);
            public static FormLink<ITreeGetter> TreeSwordFernCluster06 => Construct(0xb8a68);
            public static FormLink<ITreeGetter> TreeSwordFernCluster05 => Construct(0xb8a67);
            public static FormLink<ITreeGetter> TreeSwordFernCluster04 => Construct(0xb8a66);
            public static FormLink<ITreeGetter> TreeSwordFernCluster03 => Construct(0xb8a65);
            public static FormLink<ITreeGetter> TreeSwordFernCluster02 => Construct(0xb8a64);
            public static FormLink<ITreeGetter> TreeClover01 => Construct(0xb8a62);
            public static FormLink<ITreeGetter> TreeSwordFernCluster01 => Construct(0xb8a59);
            public static FormLink<ITreeGetter> TreeReachBush01 => Construct(0xb8a57);
            public static FormLink<ITreeGetter> TreeSwordFern06 => Construct(0xb73c2);
            public static FormLink<ITreeGetter> TreeSwordFern05 => Construct(0xb73c0);
            public static FormLink<ITreeGetter> TreeSwordFern04 => Construct(0xb73be);
            public static FormLink<ITreeGetter> TreeSwordFern03 => Construct(0xb73bc);
            public static FormLink<ITreeGetter> TreeSwordFern02 => Construct(0xb73ba);
            public static FormLink<ITreeGetter> TreeSwordFern01 => Construct(0xb73b8);
            public static FormLink<ITreeGetter> NightingaleBanner06 => Construct(0xb11d8);
            public static FormLink<ITreeGetter> NightingaleBanner05 => Construct(0xb11d7);
            public static FormLink<ITreeGetter> NightingaleBanner04 => Construct(0xb11d6);
            public static FormLink<ITreeGetter> NightingaleBanner03 => Construct(0xb11d5);
            public static FormLink<ITreeGetter> NightingaleBanner02 => Construct(0xb11d4);
            public static FormLink<ITreeGetter> NightingaleBanner01 => Construct(0xb11d3);
            public static FormLink<ITreeGetter> TreeThicket01Snow => Construct(0xabd65);
            public static FormLink<ITreeGetter> TreeFallForestShrub02 => Construct(0xaae90);
            public static FormLink<ITreeGetter> TreeFallForestShrub01 => Construct(0xaae8f);
            public static FormLink<ITreeGetter> TreeReachShrub02 => Construct(0xaae8e);
            public static FormLink<ITreeGetter> TreeReachShrub01 => Construct(0xaae8d);
            public static FormLink<ITreeGetter> TreeTundraShrub10 => Construct(0xaae8b);
            public static FormLink<ITreeGetter> TreeTundraShrub09 => Construct(0xaae89);
            public static FormLink<ITreeGetter> TreeTundraShrub08 => Construct(0xaae87);
            public static FormLink<ITreeGetter> TreeTundraShrub07 => Construct(0xaae85);
            public static FormLink<ITreeGetter> TreeTundraShrub06 => Construct(0xaae83);
            public static FormLink<ITreeGetter> TreeTundraShrub05 => Construct(0xaae81);
            public static FormLink<ITreeGetter> TreeTundraShrub04 => Construct(0xaae7f);
            public static FormLink<ITreeGetter> TreeTundraShrub03 => Construct(0xaae7b);
            public static FormLink<ITreeGetter> TreeTundraShrub02 => Construct(0xaae7a);
            public static FormLink<ITreeGetter> TreeTundraShrub01 => Construct(0xaae79);
            public static FormLink<ITreeGetter> TreeYellowShrub03 => Construct(0xaae75);
            public static FormLink<ITreeGetter> TreeYellowShrub02 => Construct(0xaae74);
            public static FormLink<ITreeGetter> TreeYellowShrub01 => Construct(0xaae73);
            public static FormLink<ITreeGetter> TreeThicket01 => Construct(0xa7329);
            public static FormLink<ITreeGetter> TreeDeadShrubSnow => Construct(0xa731d);
            public static FormLink<ITreeGetter> TreeDeadShrub => Construct(0xa731c);
            public static FormLink<ITreeGetter> TreePineShrub03Snow => Construct(0xa7313);
            public static FormLink<ITreeGetter> TreePineShrub03 => Construct(0xa7312);
            public static FormLink<ITreeGetter> TreeVineMaple01Snow => Construct(0x9daa5);
            public static FormLink<ITreeGetter> TreeVineMaple01 => Construct(0x9daa4);
            public static FormLink<ITreeGetter> TreePineShrub01 => Construct(0x9daa3);
            public static FormLink<ITreeGetter> TreePineShrub01Snow => Construct(0x9daa2);
            public static FormLink<ITreeGetter> TreePineShrub02Snow => Construct(0x9daa1);
            public static FormLink<ITreeGetter> TreePineShrub02 => Construct(0x9daa0);
            public static FormLink<ITreeGetter> TreeAspen05 => Construct(0x7614b);
            public static FormLink<ITreeGetter> TreeAspen06 => Construct(0x7614a);
            public static FormLink<ITreeGetter> TreeAspen02 => Construct(0x6c9d5);
            public static FormLink<ITreeGetter> TreeAspen03 => Construct(0x6c9d4);
            public static FormLink<ITreeGetter> TreeAspen01 => Construct(0x6a9e6);
            public static FormLink<ITreeGetter> TreePineForestSnowL01 => Construct(0x5d2db);
            public static FormLink<ITreeGetter> TreePineForestSnowL02 => Construct(0x5d2da);
            public static FormLink<ITreeGetter> TreePineForestSnowL03 => Construct(0x5d2d9);
            public static FormLink<ITreeGetter> TreePineForestSnowL04 => Construct(0x5d2d8);
            public static FormLink<ITreeGetter> TreePineForestSnowL05 => Construct(0x5d2d7);
            public static FormLink<ITreeGetter> TreePineForestSnow01 => Construct(0x5c072);
            public static FormLink<ITreeGetter> TreePineForestSnow02 => Construct(0x5c071);
            public static FormLink<ITreeGetter> TreePineForestSnow03 => Construct(0x5c070);
            public static FormLink<ITreeGetter> TreePineForestSnow04 => Construct(0x5c06f);
            public static FormLink<ITreeGetter> TreePineForestSnow05 => Construct(0x5c06e);
            public static FormLink<ITreeGetter> TreePineForest05 => Construct(0x51126);
            public static FormLink<ITreeGetter> TreePineForest04 => Construct(0x4fbb0);
            public static FormLink<ITreeGetter> TreePineForest03 => Construct(0x4b016);
            public static FormLink<ITreeGetter> TreePineForest02 => Construct(0x18a02);
            public static FormLink<ITreeGetter> TreePineForest01 => Construct(0x1306d);
        }
    }
}
