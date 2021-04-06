// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample
{
<<<<<<< HEAD:samples/Azure.Management.Storage/Generated/Models/FileServiceData.Serialization.cs
    public partial class VirtualMachineScaleSetUpdatePublicIPAddressConfiguration : IUtf8JsonSerializable
=======
    public partial class ManagementPolicyData : IUtf8JsonSerializable
>>>>>>> 540b82afdf3620059a53181d81adac3166d4a2b4:samples/Azure.Management.Storage/Generated/Models/ManagementPolicyData.Serialization.cs
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings");
                writer.WriteObjectValue(DnsSettings);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

<<<<<<< HEAD:samples/Azure.Management.Storage/Generated/Models/FileServiceData.Serialization.cs
        internal static VirtualMachineScaleSetUpdatePublicIPAddressConfiguration DeserializeVirtualMachineScaleSetUpdatePublicIPAddressConfiguration(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings> dnsSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
=======
        internal static ManagementPolicyData DeserializeManagementPolicyData(JsonElement element)
        {
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<ManagementPolicySchema> policy = default;
            foreach (var property in element.EnumerateObject())
            {
>>>>>>> 540b82afdf3620059a53181d81adac3166d4a2b4:samples/Azure.Management.Storage/Generated/Models/ManagementPolicyData.Serialization.cs
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsSettings = VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings.DeserializeVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
<<<<<<< HEAD:samples/Azure.Management.Storage/Generated/Models/FileServiceData.Serialization.cs
            return new VirtualMachineScaleSetUpdatePublicIPAddressConfiguration(name.Value, Optional.ToNullable(idleTimeoutInMinutes), dnsSettings.Value);
=======
            return new ManagementPolicyData(Optional.ToNullable(lastModifiedTime), policy.Value);
>>>>>>> 540b82afdf3620059a53181d81adac3166d4a2b4:samples/Azure.Management.Storage/Generated/Models/ManagementPolicyData.Serialization.cs
        }
    }
}
