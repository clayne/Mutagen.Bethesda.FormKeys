// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> AnimObjectGroatDagger => Construct(0x4708c);
        public static FormLink<IAnimatedObjectGetter> SFBGS001_AnimObjectPainBlade => Construct(0xd9e5c);
        public static FormLink<IAnimatedObjectGetter> SFBGS001_AnimObjectCeremonialCup => Construct(0xf912f);
    }
}
