// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using lro.Models;

namespace lro
{
    /// <summary> Long running put request, service returns a Product with &apos;ProvisioningState&apos; = &apos;Creating&apos; and 201 response code. </summary>
    public partial class LrosaDsPutNonRetry201Creating400InvalidJsonOperation : Operation<Product>, IOperationSource<Product>
    {
        private readonly OperationInternals<Product> _operation;

        /// <summary> Initializes a new instance of LrosaDsPutNonRetry201Creating400InvalidJsonOperation for mocking. </summary>
        protected LrosaDsPutNonRetry201Creating400InvalidJsonOperation()
        {
        }

        internal LrosaDsPutNonRetry201Creating400InvalidJsonOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<Product>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "LrosaDsPutNonRetry201Creating400InvalidJsonOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Product Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Product>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Product>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Product IOperationSource<Product>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return Product.DeserializeProduct(document.RootElement);
        }

        async ValueTask<Product> IOperationSource<Product>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return Product.DeserializeProduct(document.RootElement);
        }
    }
}
