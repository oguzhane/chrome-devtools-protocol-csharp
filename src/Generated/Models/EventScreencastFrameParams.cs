// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Compressed image data requested by the `startScreencast`. </summary>
    public partial class EventScreencastFrameParams
    {
        /// <summary> Initializes a new instance of EventScreencastFrameParams. </summary>
        /// <param name="data"> Base64-encoded compressed image. (Encoded as a base64 string when passed over JSON). </param>
        /// <param name="metadata"> Screencast frame metadata. </param>
        /// <param name="sessionId"> Frame number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> or <paramref name="metadata"/> is null. </exception>
        public EventScreencastFrameParams(string data, TypeScreencastFrameMetadata metadata, int sessionId)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(metadata, nameof(metadata));

            Data = data;
            Metadata = metadata;
            SessionId = sessionId;
        }

        /// <summary> Base64-encoded compressed image. (Encoded as a base64 string when passed over JSON). </summary>
        public string Data { get; set; }
        /// <summary> Screencast frame metadata. </summary>
        public TypeScreencastFrameMetadata Metadata { get; set; }
        /// <summary> Frame number. </summary>
        public int SessionId { get; set; }
    }
}
