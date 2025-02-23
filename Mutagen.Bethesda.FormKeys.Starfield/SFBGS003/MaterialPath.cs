// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class MaterialPath
    {
        private static FormLink<IMaterialPathGetter> Construct(uint id) => new FormLink<IMaterialPathGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMaterialPathGetter> SFBGS003_DecalLogo_Trackersalliance01_Path => Construct(0xa375);
        public static FormLink<IMaterialPathGetter> SFBGS003_DecalLogo_Trackersalliance01b_Path => Construct(0xa378);
        public static FormLink<IMaterialPathGetter> SFBGS003_DecalLogo_Trackersalliance02_Path => Construct(0xa379);
    }
}
