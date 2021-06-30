// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;
using MgmtListOnly.Models;

namespace MgmtListOnly
{
    /// <summary> A Class representing a Fake along with the instance operations that can be performed on it. </summary>
    public class Fake : FakeOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "Fake"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal Fake(ResourceOperationsBase options, FakeData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the FakeData. </summary>
        public FakeData Data { get; private set; }

        /// <inheritdoc />
        protected override Fake GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<Fake> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
