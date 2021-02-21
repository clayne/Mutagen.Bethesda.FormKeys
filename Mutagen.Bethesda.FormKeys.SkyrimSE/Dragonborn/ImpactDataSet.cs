using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class ImpactDataSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactDataSetGetter> WPNzBlade1HandMiraakImpactSet => Construct(0x1e296);
            public static FormLink<IImpactDataSetGetter> MAGPowerMorasGraspImpactDataSet => Construct(0x1e150);
            public static FormLink<IImpactDataSetGetter> DLC2MAGRunePoisonImpactSet => Construct(0x1e0c2);
            public static FormLink<IImpactDataSetGetter> DLC2MAGRuneFenzyImpactSet => Construct(0x1e0bf);
            public static FormLink<IImpactDataSetGetter> DLC2ExpSpiderLandingImpactSet => Construct(0x3d5de);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorSkaalRImpactSet => Construct(0x3d374);
            public static FormLink<IImpactDataSetGetter> FSTSprintArmorSkaalLImpactSet => Construct(0x3d373);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenBallistaFootWalkLImpactSet => Construct(0x3cf8f);
            public static FormLink<IImpactDataSetGetter> NPCDwarvenBallistaFootWalkRImpactSet => Construct(0x3cf8e);
            public static FormLink<IImpactDataSetGetter> DLC2LurkerGooImpactSet => Construct(0x3cef7);
            public static FormLink<IImpactDataSetGetter> DLC2MAGMiraaksStaffTentacleImpactSet => Construct(0x3a3d7);
            public static FormLink<IImpactDataSetGetter> NPCRieklingBristlebackAttackStandingImpactSet => Construct(0x337e0);
            public static FormLink<IImpactDataSetGetter> DLC2MAGMorasGraspImpactSet => Construct(0x31840);
            public static FormLink<IImpactDataSetGetter> NPCRieklingFootRunRImpact => Construct(0x28b8c);
            public static FormLink<IImpactDataSetGetter> NPCRieklingFootRunLImpact => Construct(0x28b8b);
            public static FormLink<IImpactDataSetGetter> NPCRieklingFootWalkRImpact => Construct(0x28b8a);
            public static FormLink<IImpactDataSetGetter> NPCRieklingFootWalkLImpact => Construct(0x28b89);
            public static FormLink<IImpactDataSetGetter> NPCSpiderhandFootWalkRImpactSet => Construct(0x28b5c);
            public static FormLink<IImpactDataSetGetter> NPCSpiderhandFootWalkLImpactSet => Construct(0x28b5b);
            public static FormLink<IImpactDataSetGetter> NPCNetchFootImpactSet => Construct(0x2858e);
            public static FormLink<IImpactDataSetGetter> NPCBristlebackFootRunBackImpactSet => Construct(0x25c71);
            public static FormLink<IImpactDataSetGetter> NPCBristlebackFootRunFrontImpactSet => Construct(0x25c6d);
            public static FormLink<IImpactDataSetGetter> NPCBristlebackFootWalkFrontImpactSet => Construct(0x25c66);
            public static FormLink<IImpactDataSetGetter> NPCBristlebackFootWalkBackImpactSet => Construct(0x25c65);
            public static FormLink<IImpactDataSetGetter> DLC2HMDaedraImpactSet => Construct(0x24fc0);
            public static FormLink<IImpactDataSetGetter> NPCAshGhoulFootWalkRImpactSet => Construct(0x23f8e);
            public static FormLink<IImpactDataSetGetter> NPCAshGhoulFootWalkLImpactSet => Construct(0x23f8d);
            public static FormLink<IImpactDataSetGetter> NPCScribFootWalkRImpactSet => Construct(0x1f173);
            public static FormLink<IImpactDataSetGetter> NPCScribFootWalkLImpactSet => Construct(0x1f172);
            public static FormLink<IImpactDataSetGetter> NPCFishmanFootWalkRImpactSet => Construct(0x1f149);
            public static FormLink<IImpactDataSetGetter> NPCFishmanFootWalkLImpactSet => Construct(0x1f148);
            public static FormLink<IImpactDataSetGetter> DLC2MAGLurkerGooImpactSet => Construct(0x1ae9f);
            public static FormLink<IImpactDataSetGetter> DLC2MAGAshGuardianImpactSet => Construct(0x17780);
            public static FormLink<IImpactDataSetGetter> DLC2ExpSpiderZombieImpactSet => Construct(0x17727);
        }
    }
}
