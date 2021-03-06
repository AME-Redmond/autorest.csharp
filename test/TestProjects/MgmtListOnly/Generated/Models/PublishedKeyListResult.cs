// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtListOnly.Models
{
    /// <summary> The List Resource Group Feature operation response. </summary>
    public partial class PublishedKeyListResult
    {
        /// <summary> Initializes a new instance of PublishedKeyListResult. </summary>
        internal PublishedKeyListResult()
        {
            Value = new ChangeTrackingList<PublishedKey>();
        }

        /// <summary> Initializes a new instance of PublishedKeyListResult. </summary>
        /// <param name="value"> The list of fakes. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Fakes. Call ListNext() with this URI to fetch the next page of Fakes. </param>
        internal PublishedKeyListResult(IReadOnlyList<PublishedKey> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of fakes. </summary>
        public IReadOnlyList<PublishedKey> Value { get; }
        /// <summary> The URI to fetch the next page of Fakes. Call ListNext() with this URI to fetch the next page of Fakes. </summary>
        public string NextLink { get; }
    }
}
