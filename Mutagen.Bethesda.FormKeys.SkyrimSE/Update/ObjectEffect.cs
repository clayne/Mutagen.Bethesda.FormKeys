// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Update
{
    public static partial class ObjectEffect
    {
        private static FormLink<IObjectEffectGetter> Construct(uint id) => new FormLink<IObjectEffectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IObjectEffectGetter> CCHorseArmorEnchFortifyHealth => Construct(0x30c7);
    }
}
