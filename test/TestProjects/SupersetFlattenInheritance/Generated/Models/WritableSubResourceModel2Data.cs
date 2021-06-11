// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the WritableSubResourceModel2 data model. </summary>
    public partial class WritableSubResourceModel2Data : WritableSubResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of WritableSubResourceModel2Data. </summary>
        public WritableSubResourceModel2Data()
        {
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="foo"> . </param>
        internal WritableSubResourceModel2Data(string id, string foo) : base(id)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
