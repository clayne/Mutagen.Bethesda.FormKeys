using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Impact
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IImpactGetter> Construct(uint id) => new FormLink<IImpactGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactGetter> WPNBlade1HandMiraakVsMetalSkinImpact => Construct(0x1e29c);
            public static FormLink<IImpactGetter> WPNBlade1HandMiraakVsFleshDraugrImpact => Construct(0x1e29b);
            public static FormLink<IImpactGetter> WPNBlade1HandMiraakVsFleshImpact => Construct(0x1e298);
            public static FormLink<IImpactGetter> MAGPowerMorasGraspImpact => Construct(0x1e14e);
            public static FormLink<IImpactGetter> DLCMAGRuneFrenzyImpact => Construct(0x1e0c1);
            public static FormLink<IImpactGetter> DLCMAGRunePoisonImpact => Construct(0x1e0c0);
            public static FormLink<IImpactGetter> DLC2ExpSpiderLandingSnowImpact => Construct(0x3d5df);
            public static FormLink<IImpactGetter> DLC2ExpSpiderLandingImpact => Construct(0x3d5dd);
            public static FormLink<IImpactGetter> DLC2MAGMorasGraspImpactLargeDropHaz => Construct(0x3d54d);
            public static FormLink<IImpactGetter> FSTWoodSprintArmorSkaalRImpact => Construct(0x3d372);
            public static FormLink<IImpactGetter> FSTWoodSprintArmorSkaalLImpact => Construct(0x3d371);
            public static FormLink<IImpactGetter> FSTStoneSprintArmorSkaalRImpact => Construct(0x3d370);
            public static FormLink<IImpactGetter> FSTStoneSprintArmorSkaalLImpact => Construct(0x3d36f);
            public static FormLink<IImpactGetter> FSTSnowSprintArmorSkaalRImpact => Construct(0x3d36e);
            public static FormLink<IImpactGetter> FSTSnowSprintArmorSkaalLImpact => Construct(0x3d36d);
            public static FormLink<IImpactGetter> FSTIceSprintArmorSkaalRImpact => Construct(0x3d36c);
            public static FormLink<IImpactGetter> FSTIceSprintArmorSkaalLImpact => Construct(0x3d36b);
            public static FormLink<IImpactGetter> FSTGravelSprintArmorSkaalRImpact => Construct(0x3d36a);
            public static FormLink<IImpactGetter> FSTGravelSprintArmorSkaalLImpact => Construct(0x3d369);
            public static FormLink<IImpactGetter> FSTGrassSprintArmorSkaalRImpact => Construct(0x3d368);
            public static FormLink<IImpactGetter> FSTGrassSprintArmorSkaalLImpact => Construct(0x3d367);
            public static FormLink<IImpactGetter> FSTDirtSprintArmorSkaalRImpact => Construct(0x3d366);
            public static FormLink<IImpactGetter> FSTDirtSprintArmorSkaalLImpact => Construct(0x3d365);
            public static FormLink<IImpactGetter> FSTAshSprintArmorSkaalRImpact => Construct(0x3d364);
            public static FormLink<IImpactGetter> FSTAshSprintArmorSkaalLImpact => Construct(0x3d363);
            public static FormLink<IImpactGetter> NPCDwarvenBallistaFootWalkLImpact => Construct(0x3cf8d);
            public static FormLink<IImpactGetter> NPCDwarvenBallistaFootWalkRImpact => Construct(0x3cf8c);
            public static FormLink<IImpactGetter> DLC2LurkerBlackGooImpact => Construct(0x3cef6);
            public static FormLink<IImpactGetter> DLC2MAGMorasGraspImpactDropHaz => Construct(0x3a3d6);
            public static FormLink<IImpactGetter> DLC2MAGMorasGraspImpactNoHazard => Construct(0x3a3d0);
            public static FormLink<IImpactGetter> NPCRieklingBristlebackAttackStandingImpact => Construct(0x337df);
            public static FormLink<IImpactGetter> DLC2MAGMorasGraspImpact => Construct(0x3183f);
            public static FormLink<IImpactGetter> NPCRieklingFootStoneWalkRImpact => Construct(0x28b88);
            public static FormLink<IImpactGetter> NPCRieklingFootStoneWalkLImpact => Construct(0x28b87);
            public static FormLink<IImpactGetter> NPCRieklingFootStoneRunRImpact => Construct(0x28b86);
            public static FormLink<IImpactGetter> NPCRieklingFootStoneRunLImpact => Construct(0x28b85);
            public static FormLink<IImpactGetter> NPCRieklingFootGrassWalkRImpact => Construct(0x28b84);
            public static FormLink<IImpactGetter> NPCRieklingFootGrassWalkLImpact => Construct(0x28b83);
            public static FormLink<IImpactGetter> NPCRieklingFootGrassRunRImpact => Construct(0x28b82);
            public static FormLink<IImpactGetter> NPCRieklingFootGrassRunLImpact => Construct(0x28b81);
            public static FormLink<IImpactGetter> NPCRieklingFootWoodRunRImpact => Construct(0x28b80);
            public static FormLink<IImpactGetter> NPCRieklingFootWoodRunLImpact => Construct(0x28b7f);
            public static FormLink<IImpactGetter> NPCRieklingFootWoodWalkRImpact => Construct(0x28b7e);
            public static FormLink<IImpactGetter> NPCRieklingFootWoodWalkLImpact => Construct(0x28b7d);
            public static FormLink<IImpactGetter> NPCSpiderHandFootWalkRImpact => Construct(0x28b5a);
            public static FormLink<IImpactGetter> NPCSpiderHandFootWalkLImpact => Construct(0x28b59);
            public static FormLink<IImpactGetter> NPCNetchFootImpact => Construct(0x2858d);
            public static FormLink<IImpactGetter> NPCBristlebackFootRunBackImpact => Construct(0x25c70);
            public static FormLink<IImpactGetter> NPCBristlebackFootRunFrontImpact => Construct(0x25c6c);
            public static FormLink<IImpactGetter> NPCBristlebackFootWalkFrontImpact => Construct(0x25c64);
            public static FormLink<IImpactGetter> NPCBristlebackFootWalkBackImpact => Construct(0x25c63);
            public static FormLink<IImpactGetter> DLC2MAGHMDaedraImpact02 => Construct(0x24fc8);
            public static FormLink<IImpactGetter> NPCAshGhoulFootWalkRImpact => Construct(0x23f8c);
            public static FormLink<IImpactGetter> NPCAshGhoulFootWalkLImpact => Construct(0x23f8b);
            public static FormLink<IImpactGetter> DLC2ExpSpiderZombieBurstImpact => Construct(0x206cb);
            public static FormLink<IImpactGetter> NPCScribFootWalkRImpact => Construct(0x1f171);
            public static FormLink<IImpactGetter> NPCScribFootWalkLImpact => Construct(0x1f170);
            public static FormLink<IImpactGetter> NPCScribFootWalkDirtRImpact => Construct(0x1f16f);
            public static FormLink<IImpactGetter> NPCScribFootWalkDirtLImpact => Construct(0x1f16e);
            public static FormLink<IImpactGetter> NPCFishmanDirtWalkRImpact => Construct(0x1f147);
            public static FormLink<IImpactGetter> NPCFishmanDirtWalkLImpact => Construct(0x1f146);
            public static FormLink<IImpactGetter> FSTAshJumpDownImpact => Construct(0x1be36);
            public static FormLink<IImpactGetter> FSTAshJumpUpImpact => Construct(0x1be35);
            public static FormLink<IImpactGetter> DLC2MAGBenthicLurkerGooDropImpact => Construct(0x1ae9c);
            public static FormLink<IImpactGetter> FSTAshWalkRImpact => Construct(0x18f44);
            public static FormLink<IImpactGetter> FSTAshWalkLImpact => Construct(0x18f43);
            public static FormLink<IImpactGetter> FSTAshSprintRImpact => Construct(0x18f42);
            public static FormLink<IImpactGetter> FSTAshSprintLImpact => Construct(0x18f41);
            public static FormLink<IImpactGetter> FSTAshSprintArmorLightRImpact => Construct(0x18f40);
            public static FormLink<IImpactGetter> FSTAshSprintArmorLightLImpact => Construct(0x18f3f);
            public static FormLink<IImpactGetter> FSTAshSprintArmorHeavyRImpact => Construct(0x18f3e);
            public static FormLink<IImpactGetter> FSTAshSprintArmorHeavyLImpact => Construct(0x18f3d);
            public static FormLink<IImpactGetter> FSTAshSneakRImpact => Construct(0x18f3c);
            public static FormLink<IImpactGetter> FSTAshSneakLImpact => Construct(0x18f3b);
            public static FormLink<IImpactGetter> FSTAshRunRImpact => Construct(0x18f3a);
            public static FormLink<IImpactGetter> FSTAshRunLImpact => Construct(0x18f39);
            public static FormLink<IImpactGetter> FSTAshRunArmorLightRImpact => Construct(0x18f38);
            public static FormLink<IImpactGetter> FSTAshRunArmorLightLImpact => Construct(0x18f37);
            public static FormLink<IImpactGetter> FSTAshRunArmorHeavyRImpact => Construct(0x18f36);
            public static FormLink<IImpactGetter> FSTAshRunArmorHeavyLImpact => Construct(0x18f35);
            public static FormLink<IImpactGetter> DLC2MAGAshGuardianImpact => Construct(0x1777f);
            public static FormLink<IImpactGetter> DLC2ExpSpiderZombieImpactImpale => Construct(0x17726);
        }
    }
}
