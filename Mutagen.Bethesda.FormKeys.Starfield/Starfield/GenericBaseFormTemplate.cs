// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class GenericBaseFormTemplate
    {
        private static FormLink<IGenericBaseFormTemplateGetter> Construct(uint id) => new FormLink<IGenericBaseFormTemplateGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGenericBaseFormTemplateGetter> Spaceship => Construct(0x346e);
        public static FormLink<IGenericBaseFormTemplateGetter> DestroyableTemplate => Construct(0x669b);
        public static FormLink<IGenericBaseFormTemplateGetter> EnterableControllableTemplate => Construct(0x70dc);
        public static FormLink<IGenericBaseFormTemplateGetter> ModelGraphTemplate => Construct(0x729f);
        public static FormLink<IGenericBaseFormTemplateGetter> SpaceshipHullTemplate => Construct(0x8ebc);
        public static FormLink<IGenericBaseFormTemplateGetter> CritterTemplate => Construct(0x23716);
        public static FormLink<IGenericBaseFormTemplateGetter> SpaceshipModule => Construct(0x3058e);
        public static FormLink<IGenericBaseFormTemplateGetter> CrowdRegion => Construct(0x5fce2);
    }
}
