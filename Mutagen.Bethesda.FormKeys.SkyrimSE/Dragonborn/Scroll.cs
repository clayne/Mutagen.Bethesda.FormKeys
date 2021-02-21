using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Scroll
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IScrollGetter> Construct(uint id) => new FormLink<IScrollGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScrollGetter> DLC2ExpSpiderEmptyScroll05 => Construct(0x331a1);
            public static FormLink<IScrollGetter> DLC2ExpSpiderEmptyScroll04 => Construct(0x331a0);
            public static FormLink<IScrollGetter> DLC2ExpSpiderEmptyScroll03 => Construct(0x3319f);
            public static FormLink<IScrollGetter> DLC2ExpSpiderEmptyScroll02 => Construct(0x3319e);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireJumpingScrollENEMY => Construct(0x285d1);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireCloakScrollENEMY => Construct(0x285cf);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireBombScrollENEMY => Construct(0x285c8);
            public static FormLink<IScrollGetter> DLC2ExpSpiderPackmuleScroll => Construct(0x274a5);
            public static FormLink<IScrollGetter> DLC2ExpSpiderOilScroll => Construct(0x2749d);
            public static FormLink<IScrollGetter> DLC2ExpSpiderGlowingScroll => Construct(0x27490);
            public static FormLink<IScrollGetter> DLC2ExpSpiderShockJumpingScroll => Construct(0x20961);
            public static FormLink<IScrollGetter> DLC2ExpSpiderShockCloakScroll => Construct(0x20960);
            public static FormLink<IScrollGetter> DLC2ExpSpiderShockBombScroll => Construct(0x2095f);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFrostJumpingScroll => Construct(0x206db);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFrostCloakScroll => Construct(0x206d9);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFrostBombScroll => Construct(0x206d3);
            public static FormLink<IScrollGetter> DLC2ExpSpiderEmptyScroll01 => Construct(0x1da03);
            public static FormLink<IScrollGetter> DLC2ExpSpiderPoisonCloakScroll => Construct(0x1cab0);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireBombScroll => Construct(0x19534);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireCloakScroll => Construct(0x1952c);
            public static FormLink<IScrollGetter> DLC2ExpSpiderPoisonBombScroll => Construct(0x1707b);
            public static FormLink<IScrollGetter> DLC2ExpSpiderZombieScroll => Construct(0x16e1c);
            public static FormLink<IScrollGetter> DLC2ExpSpiderFireJumpingScroll => Construct(0x14480);
            public static FormLink<IScrollGetter> DLC2ExpSpiderPoisonJumpingScroll => Construct(0x1445e);
        }
    }
}
