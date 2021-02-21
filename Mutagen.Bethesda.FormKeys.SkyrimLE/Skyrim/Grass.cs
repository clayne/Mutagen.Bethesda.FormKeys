using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Grass
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IGrassGetter> Construct(uint id) => new FormLink<IGrassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGrassGetter> FieldGrass02 => Construct(0x1098ca);
            public static FormLink<IGrassGetter> RockGrassSnow01 => Construct(0xf871e);
            public static FormLink<IGrassGetter> RockGrassWater01 => Construct(0xf871d);
            public static FormLink<IGrassGetter> ForestGrass02 => Construct(0xf69a4);
            public static FormLink<IGrassGetter> SnowGrass02 => Construct(0xf17fe);
            public static FormLink<IGrassGetter> SnowGrass01Light => Construct(0xf17fd);
            public static FormLink<IGrassGetter> SnowGrass01Forest => Construct(0xbc025);
            public static FormLink<IGrassGetter> WaterCoralGrass01 => Construct(0x7aacc);
            public static FormLink<IGrassGetter> WaterKelpGrass02 => Construct(0x78f6e);
            public static FormLink<IGrassGetter> WaterKelpGrass01 => Construct(0x78f6d);
            public static FormLink<IGrassGetter> BeachGrass02 => Construct(0x74a8c);
            public static FormLink<IGrassGetter> BeachGrass01 => Construct(0x74a8b);
            public static FormLink<IGrassGetter> FrozenMarshGrass01 => Construct(0x4013c);
            public static FormLink<IGrassGetter> VolcanicGrass02 => Construct(0x71cf5);
            public static FormLink<IGrassGetter> VolcanicGrass01 => Construct(0x713d8);
            public static FormLink<IGrassGetter> FallForestGrass02 => Construct(0x5b5a8);
            public static FormLink<IGrassGetter> FallForestGrass01 => Construct(0x597d1);
            public static FormLink<IGrassGetter> ReachGrass02 => Construct(0x53903);
            public static FormLink<IGrassGetter> ReachGrass01 => Construct(0x53491);
            public static FormLink<IGrassGetter> RockGrass01 => Construct(0x48749);
            public static FormLink<IGrassGetter> TundraGrass04 => Construct(0x336fa);
            public static FormLink<IGrassGetter> TundraGrass03 => Construct(0x2acd3);
            public static FormLink<IGrassGetter> TundraGrass01 => Construct(0x2f3fa);
            public static FormLink<IGrassGetter> SnowGrass01 => Construct(0x1cc70);
            public static FormLink<IGrassGetter> FernGrass01 => Construct(0x173f4);
            public static FormLink<IGrassGetter> ForestGrass01 => Construct(0x14041);
            public static FormLink<IGrassGetter> FieldGrass01 => Construct(0x135be);
        }
    }
}
