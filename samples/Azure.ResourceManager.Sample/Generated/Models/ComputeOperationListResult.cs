// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> The List Compute Operation operation response. </summary>
    internal partial class ComputeOperationListResult
    {
        /// <summary> Initializes a new instance of ComputeOperationListResult. </summary>
        internal ComputeOperationListResult()
        {
            Value = new ChangeTrackingList<RestApi>();
        }

        /// <summary> Initializes a new instance of ComputeOperationListResult. </summary>
        /// <param name="value"> The list of compute operations. </param>
        internal ComputeOperationListResult(IReadOnlyList<RestApi> value)
        {
            Value = value;
        }

        /// <summary> The list of compute operations. </summary>
        public IReadOnlyList<RestApi> Value { get; }
    }
}
