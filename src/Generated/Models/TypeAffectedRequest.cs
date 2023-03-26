// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Information about a request that is affected by an inspector issue. </summary>
    public partial class TypeAffectedRequest
    {
        /// <summary> Initializes a new instance of TypeAffectedRequest. </summary>
        /// <param name="requestId"> The unique request id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> is null. </exception>
        public TypeAffectedRequest(string requestId)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));

            RequestId = requestId;
        }

        /// <summary> Initializes a new instance of TypeAffectedRequest. </summary>
        /// <param name="requestId"> The unique request id. </param>
        /// <param name="url"></param>
        internal TypeAffectedRequest(string requestId, string url)
        {
            RequestId = requestId;
            Url = url;
        }

        /// <summary> The unique request id. </summary>
        public string RequestId { get; set; }
        /// <summary> Gets or sets the url. </summary>
        public string Url { get; set; }
    }
}