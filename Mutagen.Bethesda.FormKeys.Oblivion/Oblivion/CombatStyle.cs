using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class CombatStyle
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICombatStyleGetter> SE11DopplegangerCombatStyle => Construct(0x97608);
            public static FormLink<ICombatStyleGetter> SE11RakheranStyle => Construct(0x8f192);
            public static FormLink<ICombatStyleGetter> SEJyggalagStyle => Construct(0x83f38);
            public static FormLink<ICombatStyleGetter> SE03GrummiteShamanCS => Construct(0x819a0);
            public static FormLink<ICombatStyleGetter> SEDefaultSkinnedHound => Construct(0x7939d);
            public static FormLink<ICombatStyleGetter> SEKnightOrderBerserk => Construct(0x78c35);
            public static FormLink<ICombatStyleGetter> SEDefaultHunger0 => Construct(0x6d60e);
            public static FormLink<ICombatStyleGetter> SEDefaultGrummiteArcher => Construct(0x55fd6);
            public static FormLink<ICombatStyleGetter> SEJayredIceVeinsCombatStyle => Construct(0x558de);
            public static FormLink<ICombatStyleGetter> DefaultJyggylag => Construct(0x558c4);
            public static FormLink<ICombatStyleGetter> SEDefaultGrummite => Construct(0x50534);
            public static FormLink<ICombatStyleGetter> SEDefaultGateKeeper4 => Construct(0x4fb72);
            public static FormLink<ICombatStyleGetter> DefaultMurkDweller => Construct(0x45d6b);
            public static FormLink<ICombatStyleGetter> SEDefaultBaliwog => Construct(0x44e68);
            public static FormLink<ICombatStyleGetter> DefaultBaliwog => Construct(0x441c7);
            public static FormLink<ICombatStyleGetter> SEDefaultElytra3 => Construct(0x44195);
            public static FormLink<ICombatStyleGetter> SEDefaultElytraHatchling => Construct(0x44194);
            public static FormLink<ICombatStyleGetter> SEDefaultElytra2 => Construct(0x44193);
            public static FormLink<ICombatStyleGetter> SEDefaultFleshAtronach => Construct(0x43cbc);
            public static FormLink<ICombatStyleGetter> SEDefaultScalon1 => Construct(0x4292f);
            public static FormLink<ICombatStyleGetter> SEDefaultShambles2 => Construct(0x42924);
            public static FormLink<ICombatStyleGetter> SEDefaultShambles1 => Construct(0x42923);
            public static FormLink<ICombatStyleGetter> SE08Flank => Construct(0x41eb5);
            public static FormLink<ICombatStyleGetter> SE08Heavy => Construct(0x41eb4);
            public static FormLink<ICombatStyleGetter> SE08Archer => Construct(0x41eb3);
            public static FormLink<ICombatStyleGetter> SEDefaultGnarl => Construct(0x41d88);
            public static FormLink<ICombatStyleGetter> SEDefaultHunger2 => Construct(0x41d82);
            public static FormLink<ICombatStyleGetter> SEDefaultHunger1 => Construct(0x41d81);
            public static FormLink<ICombatStyleGetter> DefaultFleshAtronach => Construct(0x41372);
            public static FormLink<ICombatStyleGetter> DefaultElytra => Construct(0x41056);
            public static FormLink<ICombatStyleGetter> SEDefaultGateKeeper => Construct(0x30fd0);
            public static FormLink<ICombatStyleGetter> DefaultGnarl => Construct(0x1b654);
            public static FormLink<ICombatStyleGetter> SE06ArcherStyle => Construct(0x1a14c);
            public static FormLink<ICombatStyleGetter> DefaultShambles => Construct(0x19f2a);
            public static FormLink<ICombatStyleGetter> DefaultHunger => Construct(0x19f08);
            public static FormLink<ICombatStyleGetter> SEDefaultMurkDweller => Construct(0x180eb);
            public static FormLink<ICombatStyleGetter> MS02LorgrenLichStyle => Construct(0xc4ed);
            public static FormLink<ICombatStyleGetter> TG11PalaceGuard => Construct(0xc3d8);
            public static FormLink<ICombatStyleGetter> DefaultGoblinWarlord => Construct(0xab91);
            public static FormLink<ICombatStyleGetter> DefaultSkeletonSummoned => Construct(0x855b);
            public static FormLink<ICombatStyleGetter> DefaultSpiderling => Construct(0x52bd);
            public static FormLink<ICombatStyleGetter> DefaultMonk => Construct(0x51a3);
            public static FormLink<ICombatStyleGetter> TG03ChapelGuardStyle => Construct(0x5180);
            public static FormLink<ICombatStyleGetter> DefaultWraithFadedWeapon => Construct(0x28f8);
            public static FormLink<ICombatStyleGetter> DefaultWraithGloom => Construct(0xfa1);
            public static FormLink<ICombatStyleGetter> DefaultWraithWeapon => Construct(0xf1c);
            public static FormLink<ICombatStyleGetter> DefaultWraith => Construct(0xf17);
            public static FormLink<ICombatStyleGetter> DefaultZombieDread => Construct(0xf16);
            public static FormLink<ICombatStyleGetter> DefaultSkeletonChampion => Construct(0xf15);
            public static FormLink<ICombatStyleGetter> DefaultSkeletonRanged => Construct(0x14f89);
            public static FormLink<ICombatStyleGetter> DefaultGoblinArcher => Construct(0x14d5a);
            public static FormLink<ICombatStyleGetter> DefaultAtronachFire => Construct(0x14d59);
            public static FormLink<ICombatStyleGetter> KvatchCastleMissile => Construct(0xcd4da);
            public static FormLink<ICombatStyleGetter> DefaultArcher => Construct(0xca389);
            public static FormLink<ICombatStyleGetter> NPCMarauderMissile => Construct(0xca0d8);
            public static FormLink<ICombatStyleGetter> NPCBanditMissile => Construct(0xca0d7);
            public static FormLink<ICombatStyleGetter> NPCNecromancer => Construct(0xca0d6);
            public static FormLink<ICombatStyleGetter> NPCConjurer => Construct(0xca0d5);
            public static FormLink<ICombatStyleGetter> NPCBanditMage => Construct(0xca0d4);
            public static FormLink<ICombatStyleGetter> NPCMarauderMage => Construct(0xca0d3);
            public static FormLink<ICombatStyleGetter> NPCDremoraMage => Construct(0xca0d2);
            public static FormLink<ICombatStyleGetter> NPCVampireMissile => Construct(0xca0d1);
            public static FormLink<ICombatStyleGetter> NPCVampireMage => Construct(0xca0d0);
            public static FormLink<ICombatStyleGetter> MankarCamoranStyle => Construct(0xc9f0b);
            public static FormLink<ICombatStyleGetter> BladesTrainingNoPowerAttack => Construct(0xc01b6);
            public static FormLink<ICombatStyleGetter> OcatoCombatStyle => Construct(0xbe32b);
            public static FormLink<ICombatStyleGetter> DefaultGhost => Construct(0x86e3f);
            public static FormLink<ICombatStyleGetter> DefaultBlackBear => Construct(0x86e3e);
            public static FormLink<ICombatStyleGetter> DefaultHorse => Construct(0x86e3d);
            public static FormLink<ICombatStyleGetter> DefaultXivilai => Construct(0x86e3c);
            public static FormLink<ICombatStyleGetter> DefaultOgreBrute => Construct(0x86e3b);
            public static FormLink<ICombatStyleGetter> SpecialSkeletonBrute => Construct(0x86e3a);
            public static FormLink<ICombatStyleGetter> DefaultZombie => Construct(0x86e39);
            public static FormLink<ICombatStyleGetter> DefaultRam => Construct(0x86e38);
            public static FormLink<ICombatStyleGetter> DefaultWraithFaded => Construct(0x86e37);
            public static FormLink<ICombatStyleGetter> DefaultLich => Construct(0x86e36);
            public static FormLink<ICombatStyleGetter> DefaultSheep => Construct(0x86e35);
            public static FormLink<ICombatStyleGetter> DefaultGoblinShaman => Construct(0x69405);
            public static FormLink<ICombatStyleGetter> CGAssassinNoMagic => Construct(0x67196);
            public static FormLink<ICombatStyleGetter> HelviusCeciaTraining => Construct(0x6555a);
            public static FormLink<ICombatStyleGetter> AndragilTraining => Construct(0x65559);
            public static FormLink<ICombatStyleGetter> DefaultWolf => Construct(0x64f45);
            public static FormLink<ICombatStyleGetter> DefaultGoblinBerserker => Construct(0x1779e0);
            public static FormLink<ICombatStyleGetter> DefaultMehrunesDagon => Construct(0x3c7c7);
            public static FormLink<ICombatStyleGetter> DefaultAtronachFrost => Construct(0x89974);
            public static FormLink<ICombatStyleGetter> SpecialXivilaiTwoHand => Construct(0x9ea7d);
            public static FormLink<ICombatStyleGetter> DefaultSpiderDaedra => Construct(0x9db11);
            public static FormLink<ICombatStyleGetter> DefaultNoFlee => Construct(0x983f8);
            public static FormLink<ICombatStyleGetter> E3DaedrothDefault => Construct(0x98098);
            public static FormLink<ICombatStyleGetter> E3ClannfearDefault => Construct(0x98044);
            public static FormLink<ICombatStyleGetter> DefaultCombatWillYield => Construct(0x97cd7);
            public static FormLink<ICombatStyleGetter> DefaultCombatRejectPCYield => Construct(0x97cd6);
            public static FormLink<ICombatStyleGetter> DefaultCombatWillYieldRejectPCYield => Construct(0x97cd5);
            public static FormLink<ICombatStyleGetter> PowerAttackNormalOnly => Construct(0x97ca7);
            public static FormLink<ICombatStyleGetter> E3OgreDefault => Construct(0x97c4c);
            public static FormLink<ICombatStyleGetter> DefaultWillOWisp => Construct(0x9758b);
            public static FormLink<ICombatStyleGetter> VidCaptureNoAttacks => Construct(0x94e3a);
            public static FormLink<ICombatStyleGetter> SideAttackStandard => Construct(0x910fd);
            public static FormLink<ICombatStyleGetter> DefaultLichNether => Construct(0x85a5c);
            public static FormLink<ICombatStyleGetter> DefaultSpriggan => Construct(0x85a5b);
            public static FormLink<ICombatStyleGetter> PowerAttackStandard => Construct(0x85496);
            public static FormLink<ICombatStyleGetter> DefaultAtronachStorm => Construct(0x51d65);
            public static FormLink<ICombatStyleGetter> DefaultSlaughterfish => Construct(0x32902);
            public static FormLink<ICombatStyleGetter> AggresiveForwardPower100 => Construct(0x2add7);
            public static FormLink<ICombatStyleGetter> SpecialTrollPowerAttacker => Construct(0x2add6);
            public static FormLink<ICombatStyleGetter> DefaultImp => Construct(0x3f28a);
            public static FormLink<ICombatStyleGetter> DefaultDog => Construct(0x3db36);
            public static FormLink<ICombatStyleGetter> DefaultLandDreugh => Construct(0x375a6);
            public static FormLink<ICombatStyleGetter> DefaultBearBrown => Construct(0x228a1);
            public static FormLink<ICombatStyleGetter> DefaultTroll => Construct(0x22d44);
            public static FormLink<ICombatStyleGetter> DefaultBoar => Construct(0x1eff3);
            public static FormLink<ICombatStyleGetter> DefaultOgre => Construct(0x17528);
            public static FormLink<ICombatStyleGetter> DefaultMountainLion => Construct(0xa2b1);
            public static FormLink<ICombatStyleGetter> DefaultClannfear => Construct(0x35e92);
            public static FormLink<ICombatStyleGetter> DefaultMudCrab => Construct(0x2c557);
            public static FormLink<ICombatStyleGetter> DefaultRat => Construct(0x2f47e);
            public static FormLink<ICombatStyleGetter> DefaultSkeleton => Construct(0x2f47d);
            public static FormLink<ICombatStyleGetter> DefaultGoblinSkirmisher => Construct(0x2f244);
            public static FormLink<ICombatStyleGetter> DefaultGoblin => Construct(0x2f243);
            public static FormLink<ICombatStyleGetter> DefaultDeerBuck => Construct(0x2e994);
            public static FormLink<ICombatStyleGetter> DefaultDeer => Construct(0x2f07d);
            public static FormLink<ICombatStyleGetter> SpecialMinotaurFavourLeft => Construct(0x2e5e9);
            public static FormLink<ICombatStyleGetter> DefaultDaedroth => Construct(0x2e5e1);
            public static FormLink<ICombatStyleGetter> DefaultScamp => Construct(0x2e5e0);
            public static FormLink<ICombatStyleGetter> SpecialMinotaurFavorForwardPower => Construct(0x2d93d);
            public static FormLink<ICombatStyleGetter> DefaultMinotaurLord => Construct(0x2d6f4);
        }
    }
}
