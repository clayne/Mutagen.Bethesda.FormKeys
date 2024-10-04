// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class SurfaceTree
    {
        private static FormLink<ISurfaceTreeGetter> Construct(uint id) => new FormLink<ISurfaceTreeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISurfaceTreeGetter> VaruunKaiSurfaceTree => Construct(0x11e90);
        public static FormLink<ISurfaceTreeGetter> KavnykISurfaceTree => Construct(0x11e91);
        public static FormLink<ISurfaceTreeGetter> KavnykI_aSurfaceTree => Construct(0x12b54);
        public static FormLink<ISurfaceTreeGetter> KavnykI_cSurfaceTree => Construct(0x12b55);
        public static FormLink<ISurfaceTreeGetter> KavnykII_cSurfaceTree => Construct(0x2af99);
        public static FormLink<ISurfaceTreeGetter> KavnykII_eSurfaceTree => Construct(0x2af9a);
        public static FormLink<ISurfaceTreeGetter> KavnykIISurfaceTree => Construct(0x2af9b);
        public static FormLink<ISurfaceTreeGetter> KavnykII_bSurfaceTree => Construct(0xa6fb5);
    }
}
