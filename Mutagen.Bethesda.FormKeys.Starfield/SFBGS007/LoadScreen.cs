// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS007
{
    public static partial class LoadScreen
    {
        private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILoadScreenGetter> PEO_GameplayOptions => Construct(0x45);
    }
}
