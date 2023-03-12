// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class Flora
    {
        private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFloraGetter> FloraFeverBlossom02 => Construct(0x1cd25);
        public static FormLink<IFloraGetter> FloraFeverBlossom01 => Construct(0x1cd23);
    }
}
