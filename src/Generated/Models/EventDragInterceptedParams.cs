// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Emitted only when `Input.setInterceptDrags` is enabled. Use this data with `Input.dispatchDragEvent` to
    /// restore normal drag and drop behavior.
    /// </summary>
    public partial class EventDragInterceptedParams
    {
        /// <summary> Initializes a new instance of EventDragInterceptedParams. </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public EventDragInterceptedParams(TypeDragData data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data;
        }

        /// <summary> Gets or sets the data. </summary>
        public TypeDragData Data { get; set; }
    }
}
