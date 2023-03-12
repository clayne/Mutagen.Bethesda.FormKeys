// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class HearthFires
{
    public static partial class Relationship
    {
        private static FormLink<IRelationshipGetter> Construct(uint id) => new FormLink<IRelationshipGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IRelationshipGetter> BYOHHousecarlPalePlayerRelationship => Construct(0x5227);
        public static FormLink<IRelationshipGetter> BYOHHousecarlHjaalmarchPlayerRelationship => Construct(0x5226);
        public static FormLink<IRelationshipGetter> BYOHHousecarlFalkreathPlayerRelationship => Construct(0x5225);
    }
}
