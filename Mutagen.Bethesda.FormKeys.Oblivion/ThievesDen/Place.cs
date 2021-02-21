using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> xDL06CaptainsQuarters => Construct(0x139d);
            public static FormLink<IPlaceGetter> xDL06DunBarrowHaven => Construct(0xce6);
            public static FormLink<IPlaceGetter> xDL06DunBarrowHaven02 => Construct(0xd94);
            public static FormLink<IPlaceGetter> xDL06ShipInterior => Construct(0x19a9);
        }
    }
}
