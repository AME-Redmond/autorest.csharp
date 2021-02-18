// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
    public partial class HardwareProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HardwareProfile DeserializeHardwareProfile(JsonElement element)
        {
            Optional<VirtualMachineSizeTypes> vmSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vmSize = new VirtualMachineSizeTypes(property.Value.GetString());
                    continue;
                }
            }
            return new HardwareProfile(Optional.ToNullable(vmSize));
        }
    }
}
