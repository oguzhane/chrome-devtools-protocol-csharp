// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeHeavyAdIssueDetails. </summary>
    public partial class TypeHeavyAdIssueDetails
    {
        /// <summary> Initializes a new instance of TypeHeavyAdIssueDetails. </summary>
        /// <param name="resolution"> The resolution status, either blocking the content or warning. </param>
        /// <param name="reason"> The reason the ad was blocked, total network or cpu or peak cpu. </param>
        /// <param name="frame"> The frame that was blocked. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resolution"/>, <paramref name="reason"/> or <paramref name="frame"/> is null. </exception>
        public TypeHeavyAdIssueDetails(string resolution, string reason, TypeAffectedFrame frame)
        {
            Argument.AssertNotNull(resolution, nameof(resolution));
            Argument.AssertNotNull(reason, nameof(reason));
            Argument.AssertNotNull(frame, nameof(frame));

            Resolution = resolution;
            Reason = reason;
            Frame = frame;
        }

        /// <summary> The resolution status, either blocking the content or warning. </summary>
        public string Resolution { get; set; }
        /// <summary> The reason the ad was blocked, total network or cpu or peak cpu. </summary>
        public string Reason { get; set; }
        /// <summary> The frame that was blocked. </summary>
        public TypeAffectedFrame Frame { get; set; }
    }
}
