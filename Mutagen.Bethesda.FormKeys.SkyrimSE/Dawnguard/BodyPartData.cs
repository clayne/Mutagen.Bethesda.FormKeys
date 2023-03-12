// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Dawnguard
{
    public static partial class BodyPartData
    {
        private static FormLink<IBodyPartDataGetter> Construct(uint id) => new FormLink<IBodyPartDataGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IBodyPartDataGetter> GargoyleBodyPartData => Construct(0xa2c7);
        public static FormLink<IBodyPartDataGetter> ChaurusFlyerBodyPartData => Construct(0x5205);
    }
}
