// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of ResourceLevel and their operations over a ResourceGroup. </summary>
    public partial class ResourceLevelContainer : ContainerBase<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceLevelContainer"/> class for mocking. </summary>
        protected ResourceLevelContainer()
        {
        }

        /// <summary> Initializes a new instance of ResourceLevelContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourceLevelContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = ManagementPipelineBuilder.Build(Credential, BaseUri, ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;

        /// <summary> Represents the REST operations. </summary>
        private ResourceLevelsRestOperations _restClient => new ResourceLevelsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a ResourceLevel. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public Response<ResourceLevel> CreateOrUpdate(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(resourceLevelsName, parameters, cancellationToken: cancellationToken).WaitForCompletion();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceLevel. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<Response<ResourceLevel>> CreateOrUpdateAsync(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(resourceLevelsName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceLevel. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public ResourceLevelsPutOperation StartCreateOrUpdate(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, resourceLevelsName, parameters, cancellationToken: cancellationToken);
                return new ResourceLevelsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ResourceLevel. Please note some properties can be set only during creation. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<ResourceLevelsPutOperation> StartCreateOrUpdateAsync(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, resourceLevelsName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new ResourceLevelsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ResourceLevel" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="ResourceLevel" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ResourceLevel> List(int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResource(null, top, cancellationToken);
            return new PhWrappingPageable<GenericResource, ResourceLevel>(results, genericResource => new ResourceLevelOperations(genericResource, genericResource.Id as ResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of <see cref="ResourceLevel" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="ResourceLevel" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ResourceLevel> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResourceAsync(null, top, cancellationToken);
            return new PhWrappingAsyncPageable<GenericResource, ResourceLevel>(results, genericResource => new ResourceLevelOperations(genericResource, genericResource.Id as ResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of ResourceLevel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceLevelOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ResourceLevel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceLevelOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ResourceLevel, ResourceLevelData> Construct() { }
    }
}
