using System;

namespace Dalamud.Game.Internal
{
    public sealed class FrameworkAddressResolver : BaseAddressResolver
    {
        public IntPtr BaseAddress { get; private set; }
        
        public IntPtr GuiManager { get; private set; }
        
        public IntPtr ScriptManager { get; private set; }
    }
}
