// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class ShatteredSpace
{
    public static partial class SoundEchoMarker
    {
        private static FormLink<ISoundEchoMarkerGetter> Construct(uint id) => new FormLink<ISoundEchoMarkerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundEchoMarkerGetter> SFBGS001_QST_LC07_Ext_Rumble_Debris_EchoMarker => Construct(0x12d89f);
        public static FormLink<ISoundEchoMarkerGetter> SFBGS001_QST_LC07_Ext_Rumble_Metal_EchoMarker => Construct(0x12d8a0);
    }
}
