using Dalamud.Game.ClientState.Actors.Resolvers;
using System;

namespace Dalamud.Game.ClientState.Actors.Types
{
    /// <summary>
    ///     This class represents a player character.
    /// </summary>
    public class PlayerCharacter : Chara
    {
        /// <summary>
        ///     The current <see cref="World">world</see> of the character.
        /// </summary>
        public World CurrentWorld => throw new NotImplementedException();

        /// <summary>
        ///     The home <see cref="World">world</see> of the character.
        /// </summary>
        public World HomeWorld => throw new NotImplementedException();
    }
}
