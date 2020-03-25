using Dalamud.Game.ClientState.Actors.Types;
using System;
using System.Collections;

namespace Dalamud.Game.ClientState.Actors
{
    /// <summary>
    ///     This collection represents the currently spawned FFXIV actors.
    /// </summary>
    public class ActorTable : ICollection
    {
        /// <summary>
        ///     Get an actor at the specified spawn index.
        /// </summary>
        /// <param name="index">Spawn index.</param>
        /// <returns><see cref="Actor" /> at the specified spawn index.</returns>
        public Actor this[int index]
        {
            get {
                throw new NotImplementedException();
            }
        }

        private class ActorTableEnumerator : IEnumerator {
            public ActorTableEnumerator(ActorTable table)
            {
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public object Current => throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator() {
            return new ActorTableEnumerator(this);
        }

        /// <summary>
        ///     The amount of currently spawned actors.
        /// </summary>
        public int Length => throw new NotImplementedException();

        int ICollection.Count => Length;

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => this;

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
