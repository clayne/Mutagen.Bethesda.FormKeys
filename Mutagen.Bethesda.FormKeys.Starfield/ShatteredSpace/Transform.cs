// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Transform
    {
        private static FormLink<ITransformGetter> Construct(uint id) => new FormLink<ITransformGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ITransformGetter> SFBGS001_Inv_DefaultTransform_Effigy01 => Construct(0x164c36);
    }
}
