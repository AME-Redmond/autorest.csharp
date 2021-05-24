// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class VirtualMachineSizeListResult
    {
        internal static VirtualMachineSizeListResult DeserializeVirtualMachineSizeListResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualMachineSize>> amlCompute = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amlCompute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualMachineSize> array = new List<VirtualMachineSize>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineSize.DeserializeVirtualMachineSize(item));
                    }
                    amlCompute = array;
                    continue;
                }
            }
            return new VirtualMachineSizeListResult(Optional.ToList(amlCompute));
        }
    }
}
