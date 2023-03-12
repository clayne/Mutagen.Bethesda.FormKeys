// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class ActionRecord
    {
        private static FormLink<IActionRecordGetter> Construct(uint id) => new FormLink<IActionRecordGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActionRecordGetter> ActionToggleFurnitureCamera => Construct(0x1dc5);
    }
}
