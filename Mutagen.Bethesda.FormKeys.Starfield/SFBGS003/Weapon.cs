// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class Weapon
    {
        private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWeaponGetter> SFBGS003_MagShot_Roach_NOTPLAYABLE => Construct(0x6b6c);
        public static FormLink<IWeaponGetter> PlasmaCutter => Construct(0x6c1c);
    }
}
