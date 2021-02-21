using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Tree
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITreeGetter> Mbush16 => Construct(0x1f392);
            public static FormLink<ITreeGetter> Dbush15 => Construct(0x1f390);
            public static FormLink<ITreeGetter> Mbush13 => Construct(0x1f387);
            public static FormLink<ITreeGetter> Dbush09 => Construct(0x1f385);
            public static FormLink<ITreeGetter> Dbush08 => Construct(0x1f384);
            public static FormLink<ITreeGetter> Dbush04 => Construct(0x1f382);
            public static FormLink<ITreeGetter> DBush03 => Construct(0x1b01c);
            public static FormLink<ITreeGetter> DementiaTree10 => Construct(0x1b019);
            public static FormLink<ITreeGetter> DementiaTree04 => Construct(0x1b017);
            public static FormLink<ITreeGetter> DementiaTree02L => Construct(0x1b015);
            public static FormLink<ITreeGetter> ManiaTree09 => Construct(0x1b00b);
            public static FormLink<ITreeGetter> ManiaTree08 => Construct(0x1b009);
            public static FormLink<ITreeGetter> ManiaBush03 => Construct(0x1b005);
            public static FormLink<ITreeGetter> ManiaBush02 => Construct(0x1b003);
            public static FormLink<ITreeGetter> ManiaBush01 => Construct(0x1b001);
            public static FormLink<ITreeGetter> ManiaTree05 => Construct(0x1affa);
            public static FormLink<ITreeGetter> DementiaTree10L => Construct(0x1aff8);
            public static FormLink<ITreeGetter> ManiaTree01 => Construct(0x1aff7);
            public static FormLink<ITreeGetter> ManiaTree06 => Construct(0x1aff4);
            public static FormLink<ITreeGetter> DementiaTree04L => Construct(0x1aff2);
            public static FormLink<ITreeGetter> DementiaTree01L => Construct(0x1afee);
            public static FormLink<ITreeGetter> DementiaTree02 => Construct(0x1afec);
            public static FormLink<ITreeGetter> DementiaTree01 => Construct(0x1afea);
            public static FormLink<ITreeGetter> ManiaTree04 => Construct(0x19f2c);
            public static FormLink<ITreeGetter> ManiaTree03 => Construct(0x19f2b);
            public static FormLink<ITreeGetter> ManiaTree02 => Construct(0x19542);
            public static FormLink<ITreeGetter> TreeSugarMapleSaplingSU => Construct(0x119495);
            public static FormLink<ITreeGetter> TreeJapaneseMaple => Construct(0x115dcc);
            public static FormLink<ITreeGetter> TreeWhitePineYoungFA => Construct(0xeed89);
            public static FormLink<ITreeGetter> TreeWhitePineForest01FA => Construct(0xeed88);
            public static FormLink<ITreeGetter> TreeWhitePineForestFA => Construct(0xeed87);
            public static FormLink<ITreeGetter> TreeSugarMapleSaplingFA => Construct(0xeed86);
            public static FormLink<ITreeGetter> TreeSugarMapleYoungFA => Construct(0xeed85);
            public static FormLink<ITreeGetter> TreeSugarMapleForest01FA => Construct(0xeed84);
            public static FormLink<ITreeGetter> TreeSugarMapleForestFA => Construct(0xeed83);
            public static FormLink<ITreeGetter> TreeSilverBirchYoungFA => Construct(0xeed82);
            public static FormLink<ITreeGetter> TreeSilverBirchForest01FA => Construct(0xeed81);
            public static FormLink<ITreeGetter> TreeSilverBirchForestFA => Construct(0xeed80);
            public static FormLink<ITreeGetter> TreeQuakingAspenYoungFA => Construct(0xeed7f);
            public static FormLink<ITreeGetter> TreeQuakingAspenForest01FA => Construct(0xeed7e);
            public static FormLink<ITreeGetter> TreeQuakingAspenForestFA => Construct(0xeed7d);
            public static FormLink<ITreeGetter> TreeEnglishOakYoungFA => Construct(0xeed7c);
            public static FormLink<ITreeGetter> TreeEnglishOakForest01FA => Construct(0xeed7b);
            public static FormLink<ITreeGetter> TreeEnglishOakForestFA => Construct(0xeed7a);
            public static FormLink<ITreeGetter> TreeEnglishOakSaplingFA => Construct(0xeed79);
            public static FormLink<ITreeGetter> TreeEastHemlockFA => Construct(0xeed77);
            public static FormLink<ITreeGetter> ShrubGenericInkberrySU => Construct(0xdfa4a);
            public static FormLink<ITreeGetter> ShrubGenericDaphneSU => Construct(0xdfa49);
            public static FormLink<ITreeGetter> ShrubGenericDaphneFA => Construct(0xdfa48);
            public static FormLink<ITreeGetter> ShrubGenericElderberrySU => Construct(0xdfa47);
            public static FormLink<ITreeGetter> ShrubGenericElderberryFA => Construct(0xdfa46);
            public static FormLink<ITreeGetter> ShrubGenericInkberryFA => Construct(0xdfa45);
            public static FormLink<ITreeGetter> ShrubGenericBuckthornSU => Construct(0xdfa44);
            public static FormLink<ITreeGetter> ShrubGenericBuckthornFA => Construct(0xdfa43);
            public static FormLink<ITreeGetter> ShrubBoxwoodFA => Construct(0xdfa42);
            public static FormLink<ITreeGetter> ShrubAzaleaFA => Construct(0xdfa41);
            public static FormLink<ITreeGetter> ShrubMugoPineFA => Construct(0xdfa40);
            public static FormLink<ITreeGetter> TreeSwampCypressForestFG08 => Construct(0x89789);
            public static FormLink<ITreeGetter> TreeCPSwampCypressForest => Construct(0x5dcd9);
            public static FormLink<ITreeGetter> TreeCPGinkgo => Construct(0x5dcd8);
            public static FormLink<ITreeGetter> TreeCPSnowGumFree => Construct(0x5dcd5);
            public static FormLink<ITreeGetter> TreeCamoranParadise04 => Construct(0x5dcd2);
            public static FormLink<ITreeGetter> TreeCamoranParadise02 => Construct(0x5dccf);
            public static FormLink<ITreeGetter> ShrubCamoranParadise => Construct(0x5dccc);
            public static FormLink<ITreeGetter> TreeCamoranParadise01 => Construct(0xa9476);
            public static FormLink<ITreeGetter> TreeRedwoodSmall => Construct(0x521c4);
            public static FormLink<ITreeGetter> TreeWhitePineSnow => Construct(0x3cedb);
            public static FormLink<ITreeGetter> TreeScotchPineForestSnow => Construct(0x3ceda);
            public static FormLink<ITreeGetter> TreeIronwoodWI => Construct(0x3ced9);
            public static FormLink<ITreeGetter> TreeEastHemlockSnow => Construct(0x3ced8);
            public static FormLink<ITreeGetter> ShrubVineMapleSnow => Construct(0x3ced6);
            public static FormLink<ITreeGetter> ShrubEuonymusSnow => Construct(0x3ced4);
            public static FormLink<ITreeGetter> ShrubEnglishHollySnow => Construct(0x3ced2);
            public static FormLink<ITreeGetter> TreeBlackLocust => Construct(0x3ced0);
            public static FormLink<ITreeGetter> TreeEnglishOakSaplingSU => Construct(0x3672c);
            public static FormLink<ITreeGetter> TreeEnglishHolly01 => Construct(0x3672b);
            public static FormLink<ITreeGetter> TreeGinkgo => Construct(0x22c57);
            public static FormLink<ITreeGetter> TreeSwampCypressForest => Construct(0x22c55);
            public static FormLink<ITreeGetter> TreeDeodar => Construct(0x22c53);
            public static FormLink<ITreeGetter> TreeSnowGumFree => Construct(0x22c50);
            public static FormLink<ITreeGetter> ShrubInkberrySU => Construct(0x22f3f);
            public static FormLink<ITreeGetter> ShrubSeaBuckthornSU => Construct(0x22f32);
            public static FormLink<ITreeGetter> ShrubForsythiaSU => Construct(0x22f2f);
            public static FormLink<ITreeGetter> TreeGCSycamoreSU => Construct(0x22f2c);
            public static FormLink<ITreeGetter> TreeDogwoodSU => Construct(0x1ff1d);
            public static FormLink<ITreeGetter> TreeWeepingWillowSU => Construct(0x1ff1a);
            public static FormLink<ITreeGetter> TreeCottonwoodSU => Construct(0x1e563);
            public static FormLink<ITreeGetter> TreeJuniper01 => Construct(0x1d45c);
            public static FormLink<ITreeGetter> ShrubDeadBush => Construct(0x18425);
            public static FormLink<ITreeGetter> TreeMS14CanvasFreeSU => Construct(0x173a5);
            public static FormLink<ITreeGetter> TreeIronwoodSU => Construct(0x148a1);
            public static FormLink<ITreeGetter> TreeEastHemlock => Construct(0x8b7e);
            public static FormLink<ITreeGetter> TreeMS14WillowOakYoungSU => Construct(0x1c203);
            public static FormLink<ITreeGetter> TreeMS14WillowOakFreeSU => Construct(0x1c202);
            public static FormLink<ITreeGetter> TreeMS14WillowOakForestSU => Construct(0x1c201);
            public static FormLink<ITreeGetter> ShrubMS14Boxwood => Construct(0x1c200);
            public static FormLink<ITreeGetter> TreeMS14WillowOakForest01SU => Construct(0x1c1ff);
            public static FormLink<ITreeGetter> TreeGreyPoplarForestSU => Construct(0x17f9e);
            public static FormLink<ITreeGetter> TreeYewForest => Construct(0x17f98);
            public static FormLink<ITreeGetter> TreeScotchPineForest => Construct(0x153a3);
            public static FormLink<ITreeGetter> ShrubAzaleaPinkSU => Construct(0xbf43);
            public static FormLink<ITreeGetter> ShrubElderberry => Construct(0xbf41);
            public static FormLink<ITreeGetter> ShrubRhododendronSU => Construct(0x974f);
            public static FormLink<ITreeGetter> ShrubHydrangeaBlueSU => Construct(0x35a0e);
            public static FormLink<ITreeGetter> ShrubJapHoneysuckleSU => Construct(0x34df1);
            public static FormLink<ITreeGetter> ShrubDaphneSU => Construct(0x34dc9);
            public static FormLink<ITreeGetter> ShrubMugoPine => Construct(0x314e7);
            public static FormLink<ITreeGetter> TreeKvatchBurnt => Construct(0x2dbc7);
            public static FormLink<ITreeGetter> ShrubBoxwood => Construct(0x25070);
            public static FormLink<ITreeGetter> ShrubEnglishHolly => Construct(0x2506f);
            public static FormLink<ITreeGetter> ShrubEuonymusSU => Construct(0x262ff);
            public static FormLink<ITreeGetter> TreeRedwoodLarge => Construct(0x25104);
            public static FormLink<ITreeGetter> TreeWillowOakForest01SU => Construct(0x237ee);
            public static FormLink<ITreeGetter> TreeQuakingAspenForest01SU => Construct(0x237e8);
            public static FormLink<ITreeGetter> ShrubVineMapleSU => Construct(0x232db);
            public static FormLink<ITreeGetter> TreeSilverBirchForest01SU => Construct(0x232d9);
            public static FormLink<ITreeGetter> TreeWhitePineForest01 => Construct(0x232d8);
            public static FormLink<ITreeGetter> TreeSugarMapleForest01SU => Construct(0x232d7);
            public static FormLink<ITreeGetter> TreeEnglishOakForest01SU => Construct(0x232d6);
            public static FormLink<ITreeGetter> TreeSilverBirchFreeSU => Construct(0xbc0);
            public static FormLink<ITreeGetter> TreeQuakingAspenYoungSU => Construct(0x9fd);
            public static FormLink<ITreeGetter> TreeSugarMapleFreeSU => Construct(0x19da);
            public static FormLink<ITreeGetter> TreeSilverBirchYoungSU => Construct(0xbc2);
            public static FormLink<ITreeGetter> TreeWillowOakForestSU => Construct(0xbc4);
            public static FormLink<ITreeGetter> TreeWillowOakFreeSU => Construct(0xbc6);
            public static FormLink<ITreeGetter> TreeWillowOakYoungSU => Construct(0xbc9);
            public static FormLink<ITreeGetter> TreeSilverBirchForestSU => Construct(0x9fe);
            public static FormLink<ITreeGetter> TreeSugarMapleForestSU => Construct(0x89b);
            public static FormLink<ITreeGetter> TreeSugarMapleYoungSU => Construct(0x8b2);
            public static FormLink<ITreeGetter> ShrubAzaleaSU => Construct(0x89c);
            public static FormLink<ITreeGetter> TreeWhitePineFree => Construct(0x87f);
            public static FormLink<ITreeGetter> TestToddTree => Construct(0x898);
            public static FormLink<ITreeGetter> TestToddTree02 => Construct(0x899);
            public static FormLink<ITreeGetter> TreeQuakingAspenForestSU => Construct(0x9e9);
            public static FormLink<ITreeGetter> TreeEnglishOakUnique01SU => Construct(0xb67);
            public static FormLink<ITreeGetter> TreeEnglishOakForestSU => Construct(0xb79);
            public static FormLink<ITreeGetter> TreeEnglishOakFreeSU => Construct(0xb7b);
            public static FormLink<ITreeGetter> TreeEnglishOakYoungSU => Construct(0xb7c);
            public static FormLink<ITreeGetter> TreeWhitePineForest => Construct(0xb7d);
            public static FormLink<ITreeGetter> TreeWhitePineYoung => Construct(0xb7e);
            public static FormLink<ITreeGetter> TreeQuakingAspenFreeSU => Construct(0x9fa);
            public static FormLink<ITreeGetter> TestToddTree03 => Construct(0x17fc);
        }
    }
}
