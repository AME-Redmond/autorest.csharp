// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the RestApi data model. </summary>
    public partial class RestApiData
    {
        /// <summary> Initializes a new instance of RestApiData. </summary>
        internal RestApiData()
        {
        }

        /// <summary> Initializes a new instance of RestApiData. </summary>
        /// <param name="origin"> The origin of the compute operation. </param>
        /// <param name="name"> The name of the compute operation. </param>
        /// <param name="operation"> The display name of the compute operation. </param>
        /// <param name="resource"> The display name of the resource the operation applies to. </param>
        /// <param name="description"> The description of the operation. </param>
        /// <param name="provider"> The resource provider for the operation. </param>
        internal RestApiData(string origin, string name, string operation, string resource, string description, string provider)
        {
            Origin = origin;
            Name = name;
            Operation = operation;
            Resource = resource;
            Description = description;
            Provider = provider;
        }

        /// <summary> The origin of the compute operation. </summary>
        public string Origin { get; }
        /// <summary> The name of the compute operation. </summary>
        public string Name { get; }
        /// <summary> The display name of the compute operation. </summary>
        public string Operation { get; }
        /// <summary> The display name of the resource the operation applies to. </summary>
        public string Resource { get; }
        /// <summary> The description of the operation. </summary>
        public string Description { get; }
        /// <summary> The resource provider for the operation. </summary>
        public string Provider { get; }
    }
}
