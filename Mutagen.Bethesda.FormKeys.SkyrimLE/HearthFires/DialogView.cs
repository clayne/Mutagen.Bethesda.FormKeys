using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class DialogView
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IDialogViewGetter> Construct(uint id) => new FormLink<IDialogViewGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogViewGetter> BYOHHouseBanditAttack2View => Construct(0x8b0);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_RehirePets => Construct(0x192d4);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGNameCalling => Construct(0x192d0);
            public static FormLink<IDialogViewGetter> BYOHHouseBardView => Construct(0x18de2);
            public static FormLink<IDialogViewGetter> BYOHHousePaleView => Construct(0x17718);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGCritter => Construct(0x13f06);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGPet => Construct(0x13f05);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGInitial => Construct(0x13f03);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_NeverSpeakToYouAgain => Construct(0x13f02);
            public static FormLink<IDialogViewGetter> BYOHHouseSkeeverInfestationView => Construct(0x10a4c);
            public static FormLink<IDialogViewGetter> BYOHHouseHjaalmarchView => Construct(0xbe42);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptionCWSiegeHandlerView => Construct(0x8934);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_SpouseHowAreKids => Construct(0x8788);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_Gift => Construct(0x7b7a);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGAskGift => Construct(0x7b79);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGAllowance => Construct(0x2f59);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_FGGivePlayerGift => Construct(0x2f56);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_Moving => Construct(0x42af);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_Orders => Construct(0x42a6);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_Games => Construct(0x42a2);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptableOrphanable_AdoptionDialogue => Construct(0x428f);
            public static FormLink<IDialogViewGetter> RelationshipAdoption_JustAdopted => Construct(0x428c);
            public static FormLink<IDialogViewGetter> RelationshipAdoptableOrphanage_Matrons => Construct(0x4284);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptableUrchins_Sofie => Construct(0x4030);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptableUrchins_Alesan => Construct(0x401e);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptableUrchins_Lucia => Construct(0x3f60);
            public static FormLink<IDialogViewGetter> BYOHRelationshipAdoptableUrchins_Blaise => Construct(0x3f43);
            public static FormLink<IDialogViewGetter> BYOHHouseStewardOfferView => Construct(0x3090);
            public static FormLink<IDialogViewGetter> BYOHHouseFalkreathView => Construct(0x3078);
            public static FormLink<IDialogViewGetter> BYOHHouseBuildingView => Construct(0x3076);
        }
    }
}
