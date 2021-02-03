// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Core;

namespace AutoRest.CSharp.V3.Output.Models.Requests
{
    internal class Request
    {
        public Request(RequestMethod httpMethod, PathSegment[] pathSegments, QueryParameter[] query, RequestHeader[] headers, RequestBody? body)
        {
            HttpMethod = httpMethod;
            PathSegments = pathSegments;
            Query = query;
            Headers = headers;
            Body = body;
            segments = new PathSegment[0];
            plainTextSegment = "";

        }

        public RequestMethod HttpMethod { get; }
        public PathSegment[] PathSegments { get; }
        public QueryParameter[] Query { get; }
        public RequestHeader[] Headers { get; }
        public RequestBody? Body { get; }
        public PathSegment[] segments {get; set; }
        public string plainTextSegment {get; set; }

#pragma warning disable SA1028, CS8603, CS8602, CS8604
        public override string ToString()
        {
            string toReturn = "";
            foreach (var seg in PathSegments)
            {
                if (seg.Value.IsConstant)
                {
                    toReturn += seg.Value.Constant.Value.ToString();
                }
                else
                {
                    toReturn += "/{" + seg.Value.Reference.Name + "}/";
                }
            }
            return toReturn;
        }
    }
}
