using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> DLC2dunBloodskalTreasChestLure => Construct(0x3d2a1);
            public static FormLink<IContainerGetter> DLC2fcTernGO => Construct(0x3cd8d);
            public static FormLink<IContainerGetter> BarrelFish01_NoRespawn => Construct(0x3c366);
            public static FormLink<IContainerGetter> BarrelMeat01_NoRespawn => Construct(0x3c365);
            public static FormLink<IContainerGetter> DLC2DarkElfUrn01Food_NoRespawn => Construct(0x3c364);
            public static FormLink<IContainerGetter> DLC2DarkElfUrn01Ingredients_NoRespawn => Construct(0x3c363);
            public static FormLink<IContainerGetter> PersonalChestSmall_NoRespawn => Construct(0x3c361);
            public static FormLink<IContainerGetter> DLC2FrosselSafewithLock => Construct(0x3c250);
            public static FormLink<IContainerGetter> DLC2MQ06BookPuzzleChest => Construct(0x3b016);
            public static FormLink<IContainerGetter> DLC2TGCacheBarrel => Construct(0x3abe4);
            public static FormLink<IContainerGetter> DLC2GloverLootChest => Construct(0x3abe1);
            public static FormLink<IContainerGetter> DLC2DarkElfUrn01Ingredients => Construct(0x3ab51);
            public static FormLink<IContainerGetter> DLC2DarkElfUrn01AshYams => Construct(0x3ab50);
            public static FormLink<IContainerGetter> DLC2DarkElfUrn01Food => Construct(0x3a609);
            public static FormLink<IContainerGetter> DLC2WhiteRidgeKnapsack => Construct(0x3a4d6);
            public static FormLink<IContainerGetter> DLC2dunKolbjornTreasDraugrChestBoss => Construct(0x3a2b6);
            public static FormLink<IContainerGetter> TreasKnapsackEmpty => Construct(0x39f87);
            public static FormLink<IContainerGetter> DLC2dunFrostmoonTreasChest => Construct(0x35e25);
            public static FormLink<IContainerGetter> DLC2ElmusVendorChest => Construct(0x3572e);
            public static FormLink<IContainerGetter> DLC2TreasRieklingChestSnow => Construct(0x34b39);
            public static FormLink<IContainerGetter> DLC2WB01JournalChest => Construct(0x34022);
            public static FormLink<IContainerGetter> dlc2MerchMerchantsChest => Construct(0x31db4);
            public static FormLink<IContainerGetter> DLC2MaximianPack => Construct(0x30ca0);
            public static FormLink<IContainerGetter> DLC2TreasAlchemySatchelUncommon => Construct(0x2c467);
            public static FormLink<IContainerGetter> DLC2TreasAlchemySatchelRare => Construct(0x2c466);
            public static FormLink<IContainerGetter> DLC2TreasAlchemySatchelCommon => Construct(0x2c465);
            public static FormLink<IContainerGetter> DLC2TreasStrongBox => Construct(0x2c464);
            public static FormLink<IContainerGetter> DLC2TreasExplorerLootChestSnow => Construct(0x2c463);
            public static FormLink<IContainerGetter> DLC2TreasExplorerLootChest => Construct(0x2c462);
            public static FormLink<IContainerGetter> DLC2TreasApocryphaChestBoss => Construct(0x2c461);
            public static FormLink<IContainerGetter> DLC2TreasApocryphaChest => Construct(0x2c460);
            public static FormLink<IContainerGetter> DLC2TreasWerebearChestBoss => Construct(0x2c45f);
            public static FormLink<IContainerGetter> DLC2TreasWerebearChest => Construct(0x2c45e);
            public static FormLink<IContainerGetter> DLC2TreasWerewolfChestBoss => Construct(0x2c45a);
            public static FormLink<IContainerGetter> DLC2TreasWerewolfChest => Construct(0x2c458);
            public static FormLink<IContainerGetter> DLC2TreasWarlockChestBoss => Construct(0x2c456);
            public static FormLink<IContainerGetter> DLC2TreasWarlockChest => Construct(0x2c455);
            public static FormLink<IContainerGetter> DLC2RR03GratianSatchel => Construct(0x2b113);
            public static FormLink<IContainerGetter> DLC2TreasDraugrChestBoss => Construct(0x2aac2);
            public static FormLink<IContainerGetter> DLC2TreasDraugrChest => Construct(0x2aac1);
            public static FormLink<IContainerGetter> DLC2TreasBanditChestSnow => Construct(0x2aac0);
            public static FormLink<IContainerGetter> DLC2TreasBanditChestBoss => Construct(0x2aabf);
            public static FormLink<IContainerGetter> DLC2TreasBanditChest => Construct(0x2aabe);
            public static FormLink<IContainerGetter> DLC2TreasDwarvenJewelryBox => Construct(0x2aabd);
            public static FormLink<IContainerGetter> DLC2TreasDwarvenChestSmall => Construct(0x2aabc);
            public static FormLink<IContainerGetter> DLC2TreasDwarvenChestLarge => Construct(0x2aabb);
            public static FormLink<IContainerGetter> DLC2TreasDwarvenChestBoss => Construct(0x2aaba);
            public static FormLink<IContainerGetter> DLC2RR02BossChest => Construct(0x292a6);
            public static FormLink<IContainerGetter> DLC2ExpSpiderEggAlbino => Construct(0x28ea8);
            public static FormLink<IContainerGetter> TreasRieklingChestEMPTY => Construct(0x28211);
            public static FormLink<IContainerGetter> DLC2SV02AncarionChest => Construct(0x27e09);
            public static FormLink<IContainerGetter> DLC2ThirskBlacksmithChest => Construct(0x27108);
            public static FormLink<IContainerGetter> DLC02QASpellTomeContainer => Construct(0x26b69);
            public static FormLink<IContainerGetter> DLC02QAScrollContainer => Construct(0x26b68);
            public static FormLink<IContainerGetter> DLC02QABooksContainer => Construct(0x26b67);
            public static FormLink<IContainerGetter> DLC02QAMiscItemContainer => Construct(0x26b66);
            public static FormLink<IContainerGetter> DLC02QAPotionContainer => Construct(0x26b65);
            public static FormLink<IContainerGetter> DLC02QAIngredientContainer => Construct(0x26b64);
            public static FormLink<IContainerGetter> DLC02QAArmorContainer => Construct(0x26b63);
            public static FormLink<IContainerGetter> DLC02QAAmmoContainer => Construct(0x26b62);
            public static FormLink<IContainerGetter> DLC02QAWeaponContainer => Construct(0x26b61);
            public static FormLink<IContainerGetter> DLC2TreasRieklingChest => Construct(0x25e48);
            public static FormLink<IContainerGetter> DLC2TreasRieklingChestBoss => Construct(0x25e46);
            public static FormLink<IContainerGetter> DLC2RRFethisVendorChest => Construct(0x25020);
            public static FormLink<IContainerGetter> DLC2RRGarynVendorChest => Construct(0x2501f);
            public static FormLink<IContainerGetter> DLC2RRGeldisVendorChest => Construct(0x2501e);
            public static FormLink<IContainerGetter> DLC2RRGloverVendorChest => Construct(0x2501d);
            public static FormLink<IContainerGetter> DLC2RRMiloreVendorChest => Construct(0x2501c);
            public static FormLink<IContainerGetter> DLC2RRF05Strongbox => Construct(0x24fa5);
            public static FormLink<IContainerGetter> DLC2RRF01Barrel => Construct(0x24de2);
            public static FormLink<IContainerGetter> DLC02QAKeyContainer => Construct(0x248b8);
            public static FormLink<IContainerGetter> DLC2dunHaknirChest => Construct(0x24027);
            public static FormLink<IContainerGetter> DLC2RRHoldingSafe => Construct(0x20a41);
            public static FormLink<IContainerGetter> DLC2SkaalBlacksmithChest => Construct(0x1f897);
            public static FormLink<IContainerGetter> DLC2SkaalMerchantChest => Construct(0x1f88d);
            public static FormLink<IContainerGetter> DLC2RR02Safe => Construct(0x1f31c);
            public static FormLink<IContainerGetter> DLC2MerchantDremoraChest => Construct(0x1eec0);
            public static FormLink<IContainerGetter> DLC2dunFrostmoonVendorChest => Construct(0x1dc65);
            public static FormLink<IContainerGetter> DLC2ExpSpiderCraftingBooksContainer => Construct(0x1da1e);
            public static FormLink<IContainerGetter> testPhilSlotMachineSlot => Construct(0x18cd2);
            public static FormLink<IContainerGetter> testPhilArcaneConverterOutput => Construct(0x18cb9);
            public static FormLink<IContainerGetter> testPhilArcaneConverterInput => Construct(0x18cb8);
            public static FormLink<IContainerGetter> DLC2TreasDraugrAmbushCorpseWrapped01EMPTY => Construct(0x18c3b);
            public static FormLink<IContainerGetter> DLC2RieklingTent01 => Construct(0x18427);
            public static FormLink<IContainerGetter> DLC2MerchantTelMithrynNelothChest => Construct(0x177c1);
            public static FormLink<IContainerGetter> DLC2MerchantTelMithrynTalvasChest => Construct(0x177c0);
            public static FormLink<IContainerGetter> DLC2MerchantTelMithrynElyneasChest => Construct(0x177be);
            public static FormLink<IContainerGetter> DLC2dunNchardakCubeChest => Construct(0x173bd);
            public static FormLink<IContainerGetter> DLC2ExpSpiderCraftingChest => Construct(0x1705c);
        }
    }
}
