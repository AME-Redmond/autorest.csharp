// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> Identity for the virtual machine. </summary>
    public partial class VirtualMachineIdentity
    {
        /// <summary> Initializes a new instance of VirtualMachineIdentity. </summary>
        public VirtualMachineIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties>();
        }

        /// <summary> Initializes a new instance of VirtualMachineIdentity. </summary>
        /// <param name="principalId"> The principal id of virtual machine identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant id associated with the virtual machine. This property will only be provided for a system assigned identity. </param>
        /// <param name="type"> The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual machine. </param>
        /// <param name="userAssignedIdentities"> The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </param>
        internal VirtualMachineIdentity(string principalId, string tenantId, ResourceIdentityType? type, IDictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> The principal id of virtual machine identity. This property will only be provided for a system assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id associated with the virtual machine. This property will only be provided for a system assigned identity. </summary>
        public string TenantId { get; }
        /// <summary> The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual machine. </summary>
        public ResourceIdentityType? Type { get; set; }
        /// <summary> The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </summary>
        public IDictionary<string, Components1H8M3EpSchemasVirtualmachineidentityPropertiesUserassignedidentitiesAdditionalproperties> UserAssignedIdentities { get; }
    }
}
