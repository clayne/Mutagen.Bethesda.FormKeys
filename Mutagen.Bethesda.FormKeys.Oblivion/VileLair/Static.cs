// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class VileLair
{
    public static partial class Static
    {
        private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IStaticGetter> HumanStatue1 => Construct(0x6f83);
        public static FormLink<IStaticGetter> HumanStatue2 => Construct(0x6f84);
        public static FormLink<IStaticGetter> HumanStatue3 => Construct(0x6f85);
        public static FormLink<IStaticGetter> LairVileSithisShrineStatic => Construct(0x37f3);
    }
}
