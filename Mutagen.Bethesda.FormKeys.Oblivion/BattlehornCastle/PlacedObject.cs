using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor01DustFallREF => Construct(0x605a);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor01DustREF => Construct(0x6057);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsMenAtArms => Construct(0x555f);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyWolfREF => Construct(0x5556);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyMountainLionREF => Construct(0x5555);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretBlack01 => Construct(0x38ba);
            public static FormLink<IPlacedObjectGetter> DragonfireEastWingDoor02 => Construct(0x11a0);
            public static FormLink<IPlacedObjectGetter> DragonfireMenatArmsDoor02 => Construct(0x11a9);
            public static FormLink<IPlacedObjectGetter> DragonfireDiningDoor01 => Construct(0x11a6);
            public static FormLink<IPlacedObjectGetter> DragonfireSecret01 => Construct(0x1e1d);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor01REF => Construct(0x33d0);
            public static FormLink<IPlacedObjectGetter> BattlehornDiningDoor04 => Construct(0x11a5);
            public static FormLink<IPlacedObjectGetter> BattlehornMasterBedroomDoor01 => Construct(0x3307);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsLCMenAtArms => Construct(0x5a59);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyClannfearREF => Construct(0x489c);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyOgreREF => Construct(0x489d);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyMinotaurREF => Construct(0x489b);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyTrollREF => Construct(0x489e);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyBearREF => Construct(0x4d97);
            public static FormLink<IPlacedObjectGetter> BattlehornTrophyDaedrothREF => Construct(0x4899);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornInteriorGuardStart1 => Construct(0xcf2e);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornInteriorGuardStart2 => Construct(0xcf2f);
            public static FormLink<IPlacedObjectGetter> BHCNirnrootRef => Construct(0x11f3f);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoorLever01REF => Construct(0x33d1);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornMerchantChest => Construct(0x19b9a);
            public static FormLink<IPlacedObjectGetter> BattlehornAddonsRef => Construct(0xb095);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor02DustFall => Construct(0x605b);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor02Dust => Construct(0x6059);
            public static FormLink<IPlacedObjectGetter> BattlehornMasterBedroomDoor02 => Construct(0x4fdb);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsUCMasterBedroom => Construct(0x4e55);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor02 => Construct(0x4fd3);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretBlack02REF => Construct(0x4fd2);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsLibrary => Construct(0x5adb);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornChestSpecialRef => Construct(0x11f2f);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoorLever02REF => Construct(0x4e57);
            public static FormLink<IPlacedObjectGetter> BattlehornCookBed => Construct(0x3a10);
            public static FormLink<IPlacedObjectGetter> BattlehornMaidBed => Construct(0x3c4e);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelCheapREF => Construct(0x3a93);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelMeadREF => Construct(0x3a92);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelGREF => Construct(0xb5fe);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelFREF => Construct(0xb602);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelEREF => Construct(0xb601);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelDREF => Construct(0xb603);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelCREF => Construct(0xb600);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelBREF => Construct(0xb5ff);
            public static FormLink<IPlacedObjectGetter> BattlehornWineBarrelAREF => Construct(0xb5fc);
            public static FormLink<IPlacedObjectGetter> BattlehornNarrowSecretDoor01DustREF => Construct(0x6399);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretBlack01REF => Construct(0x6395);
            public static FormLink<IPlacedObjectGetter> BattlehornNarrowSecretDoor01REF => Construct(0x638f);
            public static FormLink<IPlacedObjectGetter> BattlhornForgottenDoor01REF => Construct(0x638c);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsLCKitchen => Construct(0x5563);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsKitchen => Construct(0x5560);
            public static FormLink<IPlacedObjectGetter> DragonfireMenatArmsDoor01 => Construct(0x1332);
            public static FormLink<IPlacedObjectGetter> DragonfireKitchenDoor02 => Construct(0x1340);
            public static FormLink<IPlacedObjectGetter> DragonfireSecret02 => Construct(0x1e26);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsVintner => Construct(0x5a79);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsTrainingRoom => Construct(0x5a97);
            public static FormLink<IPlacedObjectGetter> BattlehornTrainerBed => Construct(0x3a12);
            public static FormLink<IPlacedObjectGetter> BattlehornVintnerBed => Construct(0x3a17);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretBlack03REF => Construct(0x639d);
            public static FormLink<IPlacedObjectGetter> BattlhornForgottenDoor02REF => Construct(0x628f);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor03Dust => Construct(0x627d);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor03DustFall => Construct(0x627c);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretDoor03REF => Construct(0x6277);
            public static FormLink<IPlacedObjectGetter> BattlehornSecretLever03REF => Construct(0x6278);
            public static FormLink<IPlacedObjectGetter> DragonfireEastWingDoor01 => Construct(0x1264);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsTaxidermist => Construct(0x54c2);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsDiningArea => Construct(0x54c3);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsLCDingingArea => Construct(0x54fb);
            public static FormLink<IPlacedObjectGetter> DragonfireDiningDoor02 => Construct(0x126a);
            public static FormLink<IPlacedObjectGetter> DragonfireDiningDoor03 => Construct(0x1268);
            public static FormLink<IPlacedObjectGetter> DragonfireKitchenDoor01 => Construct(0x125e);
            public static FormLink<IPlacedObjectGetter> BattlehornDiningHallMarker => Construct(0xc51b);
            public static FormLink<IPlacedObjectGetter> BattlehornExteriorPatrolMarker4 => Construct(0xca34);
            public static FormLink<IPlacedObjectGetter> BattlehornExteriorPatrolMarker3 => Construct(0xca33);
            public static FormLink<IPlacedObjectGetter> BattlehornExteriorPatrolMarker2 => Construct(0xca32);
            public static FormLink<IPlacedObjectGetter> BattlehornExteriorPatrolMarker1 => Construct(0xca30);
            public static FormLink<IPlacedObjectGetter> BattlehornCastleMapMarker => Construct(0xb08b);
            public static FormLink<IPlacedObjectGetter> BattlehornFurnishingsForge => Construct(0xa6a0);
            public static FormLink<IPlacedObjectGetter> BattlehornCastleGateREF => Construct(0x10b35);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornGatehouseDoorN => Construct(0x133c5);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornGatehouseDoorS => Construct(0x133c7);
            public static FormLink<IPlacedObjectGetter> DLCBattlehornGatehouseTrapdoor => Construct(0x133c9);
        }
    }
}
