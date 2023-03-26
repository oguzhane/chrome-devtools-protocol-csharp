// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Fired when page is about to start a download.
    /// Deprecated. Use Browser.downloadWillBegin instead.
    /// </summary>
    public partial class EventDownloadWillBeginParamsAutoGenerated
    {
        /// <summary> Initializes a new instance of EventDownloadWillBeginParamsAutoGenerated. </summary>
        /// <param name="frameId"> Id of the frame that caused download to begin. </param>
        /// <param name="guid"> Global unique identifier of the download. </param>
        /// <param name="url"> URL of the resource being downloaded. </param>
        /// <param name="suggestedFilename"> Suggested file name of the resource (the actual name of the file saved on disk may differ). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frameId"/>, <paramref name="guid"/>, <paramref name="url"/> or <paramref name="suggestedFilename"/> is null. </exception>
        public EventDownloadWillBeginParamsAutoGenerated(string frameId, string guid, string url, string suggestedFilename)
        {
            Argument.AssertNotNull(frameId, nameof(frameId));
            Argument.AssertNotNull(guid, nameof(guid));
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(suggestedFilename, nameof(suggestedFilename));

            FrameId = frameId;
            Guid = guid;
            Url = url;
            SuggestedFilename = suggestedFilename;
        }

        /// <summary> Id of the frame that caused download to begin. </summary>
        public string FrameId { get; set; }
        /// <summary> Global unique identifier of the download. </summary>
        public string Guid { get; set; }
        /// <summary> URL of the resource being downloaded. </summary>
        public string Url { get; set; }
        /// <summary> Suggested file name of the resource (the actual name of the file saved on disk may differ). </summary>
        public string SuggestedFilename { get; set; }
    }
}
