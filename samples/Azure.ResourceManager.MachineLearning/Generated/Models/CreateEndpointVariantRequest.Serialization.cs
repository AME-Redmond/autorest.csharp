// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class CreateEndpointVariantRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault");
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(TrafficPercentile))
            {
                writer.WritePropertyName("trafficPercentile");
                writer.WriteNumberValue(TrafficPercentile.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(KvTags))
            {
                writer.WritePropertyName("kvTags");
                writer.WriteStartObject();
                foreach (var item in KvTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys");
                writer.WriteObjectValue(Keys);
            }
            writer.WritePropertyName("computeType");
            writer.WriteStringValue(ComputeType.ToString());
            if (Optional.IsDefined(EnvironmentImageRequest))
            {
                writer.WritePropertyName("environmentImageRequest");
                writer.WriteObjectValue(EnvironmentImageRequest);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            writer.WriteEndObject();
        }
    }
}
