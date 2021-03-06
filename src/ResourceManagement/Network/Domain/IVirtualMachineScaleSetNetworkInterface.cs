// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using System.Collections.Generic;

    /// <summary>
    /// Virtual machine scale set network interface.
    /// </summary>
    public interface IVirtualMachineScaleSetNetworkInterface  :
        Microsoft.Azure.Management.Network.Fluent.INetworkInterfaceBase,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.Network.Fluent.IVirtualMachineScaleSetNetworkInterface>
    {
        /// <summary>
        /// Gets the IP configurations of this network interface, indexed by their names.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,Microsoft.Azure.Management.Network.Fluent.IVirtualMachineScaleSetNicIPConfiguration> IPConfigurations { get; }

        /// <summary>
        /// Gets the primary IP configuration of this network interface.
        /// </summary>
        Microsoft.Azure.Management.Network.Fluent.IVirtualMachineScaleSetNicIPConfiguration PrimaryIPConfiguration { get; }
    }
}