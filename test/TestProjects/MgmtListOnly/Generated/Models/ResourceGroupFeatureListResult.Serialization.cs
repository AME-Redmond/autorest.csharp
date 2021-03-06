// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    internal partial class ResourceGroupFeatureListResult
    {
        internal static ResourceGroupFeatureListResult DeserializeResourceGroupFeatureListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ResourceGroupFeature>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceGroupFeature> array = new List<ResourceGroupFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGroupFeature.DeserializeResourceGroupFeature(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceGroupFeatureListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
