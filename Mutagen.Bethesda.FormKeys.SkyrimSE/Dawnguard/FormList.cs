using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class FormList
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IFormListGetter> Construct(uint id) => new FormLink<IFormListGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFormListGetter> DLC1BloodPointsProhibitedRaces => Construct(0x13ecd);
            public static FormLink<IFormListGetter> DLC1VQ08VNamasurStormTheCastleOverrideStack => Construct(0x123d2);
            public static FormLink<IFormListGetter> DLC1VQ08VModhnaStormTheCastleOverrideStack => Construct(0x123cf);
            public static FormLink<IFormListGetter> DLC1VQ08flBossRoomTrackingList => Construct(0x11e2f);
            public static FormLink<IFormListGetter> DLC1VQ08VVignalmoStormTheCastleOverrideStack => Construct(0x11342);
            public static FormLink<IFormListGetter> DLC1VQ08VStalfStormTheCastleOverrideStack => Construct(0x11278);
            public static FormLink<IFormListGetter> DLC1VQ08VSaloniaStormTheCastleOverrideStack => Construct(0x111b2);
            public static FormLink<IFormListGetter> DLC1VQ08VRonthilStormTheCastleOverrideStack => Construct(0x111af);
            public static FormLink<IFormListGetter> DLC1VQ08VRargalStormTheCastleOverrideStack => Construct(0x111ae);
            public static FormLink<IFormListGetter> DLC1VQ08VOrthjolfStormTheCastleOverrideStack => Construct(0x111a8);
            public static FormLink<IFormListGetter> DLC1VQ08VHestlaStormTheCastleOverrideStack => Construct(0x111a7);
            public static FormLink<IFormListGetter> DLC1VQ08VGarmrStormTheCastleOverrideStack => Construct(0x111a6);
            public static FormLink<IFormListGetter> DLC1VQ08VFuraStormTheCastleOverrideStack => Construct(0x111a5);
            public static FormLink<IFormListGetter> DLC1VQ08VGaranStormTheCastleOverrideStack => Construct(0x111a4);
            public static FormLink<IFormListGetter> DLC1VQ08VFeranStormTheCastleOverrideStack => Construct(0x111a3);
            public static FormLink<IFormListGetter> DLC1VQ08VCuSithStormTheCastleOverrideStack => Construct(0x111a2);
            public static FormLink<IFormListGetter> DLC1VQ08SorineStormTheCastleOverrideStack => Construct(0x11193);
            public static FormLink<IFormListGetter> DLC1VQ08IngjardStormTheCastleOverrideStack => Construct(0x11192);
            public static FormLink<IFormListGetter> DLC1VQ08GunmarStormTheCastleOverrideStack => Construct(0x11190);
            public static FormLink<IFormListGetter> DLC1VQ08FlorentiusStormTheCastleOverrideStack => Construct(0x110ce);
            public static FormLink<IFormListGetter> DLC1VQ08DurakStormTheCastleOverrideStack => Construct(0x110cd);
            public static FormLink<IFormListGetter> DLC1VQ08CelannStormTheCastleOverrideStack => Construct(0x110cc);
            public static FormLink<IFormListGetter> DLC1VQ08BelevalStormTheCastleOverrideStack => Construct(0x110cb);
            public static FormLink<IFormListGetter> DLC1VQ08AgmaerStormTheCastleOverrideStack => Construct(0x110ca);
            public static FormLink<IFormListGetter> DLC1VQ08IsranStormTheCastleOverrideStack => Construct(0x110c8);
            public static FormLink<IFormListGetter> DLC1critterInsectsAncestorMothsPlayerFollow => Construct(0x10e03);
            public static FormLink<IFormListGetter> DLC1dunHarkonGargoyleList => Construct(0xf4e4);
            public static FormLink<IFormListGetter> DLC1SoulCairnWispSpellsListVAMP => Construct(0xeba4);
            public static FormLink<IFormListGetter> DLC1SoulCairnWispSpellsListDG => Construct(0xeb57);
            public static FormLink<IFormListGetter> HeadPartsSerana => Construct(0xe88d);
            public static FormLink<IFormListGetter> DLC1dunHarkonBossBattleCombatOverride => Construct(0xd1c1);
            public static FormLink<IFormListGetter> DLC1RH04Voices => Construct(0x6786);
            public static FormLink<IFormListGetter> DLC1VQ03MothpriestCombatStack => Construct(0x59db);
            public static FormLink<IFormListGetter> DLC1SoulCairnWispSpellsList => Construct(0x515f);
            public static FormLink<IFormListGetter> DLC1SeranaCureSpellRemovalList => Construct(0x504f);
            public static FormLink<IFormListGetter> DLC1SeranaCureKeywordRemovalList => Construct(0x504e);
            public static FormLink<IFormListGetter> DLC1SeranaCureFactionRemovalList => Construct(0x504d);
            public static FormLink<IFormListGetter> DLC1FlorentiusVendorItems => Construct(0x3f4f);
            public static FormLink<IFormListGetter> DLC01SoulcairnLRodGemList => Construct(0x2912);
            public static FormLink<IFormListGetter> SoulGemsEmpty => Construct(0x2844);
            public static FormLink<IFormListGetter> DLC01SoulCairnCritterlist => Construct(0x1a719);
            public static FormLink<IFormListGetter> DLC1TrapGasOnMagicEffectApply => Construct(0x1a689);
            public static FormLink<IFormListGetter> DLC1TrapGasMagicDrawn => Construct(0x1a688);
            public static FormLink<IFormListGetter> DLC1TrapGasOnHit => Construct(0x1a687);
            public static FormLink<IFormListGetter> DLC1TrapGasOnEnter => Construct(0x1a686);
            public static FormLink<IFormListGetter> DLC1trapGasWeapon => Construct(0x1a685);
            public static FormLink<IFormListGetter> DLC1VampireSpellsPowers => Construct(0x19ad9);
            public static FormLink<IFormListGetter> PortalGemKeyList => Construct(0x19abe);
            public static FormLink<IFormListGetter> DLC1VQ03Innkeepers => Construct(0x17a06);
            public static FormLink<IFormListGetter> DLC1VoicesThralls => Construct(0x162f6);
            public static FormLink<IFormListGetter> DLC1LD_ForgemasterCombatPackageList => Construct(0x15c37);
            public static FormLink<IFormListGetter> DLC1LD_KatriaHoldPositionList => Construct(0x1538a);
            public static FormLink<IFormListGetter> defaultHoldPositionLinkCustom02_1024UntilReleasedList => Construct(0x15371);
            public static FormLink<IFormListGetter> DLC1VoicesUnique => Construct(0x14fad);
            public static FormLink<IFormListGetter> DLC1LD_AetherialStaffScrapList => Construct(0x142bb);
            public static FormLink<IFormListGetter> DLC1TrollVoices => Construct(0x117f3);
            public static FormLink<IFormListGetter> DLC1LibraryBookList => Construct(0x10a43);
            public static FormLink<IFormListGetter> DLC01SoulCairnKeeperHoldList => Construct(0xea76);
            public static FormLink<IFormListGetter> DLC1LD_KatriaVoicetype => Construct(0xd009);
            public static FormLink<IFormListGetter> DLC1VampireHateFactions => Construct(0x989f);
            public static FormLink<IFormListGetter> DLC1critterInsectsAncestorMothss => Construct(0x71c8);
            public static FormLink<IFormListGetter> FemaleEvenTonedList => Construct(0x6765);
            public static FormLink<IFormListGetter> DLC1VoicesNonUnique => Construct(0x5e57);
            public static FormLink<IFormListGetter> DLC1RadiantHighProfileFactions => Construct(0x50c3);
            public static FormLink<IFormListGetter> HeadPartsHighElfSnow => Construct(0x3785);
            public static FormLink<IFormListGetter> DLC1_WESC04_VampireVoiceTypes => Construct(0x34f7);
            public static FormLink<IFormListGetter> Vo => Construct(0x34f6);
            public static FormLink<IFormListGetter> VoicesMaleSlyCynical => Construct(0x34f3);
            public static FormLink<IFormListGetter> VoicesMaleEvenTonedAccented => Construct(0x34e9);
            public static FormLink<IFormListGetter> DLC1DefaultPackageList => Construct(0x3424);
            public static FormLink<IFormListGetter> DLC1RNPCVoiceTypes => Construct(0x2b71);
        }
    }
}
