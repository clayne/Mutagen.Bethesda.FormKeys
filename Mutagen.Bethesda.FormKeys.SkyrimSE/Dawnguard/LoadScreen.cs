using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class LoadScreen
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> DLC1Vampires => Construct(0x29e4);
            public static FormLink<ILoadScreenGetter> DLC1WeaponFletching => Construct(0x19adb);
            public static FormLink<ILoadScreenGetter> DLC1VampireLordPowersStart => Construct(0x19ada);
            public static FormLink<ILoadScreenGetter> DLC1VampireFeedCastle => Construct(0x18c51);
            public static FormLink<ILoadScreenGetter> DLC1VampireFeeding => Construct(0x18c50);
            public static FormLink<ILoadScreenGetter> DLC1WeaponDragonbone => Construct(0x17f96);
            public static FormLink<ILoadScreenGetter> DLC1WeaponCrossbow => Construct(0x17f95);
            public static FormLink<ILoadScreenGetter> DLC1CreatureChaurusHunter => Construct(0x17f94);
            public static FormLink<ILoadScreenGetter> DLC1CreatureDeathHound => Construct(0x17f93);
            public static FormLink<ILoadScreenGetter> DLC1VampireNoShun => Construct(0x11a18);
            public static FormLink<ILoadScreenGetter> DLC1CreatureDragonLegendary => Construct(0x11a17);
            public static FormLink<ILoadScreenGetter> DLC1CreatureGargoyle => Construct(0x11a16);
            public static FormLink<ILoadScreenGetter> DLC1CreatureTrollArmored => Construct(0x11a15);
            public static FormLink<ILoadScreenGetter> DLC1VampireLordStates => Construct(0xf836);
            public static FormLink<ILoadScreenGetter> DLC1VampireLordPerks => Construct(0xf835);
            public static FormLink<ILoadScreenGetter> DLC1VampireLordPerkTree => Construct(0xf834);
            public static FormLink<ILoadScreenGetter> DLC1WerewolfPerks => Construct(0xf833);
            public static FormLink<ILoadScreenGetter> DLC1WerewolfPerkTree => Construct(0xf832);
        }
    }
}
