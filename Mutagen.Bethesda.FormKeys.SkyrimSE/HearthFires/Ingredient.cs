// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class HearthFires
{
    public static partial class Ingredient
    {
        private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIngredientGetter> BYOHHawkEgg01 => Construct(0xf1cc);
        public static FormLink<IIngredientGetter> BYOHSalmonRoe01 => Construct(0x3545);
    }
}
