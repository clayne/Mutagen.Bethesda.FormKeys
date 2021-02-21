using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class DialogTopic
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogTopicGetter> BattlehornWineTopic => Construct(0xb61e);
            public static FormLink<IDialogTopicGetter> BattlehornWineA => Construct(0xb620);
            public static FormLink<IDialogTopicGetter> BattlehornVintnerGreetA => Construct(0xb624);
            public static FormLink<IDialogTopicGetter> BattlehornNeverMind => Construct(0xbb0e);
            public static FormLink<IDialogTopicGetter> BattlehornWineB => Construct(0xbb12);
            public static FormLink<IDialogTopicGetter> BattlehornWineC => Construct(0xbb13);
            public static FormLink<IDialogTopicGetter> BattlehornWineD => Construct(0xbb14);
            public static FormLink<IDialogTopicGetter> BattlehornWineE => Construct(0xbb15);
            public static FormLink<IDialogTopicGetter> BattlehornWineF => Construct(0xbb16);
            public static FormLink<IDialogTopicGetter> BattlehornWineG => Construct(0xbb17);
            public static FormLink<IDialogTopicGetter> BattlehornTrainerSparring => Construct(0xc00a);
            public static FormLink<IDialogTopicGetter> BattlehornTrainerWeaponChoiceA => Construct(0xc00c);
            public static FormLink<IDialogTopicGetter> BattlehornTrainerWeaponChoiceB => Construct(0xc00e);
            public static FormLink<IDialogTopicGetter> BattlehornTrainerWeaponChoiceC => Construct(0xc013);
            public static FormLink<IDialogTopicGetter> BattlehornTaxidermistTrophyTopic => Construct(0xc51d);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyA => Construct(0xc51f);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyNeverMind => Construct(0xc521);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyB => Construct(0xc522);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyC => Construct(0xc523);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyD => Construct(0xc524);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyE => Construct(0xc525);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyF => Construct(0xc526);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyG => Construct(0xc527);
            public static FormLink<IDialogTopicGetter> BattlehornTrophyH => Construct(0xc528);
            public static FormLink<IDialogTopicGetter> BattlehornKnight01A => Construct(0xd434);
            public static FormLink<IDialogTopicGetter> BattlehornKnight01B => Construct(0xd435);
            public static FormLink<IDialogTopicGetter> BattlehornKnight01C => Construct(0xd436);
            public static FormLink<IDialogTopicGetter> BattlehornMaidFollow => Construct(0xde21);
            public static FormLink<IDialogTopicGetter> BattlehornMaidDrink => Construct(0xde22);
            public static FormLink<IDialogTopicGetter> BattlehornMaidFood => Construct(0xde23);
            public static FormLink<IDialogTopicGetter> BattlehornMaidStopFollow => Construct(0xde24);
            public static FormLink<IDialogTopicGetter> BattlehornFoodA => Construct(0xde2a);
            public static FormLink<IDialogTopicGetter> BattlehornFoodB => Construct(0xde2b);
            public static FormLink<IDialogTopicGetter> BattlehornFoodC => Construct(0xde2c);
            public static FormLink<IDialogTopicGetter> BattlehornFoodD => Construct(0xde2d);
            public static FormLink<IDialogTopicGetter> BattlehornFoodE => Construct(0xde32);
            public static FormLink<IDialogTopicGetter> BattlehornFoodF => Construct(0xde33);
            public static FormLink<IDialogTopicGetter> BattlehornFoodG => Construct(0xde34);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkA => Construct(0xde39);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkB => Construct(0xde3a);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkC => Construct(0xde3b);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkD => Construct(0xde3c);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkMead => Construct(0xde3d);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkCheapWine => Construct(0xde3e);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkE => Construct(0xde3f);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkF => Construct(0xde40);
            public static FormLink<IDialogTopicGetter> BattlehornDrinkG => Construct(0xde41);
            public static FormLink<IDialogTopicGetter> BattlehornKnight02A => Construct(0x11ee0);
            public static FormLink<IDialogTopicGetter> BattlehornKnight02B => Construct(0x11ee1);
            public static FormLink<IDialogTopicGetter> BattlehornKnight02C => Construct(0x11ee2);
            public static FormLink<IDialogTopicGetter> BattlehornKnight03A => Construct(0x11ee3);
            public static FormLink<IDialogTopicGetter> BattlehornKnight03B => Construct(0x11ee4);
            public static FormLink<IDialogTopicGetter> BattlehornKnight03C => Construct(0x11ee5);
            public static FormLink<IDialogTopicGetter> BattlehornKnight04A => Construct(0x11ee6);
            public static FormLink<IDialogTopicGetter> BattlehornKnight04B => Construct(0x11ee7);
            public static FormLink<IDialogTopicGetter> BattlehornKnight04C => Construct(0x11ee8);
            public static FormLink<IDialogTopicGetter> BattlehornKnight05A => Construct(0x11ee9);
            public static FormLink<IDialogTopicGetter> BattlehornKnight05B => Construct(0x11eea);
            public static FormLink<IDialogTopicGetter> BattlehornKnight05C => Construct(0x11eeb);
        }
    }
}
