// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Base type for data change detection policies. </summary>
    public partial class DataChangeDetectionPolicy
    {
        /// <summary> Initializes a new instance of DataChangeDetectionPolicy. </summary>
        public DataChangeDetectionPolicy()
        {
        }

        /// <summary> Initializes a new instance of DataChangeDetectionPolicy. </summary>
        /// <param name="odataType"> Identifies the concrete type of the data change detection policy. </param>
        internal DataChangeDetectionPolicy(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> Identifies the concrete type of the data change detection policy. </summary>
        internal string OdataType { get; set; }
    }
}
