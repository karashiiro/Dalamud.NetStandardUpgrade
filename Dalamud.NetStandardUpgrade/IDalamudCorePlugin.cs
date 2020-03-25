using System;

namespace Dalamud.NetStandardUpgrade
{
    /// <summary>
    /// This interface represents a Dalamud interop plugin. All plugins have to implement this interface.
    /// </summary>
    public interface IDalamudCorePlugin : IDisposable
    {
        /// <summary>
        /// The name of the plugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Initializes a Dalamud plugin.
        /// </summary>
        /// <param name="pluginInterface">The <see cref="DalamudInteropPluginInterface"/> needed to access various Dalamud objects.</param>
        void Initialize(DalamudInteropPluginInterface pluginInterface);
    }
}
