// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace httpInfrastructure.quirks
{
    internal partial class HttpRedirectsOperations
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of HttpRedirectsOperations. </summary>
        public HttpRedirectsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreateHead300Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/300", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head300Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head300");
            scope.Start();
            try
            {
                using var message = CreateHead300Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head300(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head300");
            scope.Start();
            try
            {
                using var message = CreateHead300Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGet300Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/300", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Get300Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get300");
            scope.Start();
            try
            {
                using var message = CreateGet300Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 300 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Get300(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get300");
            scope.Start();
            try
            {
                using var message = CreateGet300Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateHead301Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/301", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head301Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head301");
            scope.Start();
            try
            {
                using var message = CreateHead301Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head301(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head301");
            scope.Start();
            try
            {
                using var message = CreateHead301Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGet301Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/301", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Get301Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get301");
            scope.Start();
            try
            {
                using var message = CreateGet301Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 301 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Get301(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get301");
            scope.Start();
            try
            {
                using var message = CreateGet301Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut301Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/301", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put true Boolean value in request returns 301.  This request should not be automatically redirected, but should return the received 301 to the caller for evaluation. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<ResponseWithHeaders<Put301Headers>> Put301Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Put301");
            scope.Start();
            try
            {
                using var message = CreatePut301Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 301:
                        var headers = new Put301Headers(message.Response);
                        return ResponseWithHeaders.FromValue(headers, message.Response);
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put true Boolean value in request returns 301.  This request should not be automatically redirected, but should return the received 301 to the caller for evaluation. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<Put301Headers> Put301(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Put301");
            scope.Start();
            try
            {
                using var message = CreatePut301Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 301:
                        var headers = new Put301Headers(message.Response);
                        return ResponseWithHeaders.FromValue(headers, message.Response);
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateHead302Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/302", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head302Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head302");
            scope.Start();
            try
            {
                using var message = CreateHead302Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head302(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head302");
            scope.Start();
            try
            {
                using var message = CreateHead302Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGet302Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/302", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Get302Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get302");
            scope.Start();
            try
            {
                using var message = CreateGet302Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Return 302 status code and redirect to /http/success/200. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Get302(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get302");
            scope.Start();
            try
            {
                using var message = CreateGet302Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePatch302Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/302", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Patch true Boolean value in request returns 302.  This request should not be automatically redirected, but should return the received 302 to the caller for evaluation. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<ResponseWithHeaders<Patch302Headers>> Patch302Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Patch302");
            scope.Start();
            try
            {
                using var message = CreatePatch302Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 302:
                        var headers = new Patch302Headers(message.Response);
                        return ResponseWithHeaders.FromValue(headers, message.Response);
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch true Boolean value in request returns 302.  This request should not be automatically redirected, but should return the received 302 to the caller for evaluation. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<Patch302Headers> Patch302(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Patch302");
            scope.Start();
            try
            {
                using var message = CreatePatch302Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 302:
                        var headers = new Patch302Headers(message.Response);
                        return ResponseWithHeaders.FromValue(headers, message.Response);
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost303Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/303", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post true Boolean value in request returns 303.  This request should be automatically redirected usign a get, ultimately returning a 200 status code. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post303Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Post303");
            scope.Start();
            try
            {
                using var message = CreatePost303Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post true Boolean value in request returns 303.  This request should be automatically redirected usign a get, ultimately returning a 200 status code. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post303(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Post303");
            scope.Start();
            try
            {
                using var message = CreatePost303Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateHead307Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Head;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Redirect with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Head307Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head307");
            scope.Start();
            try
            {
                using var message = CreateHead307Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Redirect with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Head307(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Head307");
            scope.Start();
            try
            {
                using var message = CreateHead307Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateGet307Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Redirect get with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Get307Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get307");
            scope.Start();
            try
            {
                using var message = CreateGet307Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Redirect get with 307, resulting in a 200 success. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Get307(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Get307");
            scope.Start();
            try
            {
                using var message = CreateGet307Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateOptions307Request()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Options;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> options redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Options307Async(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Options307");
            scope.Start();
            try
            {
                using var message = CreateOptions307Request();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> options redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Options307(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Options307");
            scope.Start();
            try
            {
                using var message = CreateOptions307Request();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePut307Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Put redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Put307Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Put307");
            scope.Start();
            try
            {
                using var message = CreatePut307Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Put redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Put307(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Put307");
            scope.Start();
            try
            {
                using var message = CreatePut307Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePatch307Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Patch redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Patch307Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Patch307");
            scope.Start();
            try
            {
                using var message = CreatePatch307Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Patch redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Patch307(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Patch307");
            scope.Start();
            try
            {
                using var message = CreatePatch307Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreatePost307Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Post redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Post307Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Post307");
            scope.Start();
            try
            {
                using var message = CreatePost307Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Post redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post307(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Post307");
            scope.Start();
            try
            {
                using var message = CreatePost307Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        internal HttpMessage CreateDelete307Request(bool? booleanValue)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/http/redirect/307", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteBooleanValue(booleanValue.Value);
            request.Content = content;
            return message;
        }
        /// <summary> Delete redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> Delete307Async(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Delete307");
            scope.Start();
            try
            {
                using var message = CreateDelete307Request(booleanValue);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await message.Response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Delete redirected with 307, resulting in a 200 after redirect. </summary>
        /// <param name="booleanValue"> Simple boolean value true. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete307(bool? booleanValue, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("HttpRedirectsOperations.Delete307");
            scope.Start();
            try
            {
                using var message = CreateDelete307Request(booleanValue);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw message.Response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
