// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when HTTP request has finished loading. </summary>
    public partial class EventLoadingFinishedParams
    {
        /// <summary> Initializes a new instance of EventLoadingFinishedParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="encodedDataLength"> Total number of bytes received for this request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/> is null. </exception>
        public EventLoadingFinishedParams(string requestId, float timestamp, float encodedDataLength)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));

            RequestId = requestId;
            Timestamp = timestamp;
            EncodedDataLength = encodedDataLength;
        }

        /// <summary> Initializes a new instance of EventLoadingFinishedParams. </summary>
        /// <param name="requestId"> Request identifier. </param>
        /// <param name="timestamp"> Timestamp. </param>
        /// <param name="encodedDataLength"> Total number of bytes received for this request. </param>
        /// <param name="shouldReportCorbBlocking">
        /// Set when 1) response was blocked by Cross-Origin Read Blocking and also
        /// 2) this needs to be reported to the DevTools console.
        /// </param>
        internal EventLoadingFinishedParams(string requestId, float timestamp, float encodedDataLength, bool? shouldReportCorbBlocking)
        {
            RequestId = requestId;
            Timestamp = timestamp;
            EncodedDataLength = encodedDataLength;
            ShouldReportCorbBlocking = shouldReportCorbBlocking;
        }

        /// <summary> Request identifier. </summary>
        public string RequestId { get; set; }
        /// <summary> Timestamp. </summary>
        public float Timestamp { get; set; }
        /// <summary> Total number of bytes received for this request. </summary>
        public float EncodedDataLength { get; set; }
        /// <summary>
        /// Set when 1) response was blocked by Cross-Origin Read Blocking and also
        /// 2) this needs to be reported to the DevTools console.
        /// </summary>
        public bool? ShouldReportCorbBlocking { get; set; }
    }
}
