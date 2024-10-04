// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Star
    {
        private static FormLink<IStarGetter> Construct(uint id) => new FormLink<IStarGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IStarGetter> KavnykStar => Construct(0x26bb);
    }
}
