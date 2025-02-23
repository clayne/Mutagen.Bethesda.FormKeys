// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Atmosphere
    {
        private static FormLink<IAtmosphereGetter> Construct(uint id) => new FormLink<IAtmosphereGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAtmosphereGetter> ATMO_VaruunkaiDUPLICATE000 => Construct(0x26be);
        public static FormLink<IAtmosphereGetter> ATMO_KavnykII_c => Construct(0x26c6);
        public static FormLink<IAtmosphereGetter> ATMO_KavnykII_d => Construct(0x26c7);
        public static FormLink<IAtmosphereGetter> ATMO_KavnykII_e => Construct(0x26c8);
        public static FormLink<IAtmosphereGetter> SFBGS001_ATMO_Varuunkai => Construct(0x5be03);
    }
}
