// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Admin credentials for virtual machine. </summary>
    public partial class VirtualMachineSshCredentials
    {
        /// <summary> Initializes a new instance of VirtualMachineSshCredentials. </summary>
        public VirtualMachineSshCredentials()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineSshCredentials. </summary>
        /// <param name="username"> Username of admin account. </param>
        /// <param name="password"> Password of admin account. </param>
        /// <param name="publicKeyData"> Public key data. </param>
        /// <param name="privateKeyData"> Private key data. </param>
        internal VirtualMachineSshCredentials(string username, string password, string publicKeyData, string privateKeyData)
        {
            Username = username;
            Password = password;
            PublicKeyData = publicKeyData;
            PrivateKeyData = privateKeyData;
        }

        /// <summary> Username of admin account. </summary>
        public string Username { get; set; }
        /// <summary> Password of admin account. </summary>
        public string Password { get; set; }
        /// <summary> Public key data. </summary>
        public string PublicKeyData { get; set; }
        /// <summary> Private key data. </summary>
        public string PrivateKeyData { get; set; }
    }
}
