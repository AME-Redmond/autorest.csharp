// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A Class representing a Agreement along with the instance operations that can be performed on it. </summary>
    public class Agreement : AgreementOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "Agreement"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Agreement(ResourceOperationsBase options, AgreementData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the AgreementData. </summary>
        public AgreementData Data { get; private set; }

        /// <inheritdoc />
        protected override Agreement GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<Agreement> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
