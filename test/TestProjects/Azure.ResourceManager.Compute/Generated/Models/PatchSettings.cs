// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute
{
    /// <summary> The PatchSettings. </summary>
    public partial class PatchSettings
    {
        /// <summary> Initializes a new instance of PatchSettings. </summary>
        public PatchSettings()
        {
        }

        /// <summary> Initializes a new instance of PatchSettings. </summary>
        /// <param name="patchMode"> Specifies the mode of in-guest patching to IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false&lt;br /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br /&gt;&lt;br /&gt; ** AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true. </param>
        internal PatchSettings(InGuestPatchMode? patchMode)
        {
            PatchMode = patchMode;
        }

        /// <summary> Specifies the mode of in-guest patching to IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of patches to a virtual machine. You do this by applying patches manually inside the VM. In this mode, automatic updates are disabled; the property WindowsConfiguration.enableAutomaticUpdates must be false&lt;br /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will automatically be updated by the OS. The property WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br /&gt;&lt;br /&gt; ** AutomaticByPlatform** - the virtual machine will automatically updated by the platform. The properties provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates must be true. </summary>
        public InGuestPatchMode? PatchMode { get; set; }
    }
}
