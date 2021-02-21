using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class LeveledItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<ILeveledItemGetter> Construct(uint id) => new FormLink<ILeveledItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILeveledItemGetter> ccFFBSSE002_LItemCrossbows => Construct(0x3055);
            public static FormLink<ILeveledItemGetter> cc_ShiveringIsleIngredients => Construct(0x2fda);
            public static FormLink<ILeveledItemGetter> LLI_Vendor_SpecialItems => Construct(0x2f94);
        }
    }
}
