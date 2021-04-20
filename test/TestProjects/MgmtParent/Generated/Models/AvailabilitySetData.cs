// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtParent
{
    /// <summary> A class representing the AvailabilitySet data model. </summary>
    public partial class AvailabilitySetData : TrackedResource<TenantResourceIdentifier>
    {
        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        public AvailabilitySetData()
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="bar"> specifies the bar. </param>
        internal AvailabilitySetData(string bar)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; set; }
    }
}
