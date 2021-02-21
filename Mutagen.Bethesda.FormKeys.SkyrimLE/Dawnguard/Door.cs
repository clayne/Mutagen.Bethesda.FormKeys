using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> SERuinsDoorLoadPhantom01 => Construct(0x144f2);
            public static FormLink<IDoorGetter> SERuinsDoorTemple02 => Construct(0x13df5);
            public static FormLink<IDoorGetter> PortalGemDoorNOSOUND => Construct(0xf725);
            public static FormLink<IDoorGetter> SERuinsDoorTemple01 => Construct(0xd257);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorDarkfallCave => Construct(0xc83a);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorValleyStart => Construct(0x1a3b8);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorPassageStart => Construct(0x1a346);
            public static FormLink<IDoorGetter> PortalGemDoor => Construct(0x19ac2);
            public static FormLink<IDoorGetter> CasExFreeSmDoorLoad01_MinUse => Construct(0x19a9c);
            public static FormLink<IDoorGetter> sc_BoneyardDoor => Construct(0x18ef7);
            public static FormLink<IDoorGetter> CasExFreeLgDoorLoad01_MinUse => Construct(0x176ed);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorValley => Construct(0x15043);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorWaterfalls => Construct(0x15042);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorTemple => Construct(0x15041);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorLake => Construct(0x15040);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorGrove => Construct(0x1503f);
            public static FormLink<IDoorGetter> DLC1WayshrineDoorPassage => Construct(0x1503e);
            public static FormLink<IDoorGetter> SERuinsDoorLoad01 => Construct(0x13ff8);
            public static FormLink<IDoorGetter> SERuinsDoor01 => Construct(0x13ff0);
            public static FormLink<IDoorGetter> CasExFreeSmDoorLoad01 => Construct(0x13b84);
            public static FormLink<IDoorGetter> CasExFreeLgDoorLoad01 => Construct(0x13b83);
            public static FormLink<IDoorGetter> CasExFreeSmDoor02 => Construct(0x13b82);
            public static FormLink<IDoorGetter> CasExFreeSmDoor01 => Construct(0x119f9);
            public static FormLink<IDoorGetter> CasExFreeLgDoor01 => Construct(0x119f8);
            public static FormLink<IDoorGetter> DLC1WaygateDoor => Construct(0xc147);
            public static FormLink<IDoorGetter> DLC1RowboatDoor => Construct(0xbdde);
        }
    }
}
