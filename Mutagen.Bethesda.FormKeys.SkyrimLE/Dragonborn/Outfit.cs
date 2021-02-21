using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Outfit
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IOutfitGetter> Construct(uint id) => new FormLink<IOutfitGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IOutfitGetter> DLC2TT2SkeletonInvisible => Construct(0x3cf36);
            public static FormLink<IOutfitGetter> DLC2DarkElfTempleOutfitNoHood => Construct(0x3ceee);
            public static FormLink<IOutfitGetter> DLC2DarkElfTempleOutfit => Construct(0x3ceed);
            public static FormLink<IOutfitGetter> DLC2DarkElfCommonOutfitRed => Construct(0x3ceec);
            public static FormLink<IOutfitGetter> DLC2DarkElfCommonOutfitRedNoHood => Construct(0x3ceeb);
            public static FormLink<IOutfitGetter> DLC2DarkElfCommonOutfitBlueNoHood => Construct(0x3ceea);
            public static FormLink<IOutfitGetter> DLC2DarkElfCommonOutfitBlue => Construct(0x3cee9);
            public static FormLink<IOutfitGetter> DLC2DarkElfCommonOutfit => Construct(0x3cee8);
            public static FormLink<IOutfitGetter> DLC2RRRedoranGuardOutfitNoHelmetNoShield => Construct(0x3ca5b);
            public static FormLink<IOutfitGetter> DLC2SkaalOutfitChild => Construct(0x3c81b);
            public static FormLink<IOutfitGetter> DLC2MQ06MiraakOutfit => Construct(0x3c40b);
            public static FormLink<IOutfitGetter> DLC2dunFahlbtharzExplorerOutfit => Construct(0x3b067);
            public static FormLink<IOutfitGetter> DLC2RieklingBanditCorpseArmor01 => Construct(0x3a1f1);
            public static FormLink<IOutfitGetter> DLC2SkaalOutfitChanceHat => Construct(0x39bbf);
            public static FormLink<IOutfitGetter> DLC2SkaalOutfitNoHat => Construct(0x39b34);
            public static FormLink<IOutfitGetter> DLC2StornOutfit => Construct(0x398cd);
            public static FormLink<IOutfitGetter> DLC2SkaalOutfitHat => Construct(0x398ca);
            public static FormLink<IOutfitGetter> DLC2HirelingTeldrynOutfit => Construct(0x38563);
            public static FormLink<IOutfitGetter> DLC2dunHaknirOutfit => Construct(0x37fed);
            public static FormLink<IOutfitGetter> DLC2dunHaknirGarukWindrimeOutfit => Construct(0x37fe8);
            public static FormLink<IOutfitGetter> DLC2dunHaknirThalinEbonhandOutfit => Construct(0x37fe7);
            public static FormLink<IOutfitGetter> DLC2ArmorNordicLight => Construct(0x37fe6);
            public static FormLink<IOutfitGetter> DLC2FineClothesOutfit02 => Construct(0x376dd);
            public static FormLink<IOutfitGetter> DLC2DremoraWarlockOutfit => Construct(0x376d8);
            public static FormLink<IOutfitGetter> DLC2dunAltarOfThrondOutfit => Construct(0x367b2);
            public static FormLink<IOutfitGetter> DLC2RRModynVelethOutfit => Construct(0x35e41);
            public static FormLink<IOutfitGetter> dlc2MerchMerchantOutfit => Construct(0x32800);
            public static FormLink<IOutfitGetter> DLC2SV02ThalmorOutfit02 => Construct(0x32123);
            public static FormLink<IOutfitGetter> DLC2SV02ThalmorOutfit01 => Construct(0x32122);
            public static FormLink<IOutfitGetter> DLC2VendilSeverinBattleOutfit => Construct(0x31c9c);
            public static FormLink<IOutfitGetter> DLC2DragonBlackBloodFXOutfit => Construct(0x31b4b);
            public static FormLink<IOutfitGetter> DLC2HermaeusMoraCultistOutfit => Construct(0x2bf43);
            public static FormLink<IOutfitGetter> DLC2TGEsmondTyneOutfit => Construct(0x2ad39);
            public static FormLink<IOutfitGetter> DLC2MoragTongOutfit => Construct(0x292af);
            public static FormLink<IOutfitGetter> DLC2EbonyWarriorOutfit => Construct(0x285c4);
            public static FormLink<IOutfitGetter> DLC2MogrulOutfit => Construct(0x271fe);
            public static FormLink<IOutfitGetter> DLC2SlitterOutfit => Construct(0x271fd);
            public static FormLink<IOutfitGetter> DLC2BanditArmorBoss => Construct(0x26b60);
            public static FormLink<IOutfitGetter> DLC2BanditArmorNoShieldOutfit => Construct(0x26b5b);
            public static FormLink<IOutfitGetter> DLC2BanditArmorMeleeShield20Outfit => Construct(0x26b46);
            public static FormLink<IOutfitGetter> DLC2AcolyteDukaanOutfit => Construct(0x248e4);
            public static FormLink<IOutfitGetter> DLC2AcolyteAhzidalOutfit => Construct(0x248e3);
            public static FormLink<IOutfitGetter> DLC2AcolyteZahkriisosOutfit => Construct(0x248e2);
            public static FormLink<IOutfitGetter> DLC2FreaOutfit => Construct(0x1fff4);
            public static FormLink<IOutfitGetter> DLC2dunFrostmoonOutfitAkar => Construct(0x1f9c8);
            public static FormLink<IOutfitGetter> DLC2dunFrostmoonOutfitRakel => Construct(0x1f9c7);
            public static FormLink<IOutfitGetter> DLC2dunFrostmoonOutfitHjordis => Construct(0x1f9c6);
            public static FormLink<IOutfitGetter> DLC2dunFrostmoonOutfitMajni => Construct(0x1dc66);
            public static FormLink<IOutfitGetter> DLC2dunKolbjornMinerOutfit => Construct(0x1dbc5);
            public static FormLink<IOutfitGetter> DLC2RR01FalxOutfit => Construct(0x1a577);
            public static FormLink<IOutfitGetter> DLC2RRRedoranGuardOutfit => Construct(0x195ae);
            public static FormLink<IOutfitGetter> DLC2MiraakOutfit => Construct(0x17f85);
            public static FormLink<IOutfitGetter> DLC2dunKolbjornRalisOutfit => Construct(0x179ca);
            public static FormLink<IOutfitGetter> DLC2DrovasOutfit => Construct(0x1777a);
            public static FormLink<IOutfitGetter> DLC2TalvasOutfit => Construct(0x17776);
            public static FormLink<IOutfitGetter> DLC2IldariOutfit => Construct(0x17748);
            public static FormLink<IOutfitGetter> DLC2NelothOutfit => Construct(0x17746);
        }
    }
}
