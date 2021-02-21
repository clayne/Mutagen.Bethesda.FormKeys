using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class EffectShader
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IEffectShaderGetter> Construct(uint id) => new FormLink<IEffectShaderGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEffectShaderGetter> InvisFXShaderNightingale => Construct(0xe5c);
            public static FormLink<IEffectShaderGetter> SteamFXShader => Construct(0x10fdf9);
            public static FormLink<IEffectShaderGetter> ShockPlayerCloakFXShader => Construct(0x10f9a6);
            public static FormLink<IEffectShaderGetter> FireFXTrapShader => Construct(0x10e296);
            public static FormLink<IEffectShaderGetter> PowerRacialCommandAnimalFXShader => Construct(0x10f927);
            public static FormLink<IEffectShaderGetter> PerkShieldChargeFXShader => Construct(0x10f803);
            public static FormLink<IEffectShaderGetter> DarkElfAncestorsWrathFXShader => Construct(0x10f56c);
            public static FormLink<IEffectShaderGetter> FireCloakFXShaderCOPY0001 => Construct(0x10f56b);
            public static FormLink<IEffectShaderGetter> PowerRacialBretonFXShader => Construct(0x10f566);
            public static FormLink<IEffectShaderGetter> MuffleFXShaderCOPY0000 => Construct(0x10f565);
            public static FormLink<IEffectShaderGetter> NFXS => Construct(0x10f505);
            public static FormLink<IEffectShaderGetter> NightingaleStrifeFXS => Construct(0x10f504);
            public static FormLink<IEffectShaderGetter> ArgonianHistHealFXS => Construct(0x10f4a9);
            public static FormLink<IEffectShaderGetter> AdrenalineRushFXS => Construct(0x10f4a8);
            public static FormLink<IEffectShaderGetter> EnchDamageBlueFXS => Construct(0x10eccf);
            public static FormLink<IEffectShaderGetter> EnchDamageGreenFXS => Construct(0x10ecce);
            public static FormLink<IEffectShaderGetter> ShieldSpellHit02FXS => Construct(0x10deab);
            public static FormLink<IEffectShaderGetter> ShieldSpellHitFXS => Construct(0x10deaa);
            public static FormLink<IEffectShaderGetter> HealCircleFXS => Construct(0x10cdc9);
            public static FormLink<IEffectShaderGetter> ChaurusPoisonFXShader => Construct(0x10cc64);
            public static FormLink<IEffectShaderGetter> PowerRacialHighbornFXS => Construct(0x10cc48);
            public static FormLink<IEffectShaderGetter> AlchArmorPoisonFXS => Construct(0x10bead);
            public static FormLink<IEffectShaderGetter> AlchArmorShockFXS => Construct(0x10beac);
            public static FormLink<IEffectShaderGetter> AlchArmorMagickaFXS => Construct(0x10beab);
            public static FormLink<IEffectShaderGetter> AlchArmorFrostFXS => Construct(0x10beaa);
            public static FormLink<IEffectShaderGetter> AlchArmorFireFXS => Construct(0x10bea9);
            public static FormLink<IEffectShaderGetter> SovengardeFXS01 => Construct(0x10b2df);
            public static FormLink<IEffectShaderGetter> FrostChillRendHitFXShader => Construct(0x10a044);
            public static FormLink<IEffectShaderGetter> FrostChillrendFXShader => Construct(0x10a043);
            public static FormLink<IEffectShaderGetter> AlduinFadeFXS => Construct(0x106bb6);
            public static FormLink<IEffectShaderGetter> MS04MemoryFXShaderNew => Construct(0x106add);
            public static FormLink<IEffectShaderGetter> GhostVioletFXShader => Construct(0x103129);
            public static FormLink<IEffectShaderGetter> MG02WallShader => Construct(0x10272e);
            public static FormLink<IEffectShaderGetter> MQ206ManReadsScrollFXS => Construct(0x10201f);
            public static FormLink<IEffectShaderGetter> GhostDeathFXShader => Construct(0x101727);
            public static FormLink<IEffectShaderGetter> GhostWolfSpiritFXShader => Construct(0xfe68d);
            public static FormLink<IEffectShaderGetter> GhostRedFXShader => Construct(0xfe68c);
            public static FormLink<IEffectShaderGetter> VampireChangeFX => Construct(0xfd804);
            public static FormLink<IEffectShaderGetter> BerserkerFXS => Construct(0xfd7d9);
            public static FormLink<IEffectShaderGetter> ShadowmereTransFXS => Construct(0xf4575);
            public static FormLink<IEffectShaderGetter> WerewolfTrans02FXS => Construct(0xebecd);
            public static FormLink<IEffectShaderGetter> WerewolfTransFXS => Construct(0xebec5);
            public static FormLink<IEffectShaderGetter> SkeletonNecroBirthFXS => Construct(0xebec0);
            public static FormLink<IEffectShaderGetter> SkeletonNecroDeathFXS => Construct(0xeb86b);
            public static FormLink<IEffectShaderGetter> TimeFadeOut01FXS => Construct(0xec355);
            public static FormLink<IEffectShaderGetter> TimeFadeIn01FXS => Construct(0xec354);
            public static FormLink<IEffectShaderGetter> DragonPreistDirtFXS => Construct(0xebb70);
            public static FormLink<IEffectShaderGetter> AtronachUnsummonDeathFXS => Construct(0xea8ff);
            public static FormLink<IEffectShaderGetter> IceFormBreak02FXS => Construct(0xea51a);
            public static FormLink<IEffectShaderGetter> IceFormBreak01FXS => Construct(0xea519);
            public static FormLink<IEffectShaderGetter> MagicArmorDragonFleshFXS => Construct(0xe9ac8);
            public static FormLink<IEffectShaderGetter> EnchRedFXShader => Construct(0xd7661);
            public static FormLink<IEffectShaderGetter> MS04MemoryObjectFXShader => Construct(0xc34b1);
            public static FormLink<IEffectShaderGetter> DamageHealthFXS => Construct(0xb93d8);
            public static FormLink<IEffectShaderGetter> MagicArmorIronFleshFXS => Construct(0x94163);
            public static FormLink<IEffectShaderGetter> MagicArmorEbonyFleshFXS => Construct(0x94162);
            public static FormLink<IEffectShaderGetter> MagicArmorStoneFleshFXS => Construct(0x94161);
            public static FormLink<IEffectShaderGetter> MagicArmorOakFleshFXS => Construct(0x94160);
            public static FormLink<IEffectShaderGetter> GreybeardPlayerPowerAbsorbFXS => Construct(0x91870);
            public static FormLink<IEffectShaderGetter> GreybeardPowerAbsorbFXS => Construct(0x9186f);
            public static FormLink<IEffectShaderGetter> DragonrendFXS03 => Construct(0x1fd01);
            public static FormLink<IEffectShaderGetter> DragonrendFXS02 => Construct(0x1fcff);
            public static FormLink<IEffectShaderGetter> DragonrendFXS01 => Construct(0x85faa);
            public static FormLink<IEffectShaderGetter> DA02ArmorShadow => Construct(0x81180);
            public static FormLink<IEffectShaderGetter> FrostSpikeFXShader => Construct(0x647b9);
            public static FormLink<IEffectShaderGetter> FXAlduinTimeFadeFXS => Construct(0x5b7fa);
            public static FormLink<IEffectShaderGetter> holesTest => Construct(0x474ab);
            public static FormLink<IEffectShaderGetter> ShockStormFXShader => Construct(0x3bf79);
            public static FormLink<IEffectShaderGetter> LifeDetectedUndeadEnemy => Construct(0x16439);
            public static FormLink<IEffectShaderGetter> AlduinCracksFXS => Construct(0x154bb);
            public static FormLink<IEffectShaderGetter> AlduinHolesFXS => Construct(0xe7719);
            public static FormLink<IEffectShaderGetter> AlduinDeathFXS => Construct(0xe7718);
            public static FormLink<IEffectShaderGetter> TurnUndeadFlamesFXS => Construct(0xe7557);
            public static FormLink<IEffectShaderGetter> FrostIceFormFXShader02 => Construct(0xdc20e);
            public static FormLink<IEffectShaderGetter> FrostIceFormFXShader => Construct(0xdc20d);
            public static FormLink<IEffectShaderGetter> LifeDetectedEnemy => Construct(0xdc209);
            public static FormLink<IEffectShaderGetter> DragonHolesBitsResFXS => Construct(0xda1fb);
            public static FormLink<IEffectShaderGetter> DA09LightBeamFXShader => Construct(0xd561c);
            public static FormLink<IEffectShaderGetter> ShockFXShaderNew => Construct(0xd33a0);
            public static FormLink<IEffectShaderGetter> ShockBigFXShader => Construct(0xd22fc);
            public static FormLink<IEffectShaderGetter> ShockDisintegrate01FXS => Construct(0xd22fb);
            public static FormLink<IEffectShaderGetter> GhostFXShaderNew => Construct(0xd2057);
            public static FormLink<IEffectShaderGetter> HowlSummonWolfFXS => Construct(0xcf79f);
            public static FormLink<IEffectShaderGetter> DragonHolesResFXS => Construct(0xcee10);
            public static FormLink<IEffectShaderGetter> DragonResDirtFXS => Construct(0xcee0f);
            public static FormLink<IEffectShaderGetter> DA02BoethiahFXS => Construct(0xcc6e6);
            public static FormLink<IEffectShaderGetter> GhostFXShaderNightingaleCorrupt => Construct(0xc7908);
            public static FormLink<IEffectShaderGetter> MS04MemoryFXShader => Construct(0xc723a);
            public static FormLink<IEffectShaderGetter> GhostFXShaderNightingale => Construct(0xc5ef7);
            public static FormLink<IEffectShaderGetter> AzuraGoodCrystal => Construct(0xb6bfa);
            public static FormLink<IEffectShaderGetter> AzuraEvilCrystal => Construct(0xb6bf9);
            public static FormLink<IEffectShaderGetter> TurnUnDisintegrate03FXSOLD => Construct(0x47815);
            public static FormLink<IEffectShaderGetter> TurnUnDisintegrate02FXS => Construct(0x4780e);
            public static FormLink<IEffectShaderGetter> AzuraGood => Construct(0x8ca2f);
            public static FormLink<IEffectShaderGetter> TurnUnDisintegrate01FXS => Construct(0x8c1a9);
            public static FormLink<IEffectShaderGetter> AnimalAllyFXS => Construct(0x84b3a);
            public static FormLink<IEffectShaderGetter> KynesPeaceFXS => Construct(0x84b39);
            public static FormLink<IEffectShaderGetter> ReanimateFXShader => Construct(0x75272);
            public static FormLink<IEffectShaderGetter> AzuraEvil => Construct(0x50f02);
            public static FormLink<IEffectShaderGetter> NightmareFXShader => Construct(0xbf743);
            public static FormLink<IEffectShaderGetter> WaterBreathingFXS => Construct(0xbcf27);
            public static FormLink<IEffectShaderGetter> MuffleFXShader => Construct(0xbcf25);
            public static FormLink<IEffectShaderGetter> AbsorbBlueFXS => Construct(0xabf08);
            public static FormLink<IEffectShaderGetter> AbsorbGreenFXS => Construct(0xabf07);
            public static FormLink<IEffectShaderGetter> AbsorbHealthFXS => Construct(0xabeff);
            public static FormLink<IEffectShaderGetter> LifeDetectedUndead => Construct(0xaaeb3);
            public static FormLink<IEffectShaderGetter> EnchArmorStaminaFXS => Construct(0x92dee);
            public static FormLink<IEffectShaderGetter> EnchArmorMagickaFXS => Construct(0x92ded);
            public static FormLink<IEffectShaderGetter> EnchArmorHealthFXS => Construct(0x92dec);
            public static FormLink<IEffectShaderGetter> EnchArmorShockFXS => Construct(0x92de9);
            public static FormLink<IEffectShaderGetter> EnchArmorFrostFXS => Construct(0x92de8);
            public static FormLink<IEffectShaderGetter> EnchArmorFireFXS => Construct(0x92de7);
            public static FormLink<IEffectShaderGetter> testFadeOutFXS => Construct(0x8a196);
            public static FormLink<IEffectShaderGetter> testFadeinFXS => Construct(0x8a195);
            public static FormLink<IEffectShaderGetter> WhisperFXS => Construct(0x80e1e);
            public static FormLink<IEffectShaderGetter> AtronachFlameGlowFXS => Construct(0x78ed3);
            public static FormLink<IEffectShaderGetter> MGGhostFXShader => Construct(0x6a155);
            public static FormLink<IEffectShaderGetter> AtronachFlameDeathFXS => Construct(0x60db7);
            public static FormLink<IEffectShaderGetter> IllusionFearFXS => Construct(0x7d450);
            public static FormLink<IEffectShaderGetter> DismayShout01FXS => Construct(0x7b6b9);
            public static FormLink<IEffectShaderGetter> Disguise02FXS => Construct(0x7a296);
            public static FormLink<IEffectShaderGetter> Disguise01FXS => Construct(0x7876b);
            public static FormLink<IEffectShaderGetter> LifeDetected => Construct(0x146);
            public static FormLink<IEffectShaderGetter> GhostCallValorFXShader => Construct(0x1a1e9);
            public static FormLink<IEffectShaderGetter> IllusionNegativeFXS => Construct(0x74799);
            public static FormLink<IEffectShaderGetter> IllusionPositiveFXS => Construct(0x73321);
            public static FormLink<IEffectShaderGetter> ParalyzeFxShader => Construct(0x6de84);
            public static FormLink<IEffectShaderGetter> EnchBoundSwordFXS => Construct(0x69ce8);
            public static FormLink<IEffectShaderGetter> GhostEtherealFXShaderIntro => Construct(0x658e2);
            public static FormLink<IEffectShaderGetter> GhostEtherealFXShader => Construct(0x64d67);
            public static FormLink<IEffectShaderGetter> GhostTrapFXShader => Construct(0x2bb00);
            public static FormLink<IEffectShaderGetter> MGAncanoEffectShader => Construct(0x25226);
            public static FormLink<IEffectShaderGetter> AtronachFrostFXS => Construct(0x5fb82);
            public static FormLink<IEffectShaderGetter> EnchBlueFXShader => Construct(0x5d608);
            public static FormLink<IEffectShaderGetter> EnchPurpleFXShader => Construct(0x5d607);
            public static FormLink<IEffectShaderGetter> EnchGreenFXShader => Construct(0x5d606);
            public static FormLink<IEffectShaderGetter> IceWraithFXS => Construct(0x5b367);
            public static FormLink<IEffectShaderGetter> EnchShockFXShader => Construct(0x59eda);
            public static FormLink<IEffectShaderGetter> ShockFXShader => Construct(0x57c67);
            public static FormLink<IEffectShaderGetter> ShieldSpellFXS => Construct(0x56ac9);
            public static FormLink<IEffectShaderGetter> SoulTrapCastActFXS => Construct(0x54224);
            public static FormLink<IEffectShaderGetter> SoulTrapTargetActFXS => Construct(0x54223);
            public static FormLink<IEffectShaderGetter> DragonHolesBitsLite2FXS => Construct(0x53109);
            public static FormLink<IEffectShaderGetter> DragonHolesLightFXS => Construct(0x3fa9a);
            public static FormLink<IEffectShaderGetter> DragonHolesMagicFXS => Construct(0x3fa99);
            public static FormLink<IEffectShaderGetter> FireFXShaderOLD => Construct(0x2e1da);
            public static FormLink<IEffectShaderGetter> WebbedFXS => Construct(0x2e1cd);
            public static FormLink<IEffectShaderGetter> EnchElementalFuryFXS => Construct(0x510d3);
            public static FormLink<IEffectShaderGetter> OLDSoulTrapFXShader => Construct(0x50972);
            public static FormLink<IEffectShaderGetter> SoulTrapFXShader => Construct(0x506d7);
            public static FormLink<IEffectShaderGetter> EnchFrostFXShader => Construct(0x4fa1d);
            public static FormLink<IEffectShaderGetter> EnchFireFXShader => Construct(0x4e810);
            public static FormLink<IEffectShaderGetter> HealMysticFXS => Construct(0x4e220);
            public static FormLink<IEffectShaderGetter> DragonHolesSmokeFXS => Construct(0x4d6b5);
            public static FormLink<IEffectShaderGetter> Hole => Construct(0x4d6b4);
            public static FormLink<IEffectShaderGetter> DragonHolesBitsFXS => Construct(0x4cec9);
            public static FormLink<IEffectShaderGetter> DragonHolesFXS => Construct(0x4cec8);
            public static FormLink<IEffectShaderGetter> TurnUnFXShader => Construct(0x4c6d8);
            public static FormLink<IEffectShaderGetter> FXSspiderSpitHit => Construct(0x4c6ce);
            public static FormLink<IEffectShaderGetter> GhostFXShader => Construct(0x3b6cb);
            public static FormLink<IEffectShaderGetter> InvisFXShader => Construct(0x2df92);
            public static FormLink<IEffectShaderGetter> DragonPowerAbsorbFXS => Construct(0x280c0);
            public static FormLink<IEffectShaderGetter> FrostShortFXShader => Construct(0x435a3);
            public static FormLink<IEffectShaderGetter> BackupHealFXS => Construct(0x3f80f);
            public static FormLink<IEffectShaderGetter> FireCloakFXShader => Construct(0x2acd8);
            public static FormLink<IEffectShaderGetter> FrostFXShader => Construct(0x1f03a);
            public static FormLink<IEffectShaderGetter> WardFXShader => Construct(0x1c858);
            public static FormLink<IEffectShaderGetter> FireFXShader => Construct(0x1b212);
            public static FormLink<IEffectShaderGetter> HealFXS => Construct(0x12fd9);
        }
    }
}
