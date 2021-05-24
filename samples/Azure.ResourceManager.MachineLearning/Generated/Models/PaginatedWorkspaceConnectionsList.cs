// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Paginated list of Workspace connection objects. </summary>
    internal partial class PaginatedWorkspaceConnectionsList
    {
        /// <summary> Initializes a new instance of PaginatedWorkspaceConnectionsList. </summary>
        internal PaginatedWorkspaceConnectionsList()
        {
            Value = new ChangeTrackingList<WorkspaceConnectionData>();
        }

        /// <summary> Initializes a new instance of PaginatedWorkspaceConnectionsList. </summary>
        /// <param name="value"> An array of Workspace connection objects. </param>
        /// <param name="nextLink"> A continuation link (absolute URI) to the next page of results in the list. </param>
        internal PaginatedWorkspaceConnectionsList(IReadOnlyList<WorkspaceConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of Workspace connection objects. </summary>
        public IReadOnlyList<WorkspaceConnectionData> Value { get; }
        /// <summary> A continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}
