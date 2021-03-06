// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtParent
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region AvailabilitySets
        /// <summary> Gets an object representing a AvailabilitySetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="AvailabilitySetContainer" /> object. </returns>
        public static AvailabilitySetContainer GetAvailabilitySets(this ResourceGroupOperations resourceGroup)
        {
            return new AvailabilitySetContainer(resourceGroup);
        }
        #endregion

        #region DedicatedHostGroups
        /// <summary> Gets an object representing a DedicatedHostGroupContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroupContainer" /> object. </returns>
        public static DedicatedHostGroupContainer GetDedicatedHostGroups(this ResourceGroupOperations resourceGroup)
        {
            return new DedicatedHostGroupContainer(resourceGroup);
        }
        #endregion
    }
}
