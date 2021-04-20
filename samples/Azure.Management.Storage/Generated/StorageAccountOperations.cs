// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing the operations that can be performed over a specific StorageAccount. </summary>
    public partial class StorageAccountOperations : ResourceOperationsBase<TenantResourceIdentifier, StorageAccount>
    {
        /// <summary> Initializes a new instance of StorageAccountOperations for mocking. </summary>
        protected StorageAccountOperations()
        {
        }

        /// <summary> Initializes a new instance of <see cref = "StorageAccountOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected StorageAccountOperations(ResourceOperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
        }

        public static readonly ResourceType ResourceType = "Azure.Management.Storage/StorageAccountOperations";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public override ArmResponse<StorageAccount> Get(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<ArmResponse<StorageAccount>> GetAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of location that may take multiple service requests to iterate over. </returns>
        /// <exception cref="InvalidOperationException"> The default subscription id is null. </exception>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken);
        }
    }
}
