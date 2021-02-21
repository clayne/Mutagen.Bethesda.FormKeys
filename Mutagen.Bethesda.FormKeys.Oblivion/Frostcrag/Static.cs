using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Static
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IStaticGetter> MagesTowerLevel02 => Construct(0x84fa);
            public static FormLink<IStaticGetter> ShieldSkingrad => Construct(0x532e);
            public static FormLink<IStaticGetter> MagesTowerLevel01 => Construct(0x3ef5);
            public static FormLink<IStaticGetter> FrostCragSpireMESH01 => Construct(0x3ef1);
            public static FormLink<IStaticGetter> ShieldAnvil => Construct(0x5327);
            public static FormLink<IStaticGetter> ShieldBravil => Construct(0x5328);
            public static FormLink<IStaticGetter> ShieldBruma => Construct(0x5329);
            public static FormLink<IStaticGetter> Shieldcheydinhal => Construct(0x532a);
            public static FormLink<IStaticGetter> FrostAtron => Construct(0x6c25);
            public static FormLink<IStaticGetter> FrostCragTeleportScallop => Construct(0x7b10);
            public static FormLink<IStaticGetter> ShieldChorrol => Construct(0x532b);
            public static FormLink<IStaticGetter> ShieldKvatch => Construct(0x532c);
            public static FormLink<IStaticGetter> ShieldLeyawin => Construct(0x532d);
            public static FormLink<IStaticGetter> MasterRetortStatic => Construct(0x593f);
            public static FormLink<IStaticGetter> MasterMortarPestleStatic => Construct(0x5940);
            public static FormLink<IStaticGetter> MasterAlembicStatic => Construct(0x5941);
            public static FormLink<IStaticGetter> MasterCalcinatorStatic => Construct(0x5942);
        }
    }
}
