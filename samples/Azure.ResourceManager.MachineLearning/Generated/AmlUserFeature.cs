// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A Class representing a AmlUserFeature along with the instance operations that can be performed on it. </summary>
    public class AmlUserFeature : AmlUserFeatureOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "AmlUserFeature"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AmlUserFeature(ResourceOperationsBase options, AmlUserFeatureData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AmlUserFeatureData. </summary>
        public AmlUserFeatureData Data { get; private set; }

        /// <inheritdoc />
        protected override AmlUserFeature GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<AmlUserFeature> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
