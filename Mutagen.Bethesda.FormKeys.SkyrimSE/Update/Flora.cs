using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> ccBGS_FlameStalk02 => Construct(0x308a);
            public static FormLink<IFloraGetter> ccBGS_FlameStalk01 => Construct(0x3089);
            public static FormLink<IFloraGetter> ccBGS_RootThornHook => Construct(0x306c);
            public static FormLink<IFloraGetter> ccBGS_RootRotScale => Construct(0x306b);
            public static FormLink<IFloraGetter> ccBGS_RootScreamingMaw => Construct(0x306a);
        }
    }
}
