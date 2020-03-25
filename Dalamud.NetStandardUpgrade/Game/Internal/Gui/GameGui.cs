using System;

namespace Dalamud.Game.Internal.Gui
{
    public sealed class GameGui : IDisposable
    {
        public ChatGui Chat { get; private set; }

        public void SetBgm(ushort bgmKey) => throw new NotImplementedException();

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void Dispose() {}
    }
}
