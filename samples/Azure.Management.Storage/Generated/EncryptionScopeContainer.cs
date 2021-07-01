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
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of EncryptionScope and their operations over a StorageAccount. </summary>
    public partial class EncryptionScopeContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, EncryptionScope, EncryptionScopeData>
    {
        /// <summary> Initializes a new instance of the <see cref="EncryptionScopeContainer"/> class for mocking. </summary>
        protected EncryptionScopeContainer()
        {
        }

        /// <summary> Initializes a new instance of EncryptionScopeContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal EncryptionScopeContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private EncryptionScopesRestOperations _restClient => new EncryptionScopesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a EncryptionScope. Please note some properties can be set only during creation. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<EncryptionScope> CreateOrUpdate(string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }
                if (encryptionScope == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScope));
                }

                return StartCreateOrUpdate(encryptionScopeName, encryptionScope, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a EncryptionScope. Please note some properties can be set only during creation. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<EncryptionScope>> CreateOrUpdateAsync(string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }
                if (encryptionScope == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScope));
                }

                var operation = await StartCreateOrUpdateAsync(encryptionScopeName, encryptionScope, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a EncryptionScope. Please note some properties can be set only during creation. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public EncryptionScopesPutOperation StartCreateOrUpdate(string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }
                if (encryptionScope == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScope));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, Id.Name, encryptionScopeName, encryptionScope, cancellationToken: cancellationToken);
                return new EncryptionScopesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a EncryptionScope. Please note some properties can be set only during creation. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="encryptionScope"> Encryption scope properties to be used for the create or update. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<EncryptionScopesPutOperation> StartCreateOrUpdateAsync(string encryptionScopeName, EncryptionScopeData encryptionScope, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }
                if (encryptionScope == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScope));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, encryptionScopeName, encryptionScope, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new EncryptionScopesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<EncryptionScope> Get(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.Get");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken: cancellationToken);
                return Response.FromValue(new EncryptionScope(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="encryptionScopeName"> The name of the encryption scope within the specified storage account. Encryption scope names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<EncryptionScope>> GetAsync(string encryptionScopeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.Get");
            scope.Start();
            try
            {
                if (encryptionScopeName == null)
                {
                    throw new ArgumentNullException(nameof(encryptionScopeName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, encryptionScopeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new EncryptionScope(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EncryptionScope" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<EncryptionScope> List(CancellationToken cancellationToken = default)
        {
            Page<EncryptionScope> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EncryptionScope> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the encryption scopes available under the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EncryptionScope" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<EncryptionScope> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EncryptionScope>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EncryptionScope>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EncryptionScope(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of EncryptionScope for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(EncryptionScopeOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of EncryptionScope for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EncryptionScopeContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(EncryptionScopeOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, EncryptionScope, EncryptionScopeData> Construct() { }
    }
}
