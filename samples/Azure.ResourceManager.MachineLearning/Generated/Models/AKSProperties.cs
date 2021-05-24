// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> AKS properties. </summary>
    public partial class AKSProperties
    {
        /// <summary> Initializes a new instance of AKSProperties. </summary>
        public AKSProperties()
        {
            SystemServices = new ChangeTrackingList<SystemService>();
        }

        /// <summary> Initializes a new instance of AKSProperties. </summary>
        /// <param name="clusterFqdn"> Cluster full qualified domain name. </param>
        /// <param name="systemServices"> System services. </param>
        /// <param name="agentCount"> Number of agents. </param>
        /// <param name="agentVmSize"> Agent virtual machine size. </param>
        /// <param name="clusterPurpose"> Intended usage of the cluster. </param>
        /// <param name="sslConfiguration"> SSL configuration. </param>
        /// <param name="aksNetworkingConfiguration"> AKS networking configuration for vnet. </param>
        /// <param name="loadBalancerType"> Load Balancer Type. </param>
        /// <param name="loadBalancerSubnet"> Load Balancer Subnet. </param>
        internal AKSProperties(string clusterFqdn, IReadOnlyList<SystemService> systemServices, int? agentCount, string agentVmSize, ClusterPurpose? clusterPurpose, SslConfiguration sslConfiguration, AksNetworkingConfiguration aksNetworkingConfiguration, LoadBalancerType? loadBalancerType, string loadBalancerSubnet)
        {
            ClusterFqdn = clusterFqdn;
            SystemServices = systemServices;
            AgentCount = agentCount;
            AgentVmSize = agentVmSize;
            ClusterPurpose = clusterPurpose;
            SslConfiguration = sslConfiguration;
            AksNetworkingConfiguration = aksNetworkingConfiguration;
            LoadBalancerType = loadBalancerType;
            LoadBalancerSubnet = loadBalancerSubnet;
        }

        /// <summary> Cluster full qualified domain name. </summary>
        public string ClusterFqdn { get; set; }
        /// <summary> System services. </summary>
        public IReadOnlyList<SystemService> SystemServices { get; }
        /// <summary> Number of agents. </summary>
        public int? AgentCount { get; set; }
        /// <summary> Agent virtual machine size. </summary>
        public string AgentVmSize { get; set; }
        /// <summary> Intended usage of the cluster. </summary>
        public ClusterPurpose? ClusterPurpose { get; set; }
        /// <summary> SSL configuration. </summary>
        public SslConfiguration SslConfiguration { get; set; }
        /// <summary> AKS networking configuration for vnet. </summary>
        public AksNetworkingConfiguration AksNetworkingConfiguration { get; set; }
        /// <summary> Load Balancer Type. </summary>
        public LoadBalancerType? LoadBalancerType { get; set; }
        /// <summary> Load Balancer Subnet. </summary>
        public string LoadBalancerSubnet { get; set; }
    }
}
