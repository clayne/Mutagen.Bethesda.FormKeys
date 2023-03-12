// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dragonborn
{
    public static partial class ShaderParticleGeometry
    {
        private static FormLink<IShaderParticleGeometryGetter> Construct(uint id) => new FormLink<IShaderParticleGeometryGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IShaderParticleGeometryGetter> DLC02AshParticlesLite => Construct(0x32337);
        public static FormLink<IShaderParticleGeometryGetter> DLC02VolcanicAshParticles01 => Construct(0x18472);
    }
}
