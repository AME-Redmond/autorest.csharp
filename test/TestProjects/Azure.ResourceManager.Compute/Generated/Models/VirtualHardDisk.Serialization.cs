// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualHardDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri");
                writer.WriteStringValue(Uri);
            }
            writer.WriteEndObject();
        }

        internal static VirtualHardDisk DeserializeVirtualHardDisk(JsonElement element)
        {
            Optional<string> uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualHardDisk(uri.Value);
        }
    }
}
