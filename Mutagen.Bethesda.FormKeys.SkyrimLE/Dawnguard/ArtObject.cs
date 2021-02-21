using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class ArtObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IArtObjectGetter> Construct(uint id) => new FormLink<IArtObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IArtObjectGetter> DLC1SEBossGlowingFX => Construct(0x138fd);
            public static FormLink<IArtObjectGetter> DLC1SEBossBlastBackFXArtObject => Construct(0x138e8);
            public static FormLink<IArtObjectGetter> DLC1VampBatsEatenByEffect => Construct(0x1296d);
            public static FormLink<IArtObjectGetter> DLC1BatsAbsorbTargetPointFX => Construct(0x12969);
            public static FormLink<IArtObjectGetter> DLC1BatsAbsorbCastPointFX01 => Construct(0x12968);
            public static FormLink<IArtObjectGetter> DLC1VampireBatDrainCloak01 => Construct(0x12967);
            public static FormLink<IArtObjectGetter> DLC01_ScrollAttunementObject => Construct(0x118f3);
            public static FormLink<IArtObjectGetter> DLC1VampHarkonDeathFX => Construct(0x10f7e);
            public static FormLink<IArtObjectGetter> DLC1SummonAetherialTarget => Construct(0x10d67);
            public static FormLink<IArtObjectGetter> DLC1ShadowShieldFX => Construct(0xf6a3);
            public static FormLink<IArtObjectGetter> ForgmasterFXObject => Construct(0xf5d3);
            public static FormLink<IArtObjectGetter> DLC1dunHarkonInvulnerabilityHitEffect => Construct(0xeca4);
            public static FormLink<IArtObjectGetter> DLC1ReflectingshieldEnchEffects => Construct(0xd94f);
            public static FormLink<IArtObjectGetter> DLC1AurielShrineCastFX => Construct(0xd662);
            public static FormLink<IArtObjectGetter> DLC1SummonUndeadDragonTarget => Construct(0xd60e);
            public static FormLink<IArtObjectGetter> DLC1SummonUndeadTarget => Construct(0xd60d);
            public static FormLink<IArtObjectGetter> DLC1VampireReanimateHandFX => Construct(0xcbd3);
            public static FormLink<IArtObjectGetter> DLC1VampireParalyzeHandFX => Construct(0xcbc4);
            public static FormLink<IArtObjectGetter> TestSoulCairnFog => Construct(0xcbc2);
            public static FormLink<IArtObjectGetter> DLC1DeadDragonParticlesObject => Construct(0xca87);
            public static FormLink<IArtObjectGetter> FXDLC1SCKeeperObject => Construct(0x686b);
            public static FormLink<IArtObjectGetter> DLC1GargoyleBruteGreenMeleeFX => Construct(0x5139);
            public static FormLink<IArtObjectGetter> DLC1GargoyleBruteMeleeFX => Construct(0x5132);
            public static FormLink<IArtObjectGetter> EmptyFX01 => Construct(0x2ae8);
            public static FormLink<IArtObjectGetter> FXDLC1SoulWispMeshObject => Construct(0x2ae4);
            public static FormLink<IArtObjectGetter> FXDeathHoundObject => Construct(0x2ae2);
            public static FormLink<IArtObjectGetter> DLC1DrainVitalTargetPointFX => Construct(0x28e7);
            public static FormLink<IArtObjectGetter> DLC1DrainVitalCastPointFX01 => Construct(0x28e6);
            public static FormLink<IArtObjectGetter> DLC1VampMistFormFX => Construct(0x1aa34);
            public static FormLink<IArtObjectGetter> DLC1SnowElfTelekinesisHandRObject => Construct(0x1a3bc);
            public static FormLink<IArtObjectGetter> DLC1SnowElfTelekinesisHandLObject => Construct(0x1a3ba);
            public static FormLink<IArtObjectGetter> DLC1VampLordBatsFX => Construct(0x18eef);
            public static FormLink<IArtObjectGetter> DLC1VigilantCharmedHeadArtObject => Construct(0x18c5b);
            public static FormLink<IArtObjectGetter> DLC1VampLordFloatFX => Construct(0x15fc5);
            public static FormLink<IArtObjectGetter> DLC1VampDrainTargetPointFX => Construct(0x14b8a);
            public static FormLink<IArtObjectGetter> DLC1VampTelekinesisFXHand01 => Construct(0x14b89);
            public static FormLink<IArtObjectGetter> MAGSprigganVariantConcCasting => Construct(0x13b81);
            public static FormLink<IArtObjectGetter> FXSprigganEarthMothertObject => Construct(0x13b7c);
            public static FormLink<IArtObjectGetter> CrystalAbsorbBlueTargetPointFX => Construct(0x11598);
            public static FormLink<IArtObjectGetter> DLC1_VampireBaneHandFX => Construct(0xf64a);
            public static FormLink<IArtObjectGetter> DLC1_SunCloakSpellHandFX => Construct(0xa3bd);
            public static FormLink<IArtObjectGetter> DLC01_SunAuraLightSpellFX => Construct(0xa3b8);
            public static FormLink<IArtObjectGetter> DLC01_SunAuraCloakFX => Construct(0xa3b7);
            public static FormLink<IArtObjectGetter> HorseBONE_FeetFX => Construct(0x966e);
            public static FormLink<IArtObjectGetter> DLC1SoulCairnFXKeeperHeadWithHelmetObject => Construct(0x894a);
            public static FormLink<IArtObjectGetter> DLC1SoulCairnFXKeeperHeadObject => Construct(0x8948);
            public static FormLink<IArtObjectGetter> DLC1ReadElderScrollBlankObject => Construct(0x7f7f);
            public static FormLink<IArtObjectGetter> DLC1ReadElderScrollPartCObject => Construct(0x7f7b);
            public static FormLink<IArtObjectGetter> DLC1ReadElderScrollPartBObject => Construct(0x7f7a);
            public static FormLink<IArtObjectGetter> DLC1ReadElderScrollPartAObject => Construct(0x7f79);
            public static FormLink<IArtObjectGetter> DLC01SoulRendReanimateTargetFX => Construct(0x7cbc);
            public static FormLink<IArtObjectGetter> DLC1SoulCairnFXNecroSkeletonMultiHeadObject => Construct(0x7c27);
            public static FormLink<IArtObjectGetter> FXCameraAttachUnderWaterObject => Construct(0x6b07);
            public static FormLink<IArtObjectGetter> FXCameraAttachRefract => Construct(0x6b04);
            public static FormLink<IArtObjectGetter> FXCameraAttachDLC1SoulCairnSoot => Construct(0x6b02);
            public static FormLink<IArtObjectGetter> FXCameraAttachDLC1SoulCairnBlowingFog => Construct(0x6b00);
            public static FormLink<IArtObjectGetter> FXCameraAttachBubbles => Construct(0x6afe);
            public static FormLink<IArtObjectGetter> DLC1SoulCairnFXSkeletonNecroEyeGlowObject => Construct(0x6af5);
            public static FormLink<IArtObjectGetter> DLC1SoulCairnFXNecroSkeletonMultiObject => Construct(0x6af3);
            public static FormLink<IArtObjectGetter> DLC1MothAttachFX01Object => Construct(0x58ae);
            public static FormLink<IArtObjectGetter> DLC1ReadElderScrollObject => Construct(0x5201);
        }
    }
}
