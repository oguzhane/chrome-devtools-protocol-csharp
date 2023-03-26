// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when EventSource message is received. </summary>
    public partial class EventSourceMessageReceivedParams
    {
        /// <summary> Initializes a new instance of EventSourceMessageReceivedParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="eventName"> Message type. </param>
        /// <param name="eventId"> Message identifier. </param>
        /// <param name="data"> Message content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/>, <paramref name="eventName"/>, <paramref name="eventId"/> or <paramref name="data"/> is null. </exception>
        public EventSourceMessageReceivedParams(string requestId, float timestamp, string eventName, string eventId, string data)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(eventName, nameof(eventName));
            Argument.AssertNotNull(eventId, nameof(eventId));
            Argument.AssertNotNull(data, nameof(data));

            RequestId = requestId;
            Timestamp = timestamp;
            EventName = eventName;
            EventId = eventId;
            Data = data;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
        /// <summary> Message type. </summary>
        public string EventName { get; set; }
        /// <summary> Message identifier. </summary>
        public string EventId { get; set; }
        /// <summary> Message content. </summary>
        public string Data { get; set; }
    }
}
