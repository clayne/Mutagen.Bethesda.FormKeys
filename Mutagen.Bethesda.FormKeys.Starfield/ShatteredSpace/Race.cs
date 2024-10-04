// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Race
    {
        private static FormLink<IRaceGetter> Construct(uint id) => new FormLink<IRaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IRaceGetter> SFBGS001_HexapodARace => Construct(0x6528);
        public static FormLink<IRaceGetter> SFBGS001_HumanRace => Construct(0x6529);
        public static FormLink<IRaceGetter> SFBGS001_ParasiteARace => Construct(0x652a);
        public static FormLink<IRaceGetter> SFBGS001_QuadrupedARace => Construct(0x11bf9);
        public static FormLink<IRaceGetter> SFBGS001_RedeemedRace => Construct(0x110891);
    }
}
