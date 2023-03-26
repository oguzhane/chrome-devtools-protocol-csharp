// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Notifies that a new AudioListener has been created. </summary>
    public partial class EventAudioListenerWillBeDestroyedParams
    {
        /// <summary> Initializes a new instance of EventAudioListenerWillBeDestroyedParams. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="listenerId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextId"/> or <paramref name="listenerId"/> is null. </exception>
        public EventAudioListenerWillBeDestroyedParams(string contextId, string listenerId)
        {
            Argument.AssertNotNull(contextId, nameof(contextId));
            Argument.AssertNotNull(listenerId, nameof(listenerId));

            ContextId = contextId;
            ListenerId = listenerId;
        }

        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ContextId { get; set; }
        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ListenerId { get; set; }
    }
}
