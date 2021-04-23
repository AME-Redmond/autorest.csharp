// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace SubscriptionExtensions.Models
{
    /// <summary> The ToasterListResult. </summary>
    public partial class Toaster : TrackedResource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Toaster. </summary>
        /// <param name="location"> The location. </param>
        public Toaster(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of Toaster. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        internal Toaster(TenantResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, LocationData location, string foo) : base(id, name, type, tags, location)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}
