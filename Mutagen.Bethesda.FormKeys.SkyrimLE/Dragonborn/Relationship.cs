using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Relationship
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IRelationshipGetter> Construct(uint id) => new FormLink<IRelationshipGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRelationshipGetter> DLC2NelothDrelas => Construct(0x1f8eb);
            public static FormLink<IRelationshipGetter> DLC2NelothUlves => Construct(0x1f8ea);
            public static FormLink<IRelationshipGetter> DLC2NelothElynea => Construct(0x1f8e9);
            public static FormLink<IRelationshipGetter> DLC2NelothVarona => Construct(0x1f8e8);
            public static FormLink<IRelationshipGetter> DLC2NelothTalvas => Construct(0x1f8e7);
            public static FormLink<IRelationshipGetter> DLC2ElmusHilund => Construct(0x1a532);
            public static FormLink<IRelationshipGetter> DLC2ElmusHalbarn => Construct(0x1a531);
            public static FormLink<IRelationshipGetter> DLC2KBujoldHilund => Construct(0x1a530);
            public static FormLink<IRelationshipGetter> DLC2KuvarBujold => Construct(0x1a517);
            public static FormLink<IRelationshipGetter> DLC2SVFanariTharstan => Construct(0x18fc9);
            public static FormLink<IRelationshipGetter> DLC2SVEdlaNikulas => Construct(0x18fc2);
            public static FormLink<IRelationshipGetter> DLC2SVDeorYrsa => Construct(0x18fba);
            public static FormLink<IRelationshipGetter> DLC2SVOslafFinna => Construct(0x18f9d);
            public static FormLink<IRelationshipGetter> DLC2RRLlerilCindiri => Construct(0x184a6);
            public static FormLink<IRelationshipGetter> DLC2RRGarynMilore => Construct(0x184a5);
            public static FormLink<IRelationshipGetter> DLC2RRTilisuMirri => Construct(0x184a4);
            public static FormLink<IRelationshipGetter> DLC2RRVendilMirri => Construct(0x184a3);
            public static FormLink<IRelationshipGetter> DLC2RRVendilTilisu => Construct(0x184a2);
            public static FormLink<IRelationshipGetter> DLC2RRCresciusAphia => Construct(0x184a1);
            public static FormLink<IRelationshipGetter> DLC2RRFethisDreyla => Construct(0x184a0);
            public static FormLink<IRelationshipGetter> DLC2RRGeldisDrovas => Construct(0x1849f);
            public static FormLink<IRelationshipGetter> DLC2RROthrelothGaldrus => Construct(0x1849e);
            public static FormLink<IRelationshipGetter> DLC2RRModynLleril => Construct(0x1849d);
            public static FormLink<IRelationshipGetter> DLC2RRAdrilCindiri => Construct(0x1849c);
            public static FormLink<IRelationshipGetter> DLC2RRLlerilAdril => Construct(0x1849b);
        }
    }
}
