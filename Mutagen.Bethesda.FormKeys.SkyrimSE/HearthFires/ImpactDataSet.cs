// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class HearthFires
{
    public static partial class ImpactDataSet
    {
        private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImpactDataSetGetter> WPNzBlade1HandWoodSwordImpactSet => Construct(0x8993);
    }
}
