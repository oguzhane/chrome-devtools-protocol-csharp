// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeTimelineEvent. </summary>
    public partial class TypeTimelineEvent
    {
        /// <summary> Initializes a new instance of TypeTimelineEvent. </summary>
        /// <param name="frameId"> Identifies the frame that this event is related to. Empty for non-frame targets. </param>
        /// <param name="type">
        /// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// This determines which of the optional &quot;details&quot; fiedls is present.
        /// </param>
        /// <param name="name"> Name may be empty depending on the type. </param>
        /// <param name="time"> Time in seconds since Epoch, monotonically increasing within document lifetime. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frameId"/>, <paramref name="type"/> or <paramref name="name"/> is null. </exception>
        public TypeTimelineEvent(string frameId, string type, string name, float time)
        {
            Argument.AssertNotNull(frameId, nameof(frameId));
            Argument.AssertNotNull(type, nameof(type));
            Argument.AssertNotNull(name, nameof(name));

            FrameId = frameId;
            Type = type;
            Name = name;
            Time = time;
        }

        /// <summary> Initializes a new instance of TypeTimelineEvent. </summary>
        /// <param name="frameId"> Identifies the frame that this event is related to. Empty for non-frame targets. </param>
        /// <param name="type">
        /// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// This determines which of the optional &quot;details&quot; fiedls is present.
        /// </param>
        /// <param name="name"> Name may be empty depending on the type. </param>
        /// <param name="time"> Time in seconds since Epoch, monotonically increasing within document lifetime. </param>
        /// <param name="duration"> Event duration, if applicable. </param>
        /// <param name="lcpDetails"> See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl. </param>
        /// <param name="layoutShiftDetails"> See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl. </param>
        internal TypeTimelineEvent(string frameId, string type, string name, float time, float? duration, TypeLargestContentfulPaint lcpDetails, TypeLayoutShift layoutShiftDetails)
        {
            FrameId = frameId;
            Type = type;
            Name = name;
            Time = time;
            Duration = duration;
            LcpDetails = lcpDetails;
            LayoutShiftDetails = layoutShiftDetails;
        }

        /// <summary> Identifies the frame that this event is related to. Empty for non-frame targets. </summary>
        public string FrameId { get; set; }
        /// <summary>
        /// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
        /// This determines which of the optional &quot;details&quot; fiedls is present.
        /// </summary>
        public string Type { get; set; }
        /// <summary> Name may be empty depending on the type. </summary>
        public string Name { get; set; }
        /// <summary> Time in seconds since Epoch, monotonically increasing within document lifetime. </summary>
        public float Time { get; set; }
        /// <summary> Event duration, if applicable. </summary>
        public float? Duration { get; set; }
        /// <summary> See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl. </summary>
        public TypeLargestContentfulPaint LcpDetails { get; set; }
        /// <summary> See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl. </summary>
        public TypeLayoutShift LayoutShiftDetails { get; set; }
    }
}