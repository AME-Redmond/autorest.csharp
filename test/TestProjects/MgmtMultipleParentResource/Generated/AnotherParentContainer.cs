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
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of AnotherParent and their operations over a ResourceGroup. </summary>
    public partial class AnotherParentContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, AnotherParent, AnotherParentData>
    {
        /// <summary> Initializes a new instance of the <see cref="AnotherParentContainer"/> class for mocking. </summary>
        protected AnotherParentContainer()
        {
        }

        /// <summary> Initializes a new instance of AnotherParentContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AnotherParentContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private AnotherParentsRestOperations _restClient => new AnotherParentsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a AnotherParent. Please note some properties can be set only during creation. </summary>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<AnotherParent> CreateOrUpdate(string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }
                if (anotherBody == null)
                {
                    throw new ArgumentNullException(nameof(anotherBody));
                }

                return StartCreateOrUpdate(anotherName, anotherBody, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a AnotherParent. Please note some properties can be set only during creation. </summary>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<AnotherParent>> CreateOrUpdateAsync(string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }
                if (anotherBody == null)
                {
                    throw new ArgumentNullException(nameof(anotherBody));
                }

                var operation = await StartCreateOrUpdateAsync(anotherName, anotherBody, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a AnotherParent. Please note some properties can be set only during creation. </summary>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public AnotherParentsCreateOrUpdateOperation StartCreateOrUpdate(string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }
                if (anotherBody == null)
                {
                    throw new ArgumentNullException(nameof(anotherBody));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.ResourceGroupName, anotherName, anotherBody, cancellationToken: cancellationToken);
                return new AnotherParentsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, anotherName, anotherBody).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a AnotherParent. Please note some properties can be set only during creation. </summary>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="anotherBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<AnotherParentsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string anotherName, AnotherParentData anotherBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }
                if (anotherBody == null)
                {
                    throw new ArgumentNullException(nameof(anotherBody));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, anotherName, anotherBody, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new AnotherParentsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, anotherName, anotherBody).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<AnotherParent> Get(string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.Get");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, anotherName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new AnotherParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<AnotherParent>> GetAsync(string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.Get");
            scope.Start();
            try
            {
                if (anotherName == null)
                {
                    throw new ArgumentNullException(nameof(anotherName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, anotherName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AnotherParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnotherParent" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<AnotherParent> List(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<AnotherParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AnotherParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnotherParent" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<AnotherParent> ListAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AnotherParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AnotherParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of AnotherParent for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AnotherParentOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of AnotherParent for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AnotherParentContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AnotherParentOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, AnotherParent, AnotherParentData> Construct() { }
    }
}
