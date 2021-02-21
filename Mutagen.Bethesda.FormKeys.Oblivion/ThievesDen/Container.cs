using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> DLC06SupplierChest => Construct(0x74cd);
            public static FormLink<IContainerGetter> DLC06FletcherChest => Construct(0x79c4);
            public static FormLink<IContainerGetter> DLC06SecurityChest => Construct(0x79c6);
            public static FormLink<IContainerGetter> DLC06FenceChest => Construct(0x74cf);
            public static FormLink<IContainerGetter> DLC06ChestCaptainsQuarters => Construct(0xce30);
            public static FormLink<IContainerGetter> DLC06TrainerChest => Construct(0x348d);
            public static FormLink<IContainerGetter> DLC06StealthChest => Construct(0x8d8c);
            public static FormLink<IContainerGetter> DLC06FirstMateChest => Construct(0x8d8e);
            public static FormLink<IContainerGetter> DLCChestOfDrawers => Construct(0x1a4ef);
            public static FormLink<IContainerGetter> DLCCupboardFoodUpperDrinks => Construct(0x1a4f0);
        }
    }
}
