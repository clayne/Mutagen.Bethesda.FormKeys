// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class ObjectVisibilityManager
    {
        private static FormLink<IObjectVisibilityManagerGetter> Construct(uint id) => new FormLink<IObjectVisibilityManagerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IObjectVisibilityManagerGetter> _ObjectVisibilityManager => Construct(0x27);
    }
}
