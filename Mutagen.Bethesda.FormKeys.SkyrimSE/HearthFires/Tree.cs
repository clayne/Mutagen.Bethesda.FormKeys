using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Tree
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITreeGetter> BYOHHouseIngrdWheat01 => Construct(0x110cd);
            public static FormLink<ITreeGetter> BYOHHouseIngrdThistle01 => Construct(0x110cc);
            public static FormLink<ITreeGetter> BYOHHouseIngrdSpikyGrass01 => Construct(0x110cb);
            public static FormLink<ITreeGetter> BYOHHouseIngrdSnowberry01 => Construct(0x110ca);
            public static FormLink<ITreeGetter> BYOHHouseIngrdScalyPBits01 => Construct(0x110c9);
            public static FormLink<ITreeGetter> BYOHHouseIngrdNirnroot01 => Construct(0x110c8);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom06 => Construct(0x110c7);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom05 => Construct(0x110c6);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom04 => Construct(0x110c5);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom03 => Construct(0x110c4);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom02 => Construct(0x110c3);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMushroom01 => Construct(0x110c2);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMtFlRed01 => Construct(0x110c1);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMtFlPurple01 => Construct(0x110c0);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMtFlBlue01 => Construct(0x110bf);
            public static FormLink<ITreeGetter> BYOHHouseIngrdMoraTap01 => Construct(0x110be);
            public static FormLink<ITreeGetter> BYOHHouseIngrdFungalPod01 => Construct(0x110bd);
            public static FormLink<ITreeGetter> BYOHHouseIngrdCreepCluster01 => Construct(0x110bc);
            public static FormLink<ITreeGetter> BYOHHouseIngrdCotton01 => Construct(0x110bb);
            public static FormLink<ITreeGetter> BYOHHouseFloraPotato01 => Construct(0x110ba);
            public static FormLink<ITreeGetter> BYOHHouseFloraCarrots01 => Construct(0x110b9);
            public static FormLink<ITreeGetter> BYOHHouseIngrdNightshade01 => Construct(0x10469);
            public static FormLink<ITreeGetter> BYOHHouseIngrdLavender01 => Construct(0x10468);
            public static FormLink<ITreeGetter> BYOHHouseIngrdJuniper01 => Construct(0x10467);
            public static FormLink<ITreeGetter> BYOHHouseIngrdJazbay01 => Construct(0x10466);
            public static FormLink<ITreeGetter> BYOHHouseIngrdGlowMushrm01 => Construct(0x10465);
            public static FormLink<ITreeGetter> BYOHHouseIngrdGiantLichen01 => Construct(0x10464);
            public static FormLink<ITreeGetter> BYOHHouseIngrdDragonTongue01 => Construct(0x10463);
            public static FormLink<ITreeGetter> BYOHHouseIngrdDeathbell01 => Construct(0x10462);
            public static FormLink<ITreeGetter> BYOHHouseIngrdCanisRoot01 => Construct(0x10461);
            public static FormLink<ITreeGetter> BYOHHouseFloraLeek01 => Construct(0x10460);
            public static FormLink<ITreeGetter> BYOHHouseFloraGourd01 => Construct(0x1045f);
            public static FormLink<ITreeGetter> BYOHHouseFloraCabbage01 => Construct(0x1045e);
        }
    }
}
