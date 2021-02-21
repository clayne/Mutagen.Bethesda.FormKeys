using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Activator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> BattlehornWineBarrelE => Construct(0xb60e);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelF => Construct(0xb60f);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelG => Construct(0xb610);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelCheap => Construct(0xb611);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelMead => Construct(0xb612);
            public static FormLink<IActivatorGetter> BattlehornCastlePortcullis01 => Construct(0x10b3c);
            public static FormLink<IActivatorGetter> BattlehornSecretLever01 => Construct(0x38b9);
            public static FormLink<IActivatorGetter> BattlehornSecretLever02 => Construct(0x4de4);
            public static FormLink<IActivatorGetter> BattlehornNarrowSecretDoor01 => Construct(0x6390);
            public static FormLink<IActivatorGetter> BattlehornForgottenSecretLever01 => Construct(0x6392);
            public static FormLink<IActivatorGetter> BattlehornSecretLever03 => Construct(0x6279);
            public static FormLink<IActivatorGetter> BattlehornDwemerForge => Construct(0xa69f);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelA => Construct(0xb5fb);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelB => Construct(0xb60b);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelC => Construct(0xb60c);
            public static FormLink<IActivatorGetter> BattlehornWineBarrelD => Construct(0xb60d);
        }
    }
}
