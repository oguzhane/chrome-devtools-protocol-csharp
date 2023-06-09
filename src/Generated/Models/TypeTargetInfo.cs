// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The TypeTargetInfo. </summary>
    public partial class TypeTargetInfo
    {
        /// <summary> Initializes a new instance of TypeTargetInfo. </summary>
        /// <param name="targetId"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="attached"> Whether the target has an attached client. </param>
        /// <param name="canAccessOpener"> Whether the target has access to the originating window. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetId"/>, <paramref name="type"/>, <paramref name="title"/> or <paramref name="url"/> is null. </exception>
        public TypeTargetInfo(string targetId, string type, string title, string url, bool attached, bool canAccessOpener)
        {
            Argument.AssertNotNull(targetId, nameof(targetId));
            Argument.AssertNotNull(type, nameof(type));
            Argument.AssertNotNull(title, nameof(title));
            Argument.AssertNotNull(url, nameof(url));

            TargetId = targetId;
            Type = type;
            Title = title;
            Url = url;
            Attached = attached;
            CanAccessOpener = canAccessOpener;
        }

        /// <summary> Initializes a new instance of TypeTargetInfo. </summary>
        /// <param name="targetId"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="attached"> Whether the target has an attached client. </param>
        /// <param name="openerId"> Opener target Id. </param>
        /// <param name="canAccessOpener"> Whether the target has access to the originating window. </param>
        /// <param name="openerFrameId"> Frame id of originating window (is only set if target has an opener). </param>
        /// <param name="browserContextId"></param>
        /// <param name="subtype">
        /// Provides additional details for specific target types. For example, for
        /// the type of &quot;page&quot;, this may be set to &quot;portal&quot; or &quot;prerender&quot;.
        /// </param>
        internal TypeTargetInfo(string targetId, string type, string title, string url, bool attached, string openerId, bool canAccessOpener, string openerFrameId, string browserContextId, string subtype)
        {
            TargetId = targetId;
            Type = type;
            Title = title;
            Url = url;
            Attached = attached;
            OpenerId = openerId;
            CanAccessOpener = canAccessOpener;
            OpenerFrameId = openerFrameId;
            BrowserContextId = browserContextId;
            Subtype = subtype;
        }

        /// <summary> Gets or sets the target id. </summary>
        public string TargetId { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
        /// <summary> Gets or sets the title. </summary>
        public string Title { get; set; }
        /// <summary> Gets or sets the url. </summary>
        public string Url { get; set; }
        /// <summary> Whether the target has an attached client. </summary>
        public bool Attached { get; set; }
        /// <summary> Opener target Id. </summary>
        public string OpenerId { get; set; }
        /// <summary> Whether the target has access to the originating window. </summary>
        public bool CanAccessOpener { get; set; }
        /// <summary> Frame id of originating window (is only set if target has an opener). </summary>
        public string OpenerFrameId { get; set; }
        /// <summary> Gets or sets the browser context id. </summary>
        public string BrowserContextId { get; set; }
        /// <summary>
        /// Provides additional details for specific target types. For example, for
        /// the type of &quot;page&quot;, this may be set to &quot;portal&quot; or &quot;prerender&quot;.
        /// </summary>
        public string Subtype { get; set; }
    }
}
