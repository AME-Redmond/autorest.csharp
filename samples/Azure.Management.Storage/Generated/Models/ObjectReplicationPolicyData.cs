// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> A class representing the ObjectReplicationPolicy data model. </summary>
    public partial class ObjectReplicationPolicyData
    {
        /// <summary> A unique id for object replication policy. </summary>
        public string PolicyId { get; }
        /// <summary> Indicates when the policy is enabled on the source account. </summary>
        public DateTimeOffset? EnabledTime { get; }
        /// <summary> Required. Source account name. </summary>
        public string SourceAccount { get; set; }
        /// <summary> Required. Destination account name. </summary>
        public string DestinationAccount { get; set; }
        /// <summary> The storage account object replication rules. </summary>
        public IList<ObjectReplicationPolicyRule> Rules { get; }
    }
}