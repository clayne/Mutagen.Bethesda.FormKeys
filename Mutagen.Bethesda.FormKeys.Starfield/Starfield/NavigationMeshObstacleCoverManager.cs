// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class NavigationMeshObstacleCoverManager
    {
        private static FormLink<INavigationMeshObstacleCoverManagerGetter> Construct(uint id) => new FormLink<INavigationMeshObstacleCoverManagerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<INavigationMeshObstacleCoverManagerGetter> NavmeshObstacleCoverManager => Construct(0x26);
    }
}
