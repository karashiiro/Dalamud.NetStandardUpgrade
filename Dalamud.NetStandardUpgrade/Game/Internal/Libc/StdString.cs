using System;

namespace Dalamud.Game.Internal.Libc
{
    public class StdString
    {
        public static StdString ReadFromPointer(IntPtr cstring)
        {
            throw new NotImplementedException();
        }

        public string Value { get; private set; }

        public byte[] RawData { get; set; }
    }
}
