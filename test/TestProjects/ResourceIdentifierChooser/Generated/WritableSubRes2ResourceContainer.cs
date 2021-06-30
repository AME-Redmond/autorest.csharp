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
    /// <summary> A class representing collection of WritableSubRes2Resource and their operations over a Tenant. </summary>
    public partial class WritableSubRes2ResourceContainer : ResourceContainerBase<TenantResourceIdentifier, WritableSubRes2Resource, WritableSubRes2ResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="WritableSubRes2ResourceContainer"/> class for mocking. </summary>
        protected WritableSubRes2ResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of WritableSubRes2ResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WritableSubRes2ResourceContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private WritableSubRes2ResourcesRestOperations _restClient => new WritableSubRes2ResourcesRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a WritableSubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<WritableSubRes2Resource> CreateOrUpdate(string writableSubRes2ResourcesName, WritableSubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(writableSubRes2ResourcesName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<WritableSubRes2Resource>> CreateOrUpdateAsync(string writableSubRes2ResourcesName, WritableSubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(writableSubRes2ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public WritableSubRes2ResourcesPutOperation StartCreateOrUpdate(string writableSubRes2ResourcesName, WritableSubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(writableSubRes2ResourcesName, parameters, cancellationToken: cancellationToken);
                return new WritableSubRes2ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubRes2Resource. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubRes2Resource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<WritableSubRes2ResourcesPutOperation> StartCreateOrUpdateAsync(string writableSubRes2ResourcesName, WritableSubRes2ResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(writableSubRes2ResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new WritableSubRes2ResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<WritableSubRes2Resource> Get(string writableSubRes2ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.Get");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }

                var response = _restClient.Get(writableSubRes2ResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new WritableSubRes2Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="writableSubRes2ResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<WritableSubRes2Resource>> GetAsync(string writableSubRes2ResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.Get");
            scope.Start();
            try
            {
                if (writableSubRes2ResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubRes2ResourcesName));
                }

                var response = await _restClient.GetAsync(writableSubRes2ResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WritableSubRes2Resource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of WritableSubRes2Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubRes2ResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of WritableSubRes2Resource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubRes2ResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubRes2ResourceOperations.ResourceType);
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
        // public ArmBuilder<TenantResourceIdentifier, WritableSubRes2Resource, WritableSubRes2ResourceData> Construct() { }
    }
}
