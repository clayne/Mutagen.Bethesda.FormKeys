// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class HearthFires
{
    public static partial class SoundMarker
    {
        private static FormLink<ISoundMarkerGetter> Construct(uint id) => new FormLink<ISoundMarkerGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ISoundMarkerGetter> OBJMineClay => Construct(0xba4);
    }
}
