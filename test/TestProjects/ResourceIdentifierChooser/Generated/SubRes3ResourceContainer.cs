// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of SubRes3Resource and their operations over a ResourceGroup. </summary>
    public partial class SubRes3ResourceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, SubRes3Resource, SubRes3ResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="SubRes3ResourceContainer"/> class for mocking. </summary>
        protected SubRes3ResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of SubRes3ResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubRes3ResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SubRes3ResourcesRestOperations _restClient => new SubRes3ResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a SubRes3Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes3Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<SubRes3Resource> CreateOrUpdate(string subRes3ResourcesName, SubRes3ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(subRes3ResourcesName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes3Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes3Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<SubRes3Resource>> CreateOrUpdateAsync(string subRes3ResourcesName, SubRes3ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(subRes3ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes3Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes3Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public SubRes3ResourcesPutOperation StartCreateOrUpdate(string subRes3ResourcesName, SubRes3ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.Name, Id.ResourceGroupName, subRes3ResourcesName, parameters, cancellationToken: cancellationToken);
                return new SubRes3ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubRes3Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubRes3Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<SubRes3ResourcesPutOperation> StartCreateOrUpdateAsync(string subRes3ResourcesName, SubRes3ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.Name, Id.ResourceGroupName, subRes3ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new SubRes3ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<SubRes3Resource> Get(string subRes3ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.Get");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }

                var response = _restClient.Get(Id.Name, Id.ResourceGroupName, subRes3ResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new SubRes3Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subRes3ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<SubRes3Resource>> GetAsync(string subRes3ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.Get");
            scope.Start();
            try
            {
                if (subRes3ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subRes3ResourcesName));
                }

                var response = await _restClient.GetAsync(Id.Name, Id.ResourceGroupName, subRes3ResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubRes3Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubRes3Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubRes3ResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubRes3Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubRes3ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubRes3ResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, SubRes3Resource, SubRes3ResourceData> Construct() { }
    }
}
