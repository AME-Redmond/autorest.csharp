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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Updates properties of a compute. This call will overwrite a compute if it exists. This is a nonrecoverable operation. </summary>
    public partial class MachineLearningComputeUpdateOperation : Operation<ComputeResourceData>, IOperationSource<ComputeResourceData>
    {
        private readonly OperationInternals<ComputeResourceData> _operation;

        /// <summary> Initializes a new instance of MachineLearningComputeUpdateOperation for mocking. </summary>
        protected MachineLearningComputeUpdateOperation()
        {
        }

        internal MachineLearningComputeUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ComputeResourceData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MachineLearningComputeUpdateOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ComputeResourceData Value => _operation.Value;

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
        public override ValueTask<Response<ComputeResourceData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ComputeResourceData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ComputeResourceData IOperationSource<ComputeResourceData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ComputeResourceData.DeserializeComputeResourceData(document.RootElement);
        }

        async ValueTask<ComputeResourceData> IOperationSource<ComputeResourceData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ComputeResourceData.DeserializeComputeResourceData(document.RootElement);
        }
    }
}
