// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class MaterialType
    {
        private static FormLink<IMaterialTypeGetter> Construct(uint id) => new FormLink<IMaterialTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMaterialTypeGetter> SFBGS003_MaterialShipPart => Construct(0x688b);
    }
}
