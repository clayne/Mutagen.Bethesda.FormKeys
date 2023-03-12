// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class Explosion
    {
        private static FormLink<IExplosionGetter> Construct(uint id) => new FormLink<IExplosionGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IExplosionGetter> DLC06SuperReactorExplosion => Construct(0x24fa);
        public static FormLink<IExplosionGetter> DLC06StaggerExplosion => Construct(0x107f);
        public static FormLink<IExplosionGetter> DLC06E01Explosion => Construct(0x5e76);
    }
}
