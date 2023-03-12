// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class FootstepSet
    {
        private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFootstepSetGetter> DLC04NPCRadratFootWalkFootstepSet => Construct(0x40d3a);
        public static FormLink<IFootstepSetGetter> DLC04NPCGatorclawFootstepSet => Construct(0x36378);
        public static FormLink<IFootstepSetGetter> DLC04NPCCricketFootstepSet => Construct(0x3583f);
        public static FormLink<IFootstepSetGetter> DLC04NPCBloodwormFootstepSet => Construct(0x1fb39);
    }
}
