// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Mirrors `DOMNodeInserted` event. </summary>
    public partial class EventChildNodeInsertedParams
    {
        /// <summary> Initializes a new instance of EventChildNodeInsertedParams. </summary>
        /// <param name="parentNodeId"> Id of the node that has changed. </param>
        /// <param name="previousNodeId"> Id of the previous sibling. </param>
        /// <param name="node"> Inserted node data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="node"/> is null. </exception>
        public EventChildNodeInsertedParams(int parentNodeId, int previousNodeId, TypeNode node)
        {
            Argument.AssertNotNull(node, nameof(node));

            ParentNodeId = parentNodeId;
            PreviousNodeId = previousNodeId;
            Node = node;
        }

        /// <summary> Id of the node that has changed. </summary>
        public int ParentNodeId { get; set; }
        /// <summary> Id of the previous sibling. </summary>
        public int PreviousNodeId { get; set; }
        /// <summary> Inserted node data. </summary>
        public TypeNode Node { get; set; }
    }
}
