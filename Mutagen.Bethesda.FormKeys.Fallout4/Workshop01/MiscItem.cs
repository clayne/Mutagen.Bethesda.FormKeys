// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static partial class MiscItem
    {
        private static FormLink<IMiscItemGetter> Construct(uint id) => new FormLink<IMiscItemGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMiscItemGetter> DLC02shipment_Concrete_200 => Construct(0xe80);
        public static FormLink<IMiscItemGetter> DLC02shipment_Concrete_100 => Construct(0xe7f);
    }
}
