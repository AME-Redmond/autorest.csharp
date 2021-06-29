// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    public partial class PublishedKeyListResult
    {
        internal static PublishedKeyListResult DeserializePublishedKeyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PublishedKey>> value = default;
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
                    List<PublishedKey> array = new List<PublishedKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PublishedKey.DeserializePublishedKey(item));
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
            return new PublishedKeyListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}