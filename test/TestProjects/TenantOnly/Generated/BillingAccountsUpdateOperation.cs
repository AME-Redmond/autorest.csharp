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

namespace TenantOnly
{
    /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
    public partial class BillingAccountsUpdateOperation : Operation<BillingAccountData>, IOperationSource<BillingAccountData>
    {
        private readonly ArmOperationHelpers<BillingAccountData> _operation;

        /// <summary> Initializes a new instance of BillingAccountsUpdateOperation for mocking. </summary>
        protected BillingAccountsUpdateOperation()
        {
        }

        internal BillingAccountsUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<BillingAccountData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "BillingAccountsUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BillingAccountData Value => _operation.Value;

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
        public override ValueTask<Response<BillingAccountData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BillingAccountData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BillingAccountData IOperationSource<BillingAccountData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return BillingAccountData.DeserializeBillingAccountData(document.RootElement);
        }

        async ValueTask<BillingAccountData> IOperationSource<BillingAccountData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return BillingAccountData.DeserializeBillingAccountData(document.RootElement);
        }
    }
}
