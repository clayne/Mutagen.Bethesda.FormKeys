using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class LandscapeTexture
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ILandscapeTextureGetter> Construct(uint id) => new FormLink<ILandscapeTextureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILandscapeTextureGetter> LSnowRocks01wGrass => Construct(0xf871f);
            public static FormLink<ILandscapeTextureGetter> LMineFloorDirt01 => Construct(0x4c0fa);
            public static FormLink<ILandscapeTextureGetter> LBlackreachDirt => Construct(0xd1be4);
            public static FormLink<ILandscapeTextureGetter> LCoastOceanFloor01NoGrass => Construct(0xc207a);
            public static FormLink<ILandscapeTextureGetter> LDirtPath01 => Construct(0xb424c);
            public static FormLink<ILandscapeTextureGetter> LReachMossyRocks01NoRocks => Construct(0xb3bfb);
            public static FormLink<ILandscapeTextureGetter> LFallForestRocks01NoRocks => Construct(0xaefa2);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshGrass01NoGrass => Construct(0xa9e6c);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshLichen01NoGrass => Construct(0xa9e6b);
            public static FormLink<ILandscapeTextureGetter> LFallForestGrass01NoFern => Construct(0xa7619);
            public static FormLink<ILandscapeTextureGetter> LTundra01NoGrass => Construct(0xa2741);
            public static FormLink<ILandscapeTextureGetter> LRiverMud01NoGrass => Construct(0x98e6c);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraMineralPool01 => Construct(0x8f998);
            public static FormLink<ILandscapeTextureGetter> LGrassSnow01NoGrass => Construct(0x8b01e);
            public static FormLink<ILandscapeTextureGetter> LFallForestGrass01NoGrass => Construct(0x505f2);
            public static FormLink<ILandscapeTextureGetter> LSnowCobble01 => Construct(0x7f943);
            public static FormLink<ILandscapeTextureGetter> LRiverBottom01NoGrass => Construct(0x799bb);
            public static FormLink<ILandscapeTextureGetter> LCoastBeachGrass01 => Construct(0x6dd55);
            public static FormLink<ILandscapeTextureGetter> LCoastOceanFloor01 => Construct(0x6b4c6);
            public static FormLink<ILandscapeTextureGetter> LCoastBeach02 => Construct(0x6b3d1);
            public static FormLink<ILandscapeTextureGetter> LCoastBeach01 => Construct(0x6b3cf);
            public static FormLink<ILandscapeTextureGetter> LReachGrass01NoGrass => Construct(0x579e0);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshDirtSlopes01 => Construct(0x75070);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshIce01 => Construct(0x7506e);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshLichen01 => Construct(0x75069);
            public static FormLink<ILandscapeTextureGetter> LFrozenMarshGrass01 => Construct(0x75067);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraDirt01NoGrass => Construct(0x713d9);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraGravel01 => Construct(0x6ea8a);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraDirt02 => Construct(0x6ea88);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraMinerals01 => Construct(0x6ea85);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraRocks01 => Construct(0x6ea83);
            public static FormLink<ILandscapeTextureGetter> LVolcanicTundraDirt01 => Construct(0x6ea80);
            public static FormLink<ILandscapeTextureGetter> LRocks01NoRocks => Construct(0x6de8e);
            public static FormLink<ILandscapeTextureGetter> LTundraRocks01NoRocks => Construct(0x6de8b);
            public static FormLink<ILandscapeTextureGetter> LSnow02 => Construct(0x6a1b1);
            public static FormLink<ILandscapeTextureGetter> LSnowRocks01 => Construct(0x6a1af);
            public static FormLink<ILandscapeTextureGetter> LFallForestGrass01 => Construct(0x58606);
            public static FormLink<ILandscapeTextureGetter> LFallForestRocks01 => Construct(0x57dd1);
            public static FormLink<ILandscapeTextureGetter> LFallForestDirt01 => Construct(0x57dcf);
            public static FormLink<ILandscapeTextureGetter> LFallForestLeaves01 => Construct(0x57dc7);
            public static FormLink<ILandscapeTextureGetter> LReachDirt01 => Construct(0x21711);
            public static FormLink<ILandscapeTextureGetter> LReachGrass01 => Construct(0x1cc47);
            public static FormLink<ILandscapeTextureGetter> LReachMossyRocks01 => Construct(0x1cc45);
            public static FormLink<ILandscapeTextureGetter> LReachMoss01 => Construct(0x1cc43);
            public static FormLink<ILandscapeTextureGetter> LFieldGrass02NoGrass => Construct(0x4fb99);
            public static FormLink<ILandscapeTextureGetter> LTundra02 => Construct(0x300e4);
            public static FormLink<ILandscapeTextureGetter> LTundraRocks01 => Construct(0x2c6c6);
            public static FormLink<ILandscapeTextureGetter> LFieldGrass01NoGrass => Construct(0x24e46);
            public static FormLink<ILandscapeTextureGetter> LTundra01 => Construct(0x24e30);
            public static FormLink<ILandscapeTextureGetter> LCaveDirt => Construct(0x25414);
            public static FormLink<ILandscapeTextureGetter> LDirtSnowPath01 => Construct(0x1b082);
            public static FormLink<ILandscapeTextureGetter> LPineForest02NoGrass => Construct(0x181fa);
            public static FormLink<ILandscapeTextureGetter> LPineForest03NoGrass => Construct(0x181f9);
            public static FormLink<ILandscapeTextureGetter> LPineForest03 => Construct(0x13876);
            public static FormLink<ILandscapeTextureGetter> LPineForest02 => Construct(0x137cc);
            public static FormLink<ILandscapeTextureGetter> LPineForest01 => Construct(0x137c8);
            public static FormLink<ILandscapeTextureGetter> LFieldDirtGrass01 => Construct(0x134b7);
            public static FormLink<ILandscapeTextureGetter> LFieldGrass02 => Construct(0x1342a);
            public static FormLink<ILandscapeTextureGetter> LFieldGrass01 => Construct(0x13428);
            public static FormLink<ILandscapeTextureGetter> LRiverMud01 => Construct(0x132e9);
            public static FormLink<ILandscapeTextureGetter> LRiverBottom01 => Construct(0x13184);
            public static FormLink<ILandscapeTextureGetter> LRiverbedEdge01 => Construct(0x1301f);
            public static FormLink<ILandscapeTextureGetter> LScrub01 => Construct(0xc1e);
            public static FormLink<ILandscapeTextureGetter> LDirt02 => Construct(0xc16);
            public static FormLink<ILandscapeTextureGetter> LDirt01 => Construct(0xc14);
            public static FormLink<ILandscapeTextureGetter> LRocks01 => Construct(0xae4);
            public static FormLink<ILandscapeTextureGetter> LSnow01 => Construct(0x89b);
            public static FormLink<ILandscapeTextureGetter> LGrassSnow01 => Construct(0x894);
        }
    }
}
