// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a BlobService along with the instance operations that can be performed on it. </summary>
    public class BlobService : BlobServiceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "BlobService"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal BlobService(ResourceOperationsBase options, BlobServiceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the BlobServiceData. </summary>
        public BlobServiceData Data { get; private set; }

        /// <inheritdoc />
        protected override BlobService GetResource()
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<BlobService> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
