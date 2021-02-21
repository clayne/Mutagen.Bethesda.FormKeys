using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class TalkingActivator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<ITalkingActivatorGetter> Construct(uint id) => new FormLink<ITalkingActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITalkingActivatorGetter> MGAugurTalkingActivator => Construct(0x1093d0);
            public static FormLink<ITalkingActivatorGetter> DA03ClavicusVileShrinePreQuest => Construct(0xfe530);
            public static FormLink<ITalkingActivatorGetter> DA05HircineSpiritTalkingActivator => Construct(0xeb4fe);
            public static FormLink<ITalkingActivatorGetter> DA03ClavicusVileShrineNoDog => Construct(0x20951);
            public static FormLink<ITalkingActivatorGetter> DA10AltarofMolagBalTalking => Construct(0xdee7e);
            public static FormLink<ITalkingActivatorGetter> DA13PeryiteApparition => Construct(0xa8065);
            public static FormLink<ITalkingActivatorGetter> DA07VoiceofDagon => Construct(0xac9ac);
            public static FormLink<ITalkingActivatorGetter> DA11ShrineofNamiraActivator => Construct(0xac9ab);
            public static FormLink<ITalkingActivatorGetter> DA01VoiceofAzura => Construct(0xac9aa);
            public static FormLink<ITalkingActivatorGetter> MS06PotemaMural => Construct(0x96d8b);
            public static FormLink<ITalkingActivatorGetter> DA11NamiraTalkActivator => Construct(0x8797c);
            public static FormLink<ITalkingActivatorGetter> DA11GlooredhelTalkActivator => Construct(0x7d959);
            public static FormLink<ITalkingActivatorGetter> DA02ShrineofBoethiah => Construct(0x23da6);
            public static FormLink<ITalkingActivatorGetter> DA08WhisperingDoor => Construct(0x4a389);
            public static FormLink<ITalkingActivatorGetter> DBBlackDoorDawnstarActivator => Construct(0x19516);
            public static FormLink<ITalkingActivatorGetter> DBNightMotherTalkingActivator => Construct(0x22440);
            public static FormLink<ITalkingActivatorGetter> DA06Shrine => Construct(0x3bc28);
            public static FormLink<ITalkingActivatorGetter> DA04HermaeusMora => Construct(0x3278d);
            public static FormLink<ITalkingActivatorGetter> TG05TalkingRock04 => Construct(0x1bb5c);
            public static FormLink<ITalkingActivatorGetter> TG05TalkingRock03 => Construct(0x1bb5b);
            public static FormLink<ITalkingActivatorGetter> TG05TalkingRock02 => Construct(0x1bb5a);
            public static FormLink<ITalkingActivatorGetter> TG05TalkingRock01 => Construct(0x1bb59);
            public static FormLink<ITalkingActivatorGetter> DBBlackDoorActivator => Construct(0x25bfa);
            public static FormLink<ITalkingActivatorGetter> DA10MolagBalMace => Construct(0x233ed);
            public static FormLink<ITalkingActivatorGetter> DA03ClavicusVileShrine => Construct(0x1c4e8);
        }
    }
}
