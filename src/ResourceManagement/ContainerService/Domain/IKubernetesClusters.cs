// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerService.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ContainerService.Fluent.KubernetesCluster.Definition;
    using Microsoft.Azure.Management.ContainerService.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using System.Collections.Generic;

    /// <summary>
    /// Entry point to managed Kubernetes service management API.
    /// </summary>
    public interface IKubernetesClusters  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasManager<Microsoft.Azure.Management.ContainerService.Fluent.IContainerServiceManager>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<IManagedClustersOperations>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<KubernetesCluster.Definition.IBlank>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsBatchCreation<Microsoft.Azure.Management.ContainerService.Fluent.IKubernetesCluster>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.ContainerService.Fluent.IKubernetesCluster>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingById<Microsoft.Azure.Management.ContainerService.Fluent.IKubernetesCluster>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingById,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingByResourceGroup,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByResourceGroup<Microsoft.Azure.Management.ContainerService.Fluent.IKubernetesCluster>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByResourceGroup<Microsoft.Azure.Management.ContainerService.Fluent.IKubernetesCluster>
    {
        /// <summary>
        /// Returns the list of available Kubernetes versions available for the given Azure region.
        /// </summary>
        /// <param name="region">The Azure region to query into.</param>
        /// <return>A set of Kubernetes versions which can be used when creating a service in this region.</return>
        System.Collections.Generic.ISet<string> ListKubernetesVersions(Region region);

        /// <summary>
        /// Returns the list of available Kubernetes versions available for the given Azure region.
        /// </summary>
        /// <param name="region">The Azure region to query into.</param>
        /// <return>A future representation of a set of Kubernetes versions which can be used when creating a service in this region.</return>
        Task<System.Collections.Generic.ISet<string>> ListKubernetesVersionsAsync(Region region, CancellationToken cancellationToken = default(CancellationToken));
    }
}