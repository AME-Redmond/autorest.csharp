// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> Describes a Virtual Machine Scale Set VM Reimage Parameters. </summary>
    internal partial class VirtualMachineScaleSetReimageParameters : VirtualMachineScaleSetVMReimageParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetReimageParameters. </summary>
        public VirtualMachineScaleSetReimageParameters()
        {
            InstanceIds = new ChangeTrackingList<string>();
        }

        /// <summary> The virtual machine scale set instance ids. Omitting the virtual machine scale set instance ids will result in the operation being performed on all virtual machines in the virtual machine scale set. </summary>
        public IList<string> InstanceIds { get; }
    }
}
