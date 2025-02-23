// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS007
{
    public static partial class MagicEffect
    {
        private static FormLink<IMagicEffectGetter> Construct(uint id) => new FormLink<IMagicEffectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_CarryCapacity_Effect => Construct(0x2);
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_MedicalItemHealing_Effect => Construct(0x5);
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_AmmoWeight_Effect => Construct(0xf);
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_CombatLethality_Effect => Construct(0x10);
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_ShipDamageOutput_Effect => Construct(0x1d);
        public static FormLink<IMagicEffectGetter> PEO_abAddPerk_XP_Mult_Effect => Construct(0x37);
    }
}
