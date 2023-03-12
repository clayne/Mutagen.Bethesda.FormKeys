// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static partial class PlacedObject
    {
        private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IPlacedObjectGetter> DLC02CageSpawnMarker => Construct(0xbe5);
        public static FormLink<IPlacedObjectGetter> CtestBedRef001 => Construct(0xc14);
    }
}
