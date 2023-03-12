// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class Ingestible
    {
        private static FormLink<IIngestibleGetter> Construct(uint id) => new FormLink<IIngestibleGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIngestibleGetter> DLC01RepairKit => Construct(0x4f12);
        public static FormLink<IIngestibleGetter> BrainGround04 => Construct(0x19dc);
    }
}
