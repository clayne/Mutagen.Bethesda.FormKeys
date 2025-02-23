// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class TimeOfDayRecord
    {
        private static FormLink<ITimeOfDayRecordGetter> Construct(uint id) => new FormLink<ITimeOfDayRecordGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ITimeOfDayRecordGetter> DefaultExternalEmittance_Cydonia01_Invert => Construct(0x3e8c);
        public static FormLink<ITimeOfDayRecordGetter> DefaultExternalEmittance_Plain01 => Construct(0xac1a);
        public static FormLink<ITimeOfDayRecordGetter> CydoniaIntWinOnly_XtraBright_ExternalEmittance_01 => Construct(0x15414);
        public static FormLink<ITimeOfDayRecordGetter> Inverted_LightBlue01 => Construct(0x3c5f3);
        public static FormLink<ITimeOfDayRecordGetter> DefaultExternalEmittance_Plain01_Invert => Construct(0x3c5fc);
        public static FormLink<ITimeOfDayRecordGetter> Equinox_Inverted_Emit01 => Construct(0x4fb0a);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_O_ExternalEmittance_01 => Construct(0x149fdd);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_A_ExternalEmittance_01 => Construct(0x14a55c);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_B_ExternalEmittance_01 => Construct(0x14b750);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_F_ExternalEmittance_01 => Construct(0x14b760);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_G_ExternalEmittance_01 => Construct(0x14b761);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_K_ExternalEmittance_01 => Construct(0x14b76d);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_M_ExternalEmittance_01 => Construct(0x14b76e);
        public static FormLink<ITimeOfDayRecordGetter> Star_Class_WD_ExternalEmittance_01 => Construct(0x14b76f);
    }
}
