using Dalamud.Game.ClientState.Actors;
using Dalamud.Game.ClientState.Actors.Types;
using System;
using System.ComponentModel;

namespace Dalamud.Game.ClientState
{
    /// <summary>
    /// This class represents the state of the game client at the time of access.
    /// </summary>
    public class ClientState : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public readonly ClientLanguage ClientLanguage;

        /// <summary>
        /// The table of all present actors.
        /// </summary>
        public readonly ActorTable Actors;

        /// <summary>
        /// The local player character, if one is present.
        /// </summary>
        public PlayerCharacter LocalPlayer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ushort TerritoryType => throw new NotImplementedException();

        /// <summary>
        /// The content ID of the local character.
        /// </summary>
        public ulong LocalContentId => throw new NotImplementedException();

        /// <summary>
        /// The class facilitating Job Gauge data access
        /// </summary>
        public JobGauges JobGauges;
    }
}
