// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class SoundKeywordMapping
    {
        private static FormLink<ISoundKeywordMappingGetter> Construct(uint id) => new FormLink<ISoundKeywordMappingGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundKeywordMappingGetter> SFBGS003_SKM_Hand_PlasmaCutter_NPC => Construct(0x7176);
        public static FormLink<ISoundKeywordMappingGetter> SFBGS003_SKM_Hand_PlasmaCutter_NPC_Accel => Construct(0x7177);
        public static FormLink<ISoundKeywordMappingGetter> SFBGS003_SKM_Hand_PlasmaCutter_PC => Construct(0x7178);
        public static FormLink<ISoundKeywordMappingGetter> SFBGS003_SKM_Hand_PlasmaCutter_PC_Accel => Construct(0x7179);
    }
}
