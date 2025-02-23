// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class Hazard
    {
        private static FormLink<IHazardGetter> Construct(uint id) => new FormLink<IHazardGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IHazardGetter> DLC001_LC01_PointGravHazard_SM => Construct(0xae21);
        public static FormLink<IHazardGetter> SFBGS001_ZeroGFieldHazard => Construct(0x11bb9c);
        public static FormLink<IHazardGetter> SFBGS001LC05_ENV_PoolHazard_CorrosiveLiquid => Construct(0x136e6c);
        public static FormLink<IHazardGetter> SFBGS001_LowGravity_Hazard => Construct(0x14c3a7);
        public static FormLink<IHazardGetter> SFBGS001_VortexGravWellHazard => Construct(0x155687);
        public static FormLink<IHazardGetter> SFBGS001_VortexGravWellExpulseHazard => Construct(0x155688);
    }
}
