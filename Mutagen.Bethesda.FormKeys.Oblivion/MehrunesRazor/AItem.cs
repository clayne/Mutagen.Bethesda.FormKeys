using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> DL9MTongBoots01 => Construct(0x1b8c);
            public static FormLink<IAItemGetter> DL9MTongCuirass02 => Construct(0x2085);
            public static FormLink<IAItemGetter> DL9MTongGloves02 => Construct(0x2086);
            public static FormLink<IAItemGetter> DL9MTongGreaves02 => Construct(0x2087);
            public static FormLink<IAItemGetter> DL9MTongBoots02 => Construct(0x2088);
            public static FormLink<IAItemGetter> DL9MTongBoots03 => Construct(0x208f);
            public static FormLink<IAItemGetter> DL9MTongCuirass03 => Construct(0x2090);
            public static FormLink<IAItemGetter> DL9MTongGloves03 => Construct(0x2091);
            public static FormLink<IAItemGetter> DL9MTongGreaves03 => Construct(0x2092);
            public static FormLink<IAItemGetter> DL9MTongBoots04 => Construct(0x2099);
            public static FormLink<IAItemGetter> DL9MTongCuirass04 => Construct(0x209a);
            public static FormLink<IAItemGetter> DL9MTongGloves04 => Construct(0x209b);
            public static FormLink<IAItemGetter> DL9MTongGreaves04 => Construct(0x209c);
            public static FormLink<IAItemGetter> DL9MTongBoots05 => Construct(0x20a3);
            public static FormLink<IAItemGetter> DL9MTongCuirass05 => Construct(0x20a4);
            public static FormLink<IAItemGetter> DL9MTongGloves05 => Construct(0x20a5);
            public static FormLink<IAItemGetter> DL9MTongGreaves05 => Construct(0x20a6);
            public static FormLink<IAItemGetter> DL9MTongCuirass01 => Construct(0x1b89);
            public static FormLink<IAItemGetter> DL9MTongGloves01 => Construct(0x1b8a);
            public static FormLink<IAItemGetter> DL9MTongGreaves01 => Construct(0x1b8b);
            public static FormLink<IAItemGetter> DL9StewardNote => Construct(0x5fae);
            public static FormLink<IAItemGetter> DL9ApprenticeNote => Construct(0x1a62);
            public static FormLink<IAItemGetter> DL9TomeNefarivigum => Construct(0x1a76);
            public static FormLink<IAItemGetter> DL9TransmuteGoldSCROLL => Construct(0x14ba);
            public static FormLink<IAItemGetter> DL9FinalLetter => Construct(0xd81);
            public static FormLink<IAItemGetter> DL9StewardRegistry => Construct(0x1995);
            public static FormLink<IAItemGetter> DL9DrathonJournal => Construct(0x148a);
            public static FormLink<IAItemGetter> DL9NefarivigumLore => Construct(0x14a2);
            public static FormLink<IAItemGetter> DL9receipt => Construct(0x14a7);
            public static FormLink<IAItemGetter> DL9StewardDiary => Construct(0x1582);
            public static FormLink<IAItemGetter> DL9MoragTongWrit => Construct(0x2532);
            public static FormLink<IAItemGetter> DL9JailorNote => Construct(0x1ac0);
            public static FormLink<IAItemGetter> DL9ApprenticeLetter => Construct(0x1a60);
            public static FormLink<IAItemGetter> DL9DrothmeriTunicSoldier => Construct(0x14cb);
            public static FormLink<IAItemGetter> DL9TongHood01 => Construct(0x1b42);
            public static FormLink<IAItemGetter> DL9TongHood04 => Construct(0x2098);
            public static FormLink<IAItemGetter> DL9DrothanHood01 => Construct(0x5fd6);
            public static FormLink<IAItemGetter> DL9DrothanRobe01 => Construct(0x5fd8);
            public static FormLink<IAItemGetter> DL9DrothanHood02 => Construct(0x5fd9);
            public static FormLink<IAItemGetter> DL9DrothanHood03 => Construct(0x5fda);
            public static FormLink<IAItemGetter> DL9DrothanHood04 => Construct(0x5fdb);
            public static FormLink<IAItemGetter> DL9DrothanHood05 => Construct(0x5fdc);
            public static FormLink<IAItemGetter> DL9DrothanRobe02 => Construct(0x5fdd);
            public static FormLink<IAItemGetter> DL9DrothanRobe03 => Construct(0x5fde);
            public static FormLink<IAItemGetter> DL9DrothanRobe04 => Construct(0x5fdf);
            public static FormLink<IAItemGetter> DL9DrothanRobe05 => Construct(0x5fe0);
            public static FormLink<IAItemGetter> DL9ForgeMasterAmulet02 => Construct(0x2742);
            public static FormLink<IAItemGetter> DL9ForgeMasterAmulet03 => Construct(0x2744);
            public static FormLink<IAItemGetter> DL9ForgeMasterApron02 => Construct(0x2745);
            public static FormLink<IAItemGetter> DL9ForgeMasterApron03 => Construct(0x2746);
            public static FormLink<IAItemGetter> DL9DrothmeriTunicVeteran => Construct(0x14cc);
            public static FormLink<IAItemGetter> DL9TongHood03 => Construct(0x208e);
            public static FormLink<IAItemGetter> DL9TongHood02 => Construct(0x1b92);
            public static FormLink<IAItemGetter> DL9ForgeMasterAmulet01 => Construct(0x2736);
            public static FormLink<IAItemGetter> DL9ForgeMasterApron01 => Construct(0x2738);
            public static FormLink<IAItemGetter> DL9DrothmeriTunicRecruit => Construct(0x14ca);
            public static FormLink<IAItemGetter> DL9TongHood05 => Construct(0x20a2);
            public static FormLink<IAItemGetter> DL9HumanHeart => Construct(0x1af2);
            public static FormLink<IAItemGetter> DL9ForgeFire384Pulse => Construct(0x45c5);
            public static FormLink<IAItemGetter> DL9DaedricAmb => Construct(0x1aed);
            public static FormLink<IAItemGetter> DL9Lectern => Construct(0x1980);
            public static FormLink<IAItemGetter> DL9Gem0IronNugget => Construct(0x14c0);
            public static FormLink<IAItemGetter> DL9Bezoar01 => Construct(0x1a16);
            public static FormLink<IAItemGetter> DL9EmptyFlask => Construct(0xdb7);
            public static FormLink<IAItemGetter> DL9ChampAxe02 => Construct(0x272b);
            public static FormLink<IAItemGetter> DL9ChampAxe03 => Construct(0x272f);
            public static FormLink<IAItemGetter> DL9ChampAxe04 => Construct(0x2730);
            public static FormLink<IAItemGetter> DL9ChampAxe05 => Construct(0x2731);
            public static FormLink<IAItemGetter> DL9ChampAxe06 => Construct(0x2732);
            public static FormLink<IAItemGetter> DL9ChampAxe07 => Construct(0x2734);
            public static FormLink<IAItemGetter> DL9ChampAxe08 => Construct(0x2735);
            public static FormLink<IAItemGetter> DL9LostHoe => Construct(0x49b7);
            public static FormLink<IAItemGetter> DL9RockPick => Construct(0x274a);
            public static FormLink<IAItemGetter> DL9RockRake => Construct(0x274b);
            public static FormLink<IAItemGetter> DL9MehrunesRazor02 => Construct(0x5fb8);
            public static FormLink<IAItemGetter> DL9MehrunesRazor03 => Construct(0x5fb9);
            public static FormLink<IAItemGetter> DL9MehrunesRazor04 => Construct(0x5fba);
            public static FormLink<IAItemGetter> DL9MehrunesRazor05 => Construct(0x5fbb);
            public static FormLink<IAItemGetter> DL9MehrunesRazor06 => Construct(0x5fbc);
            public static FormLink<IAItemGetter> DL9MehrunesRazor07 => Construct(0x5fbd);
            public static FormLink<IAItemGetter> DL9MehrunesRazor08 => Construct(0x5fbe);
            public static FormLink<IAItemGetter> DL9MehrunesRazor01 => Construct(0x1ab0);
            public static FormLink<IAItemGetter> DL9ChampAxe01 => Construct(0xb555);
            public static FormLink<IAItemGetter> DL9DrothanClosetKey => Construct(0x14fc);
            public static FormLink<IAItemGetter> DL9TrichoBezoarPotion => Construct(0x1493);
            public static FormLink<IAItemGetter> DL9FortifBlade => Construct(0x5654);
            public static FormLink<IAItemGetter> DL9MTongGreavesList => Construct(0x20ab);
            public static FormLink<IAItemGetter> DL9Torch30 => Construct(0x1b32);
            public static FormLink<IAItemGetter> DL9ForgeAmulets => Construct(0x2747);
            public static FormLink<IAItemGetter> DL9ForgeSmocks => Construct(0x2748);
            public static FormLink<IAItemGetter> DL9ChampAxeList => Construct(0x2737);
            public static FormLink<IAItemGetter> DL9MTongHoodList => Construct(0x20a7);
            public static FormLink<IAItemGetter> DL9MehrunesRazor => Construct(0x5fbf);
            public static FormLink<IAItemGetter> DL9MTongCuirassList => Construct(0x20a8);
            public static FormLink<IAItemGetter> DL9LaborerWeapons75 => Construct(0x274c);
            public static FormLink<IAItemGetter> DL9DrothanRobeList => Construct(0x5fe1);
            public static FormLink<IAItemGetter> DL9DrothanHoodList => Construct(0x5fe2);
            public static FormLink<IAItemGetter> DL9MTongGlovesList => Construct(0x20a9);
            public static FormLink<IAItemGetter> DL9MTongBootsList => Construct(0x20aa);
        }
    }
}
