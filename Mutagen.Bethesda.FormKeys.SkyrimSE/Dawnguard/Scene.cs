using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Scene
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ISceneGetter> Construct(uint id) => new FormLink<ISceneGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTSCENEShiftBack => Construct(0x13f86);
            public static FormLink<ISceneGetter> DLC1WEJS02VampRunningScene => Construct(0x13e21);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCPassageOpened => Construct(0x13dfd);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCPutTheCandleDotDotDotBack => Construct(0x13dfc);
            public static FormLink<ISceneGetter> DLC1VQ03VampireSpeechReactionScene => Construct(0x132a6);
            public static FormLink<ISceneGetter> DLC1VQ02HarkonIntroWaitingScene => Construct(0x11e4c);
            public static FormLink<ISceneGetter> DLC1VQ02SeranaDawnguardScene => Construct(0x10fd9);
            public static FormLink<ISceneGetter> DLC1VQ08PostGaranScene => Construct(0x10f30);
            public static FormLink<ISceneGetter> DLC1VQ08PostIsranScene => Construct(0x10f2b);
            public static FormLink<ISceneGetter> DLC1VQ01PuzzleRoomScene => Construct(0xfb20);
            public static FormLink<ISceneGetter> DLC1VampireTurnHarkonHack => Construct(0xe88e);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCSoulTrapScene => Construct(0xe885);
            public static FormLink<ISceneGetter> DLC1VQ01IsranAgmaerScene => Construct(0xd937);
            public static FormLink<ISceneGetter> DLC1VQ01IsranTolanDimhollowScene => Construct(0xd92d);
            public static FormLink<ISceneGetter> DLC1VQ01IsranIntroScene => Construct(0xd928);
            public static FormLink<ISceneGetter> DLC1VQ01AgmaerScene => Construct(0xd91a);
            public static FormLink<ISceneGetter> DLC1VQ07FinalSceneAlternate => Construct(0xd680);
            public static FormLink<ISceneGetter> DLC1VQ08HarkonBattleScene => Construct(0xd64f);
            public static FormLink<ISceneGetter> DLC1VQ05RNPCArvakRider => Construct(0x4bde);
            public static FormLink<ISceneGetter> DLC1VQElderSeranaLetsGo => Construct(0x4bdd);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCTempleInteriorScene => Construct(0x4bbe);
            public static FormLink<ISceneGetter> DLC1VQ03RNPCWinkingSkeeverScene => Construct(0x4bbb);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCArrowedExclamationMark => Construct(0x4243);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCForgottenFallsDelay => Construct(0x4241);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCForgottenFallsDropDownScene => Construct(0x423e);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge6b => Construct(0x41ab);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene10 => Construct(0x3fd4);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene9 => Construct(0x3fd2);
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTSceneKnockdown => Construct(0x3f48);
            public static FormLink<ISceneGetter> DLC1VQ03HunterRecoveryScene => Construct(0x3f42);
            public static FormLink<ISceneGetter> DLC1VQ03HunterMothPriestScene => Construct(0x3da3);
            public static FormLink<ISceneGetter> DLC1VQ03VampireMothPriestScene => Construct(0x3da2);
            public static FormLink<ISceneGetter> DLC1VQ03VampireDawnguardScene => Construct(0x3d77);
            public static FormLink<ISceneGetter> DLC1VQ03HunterDominationScene => Construct(0x3d15);
            public static FormLink<ISceneGetter> DLC1VQ05RNPCSoulWanderers => Construct(0x3224);
            public static FormLink<ISceneGetter> DLC1VQ05RNPCIdealMaster => Construct(0x3222);
            public static FormLink<ISceneGetter> DLC1VQ05RNPCSourCairnEntrance => Construct(0x3220);
            public static FormLink<ISceneGetter> DLC1VQ07Prelate00Scene => Construct(0x2b45);
            public static FormLink<ISceneGetter> DLC1HunterBaseIntroGuardStartScene => Construct(0x2afa);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Finale => Construct(0x298d);
            public static FormLink<ISceneGetter> DLC1VQ06SeranaEntryCaveScene => Construct(0x1aa4c);
            public static FormLink<ISceneGetter> DLC1VQ06SeranaMothComment => Construct(0x1a948);
            public static FormLink<ISceneGetter> DLC1VQ06SeranaBarkComment => Construct(0x1a947);
            public static FormLink<ISceneGetter> DLC1VQ06SeranaKnifeComment => Construct(0x1a946);
            public static FormLink<ISceneGetter> DLC1VQCastleGuardOpenGate => Construct(0x1a67d);
            public static FormLink<ISceneGetter> DLC1VQ02HarkonBanish => Construct(0x1a41f);
            public static FormLink<ISceneGetter> DLC1VQ08HarkonConfrontScene => Construct(0x19fc1);
            public static FormLink<ISceneGetter> DLC1VQ01SeranaLeaveCoffinScene => Construct(0x19f16);
            public static FormLink<ISceneGetter> DLC1LDIceDragonFight02Scene02 => Construct(0x19dd4);
            public static FormLink<ISceneGetter> DLC1LDIceDragonFight02Scene01 => Construct(0x19dd3);
            public static FormLink<ISceneGetter> DLC1LDIceDragonFightScene02 => Construct(0x19574);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCFightResponse => Construct(0x19518);
            public static FormLink<ISceneGetter> DLC1VQ08DawnguardCelebrate => Construct(0x1931f);
            public static FormLink<ISceneGetter> DLC1VampireTutorialScene1 => Construct(0x191e8);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Bthalft02 => Construct(0x1913c);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Bthalft01 => Construct(0x1913b);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge03 => Construct(0x1913a);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge02 => Construct(0x19139);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge01 => Construct(0x19138);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Bthalft04 => Construct(0x19137);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCTrapPreScene => Construct(0x18eed);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCFalmerSpot => Construct(0x18eec);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCDarkfallPassageEntrance => Construct(0x18eeb);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCFirstWayshrineSpot => Construct(0x18ee8);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCDarkfallCampsireDelayed => Construct(0x18ee6);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCDarkfallCampScene => Construct(0x18ee5);
            public static FormLink<ISceneGetter> DLC1VQ01Stage15VampireScene1 => Construct(0x1880e);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCTempleCourtyard => Construct(0x1819e);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCTempleSpotScene => Construct(0x1819d);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCIceLake => Construct(0x1819b);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCPostWaterfall => Construct(0x1819a);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCWaterfallSpot => Construct(0x18197);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCSpiderSpot => Construct(0x18196);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCWayshrineSpot => Construct(0x18195);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCFalmerValleyEntranceScene => Construct(0x18194);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCFrostTrollScene => Construct(0x18193);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCTrapScene => Construct(0x18192);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene8 => Construct(0x17ff6);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene7 => Construct(0x17ff4);
            public static FormLink<ISceneGetter> DLC1VQ07RNPCPrecariousBridgeScene => Construct(0x176c6);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCPostSecretPassage => Construct(0x176bc);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCPreCourtyard => Construct(0x176ba);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCDoubleLeverScene => Construct(0x176b7);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCOuttakeScene => Construct(0x176b5);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCPreBeachScene => Construct(0x16676);
            public static FormLink<ISceneGetter> DLC1VQ04RNPCBeachScene => Construct(0x16674);
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTStart => Construct(0x1666a);
            public static FormLink<ISceneGetter> DLC1LD_13g_KatriaFail => Construct(0x16529);
            public static FormLink<ISceneGetter> DLC1LD_13f_KatriaSuccess2 => Construct(0x16528);
            public static FormLink<ISceneGetter> DLC1LD_13e_KatriaSuccess1 => Construct(0x16527);
            public static FormLink<ISceneGetter> DLC1LD_04b_KatriaCommentResonator => Construct(0x16525);
            public static FormLink<ISceneGetter> DLC1HorseQuestOpenScene => Construct(0x163d2);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene6 => Construct(0x163c0);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene5 => Construct(0x163bd);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene4 => Construct(0x163bb);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene3 => Construct(0x163b9);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene2 => Construct(0x163b7);
            public static FormLink<ISceneGetter> DLC1HunterBaseScene1 => Construct(0x163b5);
            public static FormLink<ISceneGetter> DLC1VQ06LastMothScene => Construct(0x15cee);
            public static FormLink<ISceneGetter> DLC1VQ06ArrivalScene => Construct(0x15ce2);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge05 => Construct(0x15c59);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCTalkToPlayerPreCastle => Construct(0x15ac0);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCPlayerSlowGettingInBoat => Construct(0x15abe);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCSpottingCastle => Construct(0x15abb);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCBackToCamp => Construct(0x15ab9);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCOnExit => Construct(0x15ab7);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCPlayerStuckAtExit => Construct(0x15ab5);
            public static FormLink<ISceneGetter> DLC1NPCCommentary03Danger => Construct(0x15ab3);
            public static FormLink<ISceneGetter> DLC1NPCCommentary02DangerScene => Construct(0x15ab2);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCOutOfPuzzleChamberScene => Construct(0x15ab0);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCAfterKillingWrongWayDraugr => Construct(0x15aae);
            public static FormLink<ISceneGetter> DLC1VQ02RNPCFallDownScene => Construct(0x15aad);
            public static FormLink<ISceneGetter> DLC1NPCCommentary01Scene => Construct(0x15aa6);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge06 => Construct(0x15405);
            public static FormLink<ISceneGetter> DLC1VQ07FinalPreScene => Construct(0x153b4);
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTScene03 => Construct(0x15134);
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTScene02 => Construct(0x1512c);
            public static FormLink<ISceneGetter> DLC1VQ05DragonAttackScene => Construct(0x14f84);
            public static FormLink<ISceneGetter> DLC1VQ07Prelate04Scene => Construct(0x14f4d);
            public static FormLink<ISceneGetter> DLC1VQ07Prelate03Scene => Construct(0x14f4c);
            public static FormLink<ISceneGetter> DLC1VQ07Prelate02Scene => Construct(0x14f4b);
            public static FormLink<ISceneGetter> DLC1VQ07Prelate01Scene => Construct(0x14f4a);
            public static FormLink<ISceneGetter> DLC1VQ07GeleborCallOutScene => Construct(0x14f49);
            public static FormLink<ISceneGetter> DLC1LD_RaldbtharScene1 => Construct(0x14f23);
            public static FormLink<ISceneGetter> DLC1LD_00KatriaPleading02 => Construct(0x14f22);
            public static FormLink<ISceneGetter> DLC1LD_MzulftScene1 => Construct(0x14f21);
            public static FormLink<ISceneGetter> DLC1LD_BthalftPreRising => Construct(0x14f20);
            public static FormLink<ISceneGetter> DLC1LD_03e_KatriaCommentBodyStripped => Construct(0x14c04);
            public static FormLink<ISceneGetter> DLC1VQ03HunterStage5IsranScene => Construct(0x14b54);
            public static FormLink<ISceneGetter> DLC1dunRedwaterDenChatterScene => Construct(0x14987);
            public static FormLink<ISceneGetter> DLC1LD_KatriaKilledByPlayer => Construct(0x1433f);
            public static FormLink<ISceneGetter> DLC1WEDB03Scene => Construct(0x14285);
            public static FormLink<ISceneGetter> DLC1WEDB02Scene01 => Construct(0x14211);
            public static FormLink<ISceneGetter> DLC1VQSaintPacingScene => Construct(0x14029);
            public static FormLink<ISceneGetter> DLC1dunRedwaterDenSoldierScene => Construct(0x13c71);
            public static FormLink<ISceneGetter> DLC1dunRedwaterNobleScene => Construct(0x13c70);
            public static FormLink<ISceneGetter> DLC1dunRedwaterDenCageScene => Construct(0x1391f);
            public static FormLink<ISceneGetter> DLC1dunRedwaterDenKhajiitScene => Construct(0x13919);
            public static FormLink<ISceneGetter> DLC1dunRedwaterDenBouncerScene => Construct(0x13911);
            public static FormLink<ISceneGetter> DLC1VQ02SeranaLeverScene => Construct(0x133af);
            public static FormLink<ISceneGetter> DLC1VQ02HarkonAndSeranaScene => Construct(0x103a5);
            public static FormLink<ISceneGetter> DLC1VQ04StatueDoneScene => Construct(0xd7f9);
            public static FormLink<ISceneGetter> DLC1VQ04CourtyardScene => Construct(0xd7eb);
            public static FormLink<ISceneGetter> DLC1VQ04WatchPortalScene => Construct(0xd40b);
            public static FormLink<ISceneGetter> DLC01VQ05DragonFightShouts => Construct(0xd2d6);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Bthalft03 => Construct(0xd032);
            public static FormLink<ISceneGetter> DLC1LD_03c_JournalReminder => Construct(0xd031);
            public static FormLink<ISceneGetter> DLC1LD_BthalftRisingScene => Construct(0xd030);
            public static FormLink<ISceneGetter> DLC1LD_03b_KatriaCommentBody => Construct(0xd02f);
            public static FormLink<ISceneGetter> DLC1LD_00KatriaPleading => Construct(0xd02e);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge07 => Construct(0xd02d);
            public static FormLink<ISceneGetter> DLC1LD_02KatriaBackout => Construct(0xd02c);
            public static FormLink<ISceneGetter> DLC1LD_03d_JournalTaunt => Construct(0xd02b);
            public static FormLink<ISceneGetter> DLC1LD_13a_KatriaTip1 => Construct(0xd02a);
            public static FormLink<ISceneGetter> DLC1LD_13b_KatriaTip2 => Construct(0xd029);
            public static FormLink<ISceneGetter> DLC1LD_13c_KatriaTip3 => Construct(0xd028);
            public static FormLink<ISceneGetter> DLC1LD_15_KatriaCommentTreasure => Construct(0xd027);
            public static FormLink<ISceneGetter> DLC1LD_13d_KatriaTip4 => Construct(0xd026);
            public static FormLink<ISceneGetter> DLC1LD_14_KatriaCommentGotIt => Construct(0xd025);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Forge04 => Construct(0xd024);
            public static FormLink<ISceneGetter> DLC1LD_Katria_Bthalft05 => Construct(0xd022);
            public static FormLink<ISceneGetter> DLC1VQDragonScene1 => Construct(0xc73c);
            public static FormLink<ISceneGetter> DLC1HunterBaseIntroStartScene => Construct(0xbdf7);
            public static FormLink<ISceneGetter> DLC1VQ03HunterScrollReading => Construct(0x6dec);
            public static FormLink<ISceneGetter> DLC1VQ07GeleborScene => Construct(0xa886);
            public static FormLink<ISceneGetter> DLC1VQ03HunterStage17Scene => Construct(0x98d4);
            public static FormLink<ISceneGetter> DLC1VQ03HunterStage10Scene => Construct(0x98d2);
            public static FormLink<ISceneGetter> DLC1HunterBaseIntroEndScene => Construct(0x8a8c);
            public static FormLink<ISceneGetter> DLC1LDIceDragonFightScene01 => Construct(0x88e6);
            public static FormLink<ISceneGetter> DLC1VQ03VampireDexionScrollReading => Construct(0x886f);
            public static FormLink<ISceneGetter> DLC1VQ05MeetSceneSCDone => Construct(0x71be);
            public static FormLink<ISceneGetter> DLC1_BF_DunTempleQSTScene01 => Construct(0x6c16);
            public static FormLink<ISceneGetter> DLC1VQ03VampireHarkonSpeechFindScroll => Construct(0x69b1);
            public static FormLink<ISceneGetter> DLC1VampireBaseIntroSpringScene => Construct(0x5e36);
            public static FormLink<ISceneGetter> DLC1VampireBaseIntroGaranChaliceScene => Construct(0x594f);
            public static FormLink<ISceneGetter> DLC1VQ05MeetScene => Construct(0x5875);
            public static FormLink<ISceneGetter> DLC1LD_11b_KatriaCommentBowPickup => Construct(0x5832);
            public static FormLink<ISceneGetter> DLC1LD_06_KatriaCommentQuiteAPlace => Construct(0x5831);
            public static FormLink<ISceneGetter> DLC1LD_12a_KatriaCommentFinalChamber => Construct(0x5830);
            public static FormLink<ISceneGetter> DLC1LD_12b_KatriaCommentImpressed => Construct(0x582f);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene06 => Construct(0x4e23);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene05 => Construct(0x4e21);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene04 => Construct(0x4e1f);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene03 => Construct(0x4e1d);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene02 => Construct(0x4e1b);
            public static FormLink<ISceneGetter> DLC1VampireBaseScene01 => Construct(0x4e19);
            public static FormLink<ISceneGetter> DLC1LD_11a_KatriaCommentBow => Construct(0x4d86);
            public static FormLink<ISceneGetter> DLC1LD_10_KatriaCommentDrop => Construct(0x4d85);
            public static FormLink<ISceneGetter> DLC1LD_09_KatriaCommentPods => Construct(0x4d84);
            public static FormLink<ISceneGetter> DLC1LD_08_KatriaCommentSealedDoorSuccess => Construct(0x4d83);
            public static FormLink<ISceneGetter> DLC1LD_07_KatriaCommentSealedDoor => Construct(0x4d82);
            public static FormLink<ISceneGetter> DLC1LD_05_KatriaCommentMoreFalmer => Construct(0x4d81);
            public static FormLink<ISceneGetter> DLC1LD_04_KatriaCommentPassage => Construct(0x4d80);
            public static FormLink<ISceneGetter> DLC1LD_03a_KatriaCommentBody => Construct(0x4d7f);
            public static FormLink<ISceneGetter> DLC1LD_01KatriaIntro => Construct(0x4d72);
            public static FormLink<ISceneGetter> DLC1VQ04LabScene => Construct(0x3c50);
            public static FormLink<ISceneGetter> DLC01_WESC02_VampireDLG01 => Construct(0x34f5);
        }
    }
}
