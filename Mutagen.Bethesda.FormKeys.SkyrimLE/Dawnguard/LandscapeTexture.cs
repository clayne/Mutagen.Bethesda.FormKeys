// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dawnguard
{
    public static partial class LandscapeTexture
    {
        private static FormLink<ILandscapeTextureGetter> Construct(uint id) => new FormLink<ILandscapeTextureGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnBones01 => Construct(0x1182c);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnRock01 => Construct(0xcde8);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnDirt01Grass01 => Construct(0x592c);
        public static FormLink<ILandscapeTextureGetter> LWinterForestDirt01 => Construct(0x5233);
        public static FormLink<ILandscapeTextureGetter> LGlowingForestDirt01 => Construct(0x5231);
        public static FormLink<ILandscapeTextureGetter> LWinterForestLeaves02 => Construct(0x522f);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnPath01 => Construct(0x4f97);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnDirt04 => Construct(0x4bd4);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnDirt03 => Construct(0x4bd0);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnDirt02 => Construct(0x4bce);
        public static FormLink<ILandscapeTextureGetter> LDLC01SoulCairnDirt01 => Construct(0x4bcc);
        public static FormLink<ILandscapeTextureGetter> LWinterForestLeaves01 => Construct(0x3ace);
    }
}
