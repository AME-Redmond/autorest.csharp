// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Service principal credentials. </summary>
    internal partial class ServicePrincipalCredentials
    {
        /// <summary> Initializes a new instance of ServicePrincipalCredentials. </summary>
        /// <param name="clientId"> Client Id. </param>
        /// <param name="clientSecret"> Client secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> or <paramref name="clientSecret"/> is null. </exception>
        internal ServicePrincipalCredentials(string clientId, string clientSecret)
        {
            if (clientId == null)
            {
                throw new ArgumentNullException(nameof(clientId));
            }
            if (clientSecret == null)
            {
                throw new ArgumentNullException(nameof(clientSecret));
            }

            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        /// <summary> Client Id. </summary>
        public string ClientId { get; }
        /// <summary> Client secret. </summary>
        public string ClientSecret { get; }
    }
}
