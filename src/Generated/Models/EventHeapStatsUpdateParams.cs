// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> If heap objects tracking has been started then backend may send update for one or more fragments. </summary>
    public partial class EventHeapStatsUpdateParams
    {
        /// <summary> Initializes a new instance of EventHeapStatsUpdateParams. </summary>
        /// <param name="statsUpdate">
        /// An array of triplets. Each triplet describes a fragment. The first integer is the fragment
        /// index, the second integer is a total count of objects for the fragment, the third integer is
        /// a total size of the objects for the fragment.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="statsUpdate"/> is null. </exception>
        public EventHeapStatsUpdateParams(IEnumerable<int> statsUpdate)
        {
            Argument.AssertNotNull(statsUpdate, nameof(statsUpdate));

            StatsUpdate = statsUpdate.ToList();
        }

        /// <summary> Initializes a new instance of EventHeapStatsUpdateParams. </summary>
        /// <param name="statsUpdate">
        /// An array of triplets. Each triplet describes a fragment. The first integer is the fragment
        /// index, the second integer is a total count of objects for the fragment, the third integer is
        /// a total size of the objects for the fragment.
        /// </param>
        internal EventHeapStatsUpdateParams(IList<int> statsUpdate)
        {
            StatsUpdate = statsUpdate;
        }

        /// <summary>
        /// An array of triplets. Each triplet describes a fragment. The first integer is the fragment
        /// index, the second integer is a total count of objects for the fragment, the third integer is
        /// a total size of the objects for the fragment.
        /// </summary>
        public IList<int> StatsUpdate { get; }
    }
}