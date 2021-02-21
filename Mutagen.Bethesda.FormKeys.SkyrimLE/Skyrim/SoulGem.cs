using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class SoulGem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ISoulGemGetter> Construct(uint id) => new FormLink<ISoulGemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoulGemGetter> FFRiften14SoulGem => Construct(0x43e26);
            public static FormLink<ISoulGemGetter> WhiterunSoulGem => Construct(0x94e40);
            public static FormLink<ISoulGemGetter> DummySoulGem => Construct(0x6a0c2);
            public static FormLink<ISoulGemGetter> DA01SoulGemBlackStar => Construct(0x63b29);
            public static FormLink<ISoulGemGetter> DA01SoulGemAzurasStar => Construct(0x63b27);
            public static FormLink<ISoulGemGetter> SoulGemBlackFilled => Construct(0x2e504);
            public static FormLink<ISoulGemGetter> SoulGemBlack => Construct(0x2e500);
            public static FormLink<ISoulGemGetter> SoulGemGrandFilled => Construct(0x2e4ff);
            public static FormLink<ISoulGemGetter> SoulGemGrand => Construct(0x2e4fc);
            public static FormLink<ISoulGemGetter> SoulGemGreaterFilled => Construct(0x2e4fb);
            public static FormLink<ISoulGemGetter> SoulGemGreater => Construct(0x2e4f4);
            public static FormLink<ISoulGemGetter> SoulGemCommonFilled => Construct(0x2e4f3);
            public static FormLink<ISoulGemGetter> SoulGemCommon => Construct(0x2e4e6);
            public static FormLink<ISoulGemGetter> SoulGemLesserFilled => Construct(0x2e4e5);
            public static FormLink<ISoulGemGetter> SoulGemLesser => Construct(0x2e4e4);
            public static FormLink<ISoulGemGetter> SoulGemPettyFilled => Construct(0x2e4e3);
            public static FormLink<ISoulGemGetter> SoulGemPetty => Construct(0x2e4e2);
        }
    }
}
