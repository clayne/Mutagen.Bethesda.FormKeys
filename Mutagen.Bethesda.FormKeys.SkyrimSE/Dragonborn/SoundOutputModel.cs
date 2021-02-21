using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class SoundOutputModel
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<ISoundOutputModelGetter> Construct(uint id) => new FormLink<ISoundOutputModelGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad13000SiltStrider => Construct(0x1e114);
            public static FormLink<ISoundOutputModelGetter> SOMDialogue3D10000DragonRiding => Construct(0x1dc44);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad12000VolcanoAA => Construct(0x1dbfc);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad25000VolcanoBB => Construct(0x1dbec);
            public static FormLink<ISoundOutputModelGetter> SOMMono30000VolcanoB => Construct(0x1dbeb);
            public static FormLink<ISoundOutputModelGetter> SOMMono12000VolcanoA => Construct(0x1dbe9);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad09000_verb => Construct(0x3d2c7);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad05000SkaalWall => Construct(0x3d14e);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad02100OceanWaves => Construct(0x34291);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad08000Rigging => Construct(0x1defa);
            public static FormLink<ISoundOutputModelGetter> SOMStereoRad08000Harbor => Construct(0x1deee);
        }
    }
}
