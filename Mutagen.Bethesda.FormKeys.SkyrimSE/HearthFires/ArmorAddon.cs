// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class HearthFires
{
    public static partial class ArmorAddon
    {
        private static FormLink<IArmorAddonGetter> Construct(uint id) => new FormLink<IArmorAddonGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IArmorAddonGetter> ChildTorso05AA => Construct(0xc741);
        public static FormLink<IArmorAddonGetter> ChildTorso04AA => Construct(0xc73f);
    }
}
