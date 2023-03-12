// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class SoundOutputModel
    {
        private static FormLink<ISoundOutputModelGetter> Construct(uint id) => new FormLink<ISoundOutputModelGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundOutputModelGetter> DLC06SOMStereo_PA => Construct(0x563b);
    }
}
