using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IAIPackageGetter> Construct(uint id) => new FormLink<IAIPackageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAIPackageGetter> DLCOrreryBothielWaitforPlayer => Construct(0x123016);
            public static FormLink<IAIPackageGetter> DLCBanditWanderCurrentLoc => Construct(0x129c49);
            public static FormLink<IAIPackageGetter> DLCBothielRepairingOrrery => Construct(0x123019);
            public static FormLink<IAIPackageGetter> DLCOrreryBothielWanderOrrery => Construct(0x12301a);
        }
    }
}
