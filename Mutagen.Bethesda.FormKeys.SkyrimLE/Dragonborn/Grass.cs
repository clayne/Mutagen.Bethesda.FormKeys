// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dragonborn
{
    public static partial class Grass
    {
        private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGrassGetter> DLC02VolcanicAshGrass01 => Construct(0x17ea2);
        public static FormLink<IGrassGetter> DLC02VolcanicAshRocks01 => Construct(0x1771e);
    }
}
