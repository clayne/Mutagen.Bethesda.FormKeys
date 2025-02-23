// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class Perk
    {
        private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPerkGetter> SFBGS003_BountyTagPromptPerk => Construct(0x5780);
        public static FormLink<IPerkGetter> SFBGS003_ActivatePoster_Perk => Construct(0xf6d1);
    }
}
