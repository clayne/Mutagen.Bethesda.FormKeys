using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Weather
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeatherGetter> SoulCairnAmb01_Rain => Construct(0x14551);
            public static FormLink<IWeatherGetter> DLC1_SkyrimClearFV_A => Construct(0x10e10);
            public static FormLink<IWeatherGetter> DLC1_SkyrimClearFV => Construct(0x10e0f);
            public static FormLink<IWeatherGetter> DLC1_SkyrimCloudyFV => Construct(0x10e0e);
            public static FormLink<IWeatherGetter> DLC1_SkyrimCloudyFV_A => Construct(0x10e0b);
            public static FormLink<IWeatherGetter> DLC1FalmerValley_bfDark => Construct(0x195a0);
            public static FormLink<IWeatherGetter> DLC1FalmerValley_bf => Construct(0x19599);
            public static FormLink<IWeatherGetter> SoulCairnAmb04 => Construct(0x18dbd);
            public static FormLink<IWeatherGetter> SoulCairnAmb03 => Construct(0x18dbc);
            public static FormLink<IWeatherGetter> SoulCairnAmb02 => Construct(0x18dbb);
            public static FormLink<IWeatherGetter> DLC1MagicAurielBowCloudyWeather => Construct(0xf89d);
            public static FormLink<IWeatherGetter> DLC1AurielsBowClearWeather => Construct(0xf89c);
            public static FormLink<IWeatherGetter> SoulCairnAurora => Construct(0x959f);
            public static FormLink<IWeatherGetter> DLC1Eclipse => Construct(0x6aec);
            public static FormLink<IWeatherGetter> SoulCairnAmb01 => Construct(0x1407);
        }
    }
}
