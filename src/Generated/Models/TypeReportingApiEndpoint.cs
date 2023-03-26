// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeReportingApiEndpoint. </summary>
    public partial class TypeReportingApiEndpoint
    {
        /// <summary> Initializes a new instance of TypeReportingApiEndpoint. </summary>
        /// <param name="url"> The URL of the endpoint to which reports may be delivered. </param>
        /// <param name="groupName"> Name of the endpoint group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> or <paramref name="groupName"/> is null. </exception>
        public TypeReportingApiEndpoint(string url, string groupName)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(groupName, nameof(groupName));

            Url = url;
            GroupName = groupName;
        }

        /// <summary> The URL of the endpoint to which reports may be delivered. </summary>
        public string Url { get; set; }
        /// <summary> Name of the endpoint group. </summary>
        public string GroupName { get; set; }
    }
}