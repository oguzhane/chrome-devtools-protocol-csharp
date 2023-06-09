// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Issued when a target is destroyed. </summary>
    public partial class EventTargetDestroyedParams
    {
        /// <summary> Initializes a new instance of EventTargetDestroyedParams. </summary>
        /// <param name="targetId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetId"/> is null. </exception>
        public EventTargetDestroyedParams(string targetId)
        {
            Argument.AssertNotNull(targetId, nameof(targetId));

            TargetId = targetId;
        }

        /// <summary> Gets or sets the target id. </summary>
        public string TargetId { get; set; }
    }
}
