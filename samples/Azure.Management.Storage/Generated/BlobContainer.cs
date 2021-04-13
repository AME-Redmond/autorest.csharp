// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a BlobContainer along with the instance operations that can be performed on it. </summary>
    public class BlobContainer : BlobContainerOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "BlobContainer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal BlobContainer(ResourceOperationsBase options, BlobContainerData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the BlobContainerData. </summary>
        public BlobContainerData Data { get; private set; }

        /// <inheritdoc />
        protected override BlobContainer GetResource()
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<BlobContainer> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
