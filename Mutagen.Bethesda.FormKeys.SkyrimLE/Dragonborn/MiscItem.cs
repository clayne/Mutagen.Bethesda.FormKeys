using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class MiscItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMiscItemGetter> Construct(uint id) => new FormLink<IMiscItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscItemGetter> DLC2InvFirewood01 => Construct(0x3cf16);
            public static FormLink<IMiscItemGetter> DLC2TGGemSapphire => Construct(0x39e4e);
            public static FormLink<IMiscItemGetter> DLC2DweKagrumezControlGemInv05 => Construct(0x31672);
            public static FormLink<IMiscItemGetter> DLC2DweKagrumezControlGemInv04 => Construct(0x31671);
            public static FormLink<IMiscItemGetter> DLC2DweKagrumezControlGemInv03 => Construct(0x31670);
            public static FormLink<IMiscItemGetter> DLC2DweKagrumezControlGemInv02 => Construct(0x3166f);
            public static FormLink<IMiscItemGetter> DLC2dunHaknirTreasureMap => Construct(0x2baae);
            public static FormLink<IMiscItemGetter> DLC2OreStalhrim => Construct(0x2b06b);
            public static FormLink<IMiscItemGetter> DLC2ChitinPlate => Construct(0x2b04e);
            public static FormLink<IMiscItemGetter> DLC2dunKarstaagSkullItemNoName => Construct(0x2823b);
            public static FormLink<IMiscItemGetter> DLC2dunKarstaagSkullItem => Construct(0x247f9);
            public static FormLink<IMiscItemGetter> DLC2DweKagrumezControlGemInv01 => Construct(0x2145a);
            public static FormLink<IMiscItemGetter> DLC2dunKolbjornSkull => Construct(0x20dcf);
            public static FormLink<IMiscItemGetter> DLC2Bucket02b_NoName => Construct(0x1eff9);
            public static FormLink<IMiscItemGetter> DLC2TTR3aAshExtractor => Construct(0x1cdf4);
            public static FormLink<IMiscItemGetter> DLC2NetchLeather => Construct(0x1cd7c);
            public static FormLink<IMiscItemGetter> DLC2SV01HalfClawRight => Construct(0x1cac1);
            public static FormLink<IMiscItemGetter> DLC2SV01HalfClawLeft => Construct(0x1cac0);
            public static FormLink<IMiscItemGetter> DLC2TTR3aAshSample => Construct(0x1b65c);
            public static FormLink<IMiscItemGetter> DLC2TaprootSoaked => Construct(0x1aad6);
            public static FormLink<IMiscItemGetter> DLC2TT2HeartStone => Construct(0x195a9);
            public static FormLink<IMiscItemGetter> DLC2HeartStone => Construct(0x17749);
            public static FormLink<IMiscItemGetter> AetheriumCrest01 => Construct(0x17725);
            public static FormLink<IMiscItemGetter> DLC2ExpSpiderAlbinoButtDamaged => Construct(0x1771f);
            public static FormLink<IMiscItemGetter> DLC2ExpSpiderAlbinoButt => Construct(0x17719);
            public static FormLink<IMiscItemGetter> DLC2dunNchardakCube => Construct(0x173bb);
        }
    }
}
