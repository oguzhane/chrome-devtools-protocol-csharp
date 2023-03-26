// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> The EventConsoleProfileFinishedParams. </summary>
    public partial class EventConsoleProfileFinishedParams
    {
        /// <summary> Initializes a new instance of EventConsoleProfileFinishedParams. </summary>
        /// <param name="id"></param>
        /// <param name="location"> Location of console.profileEnd(). </param>
        /// <param name="profile"> Profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="location"/> or <paramref name="profile"/> is null. </exception>
        public EventConsoleProfileFinishedParams(string id, TypeLocation location, TypeProfile profile)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(location, nameof(location));
            Argument.AssertNotNull(profile, nameof(profile));

            Id = id;
            Location = location;
            Profile = profile;
        }

        /// <summary> Initializes a new instance of EventConsoleProfileFinishedParams. </summary>
        /// <param name="id"></param>
        /// <param name="location"> Location of console.profileEnd(). </param>
        /// <param name="profile"> Profile. </param>
        /// <param name="title"> Profile title passed as an argument to console.profile(). </param>
        internal EventConsoleProfileFinishedParams(string id, TypeLocation location, TypeProfile profile, string title)
        {
            Id = id;
            Location = location;
            Profile = profile;
            Title = title;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Location of console.profileEnd(). </summary>
        public TypeLocation Location { get; set; }
        /// <summary> Profile. </summary>
        public TypeProfile Profile { get; set; }
        /// <summary> Profile title passed as an argument to console.profile(). </summary>
        public string Title { get; set; }
    }
}
