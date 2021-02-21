using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Book
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IBookGetter> DLC2SpellTomeConjureAshSpawn => Construct(0x1e2b1);
            public static FormLink<IBookGetter> DLC2dunFahlbtharzJournal02 => Construct(0x3b53e);
            public static FormLink<IBookGetter> DLC2Book2CommonThirskARevisedHistory => Construct(0x3b3a5);
            public static FormLink<IBookGetter> DLC2Book2CommonRedYear02 => Construct(0x3b064);
            public static FormLink<IBookGetter> DLC2Book2CommonRedYear01 => Construct(0x3b063);
            public static FormLink<IBookGetter> DLC2Book2CommonTheReclamations => Construct(0x3b052);
            public static FormLink<IBookGetter> DLC2Book2CommonRavenRock03 => Construct(0x3af1d);
            public static FormLink<IBookGetter> DLC2Book2CommonRavenRock02 => Construct(0x3af1c);
            public static FormLink<IBookGetter> DLC2Book2CommonRavenRock01 => Construct(0x3af1b);
            public static FormLink<IBookGetter> DLC2Book4RareGuardianAndTheTraitor => Construct(0x3abcd);
            public static FormLink<IBookGetter> DLC2Book3ValuableChildrenOfTheAllMaker => Construct(0x3abcc);
            public static FormLink<IBookGetter> DLC2RRLetterMorvayn02 => Construct(0x3a4dd);
            public static FormLink<IBookGetter> DLC2RRLetterMorvayn01 => Construct(0x3a4dc);
            public static FormLink<IBookGetter> DLC2RRLetterIenthHouse01 => Construct(0x3a4b4);
            public static FormLink<IBookGetter> DLC2RRLetterBulwark01 => Construct(0x3a4b3);
            public static FormLink<IBookGetter> DLC2RRLetterDinyaHouse01 => Construct(0x3a4b2);
            public static FormLink<IBookGetter> DLC2MQ06PuzzleBook04 => Construct(0x3a362);
            public static FormLink<IBookGetter> DLC2MQ06PuzzleBook03 => Construct(0x3a361);
            public static FormLink<IBookGetter> DLC2MQ06PuzzleBook02 => Construct(0x3a360);
            public static FormLink<IBookGetter> DLC2MQ06PuzzleBook01 => Construct(0x3a35f);
            public static FormLink<IBookGetter> DLC2RRLetterFethisHouse03 => Construct(0x3a2a2);
            public static FormLink<IBookGetter> DLC2RRLetterFethisHouse02 => Construct(0x3a2a1);
            public static FormLink<IBookGetter> DLC2RRLetterFethisHouse01 => Construct(0x3a2a0);
            public static FormLink<IBookGetter> DLC2dunGyldenhulNote => Construct(0x3780a);
            public static FormLink<IBookGetter> DLC2dunKagrumezRalethJournal01 => Construct(0x374d6);
            public static FormLink<IBookGetter> DLC2WE11Note => Construct(0x37251);
            public static FormLink<IBookGetter> DLC2Book4RareDeathbrand => Construct(0x3661a);
            public static FormLink<IBookGetter> DLC2dunKolbjornCourierNote04 => Construct(0x36602);
            public static FormLink<IBookGetter> DLC2dunKolbjornCourierNote03 => Construct(0x36601);
            public static FormLink<IBookGetter> DLC2dunKolbjornCourierNote02 => Construct(0x36600);
            public static FormLink<IBookGetter> DLC2dunKolbjornCourierNote01 => Construct(0x365ff);
            public static FormLink<IBookGetter> DLC2POIUshaNote01 => Construct(0x3537c);
            public static FormLink<IBookGetter> dlc2MerchNote => Construct(0x33c7d);
            public static FormLink<IBookGetter> DLC2SpellTomeConjureSeeker => Construct(0x33c67);
            public static FormLink<IBookGetter> DLC2Book4RareAhzidalsDescent => Construct(0x33bd8);
            public static FormLink<IBookGetter> DLC2CultistOrders => Construct(0x331c2);
            public static FormLink<IBookGetter> DLC2SV02ThalmorNote => Construct(0x33154);
            public static FormLink<IBookGetter> DLC2dunFahlbtharzJournal01 => Construct(0x32cd5);
            public static FormLink<IBookGetter> DLC2BlackBookGeneric => Construct(0x32198);
            public static FormLink<IBookGetter> DLC2dunBloodskalNote01 => Construct(0x31cc8);
            public static FormLink<IBookGetter> DLC2FrostmothLetter04 => Construct(0x30c9d);
            public static FormLink<IBookGetter> DLC2FrostmothLetter03 => Construct(0x30c9c);
            public static FormLink<IBookGetter> DLC2FrostmothLetter02 => Construct(0x30c9b);
            public static FormLink<IBookGetter> DLC2FrostmothLetter01 => Construct(0x30c9a);
            public static FormLink<IBookGetter> DLC2RRF07Book => Construct(0x2bac7);
            public static FormLink<IBookGetter> DLC2HrodulfsHouseNote01 => Construct(0x2b23b);
            public static FormLink<IBookGetter> DLC2HrodulfsHouseNote00 => Construct(0x2b23a);
            public static FormLink<IBookGetter> DLC2TGLetter => Construct(0x2ad41);
            public static FormLink<IBookGetter> DLC2TGFormula => Construct(0x2ad3c);
            public static FormLink<IBookGetter> DLC2Book3ValuableTrap => Construct(0x29102);
            public static FormLink<IBookGetter> DLC2HrodulfJournal => Construct(0x28faf);
            public static FormLink<IBookGetter> DLC2Book2CommonWordsoftheWind => Construct(0x28277);
            public static FormLink<IBookGetter> DLC2Book3ValuableVarietiesofFaithintheEmpire => Construct(0x28276);
            public static FormLink<IBookGetter> DLC2Book2CommonTrueNoblesCode => Construct(0x28275);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong7 => Construct(0x28274);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong6 => Construct(0x28273);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong5 => Construct(0x28272);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong4 => Construct(0x28271);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong3 => Construct(0x28270);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong2 => Construct(0x2826f);
            public static FormLink<IBookGetter> DLC2Book1CheapPoisonSong1 => Construct(0x2826e);
            public static FormLink<IBookGetter> DLC2Book2CommonTheAxeMan => Construct(0x2826d);
            public static FormLink<IBookGetter> DLC2Book3ValuableTheAnticipations => Construct(0x2826c);
            public static FormLink<IBookGetter> DLC2Book4RareNerevaratRedMountain => Construct(0x2826b);
            public static FormLink<IBookGetter> DLC2Book4RareNchunaksFireandFaith => Construct(0x2826a);
            public static FormLink<IBookGetter> DLC2Book2ReligiousLivesoftheSaints => Construct(0x28269);
            public static FormLink<IBookGetter> DLC2Book2CommonHouseofTroubles => Construct(0x28268);
            public static FormLink<IBookGetter> DLC2Book2CommonFiveFarStars => Construct(0x28267);
            public static FormLink<IBookGetter> DLC2Book3ValuableWherewereyouDragonBroke => Construct(0x28266);
            public static FormLink<IBookGetter> DLC2Book2ReligiousDoorsoftheSpirit => Construct(0x28265);
            public static FormLink<IBookGetter> DLC2Book1CheapConfessionsofaDunmerSkoomaEater => Construct(0x28264);
            public static FormLink<IBookGetter> DLC2Book3ValuableChangedOnes => Construct(0x28263);
            public static FormLink<IBookGetter> DLC2Book2CommonBonePartII => Construct(0x28262);
            public static FormLink<IBookGetter> DLC2Book2CommonBonePartI => Construct(0x28261);
            public static FormLink<IBookGetter> DLC2WhiteRidgeBarrowMerilarsJournal => Construct(0x280c2);
            public static FormLink<IBookGetter> DLC2WhiteRidgeBarrowServosJournal => Construct(0x280c1);
            public static FormLink<IBookGetter> DLC2WE08Note => Construct(0x27e9f);
            public static FormLink<IBookGetter> DLC2IldariJournalV3 => Construct(0x27e4f);
            public static FormLink<IBookGetter> DLC2IldariJournalV2 => Construct(0x27e4e);
            public static FormLink<IBookGetter> DLC2IldariJournalV1 => Construct(0x27e4d);
            public static FormLink<IBookGetter> DLC2WE06Note => Construct(0x27a21);
            public static FormLink<IBookGetter> DLC2WE05Note => Construct(0x27a13);
            public static FormLink<IBookGetter> DLC2dunKolbjornMinersNote => Construct(0x277f1);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPackmule => Construct(0x274a1);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookOil => Construct(0x27498);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookGlowing => Construct(0x27496);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockJumping2x => Construct(0x26d5a);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockJumping => Construct(0x26d59);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockCloak2x => Construct(0x26d58);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockCloak => Construct(0x26d57);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockBomb2x => Construct(0x26d56);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookShockBomb => Construct(0x26d55);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostJumping2x => Construct(0x26d44);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostJumping => Construct(0x26d43);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostCloak2x => Construct(0x26d42);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostCloak => Construct(0x26d41);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostBomb2x => Construct(0x26d40);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFrostBomb => Construct(0x26d3f);
            public static FormLink<IBookGetter> DLC2RR01AlternateMessage => Construct(0x26ae8);
            public static FormLink<IBookGetter> DLC2RR01ExperimentJournal => Construct(0x26ae7);
            public static FormLink<IBookGetter> DLC2WB01Journal => Construct(0x26562);
            public static FormLink<IBookGetter> DLC2HorkerIslandJournal => Construct(0x2649c);
            public static FormLink<IBookGetter> DLC2RR03GratiansLetter => Construct(0x20a44);
            public static FormLink<IBookGetter> DLC2RR03GratiansJournal => Construct(0x20a2f);
            public static FormLink<IBookGetter> DLC2SpellTomePoisonRune => Construct(0x20685);
            public static FormLink<IBookGetter> DLC2MogrulNote => Construct(0x1ff2a);
            public static FormLink<IBookGetter> DLC2RR02EvidenceNote => Construct(0x1f31b);
            public static FormLink<IBookGetter> DLC2BlackBook07 => Construct(0x1e99f);
            public static FormLink<IBookGetter> DLC2BlackBook06 => Construct(0x1e99e);
            public static FormLink<IBookGetter> DLC2BlackBook05 => Construct(0x1e99d);
            public static FormLink<IBookGetter> DLC2BlackBook04 => Construct(0x1e99c);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookMindControl => Construct(0x1da1c);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonCloak2x => Construct(0x1da1a);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonCloak => Construct(0x1da19);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonJumping2x => Construct(0x1da18);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonJumping => Construct(0x1da17);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonBomb2x => Construct(0x1da16);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookPoisonBomb => Construct(0x1da15);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireJumping2x => Construct(0x1da14);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireJumping => Construct(0x1da13);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireCloak2x => Construct(0x1da12);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireCloak => Construct(0x1da11);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireBomb2x => Construct(0x1da10);
            public static FormLink<IBookGetter> DLC2ExpSpiderCrftBookFireBomb => Construct(0x1da0f);
            public static FormLink<IBookGetter> DLC2TTR3bWindAndSand => Construct(0x1d8d0);
            public static FormLink<IBookGetter> DLC2SpellTomeBoundDagger => Construct(0x1ce07);
            public static FormLink<IBookGetter> DLC2SV02Map => Construct(0x1caf2);
            public static FormLink<IBookGetter> DLC2RR01WarMessage => Construct(0x1bfe5);
            public static FormLink<IBookGetter> dunNchuandZelKragBookDUPLICATE001 => Construct(0x1bef1);
            public static FormLink<IBookGetter> DLC2DunDBRiddle04 => Construct(0x1ad50);
            public static FormLink<IBookGetter> DLC2SpellTomeConjureAshGuardian => Construct(0x1aaba);
            public static FormLink<IBookGetter> DLC2dunKolbjornRalisJournal05 => Construct(0x181cb);
            public static FormLink<IBookGetter> DLC2dunKolbjornRalisJournal04 => Construct(0x18111);
            public static FormLink<IBookGetter> DLC2dunKolbjornRalisJournal03 => Construct(0x18110);
            public static FormLink<IBookGetter> DLC2dunKolbjornRalisJournal02 => Construct(0x1810f);
            public static FormLink<IBookGetter> DLC2dunKolbjornRalisJournal01 => Construct(0x18108);
            public static FormLink<IBookGetter> DLC2SpellTomeFrenzyRune => Construct(0x177bd);
            public static FormLink<IBookGetter> DLC2SpellTomeAshRune => Construct(0x177b5);
            public static FormLink<IBookGetter> DLC2SpellTomeWhirlwindCloak => Construct(0x177ad);
            public static FormLink<IBookGetter> DLC2SpellTomeAshShell => Construct(0x177ac);
            public static FormLink<IBookGetter> DLC2DunDBRiddle03 => Construct(0x17381);
            public static FormLink<IBookGetter> DLC2DunDBRiddle02 => Construct(0x17276);
            public static FormLink<IBookGetter> DLC2DunDBRiddle01 => Construct(0x17215);
            public static FormLink<IBookGetter> DLC2ExpSpiderExperimentJournal => Construct(0x17072);
            public static FormLink<IBookGetter> DLC2BlackBook03 => Construct(0x16e2d);
            public static FormLink<IBookGetter> DLC2BlackBook02 => Construct(0x16e2c);
            public static FormLink<IBookGetter> DLC2BlackBook01 => Construct(0x16e22);
        }
    }
}
