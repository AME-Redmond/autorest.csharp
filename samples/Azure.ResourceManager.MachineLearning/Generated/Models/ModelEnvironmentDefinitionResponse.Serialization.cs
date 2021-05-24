// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class ModelEnvironmentDefinitionResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Python))
            {
                writer.WritePropertyName("python");
                writer.WriteObjectValue(Python);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Docker))
            {
                writer.WritePropertyName("docker");
                writer.WriteObjectValue(Docker);
            }
            if (Optional.IsDefined(Spark))
            {
                writer.WritePropertyName("spark");
                writer.WriteObjectValue(Spark);
            }
            if (Optional.IsDefined(R))
            {
                writer.WritePropertyName("r");
                writer.WriteObjectValue(R);
            }
            if (Optional.IsDefined(InferencingStackVersion))
            {
                writer.WritePropertyName("inferencingStackVersion");
                writer.WriteStringValue(InferencingStackVersion);
            }
            writer.WriteEndObject();
        }

        internal static ModelEnvironmentDefinitionResponse DeserializeModelEnvironmentDefinitionResponse(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> version = default;
            Optional<ModelEnvironmentDefinitionResponsePython> python = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<ModelEnvironmentDefinitionResponseDocker> docker = default;
            Optional<ModelEnvironmentDefinitionResponseSpark> spark = default;
            Optional<ModelEnvironmentDefinitionResponseR> r = default;
            Optional<string> inferencingStackVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("python"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    python = ModelEnvironmentDefinitionResponsePython.DeserializeModelEnvironmentDefinitionResponsePython(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("docker"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    docker = ModelEnvironmentDefinitionResponseDocker.DeserializeModelEnvironmentDefinitionResponseDocker(property.Value);
                    continue;
                }
                if (property.NameEquals("spark"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spark = ModelEnvironmentDefinitionResponseSpark.DeserializeModelEnvironmentDefinitionResponseSpark(property.Value);
                    continue;
                }
                if (property.NameEquals("r"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    r = ModelEnvironmentDefinitionResponseR.DeserializeModelEnvironmentDefinitionResponseR(property.Value);
                    continue;
                }
                if (property.NameEquals("inferencingStackVersion"))
                {
                    inferencingStackVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ModelEnvironmentDefinitionResponse(name.Value, version.Value, python.Value, Optional.ToDictionary(environmentVariables), docker.Value, spark.Value, r.Value, inferencingStackVersion.Value);
        }
    }
}
