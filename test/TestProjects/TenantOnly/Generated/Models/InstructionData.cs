// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A class representing the Instruction data model. </summary>
    public partial class InstructionData : Azure.ResourceManager.Core.Resource
    {
        /// <summary> Initializes a new instance of InstructionData. </summary>
        public InstructionData()
        {
        }

        /// <summary> Initializes a new instance of InstructionData. </summary>
        /// <param name="amount"> The amount budgeted for this billing instruction. </param>
        /// <param name="startDate"> The date this billing instruction goes into effect. </param>
        /// <param name="endDate"> The date this billing instruction is no longer in effect. </param>
        /// <param name="creationDate"> The date this billing instruction was created. </param>
        internal InstructionData(float? amount, DateTimeOffset? startDate, DateTimeOffset? endDate, DateTimeOffset? creationDate)
        {
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
            CreationDate = creationDate;
        }

        /// <summary> The amount budgeted for this billing instruction. </summary>
        public float? Amount { get; set; }
        /// <summary> The date this billing instruction goes into effect. </summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary> The date this billing instruction is no longer in effect. </summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary> The date this billing instruction was created. </summary>
        public DateTimeOffset? CreationDate { get; set; }
    }
}
