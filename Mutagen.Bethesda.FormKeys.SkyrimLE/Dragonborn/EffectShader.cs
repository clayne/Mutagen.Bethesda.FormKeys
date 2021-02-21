using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEffectShaderGetter> DLC2ApoWaterDamageFXShader => Construct(0x1e147);
            public static FormLink<IEffectShaderGetter> DLC2LurkerEmerge => Construct(0x3d5d1);
            public static FormLink<IEffectShaderGetter> DLC2ApocryphaHealFXS => Construct(0x3d3be);
            public static FormLink<IEffectShaderGetter> DLC2ApocryphaRewardHitFXS => Construct(0x3d3bc);
            public static FormLink<IEffectShaderGetter> DLC2ApocryphaConjureTargetFXS => Construct(0x3d3bb);
            public static FormLink<IEffectShaderGetter> DLC2MiraakMagicFXS => Construct(0x3d30e);
            public static FormLink<IEffectShaderGetter> DLC2MiraakSmokeFXS => Construct(0x3d30d);
            public static FormLink<IEffectShaderGetter> DLC2MiraakBitsLite2FXS => Construct(0x3d30c);
            public static FormLink<IEffectShaderGetter> DLC2MiraakBitsFXS => Construct(0x3d30b);
            public static FormLink<IEffectShaderGetter> DLC2LurkerJoose => Construct(0x3cef8);
            public static FormLink<IEffectShaderGetter> DLC2ApocryphaSpellFXS => Construct(0x3cd84);
            public static FormLink<IEffectShaderGetter> DLC2AshSpawnDisintegrateFXS02 => Construct(0x3c737);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXSLeaves => Construct(0x3bd3d);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXSDirt01 => Construct(0x3b061);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXSDirt => Construct(0x3b060);
            public static FormLink<IEffectShaderGetter> DLC2MQ06PuzzleCastActFXS => Construct(0x3b01b);
            public static FormLink<IEffectShaderGetter> DLC2MQ06PuzzleTargetActFXS => Construct(0x3b01a);
            public static FormLink<IEffectShaderGetter> DLC2MorasGraspFXShader => Construct(0x3a299);
            public static FormLink<IEffectShaderGetter> DLC2TelMithrynTeleportFXS => Construct(0x39fb9);
            public static FormLink<IEffectShaderGetter> DLC2mkTentacleFXShader => Construct(0x39e46);
            public static FormLink<IEffectShaderGetter> DLC2MiraakSwordEnchShader => Construct(0x397f7);
            public static FormLink<IEffectShaderGetter> DLC2AcolytePriestDisintegrate01FXS => Construct(0x3911c);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXS2 => Construct(0x38875);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXS1 => Construct(0x38874);
            public static FormLink<IEffectShaderGetter> RieklingAmbushFXS => Construct(0x38873);
            public static FormLink<IEffectShaderGetter> HopperAmbushFXS => Construct(0x387d7);
            public static FormLink<IEffectShaderGetter> HopperAmbushFXS1 => Construct(0x387d6);
            public static FormLink<IEffectShaderGetter> DLC2AshSpawnDisintegrateFXS => Construct(0x32fec);
            public static FormLink<IEffectShaderGetter> DLC2OmenOfDangerFXS => Construct(0x324c1);
            public static FormLink<IEffectShaderGetter> DLC2StandingStoneFreeFXS => Construct(0x323fc);
            public static FormLink<IEffectShaderGetter> DLC2MiraakTeleportStartFXS => Construct(0x31d71);
            public static FormLink<IEffectShaderGetter> DLC2MiraakTeleportReturnFXS => Construct(0x31b11);
            public static FormLink<IEffectShaderGetter> DLC2StandingStoneDissolveFXS => Construct(0x317d9);
            public static FormLink<IEffectShaderGetter> DLC2AshSpawnFXShader => Construct(0x2c29c);
            public static FormLink<IEffectShaderGetter> DLC2StandingStoneCorruptedFXS => Construct(0x2adee);
            public static FormLink<IEffectShaderGetter> DLC2StandingStoneCracksFXS => Construct(0x2aded);
            public static FormLink<IEffectShaderGetter> DLC2AshShellFXS => Construct(0x27e34);
            public static FormLink<IEffectShaderGetter> DLC2AshGuardianFXS => Construct(0x27e33);
            public static FormLink<IEffectShaderGetter> DLC2MiraakTeleportFXS => Construct(0x25e0f);
            public static FormLink<IEffectShaderGetter> DLC2WhirlWindCloakFXS => Construct(0x2502a);
            public static FormLink<IEffectShaderGetter> DLC2HMDaedraMouthHitFXShader => Construct(0x24fc3);
            public static FormLink<IEffectShaderGetter> DLC2HMDaedraHitFXS => Construct(0x24fbf);
            public static FormLink<IEffectShaderGetter> DLC2HMDaedraFXS => Construct(0x23f87);
            public static FormLink<IEffectShaderGetter> DLC2HMDaedraDeathFXS => Construct(0x23f85);
            public static FormLink<IEffectShaderGetter> DLC2DragonbornAspectFXS01 => Construct(0x21735);
            public static FormLink<IEffectShaderGetter> DLC2DragonbornAspectFXS02 => Construct(0x21734);
            public static FormLink<IEffectShaderGetter> DLC2DragonbornAspectFXS03 => Construct(0x21733);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderShockFXShader => Construct(0x20968);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderFrostFXShader => Construct(0x206de);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderZombieFXS => Construct(0x206ca);
            public static FormLink<IEffectShaderGetter> DLC2ScribDeathFXS => Construct(0x20690);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderMANPoisonFXShader => Construct(0x200cd);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderPoisonFXShader => Construct(0x200cc);
            public static FormLink<IEffectShaderGetter> DLC2WerebearTrans02FXS => Construct(0x1e17a);
            public static FormLink<IEffectShaderGetter> DLC2ExpSpiderFireFXShader => Construct(0x1e115);
        }
    }
}
