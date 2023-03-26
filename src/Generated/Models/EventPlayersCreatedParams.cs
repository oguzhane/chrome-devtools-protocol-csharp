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
    /// <summary>
    /// Called whenever a player is created, or when a new agent joins and receives
    /// a list of active players. If an agent is restored, it will receive the full
    /// list of player ids and all events again.
    /// </summary>
    public partial class EventPlayersCreatedParams
    {
        /// <summary> Initializes a new instance of EventPlayersCreatedParams. </summary>
        /// <param name="players"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="players"/> is null. </exception>
        public EventPlayersCreatedParams(IEnumerable<string> players)
        {
            Argument.AssertNotNull(players, nameof(players));

            Players = players.ToList();
        }

        /// <summary> Initializes a new instance of EventPlayersCreatedParams. </summary>
        /// <param name="players"></param>
        internal EventPlayersCreatedParams(IList<string> players)
        {
            Players = players;
        }

        /// <summary> Gets the players. </summary>
        public IList<string> Players { get; }
    }
}
