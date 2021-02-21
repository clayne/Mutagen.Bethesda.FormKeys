using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class CameraPath
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ICameraPathGetter> Construct(uint id) => new FormLink<ICameraPathGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICameraPathGetter> DragonKillCam02Lmid => Construct(0x10fdab);
            public static FormLink<ICameraPathGetter> DragonKillCam01Rmid => Construct(0x10fdaa);
            public static FormLink<ICameraPathGetter> MedDragonCamsLAST => Construct(0x10fda9);
            public static FormLink<ICameraPathGetter> DragonKillCam02Lshort => Construct(0x10fda5);
            public static FormLink<ICameraPathGetter> DragonKillCam01Rshort => Construct(0x10fda4);
            public static FormLink<ICameraPathGetter> ShortDragonCams => Construct(0x10fda3);
            public static FormLink<ICameraPathGetter> LongDragonCams => Construct(0x10fda2);
            public static FormLink<ICameraPathGetter> S08BackLeftStart01 => Construct(0x10f8b0);
            public static FormLink<ICameraPathGetter> S07BackRightStart01 => Construct(0x10f8ac);
            public static FormLink<ICameraPathGetter> IsBackClear02 => Construct(0x10f8ab);
            public static FormLink<ICameraPathGetter> DragonKillCam02Llong => Construct(0x10f198);
            public static FormLink<ICameraPathGetter> DragonKillCam01Rlong => Construct(0x10e750);
            public static FormLink<ICameraPathGetter> DragonCams => Construct(0x10e74f);
            public static FormLink<ICameraPathGetter> CamTestDistance => Construct(0x10d65c);
            public static FormLink<ICameraPathGetter> isFrontClearR => Construct(0x10d2ae);
            public static FormLink<ICameraPathGetter> isFrontClearL => Construct(0x10d2ad);
            public static FormLink<ICameraPathGetter> PlayerActionShot02L => Construct(0x10d2aa);
            public static FormLink<ICameraPathGetter> PlayerActionShot02R => Construct(0x10d2a7);
            public static FormLink<ICameraPathGetter> isLeftClear => Construct(0x10c760);
            public static FormLink<ICameraPathGetter> isRightClear => Construct(0x10c75f);
            public static FormLink<ICameraPathGetter> BasicCams => Construct(0x10c75e);
            public static FormLink<ICameraPathGetter> PlayerFaceBackL => Construct(0x10c75d);
            public static FormLink<ICameraPathGetter> PlayerFaceBackR => Construct(0x10c75a);
            public static FormLink<ICameraPathGetter> PlayerActionShot01R => Construct(0x10c757);
            public static FormLink<ICameraPathGetter> PlayerActionShot01L => Construct(0x10ab45);
            public static FormLink<ICameraPathGetter> _1stPRandom => Construct(0x107a9a);
            public static FormLink<ICameraPathGetter> _1stPFailsafeCam => Construct(0x106368);
            public static FormLink<ICameraPathGetter> FailSafeCamera => Construct(0x105827);
            public static FormLink<ICameraPathGetter> KillCamDragon => Construct(0xd0799);
            public static FormLink<ICameraPathGetter> KillCamSlowLeftSideFarA => Construct(0xb702e);
            public static FormLink<ICameraPathGetter> KillCamSlowFrontSideFarA => Construct(0xb702d);
            public static FormLink<ICameraPathGetter> KillCamSlowRightSideFarA => Construct(0xb702c);
            public static FormLink<ICameraPathGetter> KillCamClose => Construct(0xb702a);
            public static FormLink<ICameraPathGetter> KillCamSlowRightSideCloseUpA => Construct(0xe773b);
            public static FormLink<ICameraPathGetter> KillCamSlowFrontSideCloseUpA => Construct(0xe7739);
            public static FormLink<ICameraPathGetter> KillCamSlowLeftSideCloseUpA => Construct(0xe7738);
            public static FormLink<ICameraPathGetter> RangedKill02 => Construct(0x537ed);
            public static FormLink<ICameraPathGetter> RangedKill01 => Construct(0x537ec);
            public static FormLink<ICameraPathGetter> DoVatsAtAll => Construct(0x3ecd5);
            public static FormLink<ICameraPathGetter> LeftSideSimple => Construct(0x3530a);
            public static FormLink<ICameraPathGetter> RightSideSimple => Construct(0x35304);
            public static FormLink<ICameraPathGetter> MeleeCams => Construct(0x35303);
            public static FormLink<ICameraPathGetter> RangedKills => Construct(0x34cf0);
            public static FormLink<ICameraPathGetter> ShowAttacker => Construct(0x2c3d0);
            public static FormLink<ICameraPathGetter> PairedKillTest => Construct(0x1a71f);
            public static FormLink<ICameraPathGetter> NormalDeathAboveVari => Construct(0x142eb);
            public static FormLink<ICameraPathGetter> NormalDeathAbove => Construct(0x142ea);
            public static FormLink<ICameraPathGetter> NormalDeathBack => Construct(0x142e9);
            public static FormLink<ICameraPathGetter> NormalDeathFront => Construct(0x142e8);
            public static FormLink<ICameraPathGetter> NormalDeathCams => Construct(0x142e7);
            public static FormLink<ICameraPathGetter> PlayerDeath => Construct(0x16);
        }
    }
}
