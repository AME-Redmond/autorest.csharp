// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> This model is x-ms-azure-resource, and is exactly a WritableSubResource type. </summary>
    public partial class AzureResourceFlattenModel7 : WritableSubResource
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel7. </summary>
        public AzureResourceFlattenModel7()
        {
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel7. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> . </param>
        /// <param name="type"> . </param>
        internal AzureResourceFlattenModel7(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}