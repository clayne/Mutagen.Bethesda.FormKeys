// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS004
{
    public static partial class Cell
    {
        private static FormLink<ICellGetter> Construct(uint id) => new FormLink<ICellGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ICellGetter> PackInShipPISMODVehicleNovaREV8TopStorageCell => Construct(0x41);
    }
}
