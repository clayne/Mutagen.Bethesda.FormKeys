using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class FootstepSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IFootstepSetGetter> Construct(uint id) => new FormLink<IFootstepSetGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFootstepSetGetter> NPCVampireLordFootstepSet => Construct(0x1377c);
            public static FormLink<IFootstepSetGetter> NPCDogHuskyFootWalkFootstepSet => Construct(0x117fd);
            public static FormLink<IFootstepSetGetter> NPCDogDeathHoundFootWalkFootstepSet => Construct(0x115cd);
            public static FormLink<IFootstepSetGetter> NPCArmoredTrollFootWalkFootstepSet => Construct(0x39a7);
            public static FormLink<IFootstepSetGetter> NPCGargoyleFootWalkFootstepSet => Construct(0xf8ad);
            public static FormLink<IFootstepSetGetter> NPCHorseSkeletonFootFootstepSet => Construct(0xefb2);
        }
    }
}
