using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> FrostcragSpireTelepadTower => Construct(0xae35);
            public static FormLink<IDoorGetter> FrostcragSpireTelepadBruma => Construct(0xbd27);
            public static FormLink<IDoorGetter> FrostCragDisplayCase01 => Construct(0x3f05);
            public static FormLink<IDoorGetter> TeleportTest01DOOR => Construct(0x43ef);
            public static FormLink<IDoorGetter> FrostCragSpireDoor01 => Construct(0x3ef2);
            public static FormLink<IDoorGetter> FrostcragSpireTelepad => Construct(0xcff);
            public static FormLink<IDoorGetter> FrostcragSpireTelepadKVATCH01 => Construct(0x8012);
        }
    }
}
