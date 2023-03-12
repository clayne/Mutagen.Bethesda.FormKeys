// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Dawnguard
{
    public static partial class AddonNode
    {
        private static FormLink<IAddonNodeGetter> Construct(uint id) => new FormLink<IAddonNodeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAddonNodeGetter> DLC1MPSVampDrainTrail01 => Construct(0x1a3f9);
        public static FormLink<IAddonNodeGetter> DLC01SoulRendTrailMPS => Construct(0x7cbe);
    }
}
