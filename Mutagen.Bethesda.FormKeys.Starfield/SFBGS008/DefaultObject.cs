// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS008
{
    public static partial class DefaultObject
    {
        private static FormLink<IDefaultObjectGetter> Construct(uint id) => new FormLink<IDefaultObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDefaultObjectGetter> CityMapExteriorImageSpace_DO => Construct(0x4b);
        public static FormLink<IDefaultObjectGetter> CityMapInteriorImageSpace_DO => Construct(0x4d);
    }
}
