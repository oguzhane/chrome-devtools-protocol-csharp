// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
    /// web font.
    /// </summary>
    public partial class EventFontsUpdatedParams
    {
        /// <summary> Initializes a new instance of EventFontsUpdatedParams. </summary>
        public EventFontsUpdatedParams()
        {
        }

        /// <summary> Initializes a new instance of EventFontsUpdatedParams. </summary>
        /// <param name="font"> The web font that has loaded. </param>
        internal EventFontsUpdatedParams(TypeFontFace font)
        {
            Font = font;
        }

        /// <summary> The web font that has loaded. </summary>
        public TypeFontFace Font { get; set; }
    }
}