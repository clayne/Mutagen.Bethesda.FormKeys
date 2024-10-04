// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Perk
    {
        private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPerkGetter> SFBGS001_VortexSpawn_IncomingExplosionDamageIncrease => Construct(0x35a8c);
        public static FormLink<IPerkGetter> SFBGS001LC06_BattleDamageModPerk => Construct(0x53d9b);
        public static FormLink<IPerkGetter> SFBGS001_VortexSummonNoXPPerk => Construct(0x9273c);
        public static FormLink<IPerkGetter> SFBGS001_DazraZ03_VendorDiscountPerk => Construct(0x92e8c);
        public static FormLink<IPerkGetter> SFBGS001_MQ02_ObediencePerk => Construct(0xac1a1);
        public static FormLink<IPerkGetter> SFBGS001_MQ02_RitualPerk => Construct(0xac1a2);
        public static FormLink<IPerkGetter> SFBGS001_NPC_VaruunRedeemed_Perk => Construct(0xafd60);
        public static FormLink<IPerkGetter> SFBGS001LC06_AnaskoDamageModPerk => Construct(0xdd817);
        public static FormLink<IPerkGetter> SFBGS001LC06_PreplacedBattleDamageModPerk => Construct(0xf5d3e);
        public static FormLink<IPerkGetter> SFBGS001_MS03_TranquilizeDrinkPerk => Construct(0x106ff7);
        public static FormLink<IPerkGetter> SFBGS001_VkaiZ03b_CompanionDamagePerk => Construct(0x107fa0);
        public static FormLink<IPerkGetter> SFBGS001_PlayerCommonWeaponModPerk => Construct(0x11970d);
        public static FormLink<IPerkGetter> SFBGS001_Perk_Z01Temple_ZealotBonusXP => Construct(0x15ed19);
        public static FormLink<IPerkGetter> SFBGS001_Perk_Z01Temple_SerpentsFang => Construct(0x15ed1a);
        public static FormLink<IPerkGetter> SFBGS001_NPC_MQ05_Phantom_Maleen_Perk => Construct(0x161755);
    }
}
