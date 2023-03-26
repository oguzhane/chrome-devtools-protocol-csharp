// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when resource loading priority is changed. </summary>
    public partial class EventResourceChangedPriorityParams
    {
        /// <summary> Initializes a new instance of EventResourceChangedPriorityParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="newPriority"> New priority. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> or <paramref name="newPriority"/> is null. </exception>
        public EventResourceChangedPriorityParams(string requestId, string newPriority, float timestamp)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(newPriority, nameof(newPriority));

            RequestId = requestId;
            NewPriority = newPriority;
            Timestamp = timestamp;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> New priority. </summary>
        public string NewPriority { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
    }
}