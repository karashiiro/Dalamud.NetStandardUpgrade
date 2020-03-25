using Dalamud.Game.Internal.Gui;
using Dalamud.Game.Internal.Libc;
using Dalamud.Game.Internal.Network;
using System;

namespace Dalamud.Game.Internal
{
    /// <summary>
    /// This class represents the Framework of the native game client and grants access to various subsystems.
    /// </summary>
    public sealed class Framework : IDisposable
    {
        public delegate void OnUpdateDelegate(Framework framework);

        public event OnUpdateDelegate OnUpdateEvent;
        
        /// <summary>
        /// A raw pointer to the instance of Client::Framework
        /// </summary>
        public FrameworkAddressResolver Address { get; }
        
        #region Subsystems

        /// <summary>
        /// The GUI subsystem, used to access e.g. chat.
        /// </summary>
        public GameGui Gui { get; private set; }

        /// <summary>
        /// The Network subsystem, used to access network data.
        /// </summary>
        public GameNetwork Network { get; private set; }

        //public ResourceManager Resource { get; private set; }
        
        public LibcFunction Libc { get; private set; }

        #endregion
        
        public void Enable()
        {
            throw new NotImplementedException();
        }
        
        public void Dispose() {}
    }
}
