// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when breakpoint is resolved to an actual script and location. </summary>
    public partial class EventBreakpointResolvedParams
    {
        /// <summary> Initializes a new instance of EventBreakpointResolvedParams. </summary>
        /// <param name="breakpointId"> Breakpoint unique identifier. </param>
        /// <param name="location"> Actual breakpoint location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="breakpointId"/> or <paramref name="location"/> is null. </exception>
        public EventBreakpointResolvedParams(string breakpointId, TypeLocation location)
        {
            Argument.AssertNotNull(breakpointId, nameof(breakpointId));
            Argument.AssertNotNull(location, nameof(location));

            BreakpointId = breakpointId;
            Location = location;
        }

        /// <summary> Breakpoint unique identifier. </summary>
        public string BreakpointId { get; set; }
        /// <summary> Actual breakpoint location. </summary>
        public TypeLocation Location { get; set; }
    }
}