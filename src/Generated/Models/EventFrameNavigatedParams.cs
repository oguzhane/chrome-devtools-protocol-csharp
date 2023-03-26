// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired once navigation of the frame has completed. Frame is now associated with the new loader. </summary>
    public partial class EventFrameNavigatedParams
    {
        /// <summary> Initializes a new instance of EventFrameNavigatedParams. </summary>
        /// <param name="frame"> Frame object. </param>
        /// <param name="type"> The type of a frameNavigated event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frame"/> or <paramref name="type"/> is null. </exception>
        public EventFrameNavigatedParams(TypeFrame frame, string type)
        {
            Argument.AssertNotNull(frame, nameof(frame));
            Argument.AssertNotNull(type, nameof(type));

            Frame = frame;
            Type = type;
        }

        /// <summary> Frame object. </summary>
        public TypeFrame Frame { get; set; }
        /// <summary> The type of a frameNavigated event. </summary>
        public string Type { get; set; }
    }
}
