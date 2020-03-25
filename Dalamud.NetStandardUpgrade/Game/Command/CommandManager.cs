using System;
using System.Collections.ObjectModel;

namespace Dalamud.Game.Command
{
    /// <summary>
    /// This class manages registered in-game slash commands.
    /// </summary>
    public sealed class CommandManager {
        /// <summary>
        /// Read-only list of all registered commands.
        /// </summary>
        public ReadOnlyDictionary<string, CommandInfo> Commands => throw new NotImplementedException();

        /// <summary>
        /// Dispatch the handling of a command.
        /// </summary>
        /// <param name="command">The command to dispatch.</param>
        /// <param name="argument">The provided arguments.</param>
        /// <param name="info">A <see cref="CommandInfo"/> object describing this command.</param>
        public void DispatchCommand(string command, string argument, CommandInfo info)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a command handler, which you can use to add your own custom commands to the in-game chat.
        /// </summary>
        /// <param name="command">The command to register.</param>
        /// <param name="info">A <see cref="CommandInfo"/> object describing the command.</param>
        /// <returns>If adding was successful.</returns>
        public bool AddHandler(string command, CommandInfo info)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove a command from the command handlers.
        /// </summary>
        /// <param name="command">The command to remove.</param>
        /// <returns>If the removal was successful.</returns>
        public bool RemoveHandler(string command)
        {
            throw new NotImplementedException();
        }
    }
}
