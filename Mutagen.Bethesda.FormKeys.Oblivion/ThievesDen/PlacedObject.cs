using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class PlacedObject
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IPlacedObjectGetter> Construct(uint id) => new FormLink<IPlacedObjectGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedObjectGetter> DL06CaptainsQtrsParent => Construct(0x14b5);
            public static FormLink<IPlacedObjectGetter> DLC06ChestCaptainsQuartersRef => Construct(0x2ab8);
            public static FormLink<IPlacedObjectGetter> DLFirstMateChestRef => Construct(0xfd61);
            public static FormLink<IPlacedObjectGetter> DLCFletcherMarker => Construct(0xedf6);
            public static FormLink<IPlacedObjectGetter> DLCPirateHoldMarker => Construct(0x1651f);
            public static FormLink<IPlacedObjectGetter> DLC06SecurityTrainerMarker => Construct(0xedf8);
            public static FormLink<IPlacedObjectGetter> DLC06StealthTrainerMarker => Construct(0xedf5);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild04 => Construct(0xee0a);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild06 => Construct(0xee0b);
            public static FormLink<IPlacedObjectGetter> DLCFenceParent => Construct(0x1c258);
            public static FormLink<IPlacedObjectGetter> DLCSecurityParent => Construct(0x1c259);
            public static FormLink<IPlacedObjectGetter> DLCStealthParent => Construct(0x1c25a);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild01 => Construct(0xee04);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild06 => Construct(0xede9);
            public static FormLink<IPlacedObjectGetter> DLCFletcherParent => Construct(0x1c25b);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild09 => Construct(0xee10);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild10 => Construct(0xee0f);
            public static FormLink<IPlacedObjectGetter> DLClutterParent => Construct(0x1d111);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild08 => Construct(0xedeb);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight03 => Construct(0x12001);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight04 => Construct(0x12003);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild09 => Construct(0x12501);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild05 => Construct(0xecfe);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild06 => Construct(0xecf7);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild07 => Construct(0xecf8);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild08 => Construct(0xecfc);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild02 => Construct(0xed01);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild03 => Construct(0xed02);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild05 => Construct(0x12503);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild13 => Construct(0xedc7);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild14 => Construct(0xecf9);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild11 => Construct(0xecb1);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild01 => Construct(0x12502);
            public static FormLink<IPlacedObjectGetter> DLCFletcherChild20 => Construct(0xecb2);
            public static FormLink<IPlacedObjectGetter> DLCStealthChild04 => Construct(0xed00);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild12 => Construct(0xedc8);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild => Construct(0xedd2);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild02 => Construct(0xedd3);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild03 => Construct(0xed65);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild02 => Construct(0xecfd);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild05 => Construct(0xecfa);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild03 => Construct(0xeca8);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild07 => Construct(0xecfb);
            public static FormLink<IPlacedObjectGetter> DLCSecurityChild08 => Construct(0xeca9);
            public static FormLink<IPlacedObjectGetter> DLCFLetcherChild04 => Construct(0xecff);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight11 => Construct(0xed8e);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight10 => Construct(0xed8d);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight09 => Construct(0x11ff9);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight08 => Construct(0x11ff8);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight07 => Construct(0xed90);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight06 => Construct(0x12002);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight12 => Construct(0x11ff6);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight05 => Construct(0x12005);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight13 => Construct(0x12000);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight14 => Construct(0x11ffa);
            public static FormLink<IPlacedObjectGetter> DunbarrowMainLight02 => Construct(0x11fff);
            public static FormLink<IPlacedObjectGetter> DLC06CaptainsChest => Construct(0xeea7);
            public static FormLink<IPlacedObjectGetter> DLCCaptainsQtrsParent => Construct(0x1ee80);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild02 => Construct(0xeea1);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild01 => Construct(0xee9a);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild09 => Construct(0xee9f);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild08 => Construct(0xee89);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild07 => Construct(0xee83);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild06 => Construct(0xee98);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild05 => Construct(0x1a4f1);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild04 => Construct(0x1a4f2);
            public static FormLink<IPlacedObjectGetter> DLCaptainsQtrsChild03 => Construct(0xeea0);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild35 => Construct(0xec8a);
            public static FormLink<IPlacedObjectGetter> DLDunbarrowRedSaber01 => Construct(0x18297);
            public static FormLink<IPlacedObjectGetter> DLCSupplierParent => Construct(0x1c744);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild03 => Construct(0xebe4);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild02 => Construct(0xebe3);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild01 => Construct(0xebe2);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild34 => Construct(0xebce);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild33 => Construct(0xebcf);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild32 => Construct(0xebd0);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild31 => Construct(0xebca);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild30 => Construct(0xebcb);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild29 => Construct(0xebcc);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild28 => Construct(0xebcd);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild27 => Construct(0xebc9);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild26 => Construct(0xebde);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild25 => Construct(0xebe0);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild24 => Construct(0xebdf);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild23 => Construct(0xebd3);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild22 => Construct(0xebd4);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild21 => Construct(0xebd5);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild20 => Construct(0xebdb);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild19 => Construct(0xebdd);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild18 => Construct(0xebdc);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild17 => Construct(0xebd7);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild6 => Construct(0xec50);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild15 => Construct(0xebd8);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild14 => Construct(0xebd9);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild13 => Construct(0xebda);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild12 => Construct(0xebd6);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild11 => Construct(0xec4c);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild36 => Construct(0xebc1);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild10 => Construct(0xebc4);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild09 => Construct(0xec5f);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild08 => Construct(0xec5e);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild07 => Construct(0xec5d);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild06 => Construct(0xebc5);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild05 => Construct(0xec60);
            public static FormLink<IPlacedObjectGetter> DLCSupplierChild04 => Construct(0xebd2);
            public static FormLink<IPlacedObjectGetter> DL06SecurityTrainerParent => Construct(0x349d);
            public static FormLink<IPlacedObjectGetter> DLC06ClutterParent => Construct(0x74ca);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker1 => Construct(0x3e7e);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker2 => Construct(0x3e7d);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker3 => Construct(0x3e7a);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker4 => Construct(0x3e7b);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker6 => Construct(0x3e79);
            public static FormLink<IPlacedObjectGetter> DLC06EatMarker => Construct(0x3eab);
            public static FormLink<IPlacedObjectGetter> DLCTrainerChestRef => Construct(0x348e);
            public static FormLink<IPlacedObjectGetter> DL06StealthTrainerParent => Construct(0x3e78);
            public static FormLink<IPlacedObjectGetter> DLC06FletcherParent => Construct(0x3e80);
            public static FormLink<IPlacedObjectGetter> DLC06FenceParent => Construct(0x3e83);
            public static FormLink<IPlacedObjectGetter> DLCHideAndSeekMarker5 => Construct(0xdb6);
            public static FormLink<IPlacedObjectGetter> DLCPirateGoMarker => Construct(0x16518);
            public static FormLink<IPlacedObjectGetter> ShipInteriorParentREF => Construct(0x1aff);
            public static FormLink<IPlacedObjectGetter> DL06LowerShipREF => Construct(0x1b14);
            public static FormLink<IPlacedObjectGetter> DL06MidShipREF => Construct(0x1b13);
            public static FormLink<IPlacedObjectGetter> DLC06SupplierParent => Construct(0xb550);
            public static FormLink<IPlacedObjectGetter> DLC06SupplierParent2 => Construct(0x206b);
            public static FormLink<IPlacedObjectGetter> DLCDunbarrowMapMarker => Construct(0x1a4f3);
        }
    }
}
