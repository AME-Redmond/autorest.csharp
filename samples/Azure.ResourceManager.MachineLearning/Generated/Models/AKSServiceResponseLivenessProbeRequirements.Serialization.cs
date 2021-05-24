// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class AKSServiceResponseLivenessProbeRequirements : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold");
                writer.WriteNumberValue(FailureThreshold.Value);
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold");
                writer.WriteNumberValue(SuccessThreshold.Value);
            }
            if (Optional.IsDefined(TimeoutSeconds))
            {
                writer.WritePropertyName("timeoutSeconds");
                writer.WriteNumberValue(TimeoutSeconds.Value);
            }
            if (Optional.IsDefined(PeriodSeconds))
            {
                writer.WritePropertyName("periodSeconds");
                writer.WriteNumberValue(PeriodSeconds.Value);
            }
            if (Optional.IsDefined(InitialDelaySeconds))
            {
                writer.WritePropertyName("initialDelaySeconds");
                writer.WriteNumberValue(InitialDelaySeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static AKSServiceResponseLivenessProbeRequirements DeserializeAKSServiceResponseLivenessProbeRequirements(JsonElement element)
        {
            Optional<int> failureThreshold = default;
            Optional<int> successThreshold = default;
            Optional<int> timeoutSeconds = default;
            Optional<int> periodSeconds = default;
            Optional<int> initialDelaySeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failureThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    successThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeoutSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("periodSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    periodSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialDelaySeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialDelaySeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new AKSServiceResponseLivenessProbeRequirements(Optional.ToNullable(failureThreshold), Optional.ToNullable(successThreshold), Optional.ToNullable(timeoutSeconds), Optional.ToNullable(periodSeconds), Optional.ToNullable(initialDelaySeconds));
        }
    }
}
