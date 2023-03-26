// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired whenever an active document stylesheet is added. </summary>
    public partial class EventStyleSheetAddedParams
    {
        /// <summary> Initializes a new instance of EventStyleSheetAddedParams. </summary>
        /// <param name="header"> Added stylesheet metainfo. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="header"/> is null. </exception>
        public EventStyleSheetAddedParams(TypeCssStyleSheetHeader header)
        {
            Argument.AssertNotNull(header, nameof(header));

            Header = header;
        }

        /// <summary> Added stylesheet metainfo. </summary>
        public TypeCssStyleSheetHeader Header { get; set; }
    }
}
