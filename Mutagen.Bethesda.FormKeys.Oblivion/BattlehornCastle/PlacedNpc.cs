using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> DLCBhornKnightRef => Construct(0xca2c);
            public static FormLink<IPlacedNpcGetter> DLCBattlehornKnight2REF => Construct(0xca3f);
            public static FormLink<IPlacedNpcGetter> NilphasOmellianRef => Construct(0xb094);
            public static FormLink<IPlacedNpcGetter> ShagrolgroUzugREF => Construct(0xc008);
            public static FormLink<IPlacedNpcGetter> TalanRef => Construct(0xb0b0);
            public static FormLink<IPlacedNpcGetter> NielsREF => Construct(0xc517);
            public static FormLink<IPlacedNpcGetter> MelisiDarenRef => Construct(0xb0b3);
            public static FormLink<IPlacedNpcGetter> DLCBattlehornLordKelvynREF => Construct(0x1341b);
            public static FormLink<IPlacedNpcGetter> DLCBattlehornMarauderMissileREF => Construct(0x13425);
            public static FormLink<IPlacedNpcGetter> DLCBattlehornMarauderMeleeREF => Construct(0x13424);
            public static FormLink<IPlacedNpcGetter> DLCBattlehornMarauderBossREF => Construct(0x13423);
        }
    }
}
