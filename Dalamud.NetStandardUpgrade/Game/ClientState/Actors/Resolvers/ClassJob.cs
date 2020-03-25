using System;

namespace Dalamud.Game.ClientState.Actors.Resolvers
{
    /// <summary>
    /// This object represents a class or job.
    /// </summary>
    public class ClassJob : BaseResolver
    {
        /// <summary>
        /// ID of the ClassJob.
        /// </summary>
        public readonly int Id;

        /// <summary>
        /// GameData linked to this ClassJob.
        /// </summary>
        public Lumina.Excel.GeneratedSheets.ClassJob GameData => throw new NotImplementedException();
    }
}
