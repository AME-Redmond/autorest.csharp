// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtListOnly.Models
{
    /// <summary> The List Availability Set Feature operation response. </summary>
    public partial class FakeNonPageableFeatureListResult
    {
        /// <summary> Initializes a new instance of FakeNonPageableFeatureListResult. </summary>
        internal FakeNonPageableFeatureListResult()
        {
            Value = new ChangeTrackingList<FakeNonPageableFeature>();
        }

        /// <summary> Initializes a new instance of FakeNonPageableFeatureListResult. </summary>
        /// <param name="value"> The list of fakes. </param>
        internal FakeNonPageableFeatureListResult(IReadOnlyList<FakeNonPageableFeature> value)
        {
            Value = value;
        }

        /// <summary> The list of fakes. </summary>
        public IReadOnlyList<FakeNonPageableFeature> Value { get; }
    }
}
