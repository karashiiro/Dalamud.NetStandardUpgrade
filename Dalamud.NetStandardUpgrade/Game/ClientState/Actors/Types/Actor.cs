using System;

namespace Dalamud.Game.ClientState.Actors.Types
{
    /// <summary>
    ///     This class represents a basic FFXIV actor.
    /// </summary>
    public class Actor {
        /// <summary>
        ///     Position of this <see cref="Actor" />.
        /// </summary>
        public Position3 Position => throw new NotImplementedException();

        /// <summary>
        ///     Displayname of this <see cref="Actor">Actor</see>.
        /// </summary>
        public string Name => throw new NotImplementedException();

        /// <summary>
        ///     Actor ID of this <see cref="Actor" />.
        /// </summary>
        public int ActorId => throw new NotImplementedException();

        /// <summary>
        ///     Entity kind of this <see cref="Actor">actor</see>. See <see cref="ObjectKind">the ObjectKind enum</see> for
        ///     possible values.
        /// </summary>
        public ObjectKind ObjectKind => throw new NotImplementedException();
    }
}
