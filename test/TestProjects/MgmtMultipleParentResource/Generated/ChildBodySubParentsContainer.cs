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
    /// <summary> A class representing collection of ChildBodySubParents and their operations over a SubParent. </summary>
    public partial class ChildBodySubParentsContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ChildBodySubParents, ChildBodyData>
    {
        /// <summary> Initializes a new instance of the <see cref="ChildBodySubParentsContainer"/> class for mocking. </summary>
        protected ChildBodySubParentsContainer()
        {
        }

        /// <summary> Initializes a new instance of ChildBodySubParentsContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ChildBodySubParentsContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ChildrenRestOperations _restClient => new ChildrenRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SubParentOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a ChildBodySubParents. Please note some properties can be set only during creation. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<ChildBodySubParents> CreateOrUpdate(string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }
                if (childBody == null)
                {
                    throw new ArgumentNullException(nameof(childBody));
                }

                return StartCreateOrUpdate(childName, childBody, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ChildBodySubParents. Please note some properties can be set only during creation. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<ChildBodySubParents>> CreateOrUpdateAsync(string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }
                if (childBody == null)
                {
                    throw new ArgumentNullException(nameof(childBody));
                }

                var operation = await StartCreateOrUpdateAsync(childName, childBody, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ChildBodySubParents. Please note some properties can be set only during creation. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public ChildrenCreateOrUpdateOperation StartCreateOrUpdate(string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }
                if (childBody == null)
                {
                    throw new ArgumentNullException(nameof(childBody));
                }

                var originalResponse = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, childBody, cancellationToken: cancellationToken);
                return new ChildrenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, childBody).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a ChildBodySubParents. Please note some properties can be set only during creation. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<ChildrenCreateOrUpdateOperation> StartCreateOrUpdateAsync(string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }
                if (childBody == null)
                {
                    throw new ArgumentNullException(nameof(childBody));
                }

                var originalResponse = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, childBody, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new ChildrenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, childBody).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<ChildBodySubParents> Get(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.Get");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new ChildBodySubParents(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<ChildBodySubParents>> GetAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.Get");
            scope.Start();
            try
            {
                if (childName == null)
                {
                    throw new ArgumentNullException(nameof(childName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, childName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ChildBodySubParents(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ChildBodySubParents" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<ChildBodySubParents> List(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ChildBodySubParents> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ChildBodySubParents(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ChildBodySubParents> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ChildBodySubParents(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ChildBodySubParents" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ChildBodySubParents> ListAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ChildBodySubParents>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ChildBodySubParents(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ChildBodySubParents>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ChildBodySubParents(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of ChildBodySubParents for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ChildBodySubParentsOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ChildBodySubParents for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ChildBodySubParentsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ChildBodySubParentsOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, ChildBodySubParents, ChildBodyData> Construct() { }
    }
}
