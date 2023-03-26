// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Issued when new message was logged. </summary>
    public partial class EventEntryAddedParams
    {
        /// <summary> Initializes a new instance of EventEntryAddedParams. </summary>
        /// <param name="entry"> The entry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entry"/> is null. </exception>
        public EventEntryAddedParams(TypeLogEntry entry)
        {
            Argument.AssertNotNull(entry, nameof(entry));

            Entry = entry;
        }

        /// <summary> The entry. </summary>
        public TypeLogEntry Entry { get; set; }
    }
}
