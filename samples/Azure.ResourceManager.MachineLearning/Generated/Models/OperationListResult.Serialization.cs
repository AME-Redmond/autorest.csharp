// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal partial class OperationListResult
    {
        internal static OperationListResult DeserializeOperationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Operation>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Operation> array = new List<Operation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Operation.DeserializeOperation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new OperationListResult(Optional.ToList(value));
        }
    }
}
