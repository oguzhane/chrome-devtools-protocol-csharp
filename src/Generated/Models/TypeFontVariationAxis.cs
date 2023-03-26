// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Information about font variation axes for variable fonts. </summary>
    public partial class TypeFontVariationAxis
    {
        /// <summary> Initializes a new instance of TypeFontVariationAxis. </summary>
        /// <param name="tag"> The font-variation-setting tag (a.k.a. &quot;axis tag&quot;). </param>
        /// <param name="name"> Human-readable variation name in the default language (normally, &quot;en&quot;). </param>
        /// <param name="minValue"> The minimum value (inclusive) the font supports for this tag. </param>
        /// <param name="maxValue"> The maximum value (inclusive) the font supports for this tag. </param>
        /// <param name="defaultValue"> The default value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tag"/> or <paramref name="name"/> is null. </exception>
        public TypeFontVariationAxis(string tag, string name, float minValue, float maxValue, float defaultValue)
        {
            Argument.AssertNotNull(tag, nameof(tag));
            Argument.AssertNotNull(name, nameof(name));

            Tag = tag;
            Name = name;
            MinValue = minValue;
            MaxValue = maxValue;
            DefaultValue = defaultValue;
        }

        /// <summary> The font-variation-setting tag (a.k.a. &quot;axis tag&quot;). </summary>
        public string Tag { get; set; }
        /// <summary> Human-readable variation name in the default language (normally, &quot;en&quot;). </summary>
        public string Name { get; set; }
        /// <summary> The minimum value (inclusive) the font supports for this tag. </summary>
        public float MinValue { get; set; }
        /// <summary> The maximum value (inclusive) the font supports for this tag. </summary>
        public float MaxValue { get; set; }
        /// <summary> The default value. </summary>
        public float DefaultValue { get; set; }
    }
}
