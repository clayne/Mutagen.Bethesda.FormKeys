using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MoveableStatic
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IMoveableStaticGetter> Construct(uint id) => new FormLink<IMoveableStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMoveableStaticGetter> DLC1FXAncestorGladeGroundCircle => Construct(0x1459b);
            public static FormLink<IMoveableStaticGetter> DLC1GlowFillBlack => Construct(0x144f4);
            public static FormLink<IMoveableStaticGetter> FXDarkFallSplash02 => Construct(0x12ff8);
            public static FormLink<IMoveableStaticGetter> FXDarkFallSplash01 => Construct(0x12ff7);
            public static FormLink<IMoveableStaticGetter> DLC1BthalfFXWaterfallThinLeak => Construct(0x12e7a);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWispWall => Construct(0x12876);
            public static FormLink<IMoveableStaticGetter> DLC1FalmerValleyBrazierLight => Construct(0x10dfb);
            public static FormLink<IMoveableStaticGetter> DLC1FXSCMistLow01Small => Construct(0xca84);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCTreasureBarrier01 => Construct(0x686d);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCTransportal => Construct(0x686c);
            public static FormLink<IMoveableStaticGetter> DLC1FXSCMistLow01 => Construct(0x6868);
            public static FormLink<IMoveableStaticGetter> DLC1_FXCreekFlatLong01_INTERIOR => Construct(0x541f);
            public static FormLink<IMoveableStaticGetter> FXAmbPinkPetals => Construct(0x4d21);
            public static FormLink<IMoveableStaticGetter> DLC1DBanner01 => Construct(0x43e1);
            public static FormLink<IMoveableStaticGetter> FXSoulCairnBeam => Construct(0x1a1c3);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCLightWallMist => Construct(0x15ff1);
            public static FormLink<IMoveableStaticGetter> DLC1FXAmbBeamGladeSpot => Construct(0x15f96);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWallMistSmallNoCollision01 => Construct(0x1541a);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWallMistCorner02 => Construct(0x142a9);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWallMistSmall => Construct(0x141ab);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWallMistCorner01 => Construct(0x141aa);
            public static FormLink<IMoveableStaticGetter> FXDLC1SCWallMist => Construct(0x141a9);
            public static FormLink<IMoveableStaticGetter> FXCreekFlatLarge_noCurrent => Construct(0xf651);
            public static FormLink<IMoveableStaticGetter> sc_crater01FX => Construct(0xd2c0);
            public static FormLink<IMoveableStaticGetter> DLC01Fissure01SoulCairnFXSteam00 => Construct(0x8940);
            public static FormLink<IMoveableStaticGetter> DLC1FXFasterFallsLine01 => Construct(0x6b93);
            public static FormLink<IMoveableStaticGetter> DLC1FXFasterRapids01 => Construct(0x6b92);
            public static FormLink<IMoveableStaticGetter> DLC1FXFasterRapids02 => Construct(0x6b91);
            public static FormLink<IMoveableStaticGetter> testDLCFXRapids => Construct(0x6b33);
            public static FormLink<IMoveableStaticGetter> testDLCFXrapidsFallsLine01 => Construct(0x6b32);
            public static FormLink<IMoveableStaticGetter> MeadBarrel_BloodDrip02 => Construct(0x4847);
            public static FormLink<IMoveableStaticGetter> MeadBarrel_BloodDrip01 => Construct(0x482d);
            public static FormLink<IMoveableStaticGetter> testPhosDrips01 => Construct(0x47e3);
            public static FormLink<IMoveableStaticGetter> LargeRainBarrel_Blood_Puddle01 => Construct(0x42bd);
        }
    }
}
