// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Protocol object for BaseAudioContext. </summary>
    public partial class TypeBaseAudioContext
    {
        /// <summary> Initializes a new instance of TypeBaseAudioContext. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="contextType"> Enum of BaseAudioContext types. </param>
        /// <param name="contextState"> Enum of AudioContextState from the spec. </param>
        /// <param name="callbackBufferSize"> Platform-dependent callback buffer size. </param>
        /// <param name="maxOutputChannelCount"> Number of output channels supported by audio hardware in use. </param>
        /// <param name="sampleRate"> Context sample rate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextId"/>, <paramref name="contextType"/> or <paramref name="contextState"/> is null. </exception>
        public TypeBaseAudioContext(string contextId, string contextType, string contextState, float callbackBufferSize, float maxOutputChannelCount, float sampleRate)
        {
            Argument.AssertNotNull(contextId, nameof(contextId));
            Argument.AssertNotNull(contextType, nameof(contextType));
            Argument.AssertNotNull(contextState, nameof(contextState));

            ContextId = contextId;
            ContextType = contextType;
            ContextState = contextState;
            CallbackBufferSize = callbackBufferSize;
            MaxOutputChannelCount = maxOutputChannelCount;
            SampleRate = sampleRate;
        }

        /// <summary> Initializes a new instance of TypeBaseAudioContext. </summary>
        /// <param name="contextId"> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </param>
        /// <param name="contextType"> Enum of BaseAudioContext types. </param>
        /// <param name="contextState"> Enum of AudioContextState from the spec. </param>
        /// <param name="realtimeData"> Fields in AudioContext that change in real-time. </param>
        /// <param name="callbackBufferSize"> Platform-dependent callback buffer size. </param>
        /// <param name="maxOutputChannelCount"> Number of output channels supported by audio hardware in use. </param>
        /// <param name="sampleRate"> Context sample rate. </param>
        internal TypeBaseAudioContext(string contextId, string contextType, string contextState, TypeContextRealtimeData realtimeData, float callbackBufferSize, float maxOutputChannelCount, float sampleRate)
        {
            ContextId = contextId;
            ContextType = contextType;
            ContextState = contextState;
            RealtimeData = realtimeData;
            CallbackBufferSize = callbackBufferSize;
            MaxOutputChannelCount = maxOutputChannelCount;
            SampleRate = sampleRate;
        }

        /// <summary> An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API. </summary>
        public string ContextId { get; set; }
        /// <summary> Enum of BaseAudioContext types. </summary>
        public string ContextType { get; set; }
        /// <summary> Enum of AudioContextState from the spec. </summary>
        public string ContextState { get; set; }
        /// <summary> Fields in AudioContext that change in real-time. </summary>
        public TypeContextRealtimeData RealtimeData { get; set; }
        /// <summary> Platform-dependent callback buffer size. </summary>
        public float CallbackBufferSize { get; set; }
        /// <summary> Number of output channels supported by audio hardware in use. </summary>
        public float MaxOutputChannelCount { get; set; }
        /// <summary> Context sample rate. </summary>
        public float SampleRate { get; set; }
    }
}
