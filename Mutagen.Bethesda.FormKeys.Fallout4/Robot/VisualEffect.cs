// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Robot
{
    public static partial class VisualEffect
    {
        private static FormLink<IVisualEffectGetter> Construct(uint id) => new FormLink<IVisualEffectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IVisualEffectGetter> DLC01CreateABotInteractVFX => Construct(0xf904);
        public static FormLink<IVisualEffectGetter> DLC01Bot_Trashbot_BrokenHeadVFX => Construct(0x9a6b);
        public static FormLink<IVisualEffectGetter> DLC01Bot_Trashbot_BrokenTorsoVFX => Construct(0x9a6a);
        public static FormLink<IVisualEffectGetter> DLC01Bot_Trashbot_BrokenArmRightVFX => Construct(0x9a69);
        public static FormLink<IVisualEffectGetter> DLC01Bot_Trashbot_BrokenArmLeftVFX => Construct(0x9a68);
        public static FormLink<IVisualEffectGetter> DLC01EyebotInteractVFX => Construct(0x1d24);
    }
}
