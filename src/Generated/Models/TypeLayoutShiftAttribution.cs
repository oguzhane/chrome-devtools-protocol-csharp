// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeLayoutShiftAttribution. </summary>
    public partial class TypeLayoutShiftAttribution
    {
        /// <summary> Initializes a new instance of TypeLayoutShiftAttribution. </summary>
        /// <param name="previousRect"> Rectangle. </param>
        /// <param name="currentRect"> Rectangle. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="previousRect"/> or <paramref name="currentRect"/> is null. </exception>
        public TypeLayoutShiftAttribution(TypeRect previousRect, TypeRect currentRect)
        {
            Argument.AssertNotNull(previousRect, nameof(previousRect));
            Argument.AssertNotNull(currentRect, nameof(currentRect));

            PreviousRect = previousRect;
            CurrentRect = currentRect;
        }

        /// <summary> Initializes a new instance of TypeLayoutShiftAttribution. </summary>
        /// <param name="previousRect"> Rectangle. </param>
        /// <param name="currentRect"> Rectangle. </param>
        /// <param name="nodeId">
        /// Unique DOM node identifier used to reference a node that may not have been pushed to the
        /// front-end.
        /// </param>
        internal TypeLayoutShiftAttribution(TypeRect previousRect, TypeRect currentRect, int? nodeId)
        {
            PreviousRect = previousRect;
            CurrentRect = currentRect;
            NodeId = nodeId;
        }

        /// <summary> Rectangle. </summary>
        public TypeRect PreviousRect { get; set; }
        /// <summary> Rectangle. </summary>
        public TypeRect CurrentRect { get; set; }
        /// <summary>
        /// Unique DOM node identifier used to reference a node that may not have been pushed to the
        /// front-end.
        /// </summary>
        public int? NodeId { get; set; }
    }
}