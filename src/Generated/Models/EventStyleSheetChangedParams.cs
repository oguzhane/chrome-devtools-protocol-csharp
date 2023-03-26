// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired whenever a stylesheet is changed as a result of the client operation. </summary>
    public partial class EventStyleSheetChangedParams
    {
        /// <summary> Initializes a new instance of EventStyleSheetChangedParams. </summary>
        /// <param name="styleSheetId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="styleSheetId"/> is null. </exception>
        public EventStyleSheetChangedParams(string styleSheetId)
        {
            Argument.AssertNotNull(styleSheetId, nameof(styleSheetId));

            StyleSheetId = styleSheetId;
        }

        /// <summary> Gets or sets the style sheet id. </summary>
        public string StyleSheetId { get; set; }
    }
}
