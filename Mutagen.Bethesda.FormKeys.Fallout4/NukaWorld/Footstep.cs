// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class Footstep
    {
        private static FormLink<IFootstepGetter> Construct(uint id) => new FormLink<IFootstepGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepGetter> DLC04NPCRadratBreatheRunFootstep => Construct(0x418b9);
        public static FormLink<IFootstepGetter> DLC04NPCCricketFootBackFootstep => Construct(0x3583e);
        public static FormLink<IFootstepGetter> DLC04NPCCricketFootFrontFootstep => Construct(0x3583d);
        public static FormLink<IFootstepGetter> Dlc04NPCBloodwormFootstep => Construct(0x1fb3a);
    }
}
