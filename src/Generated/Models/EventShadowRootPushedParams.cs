// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Called when shadow root is pushed into the element. </summary>
    public partial class EventShadowRootPushedParams
    {
        /// <summary> Initializes a new instance of EventShadowRootPushedParams. </summary>
        /// <param name="hostId"> Host element id. </param>
        /// <param name="root"> Shadow root. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="root"/> is null. </exception>
        public EventShadowRootPushedParams(int hostId, TypeNode root)
        {
            Argument.AssertNotNull(root, nameof(root));

            HostId = hostId;
            Root = root;
        }

        /// <summary> Host element id. </summary>
        public int HostId { get; set; }
        /// <summary> Shadow root. </summary>
        public TypeNode Root { get; set; }
    }
}
