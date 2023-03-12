// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dawnguard
{
    public static partial class Grass
    {
        private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGrassGetter> DLC01SoulCairnGrass01 => Construct(0x78ae);
    }
}
