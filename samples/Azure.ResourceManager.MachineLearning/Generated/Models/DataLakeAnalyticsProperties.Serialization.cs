// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class DataLakeAnalyticsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataLakeStoreAccountName))
            {
                writer.WritePropertyName("dataLakeStoreAccountName");
                writer.WriteStringValue(DataLakeStoreAccountName);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeAnalyticsProperties DeserializeDataLakeAnalyticsProperties(JsonElement element)
        {
            Optional<string> dataLakeStoreAccountName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataLakeStoreAccountName"))
                {
                    dataLakeStoreAccountName = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeAnalyticsProperties(dataLakeStoreAccountName.Value);
        }
    }
}
