// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A HDInsight compute. </summary>
    public partial class HDInsight : Compute
    {
        /// <summary> Initializes a new instance of HDInsight. </summary>
        public HDInsight()
        {
            ComputeType = ComputeType.HDInsight;
        }

        /// <summary> Initializes a new instance of HDInsight. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="computeLocation"> Location for the underlying compute. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="description"> The description of the Machine Learning compute. </param>
        /// <param name="createdOn"> The time at which the compute was created. </param>
        /// <param name="modifiedOn"> The time at which the compute was last modified. </param>
        /// <param name="resourceId"> ARM resource id of the underlying compute. </param>
        /// <param name="provisioningErrors"> Errors during provisioning. </param>
        /// <param name="isAttachedCompute"> Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication. </param>
        /// <param name="properties"> . </param>
        internal HDInsight(ComputeType computeType, string computeLocation, ProvisioningState? provisioningState, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string resourceId, IReadOnlyList<MachineLearningServiceError> provisioningErrors, bool? isAttachedCompute, bool? disableLocalAuth, HDInsightProperties properties) : base(computeType, computeLocation, provisioningState, description, createdOn, modifiedOn, resourceId, provisioningErrors, isAttachedCompute, disableLocalAuth)
        {
            Properties = properties;
            ComputeType = computeType;
        }

        public HDInsightProperties Properties { get; set; }
    }
}
