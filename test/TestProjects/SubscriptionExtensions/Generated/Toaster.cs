// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;
using SubscriptionExtensions.Models;

namespace SubscriptionExtensions
{
    /// <summary> A Class representing a Toaster along with the instance operations that can be performed on it. </summary>
    public class Toaster : ToasterOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "Toaster"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Toaster(ResourceOperationsBase options, ToasterData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ToasterData. </summary>
        public ToasterData Data { get; private set; }

        /// <inheritdoc />
        protected override Toaster GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<Toaster> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
