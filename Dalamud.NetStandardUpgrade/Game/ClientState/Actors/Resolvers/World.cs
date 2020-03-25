using System;

namespace Dalamud.Game.ClientState.Actors.Resolvers
{
    /// <summary>
    /// This object represents a world a character can reside on.
    /// </summary>
    public class World : BaseResolver
    {
        /// <summary>
        /// ID of the world.
        /// </summary>
        public readonly int Id;

        /// <summary>
        /// GameData linked to this world.
        /// </summary>
        public Lumina.Excel.GeneratedSheets.World GameData => throw new NotImplementedException();
    }
}
