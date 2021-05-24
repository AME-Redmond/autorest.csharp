// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class AmlUserFeatureData
    {
        internal static AmlUserFeatureData DeserializeAmlUserFeatureData(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<string> description = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new AmlUserFeatureData(id, displayName.Value, description.Value);
        }
    }
}
