using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class VisualEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IVisualEffectGetter> Construct(uint id) => new FormLink<IVisualEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IVisualEffectGetter> DLC1SEBossGlowingVFX => Construct(0x1391a);
            public static FormLink<IVisualEffectGetter> DLC1SEBossBlastBackVFX => Construct(0x138ed);
            public static FormLink<IVisualEffectGetter> DLC1BatsAbsorbCastVFX01 => Construct(0x1296b);
            public static FormLink<IVisualEffectGetter> DLC1BatsAbsorbTargetVFX01 => Construct(0x1296a);
            public static FormLink<IVisualEffectGetter> DLC01_ScrollAttunementEffect => Construct(0x118f4);
            public static FormLink<IVisualEffectGetter> ForgmasterFXEffect => Construct(0xf5d4);
            public static FormLink<IVisualEffectGetter> DLC1TestSoulCairnFog => Construct(0xcbc3);
            public static FormLink<IVisualEffectGetter> DLC1DeadDragonParticlesEffect => Construct(0xca88);
            public static FormLink<IVisualEffectGetter> FXDLC1SCKeeperEffect => Construct(0x686a);
            public static FormLink<IVisualEffectGetter> DLC1GargolyeBruteHandVFXGreen => Construct(0x513a);
            public static FormLink<IVisualEffectGetter> DLC1GargoyleAbsorbCastVFX01 => Construct(0x5136);
            public static FormLink<IVisualEffectGetter> DLC1GargolyeBruteHandVFX => Construct(0x5134);
            public static FormLink<IVisualEffectGetter> EmptyVFX01 => Construct(0x2ae9);
            public static FormLink<IVisualEffectGetter> FXDLC1SoulWispMeshEffect => Construct(0x2ae3);
            public static FormLink<IVisualEffectGetter> FXDeathHoundEffect => Construct(0x2ae1);
            public static FormLink<IVisualEffectGetter> DLC1DrainVitalCastVFX01 => Construct(0x28e9);
            public static FormLink<IVisualEffectGetter> DLC1DrainVitalTargetVFX01 => Construct(0x28e8);
            public static FormLink<IVisualEffectGetter> DLC01_SunAuraCloakEffect => Construct(0x1a3be);
            public static FormLink<IVisualEffectGetter> DLC1SnowElfTelekinesisHandREffect => Construct(0x1a3bd);
            public static FormLink<IVisualEffectGetter> DLC1SnowElfTelekinesisHandLEffect => Construct(0x1a3bb);
            public static FormLink<IVisualEffectGetter> DLC1VampireBatsVFX => Construct(0x19c9f);
            public static FormLink<IVisualEffectGetter> DLC1VigilantCharmedHeadVisualEffect => Construct(0x18c5e);
            public static FormLink<IVisualEffectGetter> DLC1VampDrainTargetVFX01 => Construct(0x14b8b);
            public static FormLink<IVisualEffectGetter> FXSprigganEarthMotherEffect => Construct(0x13b7d);
            public static FormLink<IVisualEffectGetter> DLC1CrystalAbsorbSoulCairnTargetVFX01 => Construct(0x1159c);
            public static FormLink<IVisualEffectGetter> HorseBONE_Effect => Construct(0x966f);
            public static FormLink<IVisualEffectGetter> DLC1SoulCairnFXKeeperHeadWithHelmetEffect => Construct(0x8949);
            public static FormLink<IVisualEffectGetter> DLC1SoulCairnFXKeeperHeadEffect => Construct(0x8947);
            public static FormLink<IVisualEffectGetter> DLC1ReadElderScrollBlankEffect => Construct(0x7f80);
            public static FormLink<IVisualEffectGetter> DLC1ReadElderScrollPartCEffect => Construct(0x7f7e);
            public static FormLink<IVisualEffectGetter> DLC1ReadElderScrollPartBEffect => Construct(0x7f7d);
            public static FormLink<IVisualEffectGetter> DLC1ReadElderScrollPartAEffect => Construct(0x7f7c);
            public static FormLink<IVisualEffectGetter> DLC1SoulCairnFXNecroSkeletonMultiHeadEffect => Construct(0x7c26);
            public static FormLink<IVisualEffectGetter> FXCameraAttachUnderWaterEffect => Construct(0x6b06);
            public static FormLink<IVisualEffectGetter> FXCameraAttachRefractEffect => Construct(0x6b05);
            public static FormLink<IVisualEffectGetter> FXCameraAttachDLC1SoulCairnSootEffect => Construct(0x6b03);
            public static FormLink<IVisualEffectGetter> FXCameraAttachDLC1SoulCairnBlowingFogEffect => Construct(0x6b01);
            public static FormLink<IVisualEffectGetter> FXCameraAttachBubblesEffect => Construct(0x6aff);
            public static FormLink<IVisualEffectGetter> DLC1SoulCairnFXSkeletonNecroEyeGlowEffect => Construct(0x6af4);
            public static FormLink<IVisualEffectGetter> DLC1SoulCairnFXNecroSkeletonMultiEffect => Construct(0x6af2);
            public static FormLink<IVisualEffectGetter> DLC1MothAttachFX01Effect => Construct(0x58af);
            public static FormLink<IVisualEffectGetter> DLC1ReadElderScrollEffect => Construct(0x5202);
        }
    }
}
