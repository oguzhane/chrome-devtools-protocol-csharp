// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when WebSocket is about to initiate handshake. </summary>
    public partial class EventWebSocketWillSendHandshakeRequestParams
    {
        /// <summary> Initializes a new instance of EventWebSocketWillSendHandshakeRequestParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="wallTime"> UTC Timestamp. </param>
        /// <param name="request"> WebSocket request data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> or <paramref name="request"/> is null. </exception>
        public EventWebSocketWillSendHandshakeRequestParams(string requestId, float timestamp, float wallTime, TypeWebSocketRequest request)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(request, nameof(request));

            RequestId = requestId;
            Timestamp = timestamp;
            WallTime = wallTime;
            Request = request;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
        /// <summary> UTC Timestamp. </summary>
        public float WallTime { get; set; }
        /// <summary> WebSocket request data. </summary>
        public TypeWebSocketRequest Request { get; set; }
    }
}
