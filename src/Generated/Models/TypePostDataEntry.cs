// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Chrome.DevTools.Models
{
    /// <summary> Post data entry for HTTP request. </summary>
    public partial class TypePostDataEntry
    {
        /// <summary> Initializes a new instance of TypePostDataEntry. </summary>
        public TypePostDataEntry()
        {
        }

        /// <summary> Initializes a new instance of TypePostDataEntry. </summary>
        /// <param name="bytes"></param>
        internal TypePostDataEntry(string bytes)
        {
            Bytes = bytes;
        }

        /// <summary> Gets or sets the bytes. </summary>
        public string Bytes { get; set; }
    }
}
