using System;

namespace Dalamud.Game.Internal.Libc
{
    public sealed class OwnedStdString : IDisposable
    {
        public IntPtr Address { get; private set; }

        public void Dispose() {}

        public StdString Read()
        {
            throw new NotImplementedException();
        }
    }
}
