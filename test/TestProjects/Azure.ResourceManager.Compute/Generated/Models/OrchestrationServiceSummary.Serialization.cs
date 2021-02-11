// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    public partial class OrchestrationServiceSummary
    {
        internal static OrchestrationServiceSummary DeserializeOrchestrationServiceSummary(JsonElement element)
        {
            Optional<OrchestrationServiceNames> serviceName = default;
            Optional<OrchestrationServiceState> serviceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceName = new OrchestrationServiceNames(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceState = new OrchestrationServiceState(property.Value.GetString());
                    continue;
                }
            }
            return new OrchestrationServiceSummary(Optional.ToNullable(serviceName), Optional.ToNullable(serviceState));
        }
    }
}
