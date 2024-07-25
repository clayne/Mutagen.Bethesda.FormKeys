// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class Impact
    {
        private static FormLink<IImpactGetter> Construct(uint id) => new FormLink<IImpactGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImpactGetter> SFBGS003_MaterialShipPart_Impact => Construct(0x688d);
        public static FormLink<IImpactGetter> SFBGS003_PlasmaCutter_vs_MetalImpact => Construct(0xf655);
        public static FormLink<IImpactGetter> SFBGS003_PlasmaCutter_vs_GenericImpact => Construct(0xf656);
    }
}
