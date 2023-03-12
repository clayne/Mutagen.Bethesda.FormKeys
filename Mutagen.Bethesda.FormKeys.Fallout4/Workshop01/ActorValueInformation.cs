// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static partial class ActorValueInformation
    {
        private static FormLink<IActorValueInformationGetter> Construct(uint id) => new FormLink<IActorValueInformationGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingTamedActorCount => Construct(0xca4);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopCheering => Construct(0xa4f);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingArenaPlatform => Construct(0xd11);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopWork24HoursFlag => Construct(0xa9b);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingTame => Construct(0x848);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackBugs => Construct(0x843);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackMolerat => Construct(0x836);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackFeralGhoul => Construct(0x832);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackRadscorpion => Construct(0x828);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackGunner => Construct(0x819);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackDog => Construct(0x815);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackMirelurk => Construct(0x80f);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackSuperMutant => Construct(0x80d);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackRaider => Construct(0x80c);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackYaoGuai => Construct(0x80b);
        public static FormLink<IActorValueInformationGetter> DLC02WorkshopRatingAttackDeathclaw => Construct(0x80a);
    }
}
