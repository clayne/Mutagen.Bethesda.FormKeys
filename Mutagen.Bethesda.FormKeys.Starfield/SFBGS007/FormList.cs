// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS007
{
    public static partial class FormList
    {
        private static FormLink<IFormListGetter> Construct(uint id) => new FormLink<IFormListGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFormListGetter> GPO_PEO_GameplayOptionDifficultySliders => Construct(0x47);
    }
}
