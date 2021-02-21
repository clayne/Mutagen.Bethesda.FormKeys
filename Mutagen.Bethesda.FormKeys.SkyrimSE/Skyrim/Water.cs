using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Water
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWaterGetter> DefaultWaterKatariahWorld => Construct(0x10cc8e);
            public static FormLink<IWaterGetter> MarkarthWaterFlow => Construct(0x10b1d7);
            public static FormLink<IWaterGetter> RiverWaterFlowSE => Construct(0x108ac7);
            public static FormLink<IWaterGetter> CreekWaterFlowSW => Construct(0x106a24);
            public static FormLink<IWaterGetter> CreekWaterFlowSE => Construct(0x106a20);
            public static FormLink<IWaterGetter> RiverWaterFlowNW => Construct(0x1063aa);
            public static FormLink<IWaterGetter> DefaultWaterNW => Construct(0x10639f);
            public static FormLink<IWaterGetter> DefaultRiverWater => Construct(0x105ce1);
            public static FormLink<IWaterGetter> DefaultMarshWaterTransition => Construct(0x105cc4);
            public static FormLink<IWaterGetter> DefaultMarshWater => Construct(0x105cc3);
            public static FormLink<IWaterGetter> PuddleWaterFlow => Construct(0xfe092);
            public static FormLink<IWaterGetter> PuddleWaterLiteFog => Construct(0xfd0db);
            public static FormLink<IWaterGetter> HorseTroughWater01 => Construct(0xf762d);
            public static FormLink<IWaterGetter> ShadowmereWater => Construct(0xf4573);
            public static FormLink<IWaterGetter> RiftenWater => Construct(0xf2407);
            public static FormLink<IWaterGetter> DefaultIntWaterAnkleHeightStill => Construct(0xcc7b7);
            public static FormLink<IWaterGetter> DefaultIntWaterWaistHeightStill => Construct(0xcc7b4);
            public static FormLink<IWaterGetter> ClearInteriorWaterAnkleHeightStill => Construct(0xcb11f);
            public static FormLink<IWaterGetter> WRWaterFlow => Construct(0x85fc8);
            public static FormLink<IWaterGetter> RiverWaterFlowNE => Construct(0xe717c);
            public static FormLink<IWaterGetter> DeepwoodRedoubtWater => Construct(0xe3812);
            public static FormLink<IWaterGetter> HelgenWater => Construct(0xc1d45);
            public static FormLink<IWaterGetter> MurkyWater => Construct(0x62a72);
            public static FormLink<IWaterGetter> MarkarthWater => Construct(0x7a5f6);
            public static FormLink<IWaterGetter> BlackreachWater => Construct(0x48c2b);
            public static FormLink<IWaterGetter> WRWaterType => Construct(0x74eea);
            public static FormLink<IWaterGetter> DefaultVolcanicWater => Construct(0x713c4);
            public static FormLink<IWaterGetter> LavaWater => Construct(0x51353);
            public static FormLink<IWaterGetter> PuddleWater => Construct(0x4cc4b);
            public static FormLink<IWaterGetter> dunSleepingTreeCampWater => Construct(0x261ea);
            public static FormLink<IWaterGetter> CreekWaterFlow => Construct(0x15429);
            public static FormLink<IWaterGetter> DefaultCreekWater => Construct(0x15427);
            public static FormLink<IWaterGetter> DefaultIntWaterWaistHeightFlow => Construct(0x33da7);
            public static FormLink<IWaterGetter> DefaultWater => Construct(0x18);
        }
    }
}
