// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> The SharedPrivateLinkResource. </summary>
    public partial class SharedPrivateLinkResource
    {
        /// <summary> Initializes a new instance of SharedPrivateLinkResource. </summary>
        public SharedPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of SharedPrivateLinkResource. </summary>
        /// <param name="name"> Unique name of the private link. </param>
        /// <param name="privateLinkResourceId"> The resource id that private link links to. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requestMessage"> Request message. </param>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </param>
        internal SharedPrivateLinkResource(string name, string privateLinkResourceId, string groupId, string requestMessage, PrivateEndpointServiceConnectionStatus? status)
        {
            Name = name;
            PrivateLinkResourceId = privateLinkResourceId;
            GroupId = groupId;
            RequestMessage = requestMessage;
            Status = status;
        }

        /// <summary> Unique name of the private link. </summary>
        public string Name { get; set; }
        /// <summary> The resource id that private link links to. </summary>
        public string PrivateLinkResourceId { get; set; }
        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; set; }
        /// <summary> Request message. </summary>
        public string RequestMessage { get; set; }
        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
        public PrivateEndpointServiceConnectionStatus? Status { get; set; }
    }
}
