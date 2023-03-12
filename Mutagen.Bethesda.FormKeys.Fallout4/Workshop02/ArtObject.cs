// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class ArtObject
    {
        private static FormLink<IArtObjectGetter> Construct(uint id) => new FormLink<IArtObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehousePrefabIcon => Construct(0xe2d);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehouseRoofIcon => Construct(0xe2a);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehouseMiscIcon => Construct(0xe29);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehouseFloorIcon => Construct(0xe28);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehouseWallIcon => Construct(0xe27);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingBallTrackIcon => Construct(0xc3b);
        public static FormLink<IArtObjectGetter> DLC05WorkshopManufacturingIcon => Construct(0xbf2);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingBoxcarIconOrange => Construct(0xbeb);
        public static FormLink<IArtObjectGetter> DLC05WorkshopMarqueeIcon => Construct(0xbd0);
        public static FormLink<IArtObjectGetter> DLC05WorkshopArmorRackFemaleIcon => Construct(0xa2e);
        public static FormLink<IArtObjectGetter> DLC05WorkshopArmorRackMaleIcon => Construct(0xa2d);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingBoxcarIcon => Construct(0xa1a);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingScaffoldingIcon => Construct(0xa19);
        public static FormLink<IArtObjectGetter> DLC05WorkshopBuildingWarehouseIcon => Construct(0x8cc);
    }
}
