using Dalamud.Game.ClientState.Actors;

namespace Dalamud.Game.ClientState.Structs
{
    public struct Actor
    {
        public string Name;
        public int ActorId;
        public int DataId;
        public int OwnerId;
        public ObjectKind ObjectKind;
        public byte SubKind;
        public bool IsFriendly;
        public Position3 Position;
        public byte CurrentWorld;
        public byte HomeWorld;
        public int CurrentHp;
        public int MaxHp;
        public int CurrentMp;
        public int MaxMp;
        public byte ClassJob;
        public byte Level;
    }
}
