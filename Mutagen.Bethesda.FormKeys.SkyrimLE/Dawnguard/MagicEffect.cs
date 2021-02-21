using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MagicEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMagicEffectGetter> DLC1DetectLifeScriptEffect => Construct(0x14ce7);
            public static FormLink<IMagicEffectGetter> DLC1FrostSlowFFAimed => Construct(0x14cc7);
            public static FormLink<IMagicEffectGetter> DLC1RuneHammerVisualEffect => Construct(0x14557);
            public static FormLink<IMagicEffectGetter> DLC1AlchRestoreHealthBlood => Construct(0x13812);
            public static FormLink<IMagicEffectGetter> DLC1MistformMuffle => Construct(0x12d19);
            public static FormLink<IMagicEffectGetter> DLC1StaggerPushFFSelfArea => Construct(0x12d17);
            public static FormLink<IMagicEffectGetter> DLC1BatsAbsorbConcAimed => Construct(0x126b6);
            public static FormLink<IMagicEffectGetter> DLC1AbBatsCloak => Construct(0x126b5);
            public static FormLink<IMagicEffectGetter> DLC1SCCraterSpellEffect => Construct(0x122b9);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonMishapScrap => Construct(0x121a8);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonMishapSphere => Construct(0x121a6);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonMishapSpider => Construct(0x121a3);
            public static FormLink<IMagicEffectGetter> DLC1SeranaAbsorbStaminaConcAimed => Construct(0x11f2e);
            public static FormLink<IMagicEffectGetter> DLC1SeranaAbsorbMagickaConcAimed => Construct(0x11f2d);
            public static FormLink<IMagicEffectGetter> DLC1SeranaAbsorbHealthConcAimed => Construct(0x11f2b);
            public static FormLink<IMagicEffectGetter> DLC1WerewolfGorgingRestoreHealth => Construct(0x11cfc);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXSkeletonNecroSummon => Construct(0x11bd4);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXBonemanSummon => Construct(0x11bd3);
            public static FormLink<IMagicEffectGetter> DLC1BatsControlEffect => Construct(0x119af);
            public static FormLink<IMagicEffectGetter> DLC1VQ08SwapBatsEffect => Construct(0x11997);
            public static FormLink<IMagicEffectGetter> DLC1FortifyMarksmanFFSelf => Construct(0x11362);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageStamina => Construct(0x10fcf);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageMagicka => Construct(0x10fce);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageHealth => Construct(0x10fcd);
            public static FormLink<IMagicEffectGetter> DLC1SoulTrapFFActor => Construct(0x10fcb);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageHealRate => Construct(0x10fc9);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageMagickaRate => Construct(0x10fc8);
            public static FormLink<IMagicEffectGetter> DLC1SoulAbDamageStaminaRate => Construct(0x10fc7);
            public static FormLink<IMagicEffectGetter> DLC1SoulEssenceDamage => Construct(0x10fc6);
            public static FormLink<IMagicEffectGetter> DLC1SummonDragonDescription => Construct(0x10ec0);
            public static FormLink<IMagicEffectGetter> DLC1FXBleedVampireDeathCastEffect => Construct(0x10e17);
            public static FormLink<IMagicEffectGetter> DLC1FXBleedVampireDeathEffect => Construct(0x10e11);
            public static FormLink<IMagicEffectGetter> DLC1SunCloakFFSelfIsran => Construct(0x10d8b);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonEjectPlayerEffect => Construct(0x10cf8);
            public static FormLink<IMagicEffectGetter> crdunHarkonVampireAbsorbHealthConcAimed => Construct(0xfc75);
            public static FormLink<IMagicEffectGetter> DLC1AbFXForgemasteCenturion => Construct(0xf647);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonSummonGargoyle => Construct(0xf4e2);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonBattleReanimateFX => Construct(0xf4df);
            public static FormLink<IMagicEffectGetter> DLC1nVampireAbsorbMagickaFFAimed => Construct(0xf4d9);
            public static FormLink<IMagicEffectGetter> DLC1nVampireAbsorbMagickaConcAimed => Construct(0xf4d8);
            public static FormLink<IMagicEffectGetter> DLC1VQ03InfluenceAggDownFFAimed => Construct(0xf3ce);
            public static FormLink<IMagicEffectGetter> DLC1RestoreHealthUndeadFFActor => Construct(0xe8d3);
            public static FormLink<IMagicEffectGetter> DLC1RestoreHealthUndeadConcActor => Construct(0xe8d1);
            public static FormLink<IMagicEffectGetter> DLC1nVampireMagickaDrainClaws => Construct(0xe7e9);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBloodyGripCloakDMGEffect => Construct(0xe7e8);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBloodyGripCloakEffect => Construct(0xe7d7);
            public static FormLink<IMagicEffectGetter> DLC1nVampireDrainShadeEffect => Construct(0xe7d1);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBloodPlagueEffect => Construct(0xe7b2);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBloodCloakEffect => Construct(0xe7b0);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonConjurationDelayEffect => Construct(0xe65e);
            public static FormLink<IMagicEffectGetter> DLC1VQ08BatsEffect => Construct(0xe654);
            public static FormLink<IMagicEffectGetter> DLC1ReflectingShieldEffect03 => Construct(0xd957);
            public static FormLink<IMagicEffectGetter> DLC1ReflectingShieldEffect02 => Construct(0xd955);
            public static FormLink<IMagicEffectGetter> DLC1ReflectingShieldEffect01 => Construct(0xd952);
            public static FormLink<IMagicEffectGetter> DLC1AurielShrineCastEffect => Construct(0xd663);
            public static FormLink<IMagicEffectGetter> DLC1HarkonMistformCalmEffect => Construct(0xd652);
            public static FormLink<IMagicEffectGetter> DLC1HarkonMistformEffect => Construct(0xd651);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonDrainCloakEffect => Construct(0xd22c);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonFontAbsorbStamina => Construct(0xd1cd);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonFontAbsorbMagicka => Construct(0xd1c9);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonFontAbsorbHealth => Construct(0xd1c7);
            public static FormLink<IMagicEffectGetter> DLC1dunHarkonInvulnerabilityEffect => Construct(0xd1c5);
            public static FormLink<IMagicEffectGetter> DLC1RevertEffect => Construct(0xcd5b);
            public static FormLink<IMagicEffectGetter> DLC1DawnguardRuneVisualsEffect => Construct(0x6924);
            public static FormLink<IMagicEffectGetter> DLC1SuperReflexPhilSpeedEffect => Construct(0x68bc);
            public static FormLink<IMagicEffectGetter> DLC1testPhilSlowCloakEffect => Construct(0x68bb);
            public static FormLink<IMagicEffectGetter> DLC1testPhilSlowCloakEffectDMG => Construct(0x68ba);
            public static FormLink<IMagicEffectGetter> DLC1nVampireReflexEffect => Construct(0x68b7);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBatsAmuletEffectDMG => Construct(0x68b5);
            public static FormLink<IMagicEffectGetter> DLC1nVampireBatsAmuletEffect => Construct(0x68b3);
            public static FormLink<IMagicEffectGetter> DLC1VampireBatsKnockdown => Construct(0x68b0);
            public static FormLink<IMagicEffectGetter> DLC1AurielsAbsorbHealthFFContact => Construct(0x6785);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowBeamEffectUndead => Construct(0x6784);
            public static FormLink<IMagicEffectGetter> DLC1KeeperSoulSpellFX => Construct(0x6344);
            public static FormLink<IMagicEffectGetter> DLC1WispCloakEffect => Construct(0x5161);
            public static FormLink<IMagicEffectGetter> DLC1AbGargoyleBruteGreenFXHolder => Construct(0x513b);
            public static FormLink<IMagicEffectGetter> DLC1AbGargoyleBruteMeleeFXHolder => Construct(0x5133);
            public static FormLink<IMagicEffectGetter> DLC1SCShockDamageBoltStormNoDMG => Construct(0x4630);
            public static FormLink<IMagicEffectGetter> SummonBoneman => Construct(0x45bc);
            public static FormLink<IMagicEffectGetter> SummonMistman => Construct(0x45bb);
            public static FormLink<IMagicEffectGetter> SummonWrathman => Construct(0x45b5);
            public static FormLink<IMagicEffectGetter> DLC1AbFXMothpriestThrallEffect2 => Construct(0x459c);
            public static FormLink<IMagicEffectGetter> DLC1AbFXMothpriestThrallEffect1 => Construct(0x459a);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialShieldFearEffect => Construct(0x41af);
            public static FormLink<IMagicEffectGetter> DLC1SunDamageFFAimed => Construct(0x3f50);
            public static FormLink<IMagicEffectGetter> DLC1crChaurusHunterAmbushFXEffect => Construct(0x2b56);
            public static FormLink<IMagicEffectGetter> AbDLC1SoulWispScriptAttach => Construct(0x2adc);
            public static FormLink<IMagicEffectGetter> DLC1FortifyStaminaRateFFSelf => Construct(0x29e3);
            public static FormLink<IMagicEffectGetter> DLC1FortifyMagickaRateFFSelf => Construct(0x29e1);
            public static FormLink<IMagicEffectGetter> DLC1FireDamageFFSelfArea65 => Construct(0x29ab);
            public static FormLink<IMagicEffectGetter> AbFXChaurusFlyer => Construct(0x2995);
            public static FormLink<IMagicEffectGetter> DLC1LD_LavaImagespaceEffect => Construct(0x2980);
            public static FormLink<IMagicEffectGetter> DLC1DeathHoundFX => Construct(0x28ed);
            public static FormLink<IMagicEffectGetter> DLC1RedwaterDamageStaminaRegen => Construct(0x1aad2);
            public static FormLink<IMagicEffectGetter> DLC1RedwaterDamageMagickaRegen => Construct(0x1aad0);
            public static FormLink<IMagicEffectGetter> DLC1MistformInvisEffect => Construct(0x1aa35);
            public static FormLink<IMagicEffectGetter> DLC1VoiceSoulrendBlankHostile02 => Construct(0x1aa33);
            public static FormLink<IMagicEffectGetter> DLC1HarkonAbsorbStaminaFFAimed => Construct(0x1a937);
            public static FormLink<IMagicEffectGetter> DLC1HarkonAbsorbMagickaFFAimed => Construct(0x1a936);
            public static FormLink<IMagicEffectGetter> DLC1HarkonAbsorbHealthFFAimed => Construct(0x1a935);
            public static FormLink<IMagicEffectGetter> DLC1MistformEffect => Construct(0x1a321);
            public static FormLink<IMagicEffectGetter> DLC1VampireSlowTimeEffect => Construct(0x1a30d);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamageUndeadArrow => Construct(0x1a188);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamageArrow => Construct(0x1a187);
            public static FormLink<IMagicEffectGetter> DLC1VoiceUndeadSummonEffect3 => Construct(0x1a16e);
            public static FormLink<IMagicEffectGetter> DLC1VoiceUndeadSummonEffect2 => Construct(0x1a16d);
            public static FormLink<IMagicEffectGetter> DLC1VoiceUndeadSummonEffect1 => Construct(0x1a169);
            public static FormLink<IMagicEffectGetter> DLC1BatsInvisEffect => Construct(0x19c9c);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbGhost => Construct(0x19aaf);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireDamageHealthFFAimed => Construct(0x19325);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbStaminaFFAimed => Construct(0x19323);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbMagickaFFAimed => Construct(0x19322);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbHealthFFAimed => Construct(0x19321);
            public static FormLink<IMagicEffectGetter> DLC1BloodPotionEffect => Construct(0x18ef4);
            public static FormLink<IMagicEffectGetter> DLC1VigilantCharmedHeadMagicEffect => Construct(0x18c5c);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowEclipseSelfEffect => Construct(0x18c5a);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeSearching2 => Construct(0x18c58);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeCombat2 => Construct(0x18c57);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeSearching1 => Construct(0x18c56);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLife2 => Construct(0x18c55);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLife3 => Construct(0x18c54);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeCombat1 => Construct(0x18c53);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeSearching3 => Construct(0x18c52);
            public static FormLink<IMagicEffectGetter> DLC1SummonGargoyle => Construct(0x16906);
            public static FormLink<IMagicEffectGetter> DLC01_SoulTearWaitForDeathFX => Construct(0x16874);
            public static FormLink<IMagicEffectGetter> DLC1DawnguardRuneAxeDamageEffect => Construct(0x16696);
            public static FormLink<IMagicEffectGetter> DLC1DawnguardRuneAxeIncrementKills => Construct(0x16695);
            public static FormLink<IMagicEffectGetter> DLC1EnchHealthDamageFFContact => Construct(0x16690);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfFearEffect1 => Construct(0x15fd2);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfFearEffect2 => Construct(0x15fd1);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfFearEffect3 => Construct(0x15fd0);
            public static FormLink<IMagicEffectGetter> DLC1VampireFloatFXHolder => Construct(0x15fc6);
            public static FormLink<IMagicEffectGetter> DLC1LD_ForgemasterFlameCloakEffect => Construct(0x15c44);
            public static FormLink<IMagicEffectGetter> DLC1LD_ForgemasterFireBreathEffect => Construct(0x15c41);
            public static FormLink<IMagicEffectGetter> DLC1LD_ForgemasterFireballEffect => Construct(0x15c3b);
            public static FormLink<IMagicEffectGetter> DLC1CrystalDamageHealRateConcAimed => Construct(0x15774);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamageUndead => Construct(0x1571b);
            public static FormLink<IMagicEffectGetter> DLC1BatsEffect => Construct(0x1571a);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamage => Construct(0x15719);
            public static FormLink<IMagicEffectGetter> DLC1VoiceSoulrendBlankHostile => Construct(0x15714);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamageArea => Construct(0x15711);
            public static FormLink<IMagicEffectGetter> DLC1EnchSunDamageUndeadArea => Construct(0x15710);
            public static FormLink<IMagicEffectGetter> DLC1CrystalAbsorbHealthConcAimedVisualFX => Construct(0x154ac);
            public static FormLink<IMagicEffectGetter> testSuperMageLightAimed => Construct(0x15416);
            public static FormLink<IMagicEffectGetter> DLC1LD_LavaEffect => Construct(0x1533c);
            public static FormLink<IMagicEffectGetter> DLC1LD_SteamEffect => Construct(0x1533b);
            public static FormLink<IMagicEffectGetter> DLC1LD_SteamEffectLingering => Construct(0x1533a);
            public static FormLink<IMagicEffectGetter> DLC1LD_LavaEffectLingering => Construct(0x15339);
            public static FormLink<IMagicEffectGetter> DLC1LD_SteamBlastEffect => Construct(0x15338);
            public static FormLink<IMagicEffectGetter> DLC1LD_SteamEffectHealing => Construct(0x15337);
            public static FormLink<IMagicEffectGetter> DLC1FoodSoulHuskEffect => Construct(0x14dc5);
            public static FormLink<IMagicEffectGetter> DLC1dunRedwaterDenWithdrawalEffect => Construct(0x149aa);
            public static FormLink<IMagicEffectGetter> DLC1dunRedwaterDenPowerEffect => Construct(0x149a9);
            public static FormLink<IMagicEffectGetter> DLC1SCShockDamageBoltStormAimed => Construct(0x14322);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffEnchEffect => Construct(0x142b2);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialShieldCalmEffect => Construct(0x142af);
            public static FormLink<IMagicEffectGetter> DLC1LD_EnchAetherialArmorNullEffect => Construct(0x142ae);
            public static FormLink<IMagicEffectGetter> DLC1LD_EnchKatriaBowEffect => Construct(0x142ab);
            public static FormLink<IMagicEffectGetter> DLC1VampireChalicePowerSpell => Construct(0x1419d);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbMagickaConcAimed => Construct(0x1419c);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbStaminaConcAimed => Construct(0x1419a);
            public static FormLink<IMagicEffectGetter> DLC1dunRedwaterSlowEffect => Construct(0x14046);
            public static FormLink<IMagicEffectGetter> SprigganVariantBugDamageConcAimed => Construct(0x13b7f);
            public static FormLink<IMagicEffectGetter> AbFXSprigganEarthMother => Construct(0x13b7b);
            public static FormLink<IMagicEffectGetter> DLC1dunRedwaterSkoomaEffect => Construct(0x1391e);
            public static FormLink<IMagicEffectGetter> DLC1DawnguardRuneShieldAbility => Construct(0x11bb1);
            public static FormLink<IMagicEffectGetter> DLCDawnguardRuneHammerAbility => Construct(0x11bab);
            public static FormLink<IMagicEffectGetter> DLC1AbsorbHealthFFContact => Construct(0x11a1b);
            public static FormLink<IMagicEffectGetter> DLC1AbFortifyMagicka => Construct(0x110d0);
            public static FormLink<IMagicEffectGetter> DLC1crChaurusHunterSpitFFAimed => Construct(0x11004);
            public static FormLink<IMagicEffectGetter> dlc1testPhilVortexEffect => Construct(0x10ff4);
            public static FormLink<IMagicEffectGetter> DLC1VampireDetectLifeCombatExteriorSelfFF => Construct(0x10a80);
            public static FormLink<IMagicEffectGetter> DLC1VampireDetectLifeCombatInteriorSelfFF => Construct(0x10a7f);
            public static FormLink<IMagicEffectGetter> DLC1InfluenceAggDownFFAimed => Construct(0xd3c2);
            public static FormLink<IMagicEffectGetter> DLC1ReanimateFFAimed25 => Construct(0xd3c1);
            public static FormLink<IMagicEffectGetter> DLC1ParalysisFFAimed => Construct(0xd3c0);
            public static FormLink<IMagicEffectGetter> DLC1ReanimateFFTargetActor25 => Construct(0xd3bf);
            public static FormLink<IMagicEffectGetter> DLC1VQ05RaiseDeadFX02 => Construct(0xd2e1);
            public static FormLink<IMagicEffectGetter> DLC1AbSabreCatGlowScriptAttach => Construct(0xd0b5);
            public static FormLink<IMagicEffectGetter> DLC1AbDeerGlowScriptAttach => Construct(0xd0b1);
            public static FormLink<IMagicEffectGetter> DLC1LD_GhostAbilityFX => Construct(0xcfa7);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialShieldEtherealize => Construct(0xcfa6);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonDwarvenSpider01 => Construct(0xcfa1);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonDwarvenSphere02 => Construct(0xcfa0);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonDwarvenSphere01 => Construct(0xcf9f);
            public static FormLink<IMagicEffectGetter> DLC1LD_AetherialStaffSummonDwarvenSpider02 => Construct(0xcf9e);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowBlessedPlayerSelfEffect => Construct(0xce10);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowBlessedAreaEffect => Construct(0xc60e);
            public static FormLink<IMagicEffectGetter> DLC01SummonSoulHorseEffect => Construct(0xc601);
            public static FormLink<IMagicEffectGetter> DLC1AbDeathHoundCloakFrost => Construct(0xc5f1);
            public static FormLink<IMagicEffectGetter> DLC1VQ05RaiseDeadScriptEffect => Construct(0xbffa);
            public static FormLink<IMagicEffectGetter> DLC1VQ05RaiseDeadFX => Construct(0xbff8);
            public static FormLink<IMagicEffectGetter> DLC1CrystalSlowConcAimed => Construct(0xbf7d);
            public static FormLink<IMagicEffectGetter> DLC1VampireMesmerizeMagicEffect => Construct(0xbf72);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXBoneman => Construct(0xbdcd);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLifeCombat3 => Construct(0xba53);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfDetectLife1 => Construct(0xba51);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowBeamEffect => Construct(0xaeb5);
            public static FormLink<IMagicEffectGetter> DLC1SunLightFFSelf => Construct(0xa3b9);
            public static FormLink<IMagicEffectGetter> DLC1PCVampireAbsorbHealthConcAimed => Construct(0xa26b);
            public static FormLink<IMagicEffectGetter> TestSlowFFConstant => Construct(0x9d40);
            public static FormLink<IMagicEffectGetter> DLC01AbSoul => Construct(0x939e);
            public static FormLink<IMagicEffectGetter> DLC1VampireSleepRestedEffect => Construct(0x8e3e);
            public static FormLink<IMagicEffectGetter> DLC1CrystalAbsorbHealthConcAimed => Construct(0x8b33);
            public static FormLink<IMagicEffectGetter> crVampireAbsorbHealthConcAimedCOPY0000 => Construct(0x8b31);
            public static FormLink<IMagicEffectGetter> DLC1CrystalSoulDrainEffect => Construct(0x8b30);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonWerewolvesEffect3 => Construct(0x8a6b);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonWerewolvesEffect2 => Construct(0x8a6a);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonWerewolvesEffect1 => Construct(0x8a69);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonIceWolvesEffect3 => Construct(0x8a68);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonIceWolvesEffect2 => Construct(0x8a67);
            public static FormLink<IMagicEffectGetter> DLC1HowlWerewolfSummonIceWolvesEffect1 => Construct(0x8a66);
            public static FormLink<IMagicEffectGetter> DLC1SimDamageConcAimedCloak => Construct(0x8a5d);
            public static FormLink<IMagicEffectGetter> DLC1SunCloakFFSelf => Construct(0x8a5c);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXKeeperHeadWithHelmet => Construct(0x8943);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXKeeperHead => Construct(0x8942);
            public static FormLink<IMagicEffectGetter> DLC1testPhilSoulDrainEffect => Construct(0x844e);
            public static FormLink<IMagicEffectGetter> DLC1SunDamageFFAimedArea => Construct(0x844b);
            public static FormLink<IMagicEffectGetter> DLC1DragonDrainVitalityStaminaEffect => Construct(0x844a);
            public static FormLink<IMagicEffectGetter> DLC1DragonDrainVitalityHealthEffect => Construct(0x8449);
            public static FormLink<IMagicEffectGetter> DLC1DragonDrainVitalityMagickaEffect => Construct(0x8448);
            public static FormLink<IMagicEffectGetter> DLC1ScriptAIFlyingEffect => Construct(0x8446);
            public static FormLink<IMagicEffectGetter> DLC1ScriptAIEffect => Construct(0x8445);
            public static FormLink<IMagicEffectGetter> DLC1VampireGrabActorEffect => Construct(0x7ebd);
            public static FormLink<IMagicEffectGetter> DLC1AurielsBowScriptEffect => Construct(0x7ebb);
            public static FormLink<IMagicEffectGetter> DLC1VampireUnequipEffect => Construct(0x7eba);
            public static FormLink<IMagicEffectGetter> DLC1testPhilcrSoulDamageConcAimed => Construct(0x7eb0);
            public static FormLink<IMagicEffectGetter> DLC1testPhilAbAtronachSoulShock => Construct(0x7eae);
            public static FormLink<IMagicEffectGetter> DLC1FalmerHealerHealCheckEffect => Construct(0x7d99);
            public static FormLink<IMagicEffectGetter> DLC1FalmerHealerEffect => Construct(0x7d97);
            public static FormLink<IMagicEffectGetter> DLC01_SoulTearDamageFFAimed => Construct(0x7cb5);
            public static FormLink<IMagicEffectGetter> DLC01_SoulTearReanimateFFAimed => Construct(0x7cb4);
            public static FormLink<IMagicEffectGetter> DLC01_SoulTearTrapFFActor => Construct(0x7cb3);
            public static FormLink<IMagicEffectGetter> DLC01EnchAurielsBow => Construct(0x71e0);
            public static FormLink<IMagicEffectGetter> DLC1SoulCairnAbFXSkeletonNecro => Construct(0x6aee);
            public static FormLink<IMagicEffectGetter> DLC1VampirePoisonTalonFFContact => Construct(0x59a2);
            public static FormLink<IMagicEffectGetter> DLC1FortifyHealRate => Construct(0x59a0);
            public static FormLink<IMagicEffectGetter> DLC1AbFXReflectingShield => Construct(0x488c);
            public static FormLink<IMagicEffectGetter> DLC1IceFormWithBarrier => Construct(0x4343);
            public static FormLink<IMagicEffectGetter> DLC1TrapSpotLightConcAimed => Construct(0x37f8);
            public static FormLink<IMagicEffectGetter> TrapDisDamageHealthVampire => Construct(0x37ec);
            public static FormLink<IMagicEffectGetter> DLC1SummonDragonEffect => Construct(0x30d3);
            public static FormLink<IMagicEffectGetter> DLC1VampireChangeFXEffect => Construct(0x283e);
            public static FormLink<IMagicEffectGetter> DLC1VampireChangeEffect => Construct(0x283c);
        }
    }
}
