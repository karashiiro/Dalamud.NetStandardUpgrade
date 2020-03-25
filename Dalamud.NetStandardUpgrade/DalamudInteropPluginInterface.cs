using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.Command;
using Dalamud.Game.Internal;
using Dalamud.Interface;
using System;

namespace Dalamud.NetStandardUpgrade
{
    public class DalamudInteropPluginInterface : IDisposable
    {
        /// <summary>
        /// The CommandManager object that allows you to add and remove custom chat commands.
        /// </summary>
        public readonly CommandManager CommandManager;

        /// <summary>
        /// The ClientState object that allows you to access current client memory information like actors, territories, etc.
        /// </summary>
        public readonly ClientState ClientState;

        /// <summary>
        /// The Framework object that allows you to interact with the client.
        /// </summary>
        public readonly Framework Framework;

        /// <summary>
		/// A <see cref="UiBuilder">UiBuilder</see> instance which allows you to draw UI into the game via ImGui draw calls.
        /// </summary>
        public readonly UiBuilder UiBuilder;

        /// <summary>
        /// A <see cref="SigScanner">SigScanner</see> instance targeting the main module of the FFXIV process.
        /// </summary>
        public readonly SigScanner TargetModuleScanner;

        /// <summary>
        /// A <see cref="DataManager">DataManager</see> instance which allows you to access game data needed by the main dalamud features.
        /// </summary>
        public readonly DataManager Data;

        /// <summary>
        /// Unregister your plugin and dispose all references. You have to call this when your IDalamudCorePlugin is disposed.
        /// </summary>
        public void Dispose()
        {
            UiBuilder.Dispose();
        }

        // Configuration somehow

        #region Logging

        /// <summary>
        /// Log a templated message to the in-game debug log.
        /// </summary>
        /// <param name="messageTemplate">The message template.</param>
        /// <param name="values">Values to log.</param>
        public void Log(string messageTemplate, params object[] values)
        {
        }

        /// <summary>
        /// Log a templated error message to the in-game debug log.
        /// </summary>
        /// <param name="messageTemplate">The message template.</param>
        /// <param name="values">Values to log.</param>
        public void LogError(string messageTemplate, params object[] values)
        {
        }

        /// <summary>
        /// Log a templated error message to the in-game debug log.
        /// </summary>
        /// <param name="exception">The exception that caused the error.</param>
        /// <param name="messageTemplate">The message template.</param>
        /// <param name="values">Values to log.</param>
        public void LogError(Exception exception, string messageTemplate, params object[] values)
        {
        }

        #endregion
    }
}
