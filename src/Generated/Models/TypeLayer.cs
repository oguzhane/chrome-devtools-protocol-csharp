// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Information about a compositing layer. </summary>
    public partial class TypeLayer
    {
        /// <summary> Initializes a new instance of TypeLayer. </summary>
        /// <param name="layerId"> The unique id for this layer. </param>
        /// <param name="offsetX"> Offset from parent layer, X coordinate. </param>
        /// <param name="offsetY"> Offset from parent layer, Y coordinate. </param>
        /// <param name="width"> Layer width. </param>
        /// <param name="height"> Layer height. </param>
        /// <param name="paintCount"> Indicates how many time this layer has painted. </param>
        /// <param name="drawsContent">
        /// Indicates whether this layer hosts any content, rather than being used for
        /// transform/scrolling purposes only.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="layerId"/> is null. </exception>
        public TypeLayer(string layerId, float offsetX, float offsetY, float width, float height, int paintCount, bool drawsContent)
        {
            Argument.AssertNotNull(layerId, nameof(layerId));

            LayerId = layerId;
            OffsetX = offsetX;
            OffsetY = offsetY;
            Width = width;
            Height = height;
            Transform = new ChangeTrackingList<float>();
            PaintCount = paintCount;
            DrawsContent = drawsContent;
            ScrollRects = new ChangeTrackingList<TypeScrollRect>();
        }

        /// <summary> Initializes a new instance of TypeLayer. </summary>
        /// <param name="layerId"> The unique id for this layer. </param>
        /// <param name="parentLayerId"> The id of parent (not present for root). </param>
        /// <param name="backendNodeId"> The backend id for the node associated with this layer. </param>
        /// <param name="offsetX"> Offset from parent layer, X coordinate. </param>
        /// <param name="offsetY"> Offset from parent layer, Y coordinate. </param>
        /// <param name="width"> Layer width. </param>
        /// <param name="height"> Layer height. </param>
        /// <param name="transform"> Transformation matrix for layer, default is identity matrix. </param>
        /// <param name="anchorX"> Transform anchor point X, absent if no transform specified. </param>
        /// <param name="anchorY"> Transform anchor point Y, absent if no transform specified. </param>
        /// <param name="anchorZ"> Transform anchor point Z, absent if no transform specified. </param>
        /// <param name="paintCount"> Indicates how many time this layer has painted. </param>
        /// <param name="drawsContent">
        /// Indicates whether this layer hosts any content, rather than being used for
        /// transform/scrolling purposes only.
        /// </param>
        /// <param name="invisible"> Set if layer is not visible. </param>
        /// <param name="scrollRects"> Rectangles scrolling on main thread only. </param>
        /// <param name="stickyPositionConstraint"> Sticky position constraint information. </param>
        internal TypeLayer(string layerId, string parentLayerId, int? backendNodeId, float offsetX, float offsetY, float width, float height, IList<float> transform, float? anchorX, float? anchorY, float? anchorZ, int paintCount, bool drawsContent, bool? invisible, IList<TypeScrollRect> scrollRects, TypeStickyPositionConstraint stickyPositionConstraint)
        {
            LayerId = layerId;
            ParentLayerId = parentLayerId;
            BackendNodeId = backendNodeId;
            OffsetX = offsetX;
            OffsetY = offsetY;
            Width = width;
            Height = height;
            Transform = transform;
            AnchorX = anchorX;
            AnchorY = anchorY;
            AnchorZ = anchorZ;
            PaintCount = paintCount;
            DrawsContent = drawsContent;
            Invisible = invisible;
            ScrollRects = scrollRects;
            StickyPositionConstraint = stickyPositionConstraint;
        }

        /// <summary> The unique id for this layer. </summary>
        public string LayerId { get; set; }
        /// <summary> The id of parent (not present for root). </summary>
        public string ParentLayerId { get; set; }
        /// <summary> The backend id for the node associated with this layer. </summary>
        public int? BackendNodeId { get; set; }
        /// <summary> Offset from parent layer, X coordinate. </summary>
        public float OffsetX { get; set; }
        /// <summary> Offset from parent layer, Y coordinate. </summary>
        public float OffsetY { get; set; }
        /// <summary> Layer width. </summary>
        public float Width { get; set; }
        /// <summary> Layer height. </summary>
        public float Height { get; set; }
        /// <summary> Transformation matrix for layer, default is identity matrix. </summary>
        public IList<float> Transform { get; }
        /// <summary> Transform anchor point X, absent if no transform specified. </summary>
        public float? AnchorX { get; set; }
        /// <summary> Transform anchor point Y, absent if no transform specified. </summary>
        public float? AnchorY { get; set; }
        /// <summary> Transform anchor point Z, absent if no transform specified. </summary>
        public float? AnchorZ { get; set; }
        /// <summary> Indicates how many time this layer has painted. </summary>
        public int PaintCount { get; set; }
        /// <summary>
        /// Indicates whether this layer hosts any content, rather than being used for
        /// transform/scrolling purposes only.
        /// </summary>
        public bool DrawsContent { get; set; }
        /// <summary> Set if layer is not visible. </summary>
        public bool? Invisible { get; set; }
        /// <summary> Rectangles scrolling on main thread only. </summary>
        public IList<TypeScrollRect> ScrollRects { get; }
        /// <summary> Sticky position constraint information. </summary>
        public TypeStickyPositionConstraint StickyPositionConstraint { get; set; }
    }
}
