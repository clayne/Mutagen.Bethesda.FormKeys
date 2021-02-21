using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Cell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICellGetter> XTestRyanInt => Construct(0x477c);
            public static FormLink<ICellGetter> DLC1VQHoldingCell => Construct(0x15054);
            public static FormLink<ICellGetter> DLC1DawnguardHQ01 => Construct(0x1dba);
            public static FormLink<ICellGetter> TestTony => Construct(0x792c);
            public static FormLink<ICellGetter> DLC1Arkngthamz01 => Construct(0x140a);
            public static FormLink<ICellGetter> DLC1VampireCastleDungeon02 => Construct(0x285a);
            public static FormLink<ICellGetter> DLC1HunterCave02 => Construct(0x181c8);
            public static FormLink<ICellGetter> TestJoelDLC01 => Construct(0x1a68a);
            public static FormLink<ICellGetter> DLC1zFalmerValley04 => Construct(0x18ce1);
            public static FormLink<ICellGetter> DLC1zFalmerValley02 => Construct(0x8995);
            public static FormLink<ICellGetter> DLC1VampireCastleDungeon01 => Construct(0x285b);
            public static FormLink<ICellGetter> DLC1SoulCairnReaperCell => Construct(0x6429);
            public static FormLink<ICellGetter> DLC1WarehouseAmbushes => Construct(0x74f5);
            public static FormLink<ICellGetter> DLC1VampireCastleGuildhall => Construct(0x803);
            public static FormLink<ICellGetter> TestCoryDLC01 => Construct(0x64b5);
            public static FormLink<ICellGetter> DLC1HunterCave01 => Construct(0x9bde);
            public static FormLink<ICellGetter> DLC1DarkfallCave01 => Construct(0x4346);
            public static FormLink<ICellGetter> DLC1zFalmerValley01 => Construct(0x8482);
            public static FormLink<ICellGetter> VampireDungeon01 => Construct(0x804);
            public static FormLink<ICellGetter> DLC1VampireCastleBossRoom => Construct(0x19dfe);
            public static FormLink<ICellGetter> DLC1NPCHome => Construct(0x2b69);
            public static FormLink<ICellGetter> DLC1DBTest => Construct(0xdf7d);
            public static FormLink<ICellGetter> DLC1MolderingRuins01 => Construct(0x285d);
            public static FormLink<ICellGetter> DLC1VampireCastleZCell2 => Construct(0x154d5);
            public static FormLink<ICellGetter> DLC1TestCellRJ => Construct(0x7065);
            public static FormLink<ICellGetter> DLC1Bthalft01 => Construct(0x5734);
            public static FormLink<ICellGetter> DLC1RedwaterDen02 => Construct(0x5eaa);
            public static FormLink<ICellGetter> DLC1HunterValleyCave01 => Construct(0x8e52);
            public static FormLink<ICellGetter> testJoelDLCholdingCell => Construct(0x3358);
            public static FormLink<ICellGetter> DLC1Ruunvald01 => Construct(0x3bf0);
            public static FormLink<ICellGetter> DLC1Ruunvald02 => Construct(0x7066);
            public static FormLink<ICellGetter> DLC1FalmerTemple01 => Construct(0x384f);
            public static FormLink<ICellGetter> DLC1RedwaterDen01 => Construct(0x5eab);
            public static FormLink<ICellGetter> DLC1zFalmerValley03 => Construct(0x10a8b);
            public static FormLink<ICellGetter> DLC1VampireCastleTest => Construct(0x811);
            public static FormLink<ICellGetter> TestBrieDLC => Construct(0x37d7);
            public static FormLink<ICellGetter> testFalmer => Construct(0x362a);
            public static FormLink<ICellGetter> DLC1LDUtilityCell => Construct(0x66a4);
            public static FormLink<ICellGetter> SoulCairnZcell01 => Construct(0x6439);
            public static FormLink<ICellGetter> DLC1DimHollowCrypt02 => Construct(0xeb7);
            public static FormLink<ICellGetter> DLC1zSoulCairn01 => Construct(0xa903);
            public static FormLink<ICellGetter> DLC1GlacialCrevice01 => Construct(0x1c09);
            public static FormLink<ICellGetter> testL => Construct(0x42b5);
            public static FormLink<ICellGetter> DLC1VampireCastleZCell1 => Construct(0x7203);
            public static FormLink<ICellGetter> testPhil => Construct(0x7d94);
            public static FormLink<ICellGetter> DLC1DimHollowCrypt01 => Construct(0xeb8);
            public static FormLink<ICellGetter> TESTRyanJDLC => Construct(0x1db9);
            public static FormLink<ICellGetter> DLC1WarehousePrefabs => Construct(0xa3bf);
            public static FormLink<ICellGetter> TestRSearsDLC01 => Construct(0x373b);
            public static FormLink<ICellGetter> testGiant => Construct(0x7d95);
            public static FormLink<ICellGetter> DLC1FVWayShrine01 => Construct(0xc59);
            public static FormLink<ICellGetter> DLC1FalmerValleyCaveStart => Construct(0xc89);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI04 => Construct(0xc8d);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI02 => Construct(0xcc0);
            public static FormLink<ICellGetter> FalmerValleyStart => Construct(0xcfd);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI07 => Construct(0xd07);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI05 => Construct(0xcc5);
            public static FormLink<ICellGetter> DLC1FVWayShrine02 => Construct(0xd0a);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI06 => Construct(0xd0e);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI01 => Construct(0xccd);
            public static FormLink<ICellGetter> FalmerPlaygroundStart => Construct(0xcd4);
            public static FormLink<ICellGetter> DLC1FVWayShrine03 => Construct(0xcd5);
            public static FormLink<ICellGetter> FalmerPlayground => Construct(0xce5);
            public static FormLink<ICellGetter> testFrozen => Construct(0xd10);
            public static FormLink<ICellGetter> DLC1FalmerValleyForest01 => Construct(0x7cc4);
            public static FormLink<ICellGetter> DLC1FalmerRavineStart => Construct(0xc3a);
            public static FormLink<ICellGetter> DLC1FalmerValleyPOI03 => Construct(0xc46);
            public static FormLink<ICellGetter> TempleStart => Construct(0xc1d);
            public static FormLink<ICellGetter> DLC1FVWayShrine04 => Construct(0xc2d);
            public static FormLink<ICellGetter> DLC01TempleEntryCell => Construct(0xc99);
            public static FormLink<ICellGetter> DLC1FalmerValleyRiver01 => Construct(0xcbb);
            public static FormLink<ICellGetter> FalmerTempleExterior01 => Construct(0xcdb);
            public static FormLink<ICellGetter> FalmerTempleExterior02 => Construct(0xce4);
            public static FormLink<ICellGetter> FrozenLake01 => Construct(0xd14);
            public static FormLink<ICellGetter> SoulCairnPOIRJ06 => Construct(0x28bb);
            public static FormLink<ICellGetter> SoulCairnPOIRJ10 => Construct(0x28bd);
            public static FormLink<ICellGetter> DLC01SoulCairnBoneyardEntrance => Construct(0x28bf);
            public static FormLink<ICellGetter> DLC01SoulCairnOrigin => Construct(0x28ca);
            public static FormLink<ICellGetter> SoulCairnTome01 => Construct(0x2c67);
            public static FormLink<ICellGetter> DLC01SoulCairnCraterKeeper => Construct(0x2c75);
            public static FormLink<ICellGetter> SoulCairnPOIRJ08 => Construct(0x2c76);
            public static FormLink<ICellGetter> DLC01SoulCairnCraterKeeperStart => Construct(0x2c85);
            public static FormLink<ICellGetter> SoulCairnHorseQuest02 => Construct(0x2c86);
            public static FormLink<ICellGetter> SoulCairnPOIRJ07 => Construct(0x2c93);
            public static FormLink<ICellGetter> SoulCairnPOIRJ05 => Construct(0x2ca2);
            public static FormLink<ICellGetter> DLC01SoulCairnDragonLair => Construct(0x2cc4);
            public static FormLink<ICellGetter> SoulCairnPOIRJ02 => Construct(0x2c8a);
            public static FormLink<ICellGetter> SoulCairnPOIJiub => Construct(0x2c96);
            public static FormLink<ICellGetter> SoulCairnPOIRJ09 => Construct(0x2c97);
            public static FormLink<ICellGetter> SoulCairnTome03 => Construct(0x2c98);
            public static FormLink<ICellGetter> SoulCairnTest2 => Construct(0x2ca3);
            public static FormLink<ICellGetter> DLC01SoulCairnForestKeeper => Construct(0x2ca5);
            public static FormLink<ICellGetter> SoulCairnTest => Construct(0x28c3);
            public static FormLink<ICellGetter> SoulCairnPOI09 => Construct(0x2b1a);
            public static FormLink<ICellGetter> SoulCairnPOI06 => Construct(0x2b1e);
            public static FormLink<ICellGetter> SoulCairnPOI08 => Construct(0x2ce3);
            public static FormLink<ICellGetter> SoulCairnPOIMaze => Construct(0x2ce4);
            public static FormLink<ICellGetter> SCTest1 => Construct(0x2ce5);
            public static FormLink<ICellGetter> SoulCairnTome02 => Construct(0x2cf6);
            public static FormLink<ICellGetter> DLC01SoulCairnCemetaryKeeper => Construct(0x2d06);
            public static FormLink<ICellGetter> DLC01SoulCairnCemetaryKeeperStart => Construct(0x2d07);
            public static FormLink<ICellGetter> DLC01SoulCairnCemetaryKeeper01 => Construct(0x2d16);
            public static FormLink<ICellGetter> DLC01SoulCairnStart => Construct(0x28ba);
            public static FormLink<ICellGetter> SoulCairnPOI03 => Construct(0x2ccf);
            public static FormLink<ICellGetter> SoulCairnWallPOI01 => Construct(0x2cd9);
            public static FormLink<ICellGetter> LandscapeTest => Construct(0x2cda);
            public static FormLink<ICellGetter> SoulCairnWall01 => Construct(0x2ce9);
            public static FormLink<ICellGetter> SoulCairnPOI05 => Construct(0x2cea);
            public static FormLink<ICellGetter> SoulCairnPOI04 => Construct(0x2cec);
            public static FormLink<ICellGetter> SoulCairnPOI01 => Construct(0x2cf9);
            public static FormLink<ICellGetter> SoulCairnOffShoot => Construct(0x2cfa);
            public static FormLink<ICellGetter> SoulCairnStartAmbush => Construct(0x2cfb);
            public static FormLink<ICellGetter> SoulCairnHorseQuest => Construct(0x2cfc);
            public static FormLink<ICellGetter> SoulCairnHuskMerchant => Construct(0x2d45);
            public static FormLink<ICellGetter> SoulCairnHorseTrigger => Construct(0x2d47);
            public static FormLink<ICellGetter> DLC1HunterWorldFort02 => Construct(0x1dd9);
            public static FormLink<ICellGetter> DLC1HunterWorldFort01 => Construct(0x7bbf);
            public static FormLink<ICellGetter> DLC1DawnguardGate3 => Construct(0x1dd3);
            public static FormLink<ICellGetter> DLC1HunterWorldStart => Construct(0x7bb7);
            public static FormLink<ICellGetter> DLC1ForebearsHoldoutStart => Construct(0x2fb2);
            public static FormLink<ICellGetter> DLC1ForebearsHoldoutOrigin => Construct(0x2fbd);
            public static FormLink<ICellGetter> DLC1ForebearsHoldoutEnd => Construct(0x2fb7);
            public static FormLink<ICellGetter> DLC1AncestorGladeOrigin => Construct(0x48d6);
            public static FormLink<ICellGetter> DLC1AncestorGladePortcullis => Construct(0x48d0);
            public static FormLink<ICellGetter> DLC1AncestorGladeStart => Construct(0x48d1);
            public static FormLink<ICellGetter> DLC1DarkfallPassageStart => Construct(0x5ac5);
            public static FormLink<ICellGetter> DLC1DarkfallPassageOrigin => Construct(0x4bec);
            public static FormLink<ICellGetter> DLC1DarkfallPassageWayshrine01 => Construct(0x5abb);
            public static FormLink<ICellGetter> DLC1DarkfallPassageWayshrine02 => Construct(0x5ac1);
            public static FormLink<ICellGetter> DLC1DarkfallPassageEndStart => Construct(0x5ac8);
            public static FormLink<ICellGetter> DLC01BoneyardEntrance => Construct(0x53e4);
            public static FormLink<ICellGetter> DLC1VCCourtyardTowerExt => Construct(0x720c);
            public static FormLink<ICellGetter> DLC1VCCourtyardOrigin => Construct(0x721d);
        }
    }
}
