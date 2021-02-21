using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Projectile
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IProjectileGetter> Construct(uint id) => new FormLink<IProjectileGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IProjectileGetter> DLC1BatsDmgProjectile => Construct(0x12fec);
            public static FormLink<IProjectileGetter> DLC1HarkonFXBloodDropProjectile => Construct(0x11e3d);
            public static FormLink<IProjectileGetter> DLC1BoltSteelProjectileShock => Construct(0x10d8f);
            public static FormLink<IProjectileGetter> DLC1BoltSteelProjectileIce => Construct(0x10d8e);
            public static FormLink<IProjectileGetter> DLC1ReflectingShieldProjectile03 => Construct(0xd959);
            public static FormLink<IProjectileGetter> DLC1ReflectingShieldProjectile02 => Construct(0xd956);
            public static FormLink<IProjectileGetter> DLC1ReflectingShieldProjectile01 => Construct(0xd953);
            public static FormLink<IProjectileGetter> DLC1DrainVitalityProjectile03 => Construct(0x28df);
            public static FormLink<IProjectileGetter> DLC1DrainVitalityProjectile02 => Construct(0x28d7);
            public static FormLink<IProjectileGetter> DLC1DrainVitalityProjectile01 => Construct(0x28d6);
            public static FormLink<IProjectileGetter> DLC1SoulRendPushProjectile02 => Construct(0x1aa32);
            public static FormLink<IProjectileGetter> DLC1AurielsBloodDippedProjectile => Construct(0x1a8df);
            public static FormLink<IProjectileGetter> DLC1VampireAbsorbProjectile => Construct(0x1a30c);
            public static FormLink<IProjectileGetter> DCL1ArrowElvenBloodProjectile => Construct(0x18c59);
            public static FormLink<IProjectileGetter> ArrowDragonboneProjectile => Construct(0x176f3);
            public static FormLink<IProjectileGetter> DLC1SoulRendPushProjectile01 => Construct(0x16122);
            public static FormLink<IProjectileGetter> DLC1ArrowAurielProjectile => Construct(0x15fef);
            public static FormLink<IProjectileGetter> DLC1ArrowElvenProjectileExplode => Construct(0x15717);
            public static FormLink<IProjectileGetter> testSuperMageLightSpellProjectile => Construct(0x1540f);
            public static FormLink<IProjectileGetter> DLC1VampireDrainSpray01 => Construct(0x14d71);
            public static FormLink<IProjectileGetter> DLC1SC_ShockBoltAimStorm => Construct(0x14323);
            public static FormLink<IProjectileGetter> DLC1LD_AetherialStaffProjectile => Construct(0x142b7);
            public static FormLink<IProjectileGetter> SprigganEarthMotherConcProjectile => Construct(0x13b80);
            public static FormLink<IProjectileGetter> DLC1SunLightSpellProjectile => Construct(0xf649);
            public static FormLink<IProjectileGetter> DLC1BoltSteelProjectileFire => Construct(0xf1ba);
            public static FormLink<IProjectileGetter> DLC1BoltDwarvenProjectileExplodingShock => Construct(0xf1b8);
            public static FormLink<IProjectileGetter> DLC1BoltDwarvenProjectileExplodingIce => Construct(0xf1b6);
            public static FormLink<IProjectileGetter> DLC1BoltDwarvenProjectileExplodingFire => Construct(0xf1b0);
            public static FormLink<IProjectileGetter> DLC1BoltDwarvenProjectile => Construct(0xd09a);
            public static FormLink<IProjectileGetter> DLC1AurielsSunBeamProjectile => Construct(0xc610);
            public static FormLink<IProjectileGetter> DLC1VoiceMarkedDeathProjectile => Construct(0x8447);
            public static FormLink<IProjectileGetter> DLC01SoulRendProjectile => Construct(0x7cbb);
            public static FormLink<IProjectileGetter> TrapSpotLightProjectileCone => Construct(0x37fc);
            public static FormLink<IProjectileGetter> TrapSpotLightProjectile => Construct(0x37f9);
            public static FormLink<IProjectileGetter> DLC1BoltSteelProjectile => Construct(0xbb4);
        }
    }
}
