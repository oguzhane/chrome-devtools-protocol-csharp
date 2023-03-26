// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeSafetyTipInfo. </summary>
    public partial class TypeSafetyTipInfo
    {
        /// <summary> Initializes a new instance of TypeSafetyTipInfo. </summary>
        /// <param name="safetyTipStatus"> Describes whether the page triggers any safety tips or reputation warnings. Default is unknown. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="safetyTipStatus"/> is null. </exception>
        public TypeSafetyTipInfo(string safetyTipStatus)
        {
            Argument.AssertNotNull(safetyTipStatus, nameof(safetyTipStatus));

            SafetyTipStatus = safetyTipStatus;
        }

        /// <summary> Initializes a new instance of TypeSafetyTipInfo. </summary>
        /// <param name="safetyTipStatus"> Describes whether the page triggers any safety tips or reputation warnings. Default is unknown. </param>
        /// <param name="safeUrl"> The URL the safety tip suggested (&quot;Did you mean?&quot;). Only filled in for lookalike matches. </param>
        internal TypeSafetyTipInfo(string safetyTipStatus, string safeUrl)
        {
            SafetyTipStatus = safetyTipStatus;
            SafeUrl = safeUrl;
        }

        /// <summary> Describes whether the page triggers any safety tips or reputation warnings. Default is unknown. </summary>
        public string SafetyTipStatus { get; set; }
        /// <summary> The URL the safety tip suggested (&quot;Did you mean?&quot;). Only filled in for lookalike matches. </summary>
        public string SafeUrl { get; set; }
    }
}
