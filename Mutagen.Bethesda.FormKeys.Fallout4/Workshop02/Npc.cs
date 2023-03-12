// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class Npc
    {
        private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
        public static FormLink<INpcGetter> DLC05WorkshopArmorRackFemale01 => Construct(0x8b3);
        public static FormLink<INpcGetter> DLC05WorkshopArmorRackMale01 => Construct(0x8ac);
    }
}
