// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetInheritance
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region SupersetModel1s
        /// <summary> Gets an object representing a SupersetModel1Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SupersetModel1Container" /> object. </returns>
        public static SupersetModel1Container GetSupersetModel1s(this ResourceGroupOperations resourceGroup)
        {
            return new SupersetModel1Container(resourceGroup);
        }
        #endregion

        #region SupersetModel4s
        /// <summary> Gets an object representing a SupersetModel4Container along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SupersetModel4Container" /> object. </returns>
        public static SupersetModel4Container GetSupersetModel4s(this ResourceGroupOperations resourceGroup)
        {
            return new SupersetModel4Container(resourceGroup);
        }
        #endregion
    }
}
