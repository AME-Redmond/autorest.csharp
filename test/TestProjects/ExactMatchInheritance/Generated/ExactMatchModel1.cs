// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace ExactMatchInheritance
{
    /// <summary> A Class representing a ExactMatchModel1 along with the instance operations that can be performed on it. </summary>
    public class ExactMatchModel1 : ExactMatchModel1Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "ExactMatchModel1"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ExactMatchModel1(ResourceOperationsBase options, ExactMatchModel1Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ExactMatchModel1Data. </summary>
        public ExactMatchModel1Data Data { get; private set; }

        /// <inheritdoc />
        protected override ExactMatchModel1 GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<ExactMatchModel1> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
