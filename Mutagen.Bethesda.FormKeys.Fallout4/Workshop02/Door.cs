// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop02
{
    public static partial class Door
    {
        private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDoorGetter> Dlc05GrnhsDoorSm02 => Construct(0xd6e);
        public static FormLink<IDoorGetter> Dlc05GrnhsDoorSm01 => Construct(0xd6d);
        public static FormLink<IDoorGetter> DLC05_Boxcar_Door02 => Construct(0x9ff);
        public static FormLink<IDoorGetter> DLC05_Boxcar_Door01 => Construct(0x94a);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorMed01alt => Construct(0x87e);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorMed01 => Construct(0x87d);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorSm02 => Construct(0x87c);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorSm01 => Construct(0x87b);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorMed02alt => Construct(0x87a);
        public static FormLink<IDoorGetter> Dlc05WrhsDoorMed02 => Construct(0x879);
    }
}
