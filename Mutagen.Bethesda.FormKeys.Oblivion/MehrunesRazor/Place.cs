using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Place
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IPlaceGetter> Construct(uint id) => new FormLink<IPlaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlaceGetter> DL9jbrowneAyleid => Construct(0x2db4);
            public static FormLink<IPlaceGetter> DL9c => Construct(0x13a6);
            public static FormLink<IPlaceGetter> DL9c03house2 => Construct(0x12e8);
            public static FormLink<IPlaceGetter> DL9c02 => Construct(0xec4);
            public static FormLink<IPlaceGetter> DL9c08 => Construct(0xece);
            public static FormLink<IPlaceGetter> DL9c02house2 => Construct(0x20c6);
            public static FormLink<IPlaceGetter> DL9c01 => Construct(0xce6);
            public static FormLink<IPlaceGetter> DL9c04 => Construct(0xec6);
            public static FormLink<IPlaceGetter> DL9c03house3 => Construct(0x282a);
            public static FormLink<IPlaceGetter> DL9c09 => Construct(0xed0);
            public static FormLink<IPlaceGetter> DL9c02jail => Construct(0x1a1b);
            public static FormLink<IPlaceGetter> DL9c05 => Construct(0xec8);
            public static FormLink<IPlaceGetter> DL9c10 => Construct(0xed2);
            public static FormLink<IPlaceGetter> DL9c03house1 => Construct(0x19af);
            public static FormLink<IPlaceGetter> DL9c03house4 => Construct(0x2982);
            public static FormLink<IPlaceGetter> DL9c06 => Construct(0xeca);
            public static FormLink<IPlaceGetter> DL9c02house4 => Construct(0x2aea);
            public static FormLink<IPlaceGetter> DL9c06tent => Construct(0xed4);
            public static FormLink<IPlaceGetter> DL9c02house3 => Construct(0x216d);
            public static FormLink<IPlaceGetter> DL9c02house1 => Construct(0x130d);
            public static FormLink<IPlaceGetter> DL9c08house3 => Construct(0x385c);
            public static FormLink<IPlaceGetter> DL9c08house1 => Construct(0x3438);
            public static FormLink<IPlaceGetter> DL9c03 => Construct(0xec2);
            public static FormLink<IPlaceGetter> DL9c07 => Construct(0xecc);
            public static FormLink<IPlaceGetter> DL9c08house2 => Construct(0x364b);
        }
    }
}
