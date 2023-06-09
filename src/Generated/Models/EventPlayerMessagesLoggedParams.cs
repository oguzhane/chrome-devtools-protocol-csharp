// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Send a list of any messages that need to be delivered. </summary>
    public partial class EventPlayerMessagesLoggedParams
    {
        /// <summary> Initializes a new instance of EventPlayerMessagesLoggedParams. </summary>
        /// <param name="playerId"> Players will get an ID that is unique within the agent context. </param>
        /// <param name="messages"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="playerId"/> or <paramref name="messages"/> is null. </exception>
        public EventPlayerMessagesLoggedParams(string playerId, IEnumerable<TypePlayerMessage> messages)
        {
            Argument.AssertNotNull(playerId, nameof(playerId));
            Argument.AssertNotNull(messages, nameof(messages));

            PlayerId = playerId;
            Messages = messages.ToList();
        }

        /// <summary> Initializes a new instance of EventPlayerMessagesLoggedParams. </summary>
        /// <param name="playerId"> Players will get an ID that is unique within the agent context. </param>
        /// <param name="messages"></param>
        internal EventPlayerMessagesLoggedParams(string playerId, IList<TypePlayerMessage> messages)
        {
            PlayerId = playerId;
            Messages = messages;
        }

        /// <summary> Players will get an ID that is unique within the agent context. </summary>
        public string PlayerId { get; set; }
        /// <summary> Gets the messages. </summary>
        public IList<TypePlayerMessage> Messages { get; }
    }
}
