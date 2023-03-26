// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
    /// code. Currently only used for COEP/COOP, but may be extended to include
    /// some CSP errors in the future.
    /// </summary>
    public partial class TypeBlockedByResponseIssueDetails
    {
        /// <summary> Initializes a new instance of TypeBlockedByResponseIssueDetails. </summary>
        /// <param name="request"> Information about a request that is affected by an inspector issue. </param>
        /// <param name="reason">
        /// Enum indicating the reason a response has been blocked. These reasons are
        /// refinements of the net error BLOCKED_BY_RESPONSE.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> or <paramref name="reason"/> is null. </exception>
        public TypeBlockedByResponseIssueDetails(TypeAffectedRequest request, string reason)
        {
            Argument.AssertNotNull(request, nameof(request));
            Argument.AssertNotNull(reason, nameof(reason));

            Request = request;
            Reason = reason;
        }

        /// <summary> Initializes a new instance of TypeBlockedByResponseIssueDetails. </summary>
        /// <param name="request"> Information about a request that is affected by an inspector issue. </param>
        /// <param name="parentFrame"> Information about the frame affected by an inspector issue. </param>
        /// <param name="blockedFrame"> Information about the frame affected by an inspector issue. </param>
        /// <param name="reason">
        /// Enum indicating the reason a response has been blocked. These reasons are
        /// refinements of the net error BLOCKED_BY_RESPONSE.
        /// </param>
        internal TypeBlockedByResponseIssueDetails(TypeAffectedRequest request, TypeAffectedFrame parentFrame, TypeAffectedFrame blockedFrame, string reason)
        {
            Request = request;
            ParentFrame = parentFrame;
            BlockedFrame = blockedFrame;
            Reason = reason;
        }

        /// <summary> Information about a request that is affected by an inspector issue. </summary>
        public TypeAffectedRequest Request { get; set; }
        /// <summary> Information about the frame affected by an inspector issue. </summary>
        public TypeAffectedFrame ParentFrame { get; set; }
        /// <summary> Information about the frame affected by an inspector issue. </summary>
        public TypeAffectedFrame BlockedFrame { get; set; }
        /// <summary>
        /// Enum indicating the reason a response has been blocked. These reasons are
        /// refinements of the net error BLOCKED_BY_RESPONSE.
        /// </summary>
        public string Reason { get; set; }
    }
}
