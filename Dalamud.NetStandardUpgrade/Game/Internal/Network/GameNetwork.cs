using System;

namespace Dalamud.Game.Internal.Network
{
    public sealed class GameNetwork : IDisposable
    {
        public delegate void OnZonePacketDelegate(IntPtr dataPtr);

        public OnZonePacketDelegate OnZonePacket;

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void Dispose() {}

#if DEBUG
        public void InjectZoneProtoPacket(byte[] data)
        {
            throw new NotImplementedException();
        }
#endif

        /// <summary>
        ///     Process a chat queue.
        /// </summary>
        public void UpdateQueue(Framework framework)
        {
            throw new NotImplementedException();
        }
    }
}
