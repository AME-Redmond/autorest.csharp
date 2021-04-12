// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OperationGroupMappings
{
    /// <summary> A Class representing a AvailabilitySet along with the instance operations that can be performed on it. </summary>
    public class AvailabilitySet : AvailabilitySetOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "AvailabilitySet"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AvailabilitySet(ResourceOperationsBase options, AvailabilitySetData resource
        {
            Data = Resource;
        }
        /// <summary> Gets or sets the AvailabilitySetData. </summary>
        /// <inheritdoc />
        protected override AvailabilitySet GetResource()
        {
            return this;
        }
        /// <inheritdoc />
        protected override Task<AvailabilitySet> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
