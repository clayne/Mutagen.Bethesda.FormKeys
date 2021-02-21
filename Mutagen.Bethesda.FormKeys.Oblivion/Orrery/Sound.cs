using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Sound
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundGetter> AMBOrreryRoomLP => Construct(0x126b26);
            public static FormLink<ISoundGetter> AMBOrreryButtonPush => Construct(0x126b27);
            public static FormLink<ISoundGetter> AMBOrreryStartup => Construct(0x126b28);
            public static FormLink<ISoundGetter> AMBOrreryLP => Construct(0x126b29);
            public static FormLink<ISoundGetter> AMBOrreryGearsMediumLP => Construct(0x126b2a);
            public static FormLink<ISoundGetter> AMBOrreryGearsSmallLP => Construct(0x126b2b);
        }
    }
}
