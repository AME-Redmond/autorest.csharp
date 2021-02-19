// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace TenantOnly
{
    /// <summary> The list of invoice section properties with create subscription permission. </summary>
    public partial class InvoiceSectionListWithCreateSubPermissionResult
    {
        /// <summary> Initializes a new instance of InvoiceSectionListWithCreateSubPermissionResult. </summary>
        internal InvoiceSectionListWithCreateSubPermissionResult()
        {
            Value = new ChangeTrackingList<InstructionProperties>();
        }

        /// <summary> Initializes a new instance of InvoiceSectionListWithCreateSubPermissionResult. </summary>
        /// <param name="value"> The list of invoice section properties with create subscription permission. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal InvoiceSectionListWithCreateSubPermissionResult(IReadOnlyList<InstructionProperties> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of invoice section properties with create subscription permission. </summary>
        public IReadOnlyList<InstructionProperties> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
