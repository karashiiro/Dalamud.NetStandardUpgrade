using Dalamud.Game.Chat;
using Dalamud.Game.Chat.SeStringHandling;
using Dalamud.Game.Internal.Libc;
using System;
using System.Text;

namespace Dalamud.Game.Internal.Gui
{
    public sealed class ChatGui : IDisposable
    {
        public delegate void OnMessageDelegate(XivChatType type, uint senderId, ref SeString sender, ref SeString message,
                                               ref bool isHandled);

        public delegate void OnMessageRawDelegate(XivChatType type, uint senderId, ref StdString sender, ref StdString message,
                                               ref bool isHandled);

        public event OnMessageDelegate OnChatMessage;
        [Obsolete("Please use OnChatMessage instead. For modifications, it will take precedence.")]
        public event OnMessageRawDelegate OnChatMessageRaw;

        public int LastLinkedItemId { get; private set; }
        public byte LastLinkedItemFlags { get; private set; }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void Dispose() {}

        /// <summary>
        ///     Queue a chat message. While method is named as PrintChat, it only add a entry to the queue,
        ///     later to be processed when UpdateQueue() is called.
        /// </summary>
        /// <param name="chat">A message to send.</param>
        public void PrintChat(XivChatEntry chat)
        {
            throw new NotImplementedException();
        }

        public void Print(string message)
        {
            PrintChat(new XivChatEntry {
                MessageBytes = Encoding.UTF8.GetBytes(message)
            });
        }

        public void PrintError(string message)
        {
            PrintChat(new XivChatEntry {
                MessageBytes = Encoding.UTF8.GetBytes(message),
                Type = XivChatType.Urgent
            });
        }

        /// <summary>
        ///     Process a chat queue.
        /// </summary>
        public void UpdateQueue(Framework framework)
        {
            throw new NotImplementedException();
        }
    }
}
