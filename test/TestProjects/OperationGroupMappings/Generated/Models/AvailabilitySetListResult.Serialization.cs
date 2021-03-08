// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace OperationGroupMappings
{
    internal partial class AvailabilitySetListResult
    {
        internal static AvailabilitySetListResult DeserializeAvailabilitySetListResult(JsonElement element)
        {
            IReadOnlyList<AvailabilitySet> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AvailabilitySet> array = new List<AvailabilitySet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilitySet.DeserializeAvailabilitySet(item));
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
            return new AvailabilitySetListResult(value, nextLink.Value);
        }
    }
}
