using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Ingestible
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IIngestibleGetter> Construct(uint id) => new FormLink<IIngestibleGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngestibleGetter> BYOHFoodGarlicBread01 => Construct(0x9dc);
            public static FormLink<IIngestibleGetter> BYOHFoodBraidedBread01 => Construct(0x9db);
            public static FormLink<IIngestibleGetter> BYOHFoodLavenderDumpling01 => Construct(0x11801);
            public static FormLink<IIngestibleGetter> BYOHFoodChickenDumpling01 => Construct(0x117ff);
            public static FormLink<IIngestibleGetter> BYOHFoodSalmonCooked02 => Construct(0x3541);
            public static FormLink<IIngestibleGetter> BYOHFoodMudcrabLegs => Construct(0x3540);
            public static FormLink<IIngestibleGetter> BYOHFoodMudcrabLegsCooked => Construct(0x353f);
            public static FormLink<IIngestibleGetter> BYOHFoodClamChowder => Construct(0x353e);
            public static FormLink<IIngestibleGetter> FoodPotatoSoup => Construct(0x353d);
            public static FormLink<IIngestibleGetter> BYOHFoodButter => Construct(0x353c);
            public static FormLink<IIngestibleGetter> BYOHFoodSnowberryCrostata => Construct(0x353b);
            public static FormLink<IIngestibleGetter> BYOHFoodJazbayCrostata => Construct(0x353a);
            public static FormLink<IIngestibleGetter> BYOHFoodJuniperBerryCrostata => Construct(0x3539);
            public static FormLink<IIngestibleGetter> BYOHFoodFlour => Construct(0x3538);
            public static FormLink<IIngestibleGetter> BYOHFoodPotatoBread01A => Construct(0x3537);
            public static FormLink<IIngestibleGetter> BYOHFoodWineBottle03 => Construct(0x3536);
            public static FormLink<IIngestibleGetter> BYOHFoodWineBottle04 => Construct(0x3535);
            public static FormLink<IIngestibleGetter> BYOHFoodMilk => Construct(0x3534);
            public static FormLink<IIngestibleGetter> BYOHFoodAppleDumpling01 => Construct(0x3533);
        }
    }
}
