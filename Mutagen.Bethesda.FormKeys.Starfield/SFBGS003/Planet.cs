// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class Planet
    {
        private static FormLink<IPlanetGetter> Construct(uint id) => new FormLink<IPlanetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPlanetGetter> _SFBGS003ChopShopOrbitalPlanetData => Construct(0x2810);
    }
}
