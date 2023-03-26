// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when WebSocket handshake response becomes available. </summary>
    public partial class EventWebSocketHandshakeResponseReceivedParams
    {
        /// <summary> Initializes a new instance of EventWebSocketHandshakeResponseReceivedParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="response"> WebSocket response data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> or <paramref name="response"/> is null. </exception>
        public EventWebSocketHandshakeResponseReceivedParams(string requestId, float timestamp, TypeWebSocketResponse response)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(response, nameof(response));

            RequestId = requestId;
            Timestamp = timestamp;
            Response = response;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
        /// <summary> WebSocket response data. </summary>
        public TypeWebSocketResponse Response { get; set; }
    }
}
