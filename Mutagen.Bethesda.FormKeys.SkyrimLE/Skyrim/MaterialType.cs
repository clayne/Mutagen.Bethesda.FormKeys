using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class MaterialType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IMaterialTypeGetter> Construct(uint id) => new FormLink<IMaterialTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMaterialTypeGetter> MaterialInsect => Construct(0x10d5cc);
            public static FormLink<IMaterialTypeGetter> MaterialGhost => Construct(0x100752);
            public static FormLink<IMaterialTypeGetter> MaterialBone => Construct(0xf7b68);
            public static FormLink<IMaterialTypeGetter> MaterialSkinSkeleton => Construct(0xf7b65);
            public static FormLink<IMaterialTypeGetter> MaterialBoneActor => Construct(0xf0ea8);
            public static FormLink<IMaterialTypeGetter> MaterialIceForm => Construct(0xd9b1e);
            public static FormLink<IMaterialTypeGetter> MaterialWaterPuddle => Construct(0xd6c11);
            public static FormLink<IMaterialTypeGetter> MaterialGlassStairs => Construct(0xc6fb1);
            public static FormLink<IMaterialTypeGetter> MaterialStoneAsStairs => Construct(0x1686b);
            public static FormLink<IMaterialTypeGetter> MaterialWoodAsStairs => Construct(0x1686a);
            public static FormLink<IMaterialTypeGetter> MaterialMetalLight => Construct(0x624b4);
            public static FormLink<IMaterialTypeGetter> MaterialBlade1HandSmall => Construct(0x624ae);
            public static FormLink<IMaterialTypeGetter> MaterialBook => Construct(0x5cf14);
            public static FormLink<IMaterialTypeGetter> MaterialAlduin => Construct(0xe7714);
            public static FormLink<IMaterialTypeGetter> MaterialBlunt2Hand => Construct(0xe7530);
            public static FormLink<IMaterialTypeGetter> MaterialBlade2Hand => Construct(0xe7527);
            public static FormLink<IMaterialTypeGetter> MaterialBlockBlunt2Hand => Construct(0xe64a9);
            public static FormLink<IMaterialTypeGetter> MaterialMeat => Construct(0xe64a6);
            public static FormLink<IMaterialTypeGetter> MaterialOrganicLarge => Construct(0xd309f);
            public static FormLink<IMaterialTypeGetter> MaterialCarpet => Construct(0xc8244);
            public static FormLink<IMaterialTypeGetter> MaterialSkinLarge => Construct(0xc1ad7);
            public static FormLink<IMaterialTypeGetter> MaterialBlockBlade2Hand => Construct(0x97786);
            public static FormLink<IMaterialTypeGetter> MaterialCarriageWheel => Construct(0x84782);
            public static FormLink<IMaterialTypeGetter> MaterialBoulderSmall => Construct(0xaf63d);
            public static FormLink<IMaterialTypeGetter> MaterialSkinMetalSmall => Construct(0x9644c);
            public static FormLink<IMaterialTypeGetter> MaterialSkinMetalLarge => Construct(0x9150b);
            public static FormLink<IMaterialTypeGetter> MaterialSkinSmall => Construct(0x5a28f);
            public static FormLink<IMaterialTypeGetter> MaterialBoulderMedium => Construct(0x876b8);
            public static FormLink<IMaterialTypeGetter> MaterialBoulderLarge => Construct(0x876b5);
            public static FormLink<IMaterialTypeGetter> MaterialBlockBlade1Hand => Construct(0x774c2);
            public static FormLink<IMaterialTypeGetter> MaterialBlockBlunt => Construct(0x774c1);
            public static FormLink<IMaterialTypeGetter> MaterialBlockAxe => Construct(0x774c0);
            public static FormLink<IMaterialTypeGetter> MaterialBlockBowsStaves => Construct(0x774b6);
            public static FormLink<IMaterialTypeGetter> MaterialBlunt1Hand => Construct(0x77251);
            public static FormLink<IMaterialTypeGetter> MaterialStairsBrokenStone => Construct(0x70343);
            public static FormLink<IMaterialTypeGetter> MaterialDragon => Construct(0x5add4);
            public static FormLink<IMaterialTypeGetter> MaterialCoin => Construct(0x21340);
            public static FormLink<IMaterialTypeGetter> MaterialStairsSnow => Construct(0x52ed0);
            public static FormLink<IMaterialTypeGetter> MaterialWeb => Construct(0x52798);
            public static FormLink<IMaterialTypeGetter> MaterialBottleSmall => Construct(0x5178c);
            public static FormLink<IMaterialTypeGetter> MaterialBowsStaves => Construct(0x50dbe);
            public static FormLink<IMaterialTypeGetter> MaterialPotsPans => Construct(0x50afa);
            public static FormLink<IMaterialTypeGetter> MaterialArrow => Construct(0x4d2b3);
            public static FormLink<IMaterialTypeGetter> MaterialCeramicMedium => Construct(0x2fd39);
            public static FormLink<IMaterialTypeGetter> MaterialAxe1Hand => Construct(0x1a353);
            public static FormLink<IMaterialTypeGetter> MaterialWoodMedium => Construct(0x43dcc);
            public static FormLink<IMaterialTypeGetter> MaterialArmorLight => Construct(0x388fc);
            public static FormLink<IMaterialTypeGetter> MaterialArmorHeavy => Construct(0x388fb);
            public static FormLink<IMaterialTypeGetter> MaterialBasket => Construct(0x363b0);
            public static FormLink<IMaterialTypeGetter> MaterialStairsWood => Construct(0x2ee2d);
            public static FormLink<IMaterialTypeGetter> MaterialStairsStone => Construct(0x2ee2c);
            public static FormLink<IMaterialTypeGetter> MaterialWard => Construct(0x1eff7);
            public static FormLink<IMaterialTypeGetter> MaterialChain => Construct(0x28e99);
            public static FormLink<IMaterialTypeGetter> MaterialGravel => Construct(0x1c151);
            public static FormLink<IMaterialTypeGetter> MaterialBlade1Hand => Construct(0x18401);
            public static FormLink<IMaterialTypeGetter> MaterialShieldHeavy => Construct(0x16979);
            public static FormLink<IMaterialTypeGetter> MaterialShieldLight => Construct(0x16978);
            public static FormLink<IMaterialTypeGetter> MaterialMud => Construct(0x12f48);
            public static FormLink<IMaterialTypeGetter> MaterialIce => Construct(0x12f47);
            public static FormLink<IMaterialTypeGetter> MaterialGrass => Construct(0x12f46);
            public static FormLink<IMaterialTypeGetter> MaterialSnow => Construct(0x12f45);
            public static FormLink<IMaterialTypeGetter> MaterialBottle => Construct(0x12f44);
            public static FormLink<IMaterialTypeGetter> MaterialBarrel => Construct(0x12f43);
            public static FormLink<IMaterialTypeGetter> MaterialWoodHeavy => Construct(0x12f42);
            public static FormLink<IMaterialTypeGetter> MaterialWoodLight => Construct(0x12f41);
            public static FormLink<IMaterialTypeGetter> MaterialWater => Construct(0x12f40);
            public static FormLink<IMaterialTypeGetter> MaterialSkin => Construct(0x12f3f);
            public static FormLink<IMaterialTypeGetter> MaterialSand => Construct(0x12f3e);
            public static FormLink<IMaterialTypeGetter> MaterialOrganic => Construct(0x12f3d);
            public static FormLink<IMaterialTypeGetter> MaterialSolidMetal => Construct(0x12f3c);
            public static FormLink<IMaterialTypeGetter> MaterialHeavyMetal => Construct(0x12f3b);
            public static FormLink<IMaterialTypeGetter> MaterialChainMetal => Construct(0x12f3a);
            public static FormLink<IMaterialTypeGetter> MaterialGlass => Construct(0x12f39);
            public static FormLink<IMaterialTypeGetter> MaterialDirt => Construct(0x12f38);
            public static FormLink<IMaterialTypeGetter> MaterialCloth => Construct(0x12f37);
            public static FormLink<IMaterialTypeGetter> MaterialHeavyStone => Construct(0x12f36);
            public static FormLink<IMaterialTypeGetter> MaterialBrokenStone => Construct(0x12f35);
            public static FormLink<IMaterialTypeGetter> MaterialStone => Construct(0x12f34);
        }
    }
}
