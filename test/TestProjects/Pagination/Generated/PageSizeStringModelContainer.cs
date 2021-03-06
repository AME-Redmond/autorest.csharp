// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Pagination.Models;

namespace Pagination
{
    /// <summary> A class representing collection of PageSizeStringModel and their operations over a ResourceGroup. </summary>
    public partial class PageSizeStringModelContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, PageSizeStringModel, PageSizeStringModelData>
    {
        /// <summary> Initializes a new instance of the <see cref="PageSizeStringModelContainer"/> class for mocking. </summary>
        protected PageSizeStringModelContainer()
        {
        }

        /// <summary> Initializes a new instance of PageSizeStringModelContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PageSizeStringModelContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PageSizeStringModelsRestOperations _restClient => new PageSizeStringModelsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a PageSizeStringModel. Please note some properties can be set only during creation. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PageSizeStringModel> CreateOrUpdate(string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(name, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PageSizeStringModel. Please note some properties can be set only during creation. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PageSizeStringModel>> CreateOrUpdateAsync(string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(name, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PageSizeStringModel. Please note some properties can be set only during creation. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public PageSizeStringModelsPutOperation StartCreateOrUpdate(string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, name, parameters, cancellationToken: cancellationToken);
                return new PageSizeStringModelsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PageSizeStringModel. Please note some properties can be set only during creation. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The PageSizeStringModel to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<PageSizeStringModelsPutOperation> StartCreateOrUpdateAsync(string name, PageSizeStringModelData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, name, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PageSizeStringModelsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<PageSizeStringModel> Get(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = _restClient.Get(Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                return Response.FromValue(new PageSizeStringModel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<PageSizeStringModel>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PageSizeStringModel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PageSizeStringModel" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PageSizeStringModel> List(string maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Page<PageSizeStringModel> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PageSizeStringModel> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PageSizeStringModel" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PageSizeStringModel> ListAsync(string maxpagesize = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PageSizeStringModel>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PageSizeStringModel>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, maxpagesize, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PageSizeStringModel(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of PageSizeStringModel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PageSizeStringModelOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of PageSizeStringModel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PageSizeStringModelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PageSizeStringModelOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, PageSizeStringModel, PageSizeStringModelData> Construct() { }
    }
}
