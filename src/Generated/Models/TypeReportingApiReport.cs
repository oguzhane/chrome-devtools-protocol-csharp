// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> An object representing a report generated by the Reporting API. </summary>
    public partial class TypeReportingApiReport
    {
        /// <summary> Initializes a new instance of TypeReportingApiReport. </summary>
        /// <param name="id"></param>
        /// <param name="initiatorUrl"> The URL of the document that triggered the report. </param>
        /// <param name="destination"> The name of the endpoint group that should be used to deliver the report. </param>
        /// <param name="type"> The type of the report (specifies the set of data that is contained in the report body). </param>
        /// <param name="timestamp"> When the report was generated. </param>
        /// <param name="depth"> How many uploads deep the related request was. </param>
        /// <param name="completedAttempts"> The number of delivery attempts made so far, not including an active attempt. </param>
        /// <param name="body"> Any object. </param>
        /// <param name="status"> The status of a Reporting API report. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="initiatorUrl"/>, <paramref name="destination"/>, <paramref name="type"/>, <paramref name="body"/> or <paramref name="status"/> is null. </exception>
        public TypeReportingApiReport(string id, string initiatorUrl, string destination, string type, float timestamp, int depth, int completedAttempts, object body, string status)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(initiatorUrl, nameof(initiatorUrl));
            Argument.AssertNotNull(destination, nameof(destination));
            Argument.AssertNotNull(type, nameof(type));
            Argument.AssertNotNull(body, nameof(body));
            Argument.AssertNotNull(status, nameof(status));

            Id = id;
            InitiatorUrl = initiatorUrl;
            Destination = destination;
            Type = type;
            Timestamp = timestamp;
            Depth = depth;
            CompletedAttempts = completedAttempts;
            Body = body;
            Status = status;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> The URL of the document that triggered the report. </summary>
        public string InitiatorUrl { get; set; }
        /// <summary> The name of the endpoint group that should be used to deliver the report. </summary>
        public string Destination { get; set; }
        /// <summary> The type of the report (specifies the set of data that is contained in the report body). </summary>
        public string Type { get; set; }
        /// <summary> When the report was generated. </summary>
        public float Timestamp { get; set; }
        /// <summary> How many uploads deep the related request was. </summary>
        public int Depth { get; set; }
        /// <summary> The number of delivery attempts made so far, not including an active attempt. </summary>
        public int CompletedAttempts { get; set; }
        /// <summary> Any object. </summary>
        public object Body { get; set; }
        /// <summary> The status of a Reporting API report. </summary>
        public string Status { get; set; }
    }
}
