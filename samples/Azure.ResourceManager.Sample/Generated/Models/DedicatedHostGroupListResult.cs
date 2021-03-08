// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Sample
{
    /// <summary> The List Dedicated Host Group with resource group response. </summary>
    internal partial class DedicatedHostGroupListResult
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupListResult. </summary>
        /// <param name="value"> The list of dedicated host groups. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DedicatedHostGroupListResult(IEnumerable<DedicatedHostGroup> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupListResult. </summary>
        /// <param name="value"> The list of dedicated host groups. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Dedicated Host Groups. Call ListNext() with this URI to fetch the next page of Dedicated Host Groups. </param>
        internal DedicatedHostGroupListResult(IReadOnlyList<DedicatedHostGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of dedicated host groups. </summary>
        public IReadOnlyList<DedicatedHostGroup> Value { get; }
        /// <summary> The URI to fetch the next page of Dedicated Host Groups. Call ListNext() with this URI to fetch the next page of Dedicated Host Groups. </summary>
        public string NextLink { get; }
    }
}
