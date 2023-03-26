// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Notifies that an existing BaseAudioContext will be destroyed. </summary>
    public partial class EventContextWillBeDestroyedParams
    {
        /// <summary> Initializes a new instance of EventContextWillBeDestroyedParams. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextId"/> is null. </exception>
        public EventContextWillBeDestroyedParams(string contextId)
        {
            Argument.AssertNotNull(contextId, nameof(contextId));

            ContextId = contextId;
        }

        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ContextId { get; set; }
    }
}
