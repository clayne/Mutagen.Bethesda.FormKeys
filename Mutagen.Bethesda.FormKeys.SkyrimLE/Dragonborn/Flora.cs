using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> DLC2HorkerDead01 => Construct(0x38a83);
            public static FormLink<IFloraGetter> DLC2HorkerMeat01 => Construct(0x38a7a);
            public static FormLink<IFloraGetter> DLC2PearlOysterThin01 => Construct(0x3828d);
            public static FormLink<IFloraGetter> DLC2PearlOysterLarge01 => Construct(0x3828c);
            public static FormLink<IFloraGetter> DLC2FloraCreepClusterAshRock => Construct(0x195dd);
            public static FormLink<IFloraGetter> DLC2FloraCreepClusterAsh => Construct(0x195dc);
            public static FormLink<IFloraGetter> DLC2FloraTramaRoot03 => Construct(0x18b19);
            public static FormLink<IFloraGetter> DLC2FloraTramaRoot02 => Construct(0x184ef);
            public static FormLink<IFloraGetter> DLC2FloraTramaRoot01 => Construct(0x17005);
        }
    }
}
