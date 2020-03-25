namespace Dalamud.Game.Chat.SeStringHandling
{
    /// <summary>
    /// This class represents a parsed SeString payload.
    /// </summary>
    public abstract class Payload
    {
        public abstract PayloadType Type { get; }

        public abstract void Resolve();

        public abstract byte[] Encode();
    }
}
