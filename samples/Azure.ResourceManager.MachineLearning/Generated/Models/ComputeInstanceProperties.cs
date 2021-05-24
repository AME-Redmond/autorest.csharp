// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Compute Instance properties. </summary>
    public partial class ComputeInstanceProperties
    {
        /// <summary> Initializes a new instance of ComputeInstanceProperties. </summary>
        public ComputeInstanceProperties()
        {
            Applications = new ChangeTrackingList<ComputeInstanceApplication>();
            Errors = new ChangeTrackingList<MachineLearningServiceError>();
        }

        /// <summary> Initializes a new instance of ComputeInstanceProperties. </summary>
        /// <param name="vmSize"> Virtual Machine Size. </param>
        /// <param name="subnet"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="applicationSharingPolicy"> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </param>
        /// <param name="sshSettings"> Specifies policy and settings for SSH access. </param>
        /// <param name="connectivityEndpoints"> Describes all connectivity endpoints available for this ComputeInstance. </param>
        /// <param name="applications"> Describes available applications and their endpoints on this ComputeInstance. </param>
        /// <param name="createdBy"> Describes information on user who created this ComputeInstance. </param>
        /// <param name="errors"> Collection of errors encountered on this ComputeInstance. </param>
        /// <param name="state"> The current state of this ComputeInstance. </param>
        /// <param name="computeInstanceAuthorizationType"> The Compute Instance Authorization type. Available values are personal (default). </param>
        /// <param name="personalComputeInstanceSettings"> Settings for a personal compute instance. </param>
        /// <param name="setupScripts"> Details of customized scripts to execute for setting up the cluster. </param>
        /// <param name="lastOperation"> The last operation on ComputeInstance. </param>
        internal ComputeInstanceProperties(string vmSize, ResourceId subnet, ApplicationSharingPolicy? applicationSharingPolicy, ComputeInstanceSshSettings sshSettings, ComputeInstanceConnectivityEndpoints connectivityEndpoints, IReadOnlyList<ComputeInstanceApplication> applications, ComputeInstanceCreatedBy createdBy, IReadOnlyList<MachineLearningServiceError> errors, ComputeInstanceState? state, ComputeInstanceAuthorizationType? computeInstanceAuthorizationType, PersonalComputeInstanceSettings personalComputeInstanceSettings, SetupScripts setupScripts, ComputeInstanceLastOperation lastOperation)
        {
            VmSize = vmSize;
            Subnet = subnet;
            ApplicationSharingPolicy = applicationSharingPolicy;
            SshSettings = sshSettings;
            ConnectivityEndpoints = connectivityEndpoints;
            Applications = applications;
            CreatedBy = createdBy;
            Errors = errors;
            State = state;
            ComputeInstanceAuthorizationType = computeInstanceAuthorizationType;
            PersonalComputeInstanceSettings = personalComputeInstanceSettings;
            SetupScripts = setupScripts;
            LastOperation = lastOperation;
        }

        /// <summary> Virtual Machine Size. </summary>
        public string VmSize { get; set; }
        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        public ResourceId Subnet { get; set; }
        /// <summary> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </summary>
        public ApplicationSharingPolicy? ApplicationSharingPolicy { get; set; }
        /// <summary> Specifies policy and settings for SSH access. </summary>
        public ComputeInstanceSshSettings SshSettings { get; set; }
        /// <summary> Describes all connectivity endpoints available for this ComputeInstance. </summary>
        public ComputeInstanceConnectivityEndpoints ConnectivityEndpoints { get; }
        /// <summary> Describes available applications and their endpoints on this ComputeInstance. </summary>
        public IReadOnlyList<ComputeInstanceApplication> Applications { get; }
        /// <summary> Describes information on user who created this ComputeInstance. </summary>
        public ComputeInstanceCreatedBy CreatedBy { get; }
        /// <summary> Collection of errors encountered on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningServiceError> Errors { get; }
        /// <summary> The current state of this ComputeInstance. </summary>
        public ComputeInstanceState? State { get; }
        /// <summary> The Compute Instance Authorization type. Available values are personal (default). </summary>
        public ComputeInstanceAuthorizationType? ComputeInstanceAuthorizationType { get; set; }
        /// <summary> Settings for a personal compute instance. </summary>
        public PersonalComputeInstanceSettings PersonalComputeInstanceSettings { get; set; }
        /// <summary> Details of customized scripts to execute for setting up the cluster. </summary>
        public SetupScripts SetupScripts { get; set; }
        /// <summary> The last operation on ComputeInstance. </summary>
        public ComputeInstanceLastOperation LastOperation { get; }
    }
}
