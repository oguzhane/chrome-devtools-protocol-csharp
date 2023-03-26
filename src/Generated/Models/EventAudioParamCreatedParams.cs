// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Notifies that a new AudioParam has been created. </summary>
    public partial class EventAudioParamCreatedParams
    {
        /// <summary> Initializes a new instance of EventAudioParamCreatedParams. </summary>
        /// <param name="param"> Protocol object for AudioParam. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="param"/> is null. </exception>
        public EventAudioParamCreatedParams(TypeAudioParam param)
        {
            Argument.AssertNotNull(param, nameof(param));

            Param = param;
        }

        /// <summary> Protocol object for AudioParam. </summary>
        public TypeAudioParam Param { get; set; }
    }
}