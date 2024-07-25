// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Starfield
{
    public static partial class IdleMarker
    {
        private static FormLink<IIdleMarkerGetter> Construct(uint id) => new FormLink<IIdleMarkerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IIdleMarkerGetter> PatrolIdleMarker => Construct(0x2ce2);
        public static FormLink<IIdleMarkerGetter> ShipPatrolMarker => Construct(0x1118b);
        public static FormLink<IIdleMarkerGetter> NPCThinkingStanding => Construct(0x192c9);
        public static FormLink<IIdleMarkerGetter> NPCPointingForward => Construct(0x192ca);
        public static FormLink<IIdleMarkerGetter> NPCIdleLongFlavor => Construct(0x27107);
        public static FormLink<IIdleMarkerGetter> NPCDataSlateEquip => Construct(0x5afd7);
        public static FormLink<IIdleMarkerGetter> EmptyIdleMarker => Construct(0x91c84);
        public static FormLink<IIdleMarkerGetter> GuardStandPatrolIdleMarker => Construct(0x146da8);
        public static FormLink<IIdleMarkerGetter> SandboxIdleMarker => Construct(0x160c22);
        public static FormLink<IIdleMarkerGetter> CrowdConversationMarker => Construct(0x253dd7);
        public static FormLink<IIdleMarkerGetter> DCB_PreyIdleFeedMarker => Construct(0x2bf8f1);
        public static FormLink<IIdleMarkerGetter> DCB_PreyIdleSleepMarker => Construct(0x2bf8f2);
        public static FormLink<IIdleMarkerGetter> DCB_PreyIdleWanderMarker => Construct(0x2bf8f3);
        public static FormLink<IIdleMarkerGetter> DCB_PredatorIdleFeedMarker => Construct(0x2c0652);
        public static FormLink<IIdleMarkerGetter> DCB_PredatorIdleSleepMarker => Construct(0x2c0653);
        public static FormLink<IIdleMarkerGetter> DCB_PredatorIdleWanderMarker => Construct(0x2c0654);
        public static FormLink<IIdleMarkerGetter> DepressedIdleMarker => Construct(0x2cf3db);
        public static FormLink<IIdleMarkerGetter> SpaceMarkerSphere01 => Construct(0x377e1d);
    }
}
