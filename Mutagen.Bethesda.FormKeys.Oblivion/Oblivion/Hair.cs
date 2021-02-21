using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Hair
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<IHairGetter> Construct(uint id) => new FormLink<IHairGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IHairGetter> KhajiitWisps => Construct(0xc4821);
            public static FormLink<IHairGetter> KhajiitEarrings => Construct(0xc4820);
            public static FormLink<IHairGetter> HighElfClassic => Construct(0x7b792);
            public static FormLink<IHairGetter> HighElfpony => Construct(0x69474);
            public static FormLink<IHairGetter> WoodElfFringes => Construct(0x69473);
            public static FormLink<IHairGetter> HumanFringes => Construct(0x69472);
            public static FormLink<IHairGetter> DarkElfFringe => Construct(0x690c2);
            public static FormLink<IHairGetter> HighElfBun => Construct(0x690c1);
            public static FormLink<IHairGetter> HighElfPeak => Construct(0x690c0);
            public static FormLink<IHairGetter> HighElfCone => Construct(0x690bf);
            public static FormLink<IHairGetter> WoodElfPony => Construct(0x690bd);
            public static FormLink<IHairGetter> WoodElfSpiky => Construct(0x690bc);
            public static FormLink<IHairGetter> DarkElfTopknot => Construct(0x690bb);
            public static FormLink<IHairGetter> RedguardDredz => Construct(0x66f21);
            public static FormLink<IHairGetter> OrcUpdo => Construct(0x66a2a);
            public static FormLink<IHairGetter> OrcHeadband => Construct(0x66a29);
            public static FormLink<IHairGetter> OrcOneBraid => Construct(0x66a28);
            public static FormLink<IHairGetter> OrcTwoBraids => Construct(0x66a27);
            public static FormLink<IHairGetter> OrcBraids => Construct(0x663fc);
            public static FormLink<IHairGetter> KhajiitJeweled => Construct(0x653d5);
            public static FormLink<IHairGetter> KhajiitMane => Construct(0x653d4);
            public static FormLink<IHairGetter> KhajiitHeadBand => Construct(0x653d3);
            public static FormLink<IHairGetter> KhajiitFeathers => Construct(0x653d2);
            public static FormLink<IHairGetter> KhajiitCommon => Construct(0x653d1);
            public static FormLink<IHairGetter> KhajiitDreds => Construct(0x653d0);
            public static FormLink<IHairGetter> KhajiitBraids => Construct(0x653cf);
            public static FormLink<IHairGetter> OrcRomantic => Construct(0x651d7);
            public static FormLink<IHairGetter> ArgonianSpines => Construct(0x64f36);
            public static FormLink<IHairGetter> ArgonianSpikes => Construct(0x64f35);
            public static FormLink<IHairGetter> ArgonianRidge => Construct(0x64f34);
            public static FormLink<IHairGetter> ArgonianJeweledFins => Construct(0x64f33);
            public static FormLink<IHairGetter> ArgonianFins => Construct(0x64f32);
            public static FormLink<IHairGetter> ArgonianDecoratedSpikes => Construct(0x64f31);
            public static FormLink<IHairGetter> ImperialBald => Construct(0x64c7d);
            public static FormLink<IHairGetter> OrcPlaits => Construct(0x6421a);
            public static FormLink<IHairGetter> OrcBun => Construct(0x64218);
            public static FormLink<IHairGetter> OrcStubs => Construct(0x64217);
            public static FormLink<IHairGetter> RedguardCornrows => Construct(0x64216);
            public static FormLink<IHairGetter> RedguardClassic => Construct(0x64215);
            public static FormLink<IHairGetter> DarkElfMane => Construct(0x64214);
            public static FormLink<IHairGetter> BretonTonsure => Construct(0x64213);
            public static FormLink<IHairGetter> ImperialHeadband => Construct(0x64211);
            public static FormLink<IHairGetter> RedguardCoil => Construct(0x64210);
            public static FormLink<IHairGetter> OrcTopknot => Construct(0x6420f);
            public static FormLink<IHairGetter> NordBaldPony => Construct(0x6420e);
            public static FormLink<IHairGetter> DarkElfMohawk => Construct(0x6420d);
            public static FormLink<IHairGetter> Cropped => Construct(0x18a891);
            public static FormLink<IHairGetter> Blindfold => Construct(0x177861);
            public static FormLink<IHairGetter> PonytailTwist => Construct(0x950eb);
            public static FormLink<IHairGetter> Loose => Construct(0x90475);
            public static FormLink<IHairGetter> DremoraHairLord => Construct(0x3e914);
            public static FormLink<IHairGetter> DremoraHairB => Construct(0x3b59c);
            public static FormLink<IHairGetter> dremoraHair => Construct(0x3832e);
            public static FormLink<IHairGetter> ElfBraid => Construct(0x1da83);
            public static FormLink<IHairGetter> ElfPonytail => Construct(0x1da82);
            public static FormLink<IHairGetter> Ponytail => Construct(0x2c4d0);
            public static FormLink<IHairGetter> MediumLength => Construct(0x27ff2);
        }
    }
}
