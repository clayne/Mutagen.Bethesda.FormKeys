// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Clouds
    {
        private static FormLink<ICloudsGetter> Construct(uint id) => new FormLink<ICloudsGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICloudsGetter> DLC001_CloudsPartlyCloudy06_NorthernLights => Construct(0x39bc5);
        public static FormLink<ICloudsGetter> DLC001_CloudsCloudy04_NorthernLights => Construct(0x7a0e3);
        public static FormLink<ICloudsGetter> DLC001_CloudsClear_NorthernLights => Construct(0x7a0e4);
        public static FormLink<ICloudsGetter> DLC001_CloudsClear_NorthernLightsRed => Construct(0x10d6f6);
        public static FormLink<ICloudsGetter> DLC001_CloudsEnergyStorm => Construct(0x112167);
    }
}
