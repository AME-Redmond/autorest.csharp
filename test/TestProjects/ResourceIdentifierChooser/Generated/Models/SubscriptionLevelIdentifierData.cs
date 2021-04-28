// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing the SubscriptionLevelIdentifier data model. </summary>
    public partial class SubscriptionLevelIdentifierData : TrackedResource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of SubscriptionLevelIdentifierData. </summary>
        /// <param name="location"> The location. </param>
        public SubscriptionLevelIdentifierData(LocationData location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SubscriptionLevelIdentifierData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="new"> . </param>
        internal SubscriptionLevelIdentifierData(TenantResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, LocationData location, string @new) : base(id, name, type, tags, location)
        {
            New = @new;
        }

        public string New { get; set; }
    }
}
