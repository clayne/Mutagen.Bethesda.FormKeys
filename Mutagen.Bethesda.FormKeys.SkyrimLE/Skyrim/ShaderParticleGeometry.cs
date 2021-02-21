using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class ShaderParticleGeometry
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IShaderParticleGeometryGetter> Construct(uint id) => new FormLink<IShaderParticleGeometryGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IShaderParticleGeometryGetter> SovngardeStardust => Construct(0x10fdc4);
            public static FormLink<IShaderParticleGeometryGetter> RainStormParticles => Construct(0x10780f);
            public static FormLink<IShaderParticleGeometryGetter> DragonRainParticles => Construct(0x4c40c);
            public static FormLink<IShaderParticleGeometryGetter> FXmRainParticles => Construct(0xe4cb4);
            public static FormLink<IShaderParticleGeometryGetter> HeavyBlowingGrass => Construct(0xd5105);
            public static FormLink<IShaderParticleGeometryGetter> SnowParticlesStorm => Construct(0xd299c);
            public static FormLink<IShaderParticleGeometryGetter> BlackreachSnow => Construct(0x48c1b);
            public static FormLink<IShaderParticleGeometryGetter> MAGBlizzardParticles => Construct(0xb79fb);
            public static FormLink<IShaderParticleGeometryGetter> SnowParticlesLite => Construct(0x9ee7d);
            public static FormLink<IShaderParticleGeometryGetter> SnowParticlesBlustery => Construct(0x89418);
            public static FormLink<IShaderParticleGeometryGetter> SlowTimeParticles02 => Construct(0x486f3);
            public static FormLink<IShaderParticleGeometryGetter> SlowTimeParticles => Construct(0x486f2);
            public static FormLink<IShaderParticleGeometryGetter> DustParticles => Construct(0x2f777);
            public static FormLink<IShaderParticleGeometryGetter> FogParticles => Construct(0x2e2d0);
            public static FormLink<IShaderParticleGeometryGetter> SnowParticlesMed => Construct(0x23c49);
            public static FormLink<IShaderParticleGeometryGetter> RainParticles => Construct(0x23c48);
        }
    }
}
