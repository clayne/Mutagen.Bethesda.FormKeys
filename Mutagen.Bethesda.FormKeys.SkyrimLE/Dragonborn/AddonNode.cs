// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dragonborn
{
    public static partial class AddonNode
    {
        private static FormLink<IAddonNodeGetter> Construct(uint id) => new FormLink<IAddonNodeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAddonNodeGetter> AshMps => Construct(0x27bf8);
    }
}
