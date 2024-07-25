// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class SFBGS003
{
    public static partial class ActorValueModulation
    {
        private static FormLink<IActorValueModulationGetter> Construct(uint id) => new FormLink<IActorValueModulationGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActorValueModulationGetter> ComplexGroup_AVM_MagStorm_SFBGS003_MantisVariant => Construct(0x476);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_MagStorm_SFBGS003_MantisVariant_Color => Construct(0x477);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_MagStorm_SFBGS003_MantisVariant_Normal => Construct(0x478);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_MagStorm_SFBGS003_MantisVariant_Metal => Construct(0x479);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_MagStorm_SFBGS003_MantisVariant_Rough => Construct(0x47a);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_MagStorm_SFBGS003_MantisVariant_Opacity => Construct(0x47b);
        public static FormLink<IActorValueModulationGetter> ComplexGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance => Construct(0xfd33);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance_Color => Construct(0xfd34);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance_Normal => Construct(0xfd35);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance_Metal => Construct(0xfd36);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance_Rough => Construct(0xfd37);
        public static FormLink<IActorValueModulationGetter> SimpleGroup_AVM_Cutter_SFBGS003_Cutter_TrackersAlliance_Opacity => Construct(0xfd38);
    }
}
