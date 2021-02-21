using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class ObjectEffect
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IObjectEffectGetter> Construct(uint id) => new FormLink<IObjectEffectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IObjectEffectGetter> DLC2EnchArmorDragonAbsorbBoost => Construct(0x1e288);
            public static FormLink<IObjectEffectGetter> DLC2EnchArmorDragonAbsorb => Construct(0x1e287);
            public static FormLink<IObjectEffectGetter> DLC2dunKolbjorn_EnchBlank => Construct(0x3d58a);
            public static FormLink<IObjectEffectGetter> BoundDaggerEnchantment => Construct(0x3d37c);
            public static FormLink<IObjectEffectGetter> DLC2StaffEnchMayhem => Construct(0x3d29f);
            public static FormLink<IObjectEffectGetter> DLC2StaffEnchLightningStorm => Construct(0x3d29a);
            public static FormLink<IObjectEffectGetter> DLC2StaffEnchFireStorm => Construct(0x3d296);
            public static FormLink<IObjectEffectGetter> DLC2StaffEnchBlizzard => Construct(0x3d292);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakFightStaff1 => Construct(0x3d128);
            public static FormLink<IObjectEffectGetter> DLC2LurkerEnchStagger => Construct(0x3cefc);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakStaffTentacles1 => Construct(0x3a3d3);
            public static FormLink<IObjectEffectGetter> DLC2MKEnchMiraakSwordNPC => Construct(0x39fb6);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakStaffNPC => Construct(0x39fb5);
            public static FormLink<IObjectEffectGetter> DLC2MKEnchMiraakSword3 => Construct(0x39fb3);
            public static FormLink<IObjectEffectGetter> DLC2MKEnchMiraakSword1 => Construct(0x39faf);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakStaff3 => Construct(0x39fa9);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakStaff2 => Construct(0x39fa8);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakStaff1 => Construct(0x39fa7);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakRobe03 => Construct(0x39d25);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakRobe01 => Construct(0x39d24);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakRobe02 => Construct(0x39d23);
            public static FormLink<IObjectEffectGetter> dlc2MKEncMiraakRobeExplosion => Construct(0x39d1c);
            public static FormLink<IObjectEffectGetter> DLC2MKEnchMiraakSword2 => Construct(0x397f3);
            public static FormLink<IObjectEffectGetter> MiraaktestStaffEnchWallOfStorms => Construct(0x397ed);
            public static FormLink<IObjectEffectGetter> DLC2EnchBloodskalWeaponGlow => Construct(0x390f5);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchScimitar02NP => Construct(0x38058);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchScimitar01NP => Construct(0x38056);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchScimitar02 => Construct(0x38051);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchScimitar01 => Construct(0x3804f);
            public static FormLink<IObjectEffectGetter> DLC2dunKolbjornRalisPickaxeEnch => Construct(0x373d6);
            public static FormLink<IObjectEffectGetter> DLC2dunKolbjornHelmEnch => Construct(0x36687);
            public static FormLink<IObjectEffectGetter> DLC2dunKolbjornGauntletsEnch => Construct(0x36685);
            public static FormLink<IObjectEffectGetter> DLC2dunFrostmoonRingBloodlustEnch => Construct(0x35b25);
            public static FormLink<IObjectEffectGetter> DLC2dunFrostmoonRingHuntRegenEnch => Construct(0x35b23);
            public static FormLink<IObjectEffectGetter> DLC2dunFrostmoonRingInstinctSlowTimeEnch => Construct(0x35b22);
            public static FormLink<IObjectEffectGetter> DLC2dunFrostmoonRingMoonMagnifyHowlsEnch => Construct(0x35b1f);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponKagrumezFateBow => Construct(0x35529);
            public static FormLink<IObjectEffectGetter> DLC2EnchBallistaStagger50 => Construct(0x339a6);
            public static FormLink<IObjectEffectGetter> DLC2ExpSpiderPoisonBombDMG => Construct(0x322ae);
            public static FormLink<IObjectEffectGetter> DLC2ExpSpiderShockBombDMG => Construct(0x322ac);
            public static FormLink<IObjectEffectGetter> DLC2ExpSpiderFireBombDMG => Construct(0x322aa);
            public static FormLink<IObjectEffectGetter> DLC2ExpSpiderFrostBombDMG => Construct(0x322a8);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponChaosDamage06 => Construct(0x2c472);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponChaosDamage05 => Construct(0x2c471);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponChaosDamage04 => Construct(0x2c470);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponChaosDamage03 => Construct(0x2c46f);
            public static FormLink<IObjectEffectGetter> DLC2EnchWeaponChaosDamageBase => Construct(0x2c46e);
            public static FormLink<IObjectEffectGetter> DLC2TGArmorFortifySpeechcraftBlackguard => Construct(0x2ad38);
            public static FormLink<IObjectEffectGetter> DLC2TGArmorFortifyPickpocketBlackguard => Construct(0x2ad37);
            public static FormLink<IObjectEffectGetter> DLC2TGArmorFortifyLockpickingBlackguard => Construct(0x2ad36);
            public static FormLink<IObjectEffectGetter> DLC2TGArmorFortifyCarryBlackguard => Construct(0x2ad35);
            public static FormLink<IObjectEffectGetter> DLC2KagrumezSteamEnch => Construct(0x2662a);
            public static FormLink<IObjectEffectGetter> DLC2KagrumezElectrifiedWaterEnch => Construct(0x260e9);
            public static FormLink<IObjectEffectGetter> DLC2EnchAcolyteMaskShock => Construct(0x250e3);
            public static FormLink<IObjectEffectGetter> DLC2EnchAcolyteMaskFrost => Construct(0x250e2);
            public static FormLink<IObjectEffectGetter> DLC2EnchAcolyteMaskFire => Construct(0x250e1);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchHelm => Construct(0x24021);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchCuirass => Construct(0x24020);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchGauntlets => Construct(0x2401f);
            public static FormLink<IObjectEffectGetter> DLC2dunHaknirEnchBoots => Construct(0x2401e);
            public static FormLink<IObjectEffectGetter> DLC2VoiceEnchBattleFury => Construct(0x200c7);
            public static FormLink<IObjectEffectGetter> DLC2EnchPoisonRuneExplosion => Construct(0x1d749);
            public static FormLink<IObjectEffectGetter> DLC2dunKolbjornBootsWaterwalking => Construct(0x1c656);
            public static FormLink<IObjectEffectGetter> dlc2DBEnchDragonSword => Construct(0x1bff0);
            public static FormLink<IObjectEffectGetter> DLC2BloodskalEnch => Construct(0x1aea6);
            public static FormLink<IObjectEffectGetter> DLC2DetectAshSource => Construct(0x19619);
            public static FormLink<IObjectEffectGetter> dlc2MerchEnchWeapBowOfTheStagPrince => Construct(0x18ed6);
            public static FormLink<IObjectEffectGetter> DLC2EnchFrenzyRuneExplosion => Construct(0x177bb);
            public static FormLink<IObjectEffectGetter> DLC2EnchAshRuneExplosion => Construct(0x177b2);
        }
    }
}
