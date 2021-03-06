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
using Azure.ResourceManager.Core;
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary> The operation to update the VMSS VM run command. </summary>
    public partial class ChildrenUpdateOperation : Operation<ChildBodySubParents>, IOperationSource<ChildBodySubParents>
    {
        private readonly OperationInternals<ChildBodySubParents> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of ChildrenUpdateOperation for mocking. </summary>
        protected ChildrenUpdateOperation()
        {
        }

        internal ChildrenUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ChildBodySubParents>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ChildrenUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ChildBodySubParents Value => _operation.Value;

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
        public override ValueTask<Response<ChildBodySubParents>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ChildBodySubParents>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ChildBodySubParents IOperationSource<ChildBodySubParents>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ChildBodySubParents(_operationBase, ChildBodyData.DeserializeChildBodyData(document.RootElement));
        }

        async ValueTask<ChildBodySubParents> IOperationSource<ChildBodySubParents>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ChildBodySubParents(_operationBase, ChildBodyData.DeserializeChildBodyData(document.RootElement));
        }
    }
}
