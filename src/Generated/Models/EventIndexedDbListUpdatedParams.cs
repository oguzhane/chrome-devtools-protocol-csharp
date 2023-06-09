// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The origin&apos;s IndexedDB database list has been modified. </summary>
    public partial class EventIndexedDbListUpdatedParams
    {
        /// <summary> Initializes a new instance of EventIndexedDbListUpdatedParams. </summary>
        /// <param name="origin"> Origin to update. </param>
        /// <param name="storageKey"> Storage key to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="origin"/> or <paramref name="storageKey"/> is null. </exception>
        public EventIndexedDbListUpdatedParams(string origin, string storageKey)
        {
            Argument.AssertNotNull(origin, nameof(origin));
            Argument.AssertNotNull(storageKey, nameof(storageKey));

            Origin = origin;
            StorageKey = storageKey;
        }

        /// <summary> Origin to update. </summary>
        public string Origin { get; set; }
        /// <summary> Storage key to update. </summary>
        public string StorageKey { get; set; }
    }
}
