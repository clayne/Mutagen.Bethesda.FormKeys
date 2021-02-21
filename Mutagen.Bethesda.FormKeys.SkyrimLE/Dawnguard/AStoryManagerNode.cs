using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class AStoryManagerNode
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IAStoryManagerNodeGetter> Construct(uint id) => new FormLink<IAStoryManagerNodeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAStoryManagerNodeGetter> DLC1LD_AetherialItemsNode => Construct(0xd00e);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VampireBaseScenes => Construct(0x4e26);
            public static FormLink<IAStoryManagerNodeGetter> DLC1HunterBaseScenes => Construct(0x4e25);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RadiantQuestNode => Construct(0x4c21);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VampireFeedBystanderNode => Construct(0x14cba);
            public static FormLink<IAStoryManagerNodeGetter> DLC1ScrollHandlingChangeLocNode => Construct(0x12f93);
            public static FormLink<IAStoryManagerNodeGetter> DLC1HunterBaseFlorentiusNode => Construct(0x11f0e);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VQ00VampireAttackNodeAM => Construct(0x10de4);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VQ00VampireAttackNodePM => Construct(0x10de3);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VQ00Node => Construct(0xd911);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RadiantDisguisedVampireLordQuestNode => Construct(0x4210);
            public static FormLink<IAStoryManagerNodeGetter> DLC1WESpecialAttacks => Construct(0x4204);
            public static FormLink<IAStoryManagerNodeGetter> DLC1ScoutQuestNode => Construct(0x41d3);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RH05QuestNode => Construct(0x2f21);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VQ08HunterMoveNode => Construct(0x1a8bc);
            public static FormLink<IAStoryManagerNodeGetter> DLC1HunterBaseEnableSet2Node => Construct(0x19ca2);
            public static FormLink<IAStoryManagerNodeGetter> DLC1HunterBaseEnableSet1Node => Construct(0x198b3);
            public static FormLink<IAStoryManagerNodeGetter> DLC1WEQuestsEclipseActive => Construct(0x17869);
            public static FormLink<IAStoryManagerNodeGetter> DLC1HunterBaseFortScenes => Construct(0x163bf);
            public static FormLink<IAStoryManagerNodeGetter> DLC1EclipseAttackNode => Construct(0x162a0);
            public static FormLink<IAStoryManagerNodeGetter> DLC1LD_CraftItemQuestNode => Construct(0xd010);
            public static FormLink<IAStoryManagerNodeGetter> DLC1LD_BthalftNode => Construct(0xd00f);
            public static FormLink<IAStoryManagerNodeGetter> DLC1dunRedwaterDenNode => Construct(0x8e27);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RadiantHunterQuestNode => Construct(0x5e52);
            public static FormLink<IAStoryManagerNodeGetter> DLC1LD_ArkngthamzNode => Construct(0x5827);
            public static FormLink<IAStoryManagerNodeGetter> DLC1VampireBaseGuildhallScenes => Construct(0x4e27);
            public static FormLink<IAStoryManagerNodeGetter> DLC1LD_MasterNode => Construct(0x4d71);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RV01AssaultMonitorQuestNode => Construct(0x4c31);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RadiantKillActorMonitorQuestNode => Construct(0x4c2f);
            public static FormLink<IAStoryManagerNodeGetter> DLC1RadiantVampireQuestNode => Construct(0x4c22);
        }
    }
}
