// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ManagementPolicyBaseBlob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TierToCool != null)
            {
                writer.WritePropertyName("tierToCool");
                writer.WriteObjectValue(TierToCool);
            }
            if (TierToArchive != null)
            {
                writer.WritePropertyName("tierToArchive");
                writer.WriteObjectValue(TierToArchive);
            }
            if (Delete != null)
            {
                writer.WritePropertyName("delete");
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyBaseBlob DeserializeManagementPolicyBaseBlob(JsonElement element)
        {
            ManagementPolicyBaseBlob result = new ManagementPolicyBaseBlob();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TierToCool = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToArchive"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TierToArchive = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
                if (property.NameEquals("delete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Delete = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}