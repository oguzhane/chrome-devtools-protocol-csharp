// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when WebSocket message error occurs. </summary>
    public partial class EventWebSocketFrameErrorParams
    {
        /// <summary> Initializes a new instance of EventWebSocketFrameErrorParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="errorMessage"> WebSocket error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> or <paramref name="errorMessage"/> is null. </exception>
        public EventWebSocketFrameErrorParams(string requestId, float timestamp, string errorMessage)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(errorMessage, nameof(errorMessage));

            RequestId = requestId;
            Timestamp = timestamp;
            ErrorMessage = errorMessage;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
        /// <summary> WebSocket error message. </summary>
        public string ErrorMessage { get; set; }
    }
}