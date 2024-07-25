// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class MagicEffect
    {
        private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMagicEffectGetter> SFBGS003_abAddPerkActivatePoster => Construct(0xf6cf);
    }
}
