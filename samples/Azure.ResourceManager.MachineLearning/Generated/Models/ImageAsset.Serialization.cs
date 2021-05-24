// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class ImageAsset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MimeType))
            {
                writer.WritePropertyName("mimeType");
                writer.WriteStringValue(MimeType);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(Unpack))
            {
                writer.WritePropertyName("unpack");
                writer.WriteBooleanValue(Unpack.Value);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static ImageAsset DeserializeImageAsset(JsonElement element)
        {
            Optional<string> mimeType = default;
            Optional<string> url = default;
            Optional<bool> unpack = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mimeType"))
                {
                    mimeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unpack"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unpack = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ImageAsset(id, mimeType.Value, url.Value, Optional.ToNullable(unpack));
        }
    }
}
