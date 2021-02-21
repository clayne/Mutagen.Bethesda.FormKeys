using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Ingredient
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IIngredientGetter> Construct(uint id) => new FormLink<IIngredientGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIngredientGetter> DLC2TernFeathers => Construct(0x3cd8e);
            public static FormLink<IIngredientGetter> DLC2HangingMoss => Construct(0x1ff75);
            public static FormLink<IIngredientGetter> DLC2AshCreepCluster => Construct(0x1cd74);
            public static FormLink<IIngredientGetter> DLC2NetchJelly => Construct(0x1cd72);
            public static FormLink<IIngredientGetter> DLC2AshHopperJelly => Construct(0x1cd71);
            public static FormLink<IIngredientGetter> DLC2BoarTusk => Construct(0x1cd6f);
            public static FormLink<IIngredientGetter> DLC2BurntSprigganWood => Construct(0x1cd6e);
            public static FormLink<IIngredientGetter> DLC2GhoulAsh => Construct(0x1cd6d);
            public static FormLink<IIngredientGetter> DLC2Scathecraw01 => Construct(0x17e97);
            public static FormLink<IIngredientGetter> DLC2TramaRoot01 => Construct(0x17008);
            public static FormLink<IIngredientGetter> DLC2SpikyGrassAsh01 => Construct(0x16e26);
        }
    }
}
