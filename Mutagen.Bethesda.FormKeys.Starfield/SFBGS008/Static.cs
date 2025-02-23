// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS008
{
    public static partial class Static
    {
        private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IStaticGetter> SFBGS008_CityMaps_NeonCore => Construct(0x47);
        public static FormLink<IStaticGetter> SFBGS008_CityMaps_CydoniaResidential01 => Construct(0x48);
        public static FormLink<IStaticGetter> SFBGS008_CityMaps_CydoniaMainLevel01 => Construct(0x49);
    }
}
