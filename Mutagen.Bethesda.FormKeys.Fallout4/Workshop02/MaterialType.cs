// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class MaterialType
    {
        private static FormLink<IMaterialTypeGetter> Construct(uint id) => new FormLink<IMaterialTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMaterialTypeGetter> DLC05MaterialBallTrackMetalFunnel => Construct(0xe18);
        public static FormLink<IMaterialTypeGetter> DLC05MaterialBallTrackWood => Construct(0xe17);
        public static FormLink<IMaterialTypeGetter> DLC05MaterialBallTrackMetal => Construct(0xe16);
        public static FormLink<IMaterialTypeGetter> DLC05MaterialBallTrackBall => Construct(0xe0f);
    }
}
