// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Update
{
    public static partial class ImpactDataSet
    {
        private static FormLink<IImpactDataSetGetter> Construct(uint id) => new FormLink<IImpactDataSetGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleTailImpactSet => Construct(0x2f88);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleRearUpImpactSet => Construct(0x2f87);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdlePawImpactSet => Construct(0x2f86);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleHeadShakeImpactSet => Construct(0x2f85);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleHead03ImpactSet => Construct(0x2f84);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleHead01BImpactSet => Construct(0x2f83);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleHead01AImpactSet => Construct(0x2f82);
        public static FormLink<IImpactDataSetGetter> NPCHorseIdleGrazeImpactSet => Construct(0x2f81);
        public static FormLink<IImpactDataSetGetter> NPCHorseAttack2ImpactSet => Construct(0x2f80);
        public static FormLink<IImpactDataSetGetter> NPCHorseAttackImpactSet => Construct(0x2f7f);
        public static FormLink<IImpactDataSetGetter> NPCWolfAggroWarningImpactSet => Construct(0x2f50);
        public static FormLink<IImpactDataSetGetter> NPCWolfHowlDistantImpactSet => Construct(0x2f4d);
        public static FormLink<IImpactDataSetGetter> NPCWolfHowlImpactSet => Construct(0x2f4a);
        public static FormLink<IImpactDataSetGetter> NPCWolfAttackPowerShortImpactSet => Construct(0x2f44);
        public static FormLink<IImpactDataSetGetter> NPCWolfAttackPowerImpactSet => Construct(0x2f43);
        public static FormLink<IImpactDataSetGetter> NPCWolfAttackBImpactSet => Construct(0x2f42);
        public static FormLink<IImpactDataSetGetter> NPCWolfAttackAImpactSet => Construct(0x2f41);
    }
}
