using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEffectShaderGetter> Dlc1DeathHound01 => Construct(0x12d08);
            public static FormLink<IEffectShaderGetter> DeathHoundDeathFXShader => Construct(0x12d07);
            public static FormLink<IEffectShaderGetter> DLC1VampBatsEatenByBatsSkinFXS => Construct(0x12970);
            public static FormLink<IEffectShaderGetter> DLC1BatsEatenBloodSplats => Construct(0x1296f);
            public static FormLink<IEffectShaderGetter> DLC1BatsEatenBloodDrops => Construct(0x1296e);
            public static FormLink<IEffectShaderGetter> DLC1VampireBatsEatenByBatsFXS => Construct(0x1296c);
            public static FormLink<IEffectShaderGetter> DLC1VampireChangeBack02FXS => Construct(0x122b6);
            public static FormLink<IEffectShaderGetter> DLC1VampireBleedHarkonFireFXS => Construct(0x10f7f);
            public static FormLink<IEffectShaderGetter> DLC1HarkonDisintegrate01FXS => Construct(0x10e1a);
            public static FormLink<IEffectShaderGetter> DLC1VampireBleedHarkonDeathFXS => Construct(0x10e19);
            public static FormLink<IEffectShaderGetter> DLC1VampireDeathBleedingShader => Construct(0x10e13);
            public static FormLink<IEffectShaderGetter> DLC1GargoyleStoneChipsFXS => Construct(0x10d5c);
            public static FormLink<IEffectShaderGetter> forgeMasterFXs => Construct(0xf670);
            public static FormLink<IEffectShaderGetter> DLC1nVampireGoreFXS => Construct(0xe7b3);
            public static FormLink<IEffectShaderGetter> DLC1VampireChangeBack01FXS => Construct(0xd9ad);
            public static FormLink<IEffectShaderGetter> DLC1DrainVital01FXS => Construct(0xcbc1);
            public static FormLink<IEffectShaderGetter> DLC1BonemanUnSummonFXS => Construct(0xcad5);
            public static FormLink<IEffectShaderGetter> DLC1BonemanSummonFXS => Construct(0xcad4);
            public static FormLink<IEffectShaderGetter> DLC1DragonUnSummonFXS => Construct(0xca89);
            public static FormLink<IEffectShaderGetter> DLC1DragonSummonFXS => Construct(0xca86);
            public static FormLink<IEffectShaderGetter> DLC1SoulCairnKeeperFXShader => Construct(0x6869);
            public static FormLink<IEffectShaderGetter> DLCGargoyleAbsorbHealthFXS => Construct(0x5135);
            public static FormLink<IEffectShaderGetter> DLC01scBlackOozeFXS => Construct(0x38f8);
            public static FormLink<IEffectShaderGetter> DLC1CharusFlyerEmergeFXS => Construct(0x298f);
            public static FormLink<IEffectShaderGetter> DLC1DrainVitalCasterFXS => Construct(0x2947);
            public static FormLink<IEffectShaderGetter> DLC1DeathHoundFXS => Construct(0x28ee);
            public static FormLink<IEffectShaderGetter> DLC1LifeDetectedEmpath => Construct(0x1aa85);
            public static FormLink<IEffectShaderGetter> DLC1VampireMistform02FXS => Construct(0x1aa30);
            public static FormLink<IEffectShaderGetter> DLC1VampireMistformEnd03FXS => Construct(0x1aa2f);
            public static FormLink<IEffectShaderGetter> DLC1VampireMistform01FXS => Construct(0x1aa2e);
            public static FormLink<IEffectShaderGetter> DLC1SunDamageImpactSmoke => Construct(0x19c9e);
            public static FormLink<IEffectShaderGetter> DLC1SunFireImpactFXShader => Construct(0x19c9d);
            public static FormLink<IEffectShaderGetter> DLC1SoulCairnGhostFXShader => Construct(0x19ab3);
            public static FormLink<IEffectShaderGetter> DLC1VampireBatsReformBATSFXS => Construct(0x18ef2);
            public static FormLink<IEffectShaderGetter> DLC1VampireBatsReformFXS => Construct(0x18ef1);
            public static FormLink<IEffectShaderGetter> DLC1VampireBatsFXS => Construct(0x18ef0);
            public static FormLink<IEffectShaderGetter> testDLC1AurielsBowFireFXShader => Construct(0x154b9);
            public static FormLink<IEffectShaderGetter> DLC1VampireChangeFXS => Construct(0x15372);
            public static FormLink<IEffectShaderGetter> DLC1CrystalAbsorbSoulCairnAbsorbFXS => Construct(0x1159b);
            public static FormLink<IEffectShaderGetter> DLC1testPhilSoulFormFXShader => Construct(0x10ff1);
            public static FormLink<IEffectShaderGetter> DLC1BFIceFormFXS => Construct(0xd979);
            public static FormLink<IEffectShaderGetter> DLC1AurielsBowFireFXShader => Construct(0xaeb3);
            public static FormLink<IEffectShaderGetter> DLC1SunFireCloakFXShader => Construct(0xa3bc);
            public static FormLink<IEffectShaderGetter> DLC1SunFireFXShader => Construct(0xa3bb);
            public static FormLink<IEffectShaderGetter> DLC01SoulDeathFXShader => Construct(0x93a2);
            public static FormLink<IEffectShaderGetter> DLC01SoulCairnFXShader => Construct(0x939b);
            public static FormLink<IEffectShaderGetter> DLC1SoulCairnSkeletonNecroDeathFXS => Construct(0x6af9);
            public static FormLink<IEffectShaderGetter> DLC1SoulCairnSkeletonNecroBirthFXS => Construct(0x6af8);
            public static FormLink<IEffectShaderGetter> DLC1DraugrEmergeFXS3_Specs => Construct(0x42bb);
            public static FormLink<IEffectShaderGetter> DLC1DraugrEmergeFXS2 => Construct(0x42ba);
            public static FormLink<IEffectShaderGetter> DLC1DraugrEmergeFXS1_Rocks => Construct(0x42b9);
            public static FormLink<IEffectShaderGetter> DLC1DraugrEmergeFXS => Construct(0x42b8);
        }
    }
}
