// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The origin&apos;s IndexedDB object store has been modified. </summary>
    public partial class EventIndexedDbContentUpdatedParams
    {
        /// <summary> Initializes a new instance of EventIndexedDbContentUpdatedParams. </summary>
        /// <param name="origin"> Origin to update. </param>
        /// <param name="storageKey"> Storage key to update. </param>
        /// <param name="databaseName"> Database to update. </param>
        /// <param name="objectStoreName"> ObjectStore to update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="origin"/>, <paramref name="storageKey"/>, <paramref name="databaseName"/> or <paramref name="objectStoreName"/> is null. </exception>
        public EventIndexedDbContentUpdatedParams(string origin, string storageKey, string databaseName, string objectStoreName)
        {
            Argument.AssertNotNull(origin, nameof(origin));
            Argument.AssertNotNull(storageKey, nameof(storageKey));
            Argument.AssertNotNull(databaseName, nameof(databaseName));
            Argument.AssertNotNull(objectStoreName, nameof(objectStoreName));

            Origin = origin;
            StorageKey = storageKey;
            DatabaseName = databaseName;
            ObjectStoreName = objectStoreName;
        }

        /// <summary> Origin to update. </summary>
        public string Origin { get; set; }
        /// <summary> Storage key to update. </summary>
        public string StorageKey { get; set; }
        /// <summary> Database to update. </summary>
        public string DatabaseName { get; set; }
        /// <summary> ObjectStore to update. </summary>
        public string ObjectStoreName { get; set; }
    }
}
