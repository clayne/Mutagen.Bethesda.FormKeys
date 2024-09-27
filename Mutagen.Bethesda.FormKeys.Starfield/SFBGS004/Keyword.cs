// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS004
{
    public static partial class Keyword
    {
        private static FormLink<IKeywordGetter> Construct(uint id) => new FormLink<IKeywordGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IKeywordGetter> VehicleKeyword => Construct(0x17);
        public static FormLink<IKeywordGetter> VehicleDriverSeat => Construct(0x19);
        public static FormLink<IKeywordGetter> VehicleVascoSeat => Construct(0x1c);
        public static FormLink<IKeywordGetter> VehicleCompanionSeat => Construct(0x1d);
        public static FormLink<IKeywordGetter> AnimFurn_SFBGS004_Rover => Construct(0x20);
        public static FormLink<IKeywordGetter> SpaceshipPartLinkedVehicle => Construct(0x39);
        public static FormLink<IKeywordGetter> VehicleShipLinkedRef => Construct(0x3b);
        public static FormLink<IKeywordGetter> Category_ShipMod_Vehicle => Construct(0x49);
        public static FormLink<IKeywordGetter> SFBGS004_VehicleIsOpenKeyword => Construct(0x224);
        public static FormLink<IKeywordGetter> s_40_Rover_MountedLaser_SFBGS004 => Construct(0x292);
        public static FormLink<IKeywordGetter> VehicleModelNodeName => Construct(0x2a5);
        public static FormLink<IKeywordGetter> UI_Icon_Rev8 => Construct(0x312);
        public static FormLink<IKeywordGetter> VendorSM_Vehicle => Construct(0x345);
    }
}
