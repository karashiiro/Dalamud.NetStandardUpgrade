﻿namespace Dalamud.Game.Chat.SeStringHandling
{
    /// <summary>
    /// All parsed types of SeString payloads.
    /// </summary>
    public enum PayloadType
    {
        /// <summary>
        /// An SeString payload representing a player link.
        /// </summary>
        Player,
        /// <summary>
        /// An SeString payload representing an Item link.
        /// </summary>
        Item,
        /// <summary>
        /// An SeString payload representing an Status Effect link.
        /// </summary>
        Status,
        /// <summary>
        /// An SeString payload representing raw, typed text.
        /// </summary>
        RawText,
        /// <summary>
        /// An SeString payload representing any data we don't handle.
        /// </summary>
        Unknown
    }
}
