// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Event for each animation that has been created. </summary>
    public partial class EventAnimationCreatedParams
    {
        /// <summary> Initializes a new instance of EventAnimationCreatedParams. </summary>
        /// <param name="id"> Id of the animation that was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public EventAnimationCreatedParams(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Id of the animation that was created. </summary>
        public string Id { get; set; }
    }
}
