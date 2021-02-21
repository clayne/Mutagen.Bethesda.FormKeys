using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Outfit
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IOutfitGetter> Construct(uint id) => new FormLink<IOutfitGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IOutfitGetter> DLC1VampireClotheOnly => Construct(0x12240);
            public static FormLink<IOutfitGetter> DLC1HarkonDummyOutfit => Construct(0x11be4);
            public static FormLink<IOutfitGetter> DLC1TestVampSkeletonOutfit => Construct(0x10e16);
            public static FormLink<IOutfitGetter> DLC1SeranaOutfitHooded => Construct(0x10dd2);
            public static FormLink<IOutfitGetter> DLC1VCSkeletonArmorMage => Construct(0x10d66);
            public static FormLink<IOutfitGetter> DLC1VCSkeletonArmorOutfit4 => Construct(0x10d65);
            public static FormLink<IOutfitGetter> DLC1VCSkeletonArmorOutfit3 => Construct(0x10d64);
            public static FormLink<IOutfitGetter> DLC1VCSkeletonArmorOutfit1 => Construct(0x10d63);
            public static FormLink<IOutfitGetter> DLC1VCSkeletonArmorOutfit2 => Construct(0x10d62);
            public static FormLink<IOutfitGetter> DLC1GargoyleBossSTONEoutfit => Construct(0x10cff);
            public static FormLink<IOutfitGetter> DLC1VigilantAdalvaldOutfit => Construct(0xfbf4);
            public static FormLink<IOutfitGetter> DLC1VCFeralVampireOutfit => Construct(0xcae0);
            public static FormLink<IOutfitGetter> DLC1VolkiharVampireOutfitLightRed => Construct(0x67cd);
            public static FormLink<IOutfitGetter> DLC1VolkiharVampireOutfitRandom => Construct(0x677e);
            public static FormLink<IOutfitGetter> DLC1VolkiharVampireOutfitGrayLight => Construct(0x677d);
            public static FormLink<IOutfitGetter> DLC1VolkiharVampireOutfitRed => Construct(0x677c);
            public static FormLink<IOutfitGetter> DLC1RadiantDisguisedVampireLordOutfit => Construct(0x4209);
            public static FormLink<IOutfitGetter> DLC1MalkusOutfit => Construct(0x3d06);
            public static FormLink<IOutfitGetter> DLC1OutfitVanik => Construct(0x3d04);
            public static FormLink<IOutfitGetter> DLC1GeleborOutfit => Construct(0x2b49);
            public static FormLink<IOutfitGetter> DLC1SurgeonOutfit => Construct(0x2ad5);
            public static FormLink<IOutfitGetter> DLC1FalmerVampFrozenShamenOutfit => Construct(0x1aacd);
            public static FormLink<IOutfitGetter> DLC01SoulCairnReaperOutfit => Construct(0x1a73d);
            public static FormLink<IOutfitGetter> DLC1TrollArmored => Construct(0x19821);
            public static FormLink<IOutfitGetter> DLC1RuunvaldMoricOutfit => Construct(0x19583);
            public static FormLink<IOutfitGetter> DLC1NecromancerOutfitHoodOnly => Construct(0x17e9c);
            public static FormLink<IOutfitGetter> DLC1ValericaOutfit => Construct(0x16904);
            public static FormLink<IOutfitGetter> DLC1SeranaOutfit => Construct(0x16903);
            public static FormLink<IOutfitGetter> DLC1OutfitSoulCairnRiderOutfit => Construct(0x163d1);
            public static FormLink<IOutfitGetter> DLC1HarkonOutfit => Construct(0x15ccd);
            public static FormLink<IOutfitGetter> DLC1vampireOutfitHigh => Construct(0x15ccc);
            public static FormLink<IOutfitGetter> DLC1FalmerHeavyOutfit => Construct(0x15cab);
            public static FormLink<IOutfitGetter> DLC1PrelateOutfit => Construct(0x1570f);
            public static FormLink<IOutfitGetter> DLC1VyrthurOutfit => Construct(0x153af);
            public static FormLink<IOutfitGetter> DLC1MothPriestBlindfoldOutfit => Construct(0x153ae);
            public static FormLink<IOutfitGetter> DLC1MothPriestNoBlindfoldOutfit => Construct(0x153ad);
            public static FormLink<IOutfitGetter> DLC1DragonIceLakeSkinOutfit => Construct(0x14ec1);
            public static FormLink<IOutfitGetter> DLC1DragonPurpleSkinOutfit => Construct(0x14eb4);
            public static FormLink<IOutfitGetter> DLC1_WESC09TaronOutfit => Construct(0x14c02);
            public static FormLink<IOutfitGetter> DLC1_WESC09TaronGuardOutfit03 => Construct(0x14c01);
            public static FormLink<IOutfitGetter> DLC1_WESC09TaronGuardOutfit02 => Construct(0x14c00);
            public static FormLink<IOutfitGetter> DLC1_WESC09TaronGuardOutfit01 => Construct(0x14bff);
            public static FormLink<IOutfitGetter> DLC1LD_BookCorpse1Outfit => Construct(0x146d8);
            public static FormLink<IOutfitGetter> DLC1OutfitAgmaer => Construct(0x146be);
            public static FormLink<IOutfitGetter> DLC1OutfitFlorentius => Construct(0x146bd);
            public static FormLink<IOutfitGetter> DLC1OutfitSorine => Construct(0x146bc);
            public static FormLink<IOutfitGetter> DLC1OutfitGunmar => Construct(0x146bb);
            public static FormLink<IOutfitGetter> DLC1OutfitIsran => Construct(0x146ba);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguardAll => Construct(0x146b9);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguard05 => Construct(0x146b8);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguard04 => Construct(0x146b7);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguard03 => Construct(0x146b6);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguard02Heavy => Construct(0x146b5);
            public static FormLink<IOutfitGetter> DawnguardArmorMelee => Construct(0x14218);
            public static FormLink<IOutfitGetter> DLC1VolkiharVampireOutfitGray => Construct(0x13af9);
            public static FormLink<IOutfitGetter> DLC1dunHarkonVampireLordRoyalOutfit => Construct(0x11a89);
            public static FormLink<IOutfitGetter> DLC1VampireLordOutfit => Construct(0x11a87);
            public static FormLink<IOutfitGetter> DLC1DragonUndeadSkinOutfit => Construct(0x11a73);
            public static FormLink<IOutfitGetter> DLC1LD_KatriaGhostOutfit => Construct(0xd034);
            public static FormLink<IOutfitGetter> DLC1dunRedwaterDenBouncerOutfit => Construct(0x8d7e);
            public static FormLink<IOutfitGetter> DLC01SoulCairnKeeperOutfit => Construct(0x7b0c);
            public static FormLink<IOutfitGetter> DLC1SCWrathmanOutfit01 => Construct(0x71b0);
            public static FormLink<IOutfitGetter> DLC1OutfitDawnguard01Heavy => Construct(0x50be);
            public static FormLink<IOutfitGetter> DLC1LD_KatriaOutfit => Construct(0x4d44);
            public static FormLink<IOutfitGetter> DLC1_WESC06_DawnguardOutfit => Construct(0x351c);
            public static FormLink<IOutfitGetter> DLC1_WESC02_VigilantVampireOutfitNoHood => Construct(0x34ef);
            public static FormLink<IOutfitGetter> DLC1_WESC02_VigilantVampireOutfitHood => Construct(0x34ed);
        }
    }
}
