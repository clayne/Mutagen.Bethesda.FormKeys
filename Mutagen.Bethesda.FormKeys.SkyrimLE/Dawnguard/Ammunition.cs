using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Ammunition
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IAmmunitionGetter> Construct(uint id) => new FormLink<IAmmunitionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAmmunitionGetter> DLC1SoulCairnKeeperArrow => Construct(0xff03);
            public static FormLink<IAmmunitionGetter> DLC1ElderScrollBack => Construct(0x1a958);
            public static FormLink<IAmmunitionGetter> DLC1DragonboneArrow => Construct(0x176f4);
            public static FormLink<IAmmunitionGetter> DLC1BoltSteelExplodingShock => Construct(0xf1bc);
            public static FormLink<IAmmunitionGetter> DLC1BoltSteelExplodingIce => Construct(0xf1bb);
            public static FormLink<IAmmunitionGetter> DLC1BoltDwarvenExplodingShock => Construct(0xf1b9);
            public static FormLink<IAmmunitionGetter> DLC1BoltDwarvenExplodingIce => Construct(0xf1b7);
            public static FormLink<IAmmunitionGetter> DLC1BoltDwarvenExplodingFire => Construct(0xf1b1);
            public static FormLink<IAmmunitionGetter> DLC1BoltSteelExplodingFire => Construct(0xf1a0);
            public static FormLink<IAmmunitionGetter> DLC1BoltDwarven => Construct(0xd099);
            public static FormLink<IAmmunitionGetter> DLC1ElvenArrowBlessed => Construct(0x98a1);
            public static FormLink<IAmmunitionGetter> DLC1ElvenArrowBlood => Construct(0x98a0);
            public static FormLink<IAmmunitionGetter> TestDLC1Bolt => Construct(0x590c);
            public static FormLink<IAmmunitionGetter> DLC1BoltSteel => Construct(0xbb3);
        }
    }
}
