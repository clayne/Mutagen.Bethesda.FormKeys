// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class MiscItem
    {
        private static FormLink<IMiscItemGetter> Construct(uint id) => new FormLink<IMiscItemGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA00_completed => Construct(0x52f);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA01_completed => Construct(0x532);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA00 => Construct(0xf918);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA01 => Construct(0xf928);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA02 => Construct(0xf938);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA03 => Construct(0xf948);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA04 => Construct(0xf951);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA05 => Construct(0xf982);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA06 => Construct(0xf984);
        public static FormLink<IMiscItemGetter> SFBGS003_DisplayScreen_SFTA07 => Construct(0xf996);
    }
}
