// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class MehrunesRazor
{
    public static partial class Furniture
    {
        private static FormLink<IFurnitureGetter> Construct(uint id) => new FormLink<IFurnitureGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFurnitureGetter> DL9Stool01 => Construct(0x92ce);
    }
}
