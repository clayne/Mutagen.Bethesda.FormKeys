// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS004
{
    public static partial class LensFlare
    {
        private static FormLink<ILensFlareGetter> Construct(uint id) => new FormLink<ILensFlareGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILensFlareGetter> SFBGS004_LGT_Vehicle_HeadLights_LensFlare => Construct(0x3e);
        public static FormLink<ILensFlareGetter> SFBGS004_RoverBoostLensFlare => Construct(0x28e);
        public static FormLink<ILensFlareGetter> SFBGS004_RoverMuzzleLensFlare => Construct(0x30a);
    }
}
