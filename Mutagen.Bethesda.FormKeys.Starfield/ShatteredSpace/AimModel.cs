// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class AimModel
    {
        private static FormLink<IAimModelGetter> Construct(uint id) => new FormLink<IAimModelGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAimModelGetter> SFBGS001_ParticleMachineGun_AM => Construct(0xeee5);
        public static FormLink<IAimModelGetter> SFBGS001_ParticleRocketlauncher_AM => Construct(0xef66);
        public static FormLink<IAimModelGetter> SFBGS001_VaruunEquinox_SA_AM => Construct(0x279f2);
        public static FormLink<IAimModelGetter> SFBGS001_VaruunEquinox_FA_AM => Construct(0x279f3);
    }
}
