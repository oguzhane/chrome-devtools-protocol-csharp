// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Reports coverage delta since the last poll (either from an event like this, or from
    /// `takePreciseCoverage` for the current isolate. May only be sent if precise code
    /// coverage has been started. This event can be trigged by the embedder to, for example,
    /// trigger collection of coverage data immediately at a certain point in time.
    /// </summary>
    public partial class EventPreciseCoverageDeltaUpdateParams
    {
        /// <summary> Initializes a new instance of EventPreciseCoverageDeltaUpdateParams. </summary>
        /// <param name="timestamp"> Monotonically increasing time (in seconds) when the coverage update was taken in the backend. </param>
        /// <param name="occasion"> Identifier for distinguishing coverage events. </param>
        /// <param name="result"> Coverage data for the current isolate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="occasion"/> or <paramref name="result"/> is null. </exception>
        public EventPreciseCoverageDeltaUpdateParams(float timestamp, string occasion, IEnumerable<TypeScriptCoverage> result)
        {
            Argument.AssertNotNull(occasion, nameof(occasion));
            Argument.AssertNotNull(result, nameof(result));

            Timestamp = timestamp;
            Occasion = occasion;
            Result = result.ToList();
        }

        /// <summary> Initializes a new instance of EventPreciseCoverageDeltaUpdateParams. </summary>
        /// <param name="timestamp"> Monotonically increasing time (in seconds) when the coverage update was taken in the backend. </param>
        /// <param name="occasion"> Identifier for distinguishing coverage events. </param>
        /// <param name="result"> Coverage data for the current isolate. </param>
        internal EventPreciseCoverageDeltaUpdateParams(float timestamp, string occasion, IList<TypeScriptCoverage> result)
        {
            Timestamp = timestamp;
            Occasion = occasion;
            Result = result;
        }

        /// <summary> Monotonically increasing time (in seconds) when the coverage update was taken in the backend. </summary>
        public float Timestamp { get; set; }
        /// <summary> Identifier for distinguishing coverage events. </summary>
        public string Occasion { get; set; }
        /// <summary> Coverage data for the current isolate. </summary>
        public IList<TypeScriptCoverage> Result { get; }
    }
}
