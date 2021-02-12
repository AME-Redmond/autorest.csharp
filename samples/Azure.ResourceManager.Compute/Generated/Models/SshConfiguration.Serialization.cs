// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    public partial class SshConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicKeys))
            {
                writer.WritePropertyName("publicKeys");
                writer.WriteStartArray();
                foreach (var item in PublicKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SshConfiguration DeserializeSshConfiguration(JsonElement element)
        {
            Optional<IList<SshPublicKey>> publicKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SshPublicKey> array = new List<SshPublicKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SshPublicKey.DeserializeSshPublicKey(item));
                    }
                    publicKeys = array;
                    continue;
                }
            }
            return new SshConfiguration(Optional.ToList(publicKeys));
        }
    }
}