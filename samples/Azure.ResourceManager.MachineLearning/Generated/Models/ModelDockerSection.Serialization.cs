// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class ModelDockerSection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseImage))
            {
                writer.WritePropertyName("baseImage");
                writer.WriteStringValue(BaseImage);
            }
            if (Optional.IsDefined(BaseDockerfile))
            {
                writer.WritePropertyName("baseDockerfile");
                writer.WriteStringValue(BaseDockerfile);
            }
            if (Optional.IsDefined(BaseImageRegistry))
            {
                writer.WritePropertyName("baseImageRegistry");
                writer.WriteObjectValue(BaseImageRegistry);
            }
            writer.WriteEndObject();
        }
    }
}
