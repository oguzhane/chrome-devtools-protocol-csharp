// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Determines what type of Trust Token operation is executed and
    /// depending on the type, some additional parameters. The values
    /// are specified in third_party/blink/renderer/core/fetch/trust_token.idl.
    /// </summary>
    public partial class TypeTrustTokenParams
    {
        /// <summary> Initializes a new instance of TypeTrustTokenParams. </summary>
        /// <param name="operation"></param>
        /// <param name="refreshPolicy">
        /// Only set for &quot;token-redemption&quot; operation and determine whether
        /// to request a fresh SRR or use a still valid cached SRR.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operation"/> or <paramref name="refreshPolicy"/> is null. </exception>
        public TypeTrustTokenParams(string operation, string refreshPolicy)
        {
            Argument.AssertNotNull(operation, nameof(operation));
            Argument.AssertNotNull(refreshPolicy, nameof(refreshPolicy));

            Operation = operation;
            RefreshPolicy = refreshPolicy;
            Issuers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TypeTrustTokenParams. </summary>
        /// <param name="operation"></param>
        /// <param name="refreshPolicy">
        /// Only set for &quot;token-redemption&quot; operation and determine whether
        /// to request a fresh SRR or use a still valid cached SRR.
        /// </param>
        /// <param name="issuers">
        /// Origins of issuers from whom to request tokens or redemption
        /// records.
        /// </param>
        internal TypeTrustTokenParams(string operation, string refreshPolicy, IList<string> issuers)
        {
            Operation = operation;
            RefreshPolicy = refreshPolicy;
            Issuers = issuers;
        }

        /// <summary> Gets or sets the operation. </summary>
        public string Operation { get; set; }
        /// <summary>
        /// Only set for &quot;token-redemption&quot; operation and determine whether
        /// to request a fresh SRR or use a still valid cached SRR.
        /// </summary>
        public string RefreshPolicy { get; set; }
        /// <summary>
        /// Origins of issuers from whom to request tokens or redemption
        /// records.
        /// </summary>
        public IList<string> Issuers { get; }
    }
}
