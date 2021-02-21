using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ImageSpaceAdapter
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IImageSpaceAdapterGetter> Construct(uint id) => new FormLink<IImageSpaceAdapterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImageSpaceAdapterGetter> DLC1HarkonShieldBurstImod => Construct(0x11d39);
            public static FormLink<IImageSpaceAdapterGetter> DLC1HarkonBiteFadeToBlackImod => Construct(0xe911);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ReflectingShieldBlastImod => Construct(0xd95b);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ReflectingShieldChargeImod => Construct(0xd95a);
            public static FormLink<IImageSpaceAdapterGetter> DLC1AurielsEclipseImod01 => Construct(0x3dcd);
            public static FormLink<IImageSpaceAdapterGetter> DLC1_BF_RitualChargeIMOD => Construct(0x29ee);
            public static FormLink<IImageSpaceAdapterGetter> DLC1_BF_FullWhiteIMOD => Construct(0x29ed);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ShoutDrainVital02Imod => Construct(0x28e5);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ShoutDrainVital03Imod => Construct(0x28e4);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ShoutDrainVital01Imod => Construct(0x28e3);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampireDetectLifeImod => Construct(0x1aa84);
            public static FormLink<IImageSpaceAdapterGetter> DLC1MistformIntroImod => Construct(0x1aa37);
            public static FormLink<IImageSpaceAdapterGetter> DLC1MistformOutroImod => Construct(0x1aa36);
            public static FormLink<IImageSpaceAdapterGetter> DLC1MistformStaticImod => Construct(0x1aa31);
            public static FormLink<IImageSpaceAdapterGetter> DLC1SoulRendCastImod => Construct(0x1a3f8);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampireSlowTimeIntroImod => Construct(0x1a30e);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampireBatsImod => Construct(0x19d81);
            public static FormLink<IImageSpaceAdapterGetter> DLC1AurielBowArrowExpImod => Construct(0x18f00);
            public static FormLink<IImageSpaceAdapterGetter> DLC01UnderLavaIn01 => Construct(0x181c7);
            public static FormLink<IImageSpaceAdapterGetter> DLC01UnderLavaOut01 => Construct(0x181c6);
            public static FormLink<IImageSpaceAdapterGetter> DLC01UnderLavaLoop01 => Construct(0x181c5);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampChangeExplosionImod => Construct(0x15fc4);
            public static FormLink<IImageSpaceAdapterGetter> DLC1EclipseCastImod => Construct(0xf831);
            public static FormLink<IImageSpaceAdapterGetter> DLC1AurielsBowSunGazeDark => Construct(0xf64d);
            public static FormLink<IImageSpaceAdapterGetter> DLC1AurielsBowSunGazeLight => Construct(0xf64c);
            public static FormLink<IImageSpaceAdapterGetter> DLC1AurielsSunBurstImod => Construct(0xd183);
            public static FormLink<IImageSpaceAdapterGetter> DLCAurielsBowEffectImod => Construct(0xae9d);
            public static FormLink<IImageSpaceAdapterGetter> DLC1SunCloakCastImod => Construct(0xa3be);
            public static FormLink<IImageSpaceAdapterGetter> DLC1SoulCairnCrystalImod01 => Construct(0x818d);
            public static FormLink<IImageSpaceAdapterGetter> DLC1ReadScrollsImod => Construct(0x7f81);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampireWarningImod => Construct(0x71e8);
            public static FormLink<IImageSpaceAdapterGetter> DLC1VampireChangeImod => Construct(0x71d6);
            public static FormLink<IImageSpaceAdapterGetter> testDLCNoSun01 => Construct(0x6b31);
            public static FormLink<IImageSpaceAdapterGetter> testDLCNoSun02 => Construct(0x6b30);
            public static FormLink<IImageSpaceAdapterGetter> testDLCNoSun03 => Construct(0x6b2f);
            public static FormLink<IImageSpaceAdapterGetter> testDLCNoSun04 => Construct(0x6b2e);
        }
    }
}
