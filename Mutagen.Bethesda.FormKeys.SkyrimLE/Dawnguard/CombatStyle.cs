using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class CombatStyle
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<ICombatStyleGetter> Construct(uint id) => new FormLink<ICombatStyleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICombatStyleGetter> DLC1csSoulCairnReaper => Construct(0x14cb8);
            public static FormLink<ICombatStyleGetter> DLC1csGargoyleSentinel => Construct(0x14553);
            public static FormLink<ICombatStyleGetter> DLC1csVyrthur => Construct(0x126b2);
            public static FormLink<ICombatStyleGetter> DLC1csSerana => Construct(0x11f34);
            public static FormLink<ICombatStyleGetter> DLC1_BF_csFalmerUnarmed => Construct(0x11e10);
            public static FormLink<ICombatStyleGetter> DLC1csCelann => Construct(0x10d8c);
            public static FormLink<ICombatStyleGetter> DLC1csFalmerMelee1H => Construct(0xeca6);
            public static FormLink<ICombatStyleGetter> DLC1dunHarkonBattleMeleeCS => Construct(0xd659);
            public static FormLink<ICombatStyleGetter> DLC1dunHarkonBattleMagicCS => Construct(0xd658);
            public static FormLink<ICombatStyleGetter> DLC1csDexion => Construct(0x45af);
            public static FormLink<ICombatStyleGetter> DLC1HarkonMagic => Construct(0x1a345);
            public static FormLink<ICombatStyleGetter> DLC1csGargoyle => Construct(0x166d5);
            public static FormLink<ICombatStyleGetter> csDragonDLC1Durnehviir => Construct(0xbfec);
            public static FormLink<ICombatStyleGetter> DLC1csChaurusHunterRanged => Construct(0x9d38);
            public static FormLink<ICombatStyleGetter> DLC1csChaurusHunter => Construct(0x5aa2);
            public static FormLink<ICombatStyleGetter> DLC1LD_csKatria => Construct(0x4d4d);
            public static FormLink<ICombatStyleGetter> csFalmerStaff => Construct(0x3628);
        }
    }
}
