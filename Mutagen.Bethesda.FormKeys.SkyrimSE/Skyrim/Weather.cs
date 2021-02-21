using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Weather
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IWeatherGetter> Construct(uint id) => new FormLink<IWeatherGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeatherGetter> SovngardeDark => Construct(0x10fef8);
            public static FormLink<IWeatherGetter> RiftenOvercastFog => Construct(0x10fe7e);
            public static FormLink<IWeatherGetter> EditorCloudPreview => Construct(0x10e3d4);
            public static FormLink<IWeatherGetter> SkyrimClear_A => Construct(0x10e1f2);
            public static FormLink<IWeatherGetter> SkyrimCloudy_A => Construct(0x10e1f1);
            public static FormLink<IWeatherGetter> SkyrimClearSN_A => Construct(0x10e1f0);
            public static FormLink<IWeatherGetter> SkyrimCloudySN_A => Construct(0x10e1ef);
            public static FormLink<IWeatherGetter> SkyrimClearTU_A => Construct(0x10e1ee);
            public static FormLink<IWeatherGetter> SkyrimCloudyTU_A => Construct(0x10e1ed);
            public static FormLink<IWeatherGetter> SkyrimClearFF_A => Construct(0x10e1ec);
            public static FormLink<IWeatherGetter> SkyrimCloudyFF_A => Construct(0x10e1eb);
            public static FormLink<IWeatherGetter> SkyrimClearRE_A => Construct(0x10e1ea);
            public static FormLink<IWeatherGetter> SkyrimCloudyRE_A => Construct(0x10e1e9);
            public static FormLink<IWeatherGetter> SkyrimClearCO_A => Construct(0x10e1e8);
            public static FormLink<IWeatherGetter> SkyrimCloudyCO_A => Construct(0x10e1e7);
            public static FormLink<IWeatherGetter> SkyrimClearMA_A => Construct(0x10e1e6);
            public static FormLink<IWeatherGetter> SkyrimCloudyMA_A => Construct(0x10e1e5);
            public static FormLink<IWeatherGetter> SkyrimClearVT_A => Construct(0x10e1e4);
            public static FormLink<IWeatherGetter> SkyrimCloudyVT_A => Construct(0x10e1e3);
            public static FormLink<IWeatherGetter> FXWthrInvertWindowsWinterhold => Construct(0x10da13);
            public static FormLink<IWeatherGetter> SovngardeClear => Construct(0x10d9ec);
            public static FormLink<IWeatherGetter> FXSkyrimStormBlowingGrass => Construct(0x10c32f);
            public static FormLink<IWeatherGetter> SkyrimCloudyVT => Construct(0x10a7a8);
            public static FormLink<IWeatherGetter> SkyrimFogVT => Construct(0x10a7a7);
            public static FormLink<IWeatherGetter> SkyrimOvercastRainVT => Construct(0x10a7a6);
            public static FormLink<IWeatherGetter> SkyrimClearVT => Construct(0x10a7a5);
            public static FormLink<IWeatherGetter> SkyrimCloudySN => Construct(0x10a245);
            public static FormLink<IWeatherGetter> SkyrimClearSN => Construct(0x10a244);
            public static FormLink<IWeatherGetter> SkyrimCloudyTU => Construct(0x10a243);
            public static FormLink<IWeatherGetter> SkyrimOvercastRainTU => Construct(0x10a242);
            public static FormLink<IWeatherGetter> SkyrimStormRainTU => Construct(0x10a241);
            public static FormLink<IWeatherGetter> SkyrimClearTU => Construct(0x10a240);
            public static FormLink<IWeatherGetter> SkyrimCloudyFF => Construct(0x10a23f);
            public static FormLink<IWeatherGetter> SkyrimFogFF => Construct(0x10a23e);
            public static FormLink<IWeatherGetter> SkyrimOvercastRainFF => Construct(0x10a23d);
            public static FormLink<IWeatherGetter> SkyrimStormRainFF => Construct(0x10a23c);
            public static FormLink<IWeatherGetter> SkyrimClearFF => Construct(0x10a23b);
            public static FormLink<IWeatherGetter> SkyrimCloudyRE => Construct(0x10a23a);
            public static FormLink<IWeatherGetter> SkyrimFogRE => Construct(0x10a239);
            public static FormLink<IWeatherGetter> SkyrimOvercastRainRE => Construct(0x10a238);
            public static FormLink<IWeatherGetter> SkyrimClearRE => Construct(0x10a237);
            public static FormLink<IWeatherGetter> SkyrimCloudyCO => Construct(0x10a236);
            public static FormLink<IWeatherGetter> SkyrimFogCO => Construct(0x10a235);
            public static FormLink<IWeatherGetter> SkyrimClearCO => Construct(0x10a234);
            public static FormLink<IWeatherGetter> SkyrimCloudyMA => Construct(0x10a233);
            public static FormLink<IWeatherGetter> SkyrimFogMA => Construct(0x10a232);
            public static FormLink<IWeatherGetter> SkyrimOvercastRainMA => Construct(0x10a231);
            public static FormLink<IWeatherGetter> SkyrimClearMA => Construct(0x10a230);
            public static FormLink<IWeatherGetter> KarthspireRedoubtFog => Construct(0x106635);
            public static FormLink<IWeatherGetter> SkyrimDA02Weather => Construct(0x105f40);
            public static FormLink<IWeatherGetter> SolitudeBluePalaceFog => Construct(0x105945);
            public static FormLink<IWeatherGetter> SolitudeBluePalaceFogNMARE => Construct(0x105944);
            public static FormLink<IWeatherGetter> SolitudeBluePalaceFogFEAR => Construct(0x105943);
            public static FormLink<IWeatherGetter> SolitudeBluePalaceFogARENA => Construct(0x105942);
            public static FormLink<IWeatherGetter> BloatedMansGrottoFog => Construct(0x105941);
            public static FormLink<IWeatherGetter> SkuldafnCloudy => Construct(0x104ab4);
            public static FormLink<IWeatherGetter> SkyrimMQ206weather => Construct(0x10199f);
            public static FormLink<IWeatherGetter> FXWthrInvertLightMarkarth => Construct(0x101910);
            public static FormLink<IWeatherGetter> FXWthrInvertWindowsWindhelm2 => Construct(0xecc96);
            public static FormLink<IWeatherGetter> HelgenAttackWeather => Construct(0xd9329);
            public static FormLink<IWeatherGetter> FXWthrInvertLightsSolitude => Construct(0x5ed7a);
            public static FormLink<IWeatherGetter> FXWthrInvertLightsWhiterun => Construct(0x8282a);
            public static FormLink<IWeatherGetter> FXWthrInvertWindowsWhiterun => Construct(0x8277a);
            public static FormLink<IWeatherGetter> FXMagicStormRain => Construct(0xd4886);
            public static FormLink<IWeatherGetter> SkyrimOvercastWar => Construct(0xd299e);
            public static FormLink<IWeatherGetter> SkyrimStormSnow => Construct(0xc8221);
            public static FormLink<IWeatherGetter> SkyrimStormRain => Construct(0xc8220);
            public static FormLink<IWeatherGetter> SkyrimOvercastRain => Construct(0xc821f);
            public static FormLink<IWeatherGetter> SkyrimFog => Construct(0xc821e);
            public static FormLink<IWeatherGetter> FXWthrSunlightWhite => Construct(0x75491);
            public static FormLink<IWeatherGetter> FXWthrSunlight => Construct(0x7548f);
            public static FormLink<IWeatherGetter> BlackreachWeather => Construct(0x48c14);
            public static FormLink<IWeatherGetter> FXWthrInvertWindowsWindhelm => Construct(0xaee84);
            public static FormLink<IWeatherGetter> WorldMapWeather => Construct(0xa6858);
            public static FormLink<IWeatherGetter> SovngardeFog => Construct(0x923fd);
            public static FormLink<IWeatherGetter> FXWthrInvertDayNighWarm => Construct(0x777cf);
            public static FormLink<IWeatherGetter> FXWthrCaveBluePaleLight => Construct(0x75de5);
            public static FormLink<IWeatherGetter> FXWthrCaveBlueSkylight => Construct(0x6ed5b);
            public static FormLink<IWeatherGetter> FXWthrInvertDayNight => Construct(0x6ed5a);
            public static FormLink<IWeatherGetter> SkyrimOvercastSnow => Construct(0x4d7fb);
            public static FormLink<IWeatherGetter> TESTCloudyRain => Construct(0x2e7ab);
            public static FormLink<IWeatherGetter> SkyrimCloudy => Construct(0x12f89);
            public static FormLink<IWeatherGetter> SkyrimClear => Construct(0x81a);
            public static FormLink<IWeatherGetter> DefaultWeather => Construct(0x15e);
        }
    }
}
