using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Worldspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWorldspaceGetter> DLC01FalmerValley => Construct(0xbb5);
            public static FormLink<IWorldspaceGetter> DLC01SoulCairn => Construct(0x1408);
            public static FormLink<IWorldspaceGetter> DLC1HunterHQWorld => Construct(0x1db8);
            public static FormLink<IWorldspaceGetter> DLC1ForebearsHoldout => Construct(0x2f64);
            public static FormLink<IWorldspaceGetter> TestMeganWorld => Construct(0x42c2);
            public static FormLink<IWorldspaceGetter> DLC1AncestorsGladeWorld => Construct(0x48c7);
            public static FormLink<IWorldspaceGetter> DLC1DarkfallPassageWorld => Construct(0x4bea);
            public static FormLink<IWorldspaceGetter> DLC01Boneyard => Construct(0x528d);
            public static FormLink<IWorldspaceGetter> DLC1VampireCastleCourtyard => Construct(0x7202);
        }
    }
}
