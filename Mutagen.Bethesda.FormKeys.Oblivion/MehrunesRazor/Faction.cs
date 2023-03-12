// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class MehrunesRazor
{
    public static partial class Faction
    {
        private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFactionGetter> DL9MoragTongFaction => Construct(0x252f);
        public static FormLink<IFactionGetter> DL9CommanderFaction => Construct(0x2530);
        public static FormLink<IFactionGetter> DL9DrothermiFaction => Construct(0x14e9);
    }
}
