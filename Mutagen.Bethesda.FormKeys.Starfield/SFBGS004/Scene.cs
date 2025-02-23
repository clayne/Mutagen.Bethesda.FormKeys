// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS004
{
    public static partial class Scene
    {
        private static FormLink<ISceneGetter> Construct(uint id) => new FormLink<ISceneGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISceneGetter> DialogueWarningScene => Construct(0x325);
    }
}
