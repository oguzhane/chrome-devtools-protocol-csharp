// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Corresponds to kMediaPropertyChange. </summary>
    public partial class TypePlayerProperty
    {
        /// <summary> Initializes a new instance of TypePlayerProperty. </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public TypePlayerProperty(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
    }
}
