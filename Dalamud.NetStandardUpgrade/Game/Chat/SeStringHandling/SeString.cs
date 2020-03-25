using System;
using System.Collections.Generic;

namespace Dalamud.Game.Chat.SeStringHandling
{
    /// <summary>
    /// This class represents a parsed SeString.
    /// </summary>
    public class SeString
    {
        public List<Payload> Payloads { get; }

        /// <summary>
        /// Helper function to get all raw text from a message as a single joined string
        /// </summary>
        /// <returns>
        /// All the raw text from the contained payloads, joined into a single string
        /// </returns>
        public string TextValue
        {
            get {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Parse an array of bytes to a SeString.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static SeString Parse(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Encode a parsed/created SeString to an array of bytes, to be used for injection.
        /// </summary>
        /// <param name="payloads"></param>
        /// <returns>The bytes of the message.</returns>
        public byte[] Encode()
        {
            throw new NotImplementedException();
        }
    }
}
