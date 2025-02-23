// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class FootstepSet
    {
        private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepSetGetter> SFBGS001_FSTDefaultRedeemedFootstepSet => Construct(0x961c1);
    }
}
