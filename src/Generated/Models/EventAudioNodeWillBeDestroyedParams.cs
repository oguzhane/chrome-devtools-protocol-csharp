// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Notifies that an existing AudioNode has been destroyed. </summary>
    public partial class EventAudioNodeWillBeDestroyedParams
    {
        /// <summary> Initializes a new instance of EventAudioNodeWillBeDestroyedParams. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="nodeId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextId"/> or <paramref name="nodeId"/> is null. </exception>
        public EventAudioNodeWillBeDestroyedParams(string contextId, string nodeId)
        {
            Argument.AssertNotNull(contextId, nameof(contextId));
            Argument.AssertNotNull(nodeId, nameof(nodeId));

            ContextId = contextId;
            NodeId = nodeId;
        }

        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ContextId { get; set; }
        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string NodeId { get; set; }
    }
}
