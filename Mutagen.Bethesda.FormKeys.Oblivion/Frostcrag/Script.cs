using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Script
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IScriptGetter> Construct(uint id) => new FormLink<IScriptGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScriptGetter> FrostcragTeleportKvatchSCRIPT02 => Construct(0x8013);
            public static FormLink<IScriptGetter> TombTimTest01 => Construct(0x8c2e);
            public static FormLink<IScriptGetter> FrostcragAtronachScript => Construct(0xd29);
            public static FormLink<IScriptGetter> FrostcragSpellStationScript => Construct(0xd43);
            public static FormLink<IScriptGetter> FrostcragEnchStationScript => Construct(0xd45);
            public static FormLink<IScriptGetter> FrostcragAlchemyStationScript => Construct(0xd4e);
            public static FormLink<IScriptGetter> DLCFrostcragSpireScript => Construct(0xd54);
            public static FormLink<IScriptGetter> FrostcragSpireMemoirsScript => Construct(0xd58);
            public static FormLink<IScriptGetter> FrostcragTeleportSCRIPT => Construct(0xd17);
            public static FormLink<IScriptGetter> FrostcragAtronachAltarScript => Construct(0xd22);
            public static FormLink<IScriptGetter> FrostCragDisplayCaseSCRIPT01 => Construct(0x3f06);
            public static FormLink<IScriptGetter> FrostCragSpireTeleportTestSCRIPT01 => Construct(0x3f07);
            public static FormLink<IScriptGetter> FrostcragSpireHiddenDoorSCRIPT01 => Construct(0x3f08);
            public static FormLink<IScriptGetter> FrostcragTeleportKvatchSCRIPT => Construct(0x5d09);
            public static FormLink<IScriptGetter> FrostcragBrumaPadScript => Construct(0xc20f);
            public static FormLink<IScriptGetter> TombANScript => Construct(0xf65e);
            public static FormLink<IScriptGetter> FrostcragFireAtronachScript => Construct(0xfb48);
            public static FormLink<IScriptGetter> FrostcragStormAtronachScript => Construct(0xfb49);
            public static FormLink<IScriptGetter> FrostcragSpireMagetallowCandlesScript => Construct(0x1312e);
        }
    }
}
