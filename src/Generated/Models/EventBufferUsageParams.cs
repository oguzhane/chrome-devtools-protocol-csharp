// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Chrome.DevTools.Models
{
    /// <summary> The EventBufferUsageParams. </summary>
    public partial class EventBufferUsageParams
    {
        /// <summary> Initializes a new instance of EventBufferUsageParams. </summary>
        public EventBufferUsageParams()
        {
        }

        /// <summary> Initializes a new instance of EventBufferUsageParams. </summary>
        /// <param name="percentFull">
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </param>
        /// <param name="eventCount"> An approximate number of events in the trace log. </param>
        /// <param name="value">
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </param>
        internal EventBufferUsageParams(float? percentFull, float? eventCount, float? value)
        {
            PercentFull = percentFull;
            EventCount = eventCount;
            Value = value;
        }

        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </summary>
        public float? PercentFull { get; set; }
        /// <summary> An approximate number of events in the trace log. </summary>
        public float? EventCount { get; set; }
        /// <summary>
        /// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
        /// total size.
        /// </summary>
        public float? Value { get; set; }
    }
}
