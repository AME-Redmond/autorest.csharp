// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> SSH configuration for Linux based VMs running on Azure. </summary>
    public partial class SshConfiguration
    {
        /// <summary> Initializes a new instance of SshConfiguration. </summary>
        public SshConfiguration()
        {
            PublicKeys = new ChangeTrackingList<SshPublicKey>();
        }

        /// <summary> Initializes a new instance of SshConfiguration. </summary>
        /// <param name="publicKeys"> The list of SSH public keys used to authenticate with linux based VMs. </param>
        internal SshConfiguration(IList<SshPublicKey> publicKeys)
        {
            PublicKeys = publicKeys;
        }

        /// <summary> The list of SSH public keys used to authenticate with linux based VMs. </summary>
        public IList<SshPublicKey> PublicKeys { get; }
    }
}
