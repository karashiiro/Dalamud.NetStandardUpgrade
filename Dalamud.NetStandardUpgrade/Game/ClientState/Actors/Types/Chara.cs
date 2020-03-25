using Dalamud.Game.ClientState.Actors.Resolvers;
using System;

namespace Dalamud.Game.ClientState.Actors.Types
{
    /// <summary>
    ///     This class represents the base for non-static entities.
    /// </summary>
    public class Chara : Actor {
        /// <summary>
        ///     The level of this Chara.
        /// </summary>
        public byte Level => throw new NotImplementedException();

        /// <summary>
        ///     The ClassJob of this Chara.
        /// </summary>
        public ClassJob ClassJob => throw new NotImplementedException();

        /// <summary>
        ///     The current HP of this Chara.
        /// </summary>
        public int CurrentHp => throw new NotImplementedException();

        /// <summary>
        ///     The maximum HP of this Chara.
        /// </summary>
        public int MaxHp => throw new NotImplementedException();

        /// <summary>
        ///     The current MP of this Chara.
        /// </summary>
        public int CurrentMp => throw new NotImplementedException();

        /// <summary>
        ///     The maximum MP of this Chara.
        /// </summary>
        public int MaxMp => throw new NotImplementedException();
    }
}
