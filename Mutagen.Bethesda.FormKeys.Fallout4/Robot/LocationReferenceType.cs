// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class LocationReferenceType
    {
        private static FormLink<ILocationReferenceTypeGetter> Construct(uint id) => new FormLink<ILocationReferenceTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_DungeonWorkbenchRefType => Construct(0x10c9a);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_AssaultronMed01 => Construct(0x1043f);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_SpotlightRefType => Construct(0x10383);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Caravan_MechanistBotRefType => Construct(0xfff9);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_DungeonConsolePanelRefType => Construct(0xcb30);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_RobobrainInChairRefType => Construct(0xcb29);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_DungeonTrackRefType => Construct(0xca9e);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_Pod => Construct(0xb9f6);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_DungeonRobotRefType => Construct(0xae20);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_CellKlaxon => Construct(0xae1d);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_CellDoor => Construct(0xae0e);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_MBattle_P1_Protectrons_Group2 => Construct(0x2487);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_MBattle_P1_Protectrons_Group1 => Construct(0x2486);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_MBattle_P1_Twins => Construct(0x247c);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_MBattle_P1_Protectrons => Construct(0x247b);
        public static FormLink<ILocationReferenceTypeGetter> DLC01Lair_MechanistHoldPositionRef => Construct(0x1f13);
    }
}
