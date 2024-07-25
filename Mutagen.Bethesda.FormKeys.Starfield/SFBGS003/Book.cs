// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class Book
    {
        private static FormLink<IBookGetter> Construct(uint id) => new FormLink<IBookGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IBookGetter> SFBGS003_TAHQ_FoundingTrackers_Book => Construct(0xe2f8);
        public static FormLink<IBookGetter> SFBGS003_TAHQ_Volk_Slate => Construct(0xe2f9);
        public static FormLink<IBookGetter> SFBGS003_TAHQ_TrackerHistory_Book => Construct(0xe2fd);
    }
}
