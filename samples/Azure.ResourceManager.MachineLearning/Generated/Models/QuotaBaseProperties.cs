// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> The properties for Quota update or retrieval. </summary>
    public partial class QuotaBaseProperties : SubResourceWritable
    {
        /// <summary> Initializes a new instance of QuotaBaseProperties. </summary>
        public QuotaBaseProperties()
        {
        }

        /// <summary> Specifies the resource type. </summary>
        public string Type { get; set; }
        /// <summary> The maximum permitted quota of the resource. </summary>
        public long? Limit { get; set; }
        /// <summary> An enum describing the unit of quota measurement. </summary>
        public QuotaUnit? Unit { get; set; }
    }
}
