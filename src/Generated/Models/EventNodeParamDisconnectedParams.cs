// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Notifies that an AudioNode is disconnected to an AudioParam. </summary>
    public partial class EventNodeParamDisconnectedParams
    {
        /// <summary> Initializes a new instance of EventNodeParamDisconnectedParams. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="sourceId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="destinationId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextId"/>, <paramref name="sourceId"/> or <paramref name="destinationId"/> is null. </exception>
        public EventNodeParamDisconnectedParams(string contextId, string sourceId, string destinationId)
        {
            Argument.AssertNotNull(contextId, nameof(contextId));
            Argument.AssertNotNull(sourceId, nameof(sourceId));
            Argument.AssertNotNull(destinationId, nameof(destinationId));

            ContextId = contextId;
            SourceId = sourceId;
            DestinationId = destinationId;
        }

        /// <summary> Initializes a new instance of EventNodeParamDisconnectedParams. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="sourceId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="destinationId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="sourceOutputIndex"></param>
        internal EventNodeParamDisconnectedParams(string contextId, string sourceId, string destinationId, float? sourceOutputIndex)
        {
            ContextId = contextId;
            SourceId = sourceId;
            DestinationId = destinationId;
            SourceOutputIndex = sourceOutputIndex;
        }

        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ContextId { get; set; }
        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string SourceId { get; set; }
        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string DestinationId { get; set; }
        /// <summary> Gets or sets the source output index. </summary>
        public float? SourceOutputIndex { get; set; }
    }
}