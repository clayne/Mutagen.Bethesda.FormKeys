using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class AnimatedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Oblivion.esm");
            private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAnimatedObjectGetter> SE14JugglingBalls => Construct(0x96231);
            public static FormLink<IAnimatedObjectGetter> SEHaleHalionWritesPen => Construct(0x93842);
            public static FormLink<IAnimatedObjectGetter> SEHaleHalionWritesBook => Construct(0x93733);
            public static FormLink<IAnimatedObjectGetter> SESpoon => Construct(0x8f13f);
            public static FormLink<IAnimatedObjectGetter> SEMixingBowl => Construct(0x8f13e);
            public static FormLink<IAnimatedObjectGetter> SE09RelmynaWritePen2 => Construct(0x8ef27);
            public static FormLink<IAnimatedObjectGetter> SE09RelmynaWriteBook2 => Construct(0x8ef26);
            public static FormLink<IAnimatedObjectGetter> SEBroom => Construct(0x895c2);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectAtrabhiManiaRead => Construct(0x895b0);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectDSSuicide => Construct(0x8955f);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectGSSuicide => Construct(0x8955e);
            public static FormLink<IAnimatedObjectGetter> SE09RelmynaWritePen => Construct(0x81db0);
            public static FormLink<IAnimatedObjectGetter> SE09RelmynaWriteBook => Construct(0x81daf);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectsBlackSmithHammer2 => Construct(0x811a6);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectsBlackSmithClamp2 => Construct(0x811a5);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectsBlackSmithClamp => Construct(0x811a0);
            public static FormLink<IAnimatedObjectGetter> SEIdleObjectsBlackSmithHammer => Construct(0x8119f);
            public static FormLink<IAnimatedObjectGetter> SEJugglingBalls => Construct(0x607e0);
            public static FormLink<IAnimatedObjectGetter> TGSkoomaGenericPotion => Construct(0xc5db);
            public static FormLink<IAnimatedObjectGetter> alchemyRetort => Construct(0xa303);
            public static FormLink<IAnimatedObjectGetter> alchemyBottle => Construct(0xa302);
            public static FormLink<IAnimatedObjectGetter> paintPalette => Construct(0x14939);
            public static FormLink<IAnimatedObjectGetter> paintbrush => Construct(0x14933);
            public static FormLink<IAnimatedObjectGetter> IdleObjectsascensionParticles => Construct(0x651ad);
            public static FormLink<IAnimatedObjectGetter> DrunkIdleMug => Construct(0x64c22);
            public static FormLink<IAnimatedObjectGetter> Hoe => Construct(0x62263);
            public static FormLink<IAnimatedObjectGetter> Rake => Construct(0x62262);
            public static FormLink<IAnimatedObjectGetter> IdleObjectsLockPickLow => Construct(0x150f1e);
            public static FormLink<IAnimatedObjectGetter> IdleObjectsLockPick => Construct(0x150f1d);
            public static FormLink<IAnimatedObjectGetter> IdleObjectsGenericPotion => Construct(0x9079c);
            public static FormLink<IAnimatedObjectGetter> IdleObjectsGenericBook => Construct(0x3eacc);
            public static FormLink<IAnimatedObjectGetter> GenericBottle => Construct(0x3856c);
            public static FormLink<IAnimatedObjectGetter> GenericMug => Construct(0x3856b);
            public static FormLink<IAnimatedObjectGetter> BreadPiece => Construct(0x3856a);
        }
    }
}
