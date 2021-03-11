// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the operations that can be performed over a specific VirtualMachineScaleSetVMExtensions. </summary>
    public partial class VirtualMachineScaleSetVMExtensionsOperations
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsOperations for mocking. </summary>
        protected VirtualMachineScaleSetVMExtensionsOperations()
        {
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="CancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of location that may take multiple service requests to iterate over. </returns>
        /// <exception cref="System.InvalidOperationException"> The default subscription id is null. </exception>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType);
        }
    }
}
