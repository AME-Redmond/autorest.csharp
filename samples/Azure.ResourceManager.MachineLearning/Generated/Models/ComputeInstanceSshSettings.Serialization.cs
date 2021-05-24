// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class ComputeInstanceSshSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SshPublicAccess))
            {
                writer.WritePropertyName("sshPublicAccess");
                writer.WriteStringValue(SshPublicAccess.Value.ToString());
            }
            if (Optional.IsDefined(AdminPublicKey))
            {
                writer.WritePropertyName("adminPublicKey");
                writer.WriteStringValue(AdminPublicKey);
            }
            writer.WriteEndObject();
        }

        internal static ComputeInstanceSshSettings DeserializeComputeInstanceSshSettings(JsonElement element)
        {
            Optional<SshPublicAccess> sshPublicAccess = default;
            Optional<string> adminUserName = default;
            Optional<int> sshPort = default;
            Optional<string> adminPublicKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPublicAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sshPublicAccess = new SshPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adminUserName"))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sshPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adminPublicKey"))
                {
                    adminPublicKey = property.Value.GetString();
                    continue;
                }
            }
            return new ComputeInstanceSshSettings(Optional.ToNullable(sshPublicAccess), adminUserName.Value, Optional.ToNullable(sshPort), adminPublicKey.Value);
        }
    }
}
