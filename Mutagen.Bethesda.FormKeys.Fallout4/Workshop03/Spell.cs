// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class Spell
    {
        private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISpellGetter> DLC06BuffLuck => Construct(0x808);
        public static FormLink<ISpellGetter> DLC06BuffAgility => Construct(0x807);
        public static FormLink<ISpellGetter> DLC06BuffIntelligence => Construct(0x806);
        public static FormLink<ISpellGetter> DLC06BuffCharisma => Construct(0x805);
        public static FormLink<ISpellGetter> DLC06BuffEndurance => Construct(0x804);
        public static FormLink<ISpellGetter> DLC06BuffPerception => Construct(0x803);
        public static FormLink<ISpellGetter> DLC06BuffStrength => Construct(0x801);
    }
}
