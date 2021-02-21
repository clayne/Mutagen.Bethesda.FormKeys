using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Ingestible
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IIngestibleGetter> Construct(uint id) => new FormLink<IIngestibleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngestibleGetter> DLC2FoodAshHopperLeg => Construct(0x3d125);
            public static FormLink<IIngestibleGetter> DLC2FoodBoarMeatCooked => Construct(0x3cf72);
            public static FormLink<IIngestibleGetter> DLC2FoodHorkerAshYamStew => Construct(0x3cd5b);
            public static FormLink<IIngestibleGetter> DLC2FoodAshHopperMeat => Construct(0x3bd15);
            public static FormLink<IIngestibleGetter> DLC2FoodBoarMeat => Construct(0x3bd14);
            public static FormLink<IIngestibleGetter> DLC2dunBloodskalPotionOfWaterWalking => Construct(0x390e0);
            public static FormLink<IIngestibleGetter> DLC2FoodAshfireMead => Construct(0x3572f);
            public static FormLink<IIngestibleGetter> DLC2RRFavor01EmberbrandWine => Construct(0x320df);
            public static FormLink<IIngestibleGetter> DLC2RRF04Sujamma => Construct(0x24e0b);
            public static FormLink<IIngestibleGetter> DLC2Matze => Construct(0x248ce);
            public static FormLink<IIngestibleGetter> DLC2Shein => Construct(0x248cc);
            public static FormLink<IIngestibleGetter> DLC2Sujamma => Construct(0x207e6);
            public static FormLink<IIngestibleGetter> DLC2Flin => Construct(0x207e5);
            public static FormLink<IIngestibleGetter> DLC2FoodAshYam => Construct(0x206e7);
            public static FormLink<IIngestibleGetter> DLC2NetchPoison => Construct(0x1cd7d);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll06 => Construct(0x1aae2);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll05 => Construct(0x1aae1);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll04 => Construct(0x1aae0);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll03 => Construct(0x1aadf);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll02 => Construct(0x1aade);
            public static FormLink<IIngestibleGetter> DLC2RestoreAll01 => Construct(0x1aadd);
        }
    }
}
