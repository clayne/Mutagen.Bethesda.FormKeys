// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class Container
    {
        private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IContainerGetter> DLC01WorkshopWorkbench => Construct(0x10222);
        public static FormLink<IContainerGetter> DLC01QAGunModChest => Construct(0x10026);
        public static FormLink<IContainerGetter> DLC01QARobotComponentsChestCOPY0000 => Construct(0x10025);
        public static FormLink<IContainerGetter> DLC01QARobotModChest => Construct(0x10024);
        public static FormLink<IContainerGetter> DLC01QAConsumableChest => Construct(0x10023);
        public static FormLink<IContainerGetter> DLC01QAHolotapeGamesChest => Construct(0x10022);
        public static FormLink<IContainerGetter> DLC01QAHolotapesChest => Construct(0x10021);
        public static FormLink<IContainerGetter> DLC01QABookChest => Construct(0x10020);
        public static FormLink<IContainerGetter> DLC01QAWeaponChest => Construct(0x1001f);
        public static FormLink<IContainerGetter> DLC01QAArmorChest => Construct(0x1001e);
        public static FormLink<IContainerGetter> DLC01HoldingChest => Construct(0xf964);
        public static FormLink<IContainerGetter> DLC01AliasLocker => Construct(0xa5f4);
        public static FormLink<IContainerGetter> DLC01MechanistVendorChest => Construct(0x8b8);
    }
}
