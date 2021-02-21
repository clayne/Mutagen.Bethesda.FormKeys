using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Weather
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeatherGetter> SEClearTrans => Construct(0x8ef42);
            public static FormLink<IWeatherGetter> SE13JiggyWeather => Construct(0x825a6);
            public static FormLink<IWeatherGetter> SEManiaFog => Construct(0x79d76);
            public static FormLink<IWeatherGetter> SEClear => Construct(0x78801);
            public static FormLink<IWeatherGetter> SEOrderedFringe => Construct(0x77c0a);
            public static FormLink<IWeatherGetter> SEWaitingRoomWeather => Construct(0x77b56);
            public static FormLink<IWeatherGetter> SEOvercast => Construct(0x77b28);
            public static FormLink<IWeatherGetter> SETestAsh => Construct(0x71d2f);
            public static FormLink<IWeatherGetter> SEClear03 => Construct(0x6d222);
            public static FormLink<IWeatherGetter> SEClear01 => Construct(0x6d221);
            public static FormLink<IWeatherGetter> SE09SummoningWeather => Construct(0x452b5);
            public static FormLink<IWeatherGetter> SEThunderstorm => Construct(0x44f5d);
            public static FormLink<IWeatherGetter> SERain => Construct(0x44f5c);
            public static FormLink<IWeatherGetter> SEFog => Construct(0x44f5a);
            public static FormLink<IWeatherGetter> SECloudy => Construct(0x44f59);
            public static FormLink<IWeatherGetter> SEClearBlue => Construct(0x44f58);
            public static FormLink<IWeatherGetter> TestBlissClear => Construct(0x41775);
            public static FormLink<IWeatherGetter> SE32GloomStorm => Construct(0x15883);
            public static FormLink<IWeatherGetter> ThunderstormKvatch => Construct(0x8bbc);
            public static FormLink<IWeatherGetter> SigilWhiteOut => Construct(0xc42de);
            public static FormLink<IWeatherGetter> OblivionSigil => Construct(0xc0999);
            public static FormLink<IWeatherGetter> OblivionStormTamrielMQ16 => Construct(0x6bc8b);
            public static FormLink<IWeatherGetter> OblivionMountainFog => Construct(0x671a1);
            public static FormLink<IWeatherGetter> OblivionStormOblivion => Construct(0x67199);
            public static FormLink<IWeatherGetter> OblivionElectrical => Construct(0x67198);
            public static FormLink<IWeatherGetter> MS14Sky => Construct(0x18bccf);
            public static FormLink<IWeatherGetter> OblivionStormTamriel => Construct(0x836d5);
            public static FormLink<IWeatherGetter> Rain => Construct(0x38ef2);
            public static FormLink<IWeatherGetter> Thunderstorm => Construct(0x38ef1);
            public static FormLink<IWeatherGetter> Cloudy => Construct(0x38ef0);
            public static FormLink<IWeatherGetter> Fog => Construct(0x38eef);
            public static FormLink<IWeatherGetter> Clear => Construct(0x38eee);
            public static FormLink<IWeatherGetter> Snow => Construct(0x38eed);
            public static FormLink<IWeatherGetter> Overcast => Construct(0x38eec);
            public static FormLink<IWeatherGetter> DefaultWeather => Construct(0x15e);
            public static FormLink<IWeatherGetter> CamoranWeather => Construct(0x370ce);
            public static FormLink<IWeatherGetter> Obliviondefault => Construct(0x32e15);
        }
    }
}
