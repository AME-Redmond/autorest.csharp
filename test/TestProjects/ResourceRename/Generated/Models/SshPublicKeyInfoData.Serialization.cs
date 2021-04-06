// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ResourceRename
{
    public partial class SshPublicKeyInfoData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(KeyData))
            {
                writer.WritePropertyName("keyData");
                writer.WriteStringValue(KeyData);
            }
            writer.WriteEndObject();
        }

        internal static SshPublicKeyInfoData DeserializeSshPublicKeyInfoData(JsonElement element)
        {
            Optional<string> path = default;
            Optional<string> keyData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyData"))
                {
                    keyData = property.Value.GetString();
                    continue;
                }
            }
            return new SshPublicKeyInfoData(path.Value, keyData.Value);
        }
    }
}
