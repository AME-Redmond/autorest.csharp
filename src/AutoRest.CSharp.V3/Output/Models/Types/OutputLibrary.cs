// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoRest.CSharp.V3.Input;
using AutoRest.CSharp.V3.Output.Models.Requests;
using AutoRest.CSharp.V3.Output.Models.Responses;

namespace AutoRest.CSharp.V3.Output.Models.Types
{
    internal class OutputLibrary
    {

        public enum methodType
        {
            get_get, //take parent
            put, // take parent
            post, // take second element
            get_list,// take second elemen
            none
        }
        private readonly CodeModel _codeModel;
        private readonly BuildContext _context;
        private Dictionary<Schema, TypeProvider>? _models;
        private Dictionary<OperationGroup, Client>? _clients;
        private Dictionary<OperationGroup, RestClient>? _restClients;
        private Dictionary<Operation, LongRunningOperation>? _operations;
        private Dictionary<Operation, ResponseHeaderGroupType>? _headerModels;

        public OutputLibrary(CodeModel codeModel, BuildContext context)
        {
            _codeModel = codeModel;
            _context = context;
        }

        public IEnumerable<TypeProvider> Models => SchemaMap.Values;

        public IEnumerable<RestClient> RestClients => EnsureRestClients().Values;

        public IEnumerable<Client> Clients => EnsureClients().Values;

        public IEnumerable<LongRunningOperation> LongRunningOperations => EnsureLongRunningOperations().Values;

        public IEnumerable<ResponseHeaderGroupType> HeaderModels => (_headerModels ??= EnsureHeaderModels()).Values;

        private Dictionary<Operation, ResponseHeaderGroupType> EnsureHeaderModels()
        {
            if (_headerModels != null)
            {
                return _headerModels;
            }

            _headerModels = new Dictionary<Operation, ResponseHeaderGroupType>();
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                foreach (var operation in operationGroup.Operations)
                {
                    var headers = ResponseHeaderGroupType.TryCreate(operationGroup, operation, _context);
                    if (headers != null)
                    {
                        _headerModels.Add(operation, headers);
                    }
                }
            }

            return _headerModels;
        }

        private Dictionary<Operation, LongRunningOperation> EnsureLongRunningOperations()
        {
            if (_operations != null)
            {
                return _operations;
            }

            _operations = new Dictionary<Operation, LongRunningOperation>();

            if (_context.Configuration.PublicClients)
            {
                foreach (var operationGroup in _codeModel.OperationGroups)
                {
                    foreach (var operation in operationGroup.Operations)
                    {
                        if (operation.IsLongRunning)
                        {
                            _operations.Add(operation, new LongRunningOperation(operationGroup, operation, _context));
                        }
                    }
                }
            }

            return _operations;
        }

        private Dictionary<OperationGroup, Client> EnsureClients()
        {
            if (_clients != null)
            {
                return _clients;
            }

            _clients = new Dictionary<OperationGroup, Client>();

            if (_context.Configuration.PublicClients)
            {
                foreach (var operationGroup in _codeModel.OperationGroups)
                {
                    _clients.Add(operationGroup, new Client(operationGroup, _context));
                }
            }

            return _clients;
        }
#pragma warning disable SA1028, CS8603, CS8602, CS8604, CS8619, SA1316, CS0029 // Normalize strings to uppercase
        private Dictionary<OperationGroup, RestClient> EnsureRestClients()
        {
            if (_restClients != null)
            {
                return _restClients;
            }

            _restClients = new Dictionary<OperationGroup, RestClient>();
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                _restClients.Add(operationGroup, new RestClient(operationGroup, _context));
            }

            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                var xyz = new RestClient(operationGroup, _context);
                List<List<ProviderToken>> tokens = new List<List<ProviderToken>>();
                var segments = new List<PathSegment[]>();
                foreach (var method in xyz.Methods)
                {
                    tokens.Add(tokenize(method.Request.plainTextSegment));
                    segments.Add(method.Request.segments);
                }
                var isExtension = IsExtension(tokens, segments);
                if (isExtension)
                {
                    Console.WriteLine("resource extension found: " + operationGroup.Key);
                }
                if (!isExtension)
                {
                    Console.WriteLine("not a resource extensions: " + operationGroup.Key);
                }
                Console.WriteLine("\n------------------------------------\n");
            }

            /*uint suc = 0;
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                var xyz = new RestClient(operationGroup, _context);
                var tuple = GetBestMethod(xyz.Methods);
                if (tuple.method == null)
                {
                    Console.WriteLine("could not parse, no get put post or list " + "\noperations " + operationGroup.Key + "\nuri: " + xyz.Methods[0].Request.ToString() + "\n-------------------------\n");
                    continue;
                }
                Dictionary<string, string>? dic = null;
                var method = tuple.method;
                var req = method.Request;
                if (tuple.httpType == methodType.put || tuple.httpType == methodType.get_get)
                {
                    try
                    {
                        dic = ParsePutOrGet(req.segments);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("\ncould not parse : " + e.ToString() + " uri is : " + req.ToString() + "\n-------------------------\n");
                    }
                }
                else if (tuple.httpType == methodType.get_list)
                {
                    try
                    {
                        dic = ParseList(req.segments);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("\ncould not parse list : " + e.ToString() + " uri is : " + req.ToString() + "\n-------------------------\n");
                    }

                }
                else if (tuple.httpType == methodType.post)
                {
                    try
                    {
                        dic = ParsePost(req.segments);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("\ncould not parse list : " + e.ToString() + " uri is : " + req.ToString() + "\n-------------------------\n");
                    }
                }

                var printString = PrintParent(dic, operationGroup.Key);
                if (printString == null)
                {
                    Console.WriteLine("could not parse" + " operations " + operationGroup.Key + "\nuri: " + method.Request.ToString() + "\n-------------------------\n");
                }
                else
                {
                    suc++;
                    Console.WriteLine(printString + "\n-------------------------\n");
                }

            }*/

            //Console.WriteLine("\n--------------------------------------------\n");
            //Console.WriteLine("total resources " + _codeModel.OperationGroups.Count);
            //Console.WriteLine("Succesfully parsed resources " + suc);
            //Console.WriteLine("Resources failed to parse " + (_codeModel.OperationGroups.Count - suc));

            return _restClients;
        }

        internal class ProviderToken
        {
            internal int location;
            internal bool isSubSuc;
            internal bool isRgSuc;
            internal bool noPred;
            internal bool hasReferenceSuccessor;
            internal bool isFullProvider;
            internal string tokenValue;
            internal ProviderToken()
            {
                location = -1;
                noPred = false;
                isRgSuc = false;
                isSubSuc = false;
                hasReferenceSuccessor = false;
                tokenValue = "";
                isFullProvider = false;
            }
        }

        private List<ProviderToken> tokenize(string path)
        {
            string canidate = "";
            var currentToken = new ProviderToken();
            string currentConstant = "";
            var tokens = new List<ProviderToken>();
            var idx = 0;
            foreach (var ch in path)
            {
                if (ch == '{')
                {
                    if (canidate != "" && canidate != "/")
                    {
                        var asSplit = canidate.Split('/', StringSplitOptions.RemoveEmptyEntries);
                        if (asSplit.Length == 1 && asSplit.First().Equals("providers"))
                        {
                            currentToken.tokenValue = canidate;
                            currentToken.location = idx - canidate.Length;
                            currentToken.noPred = currentConstant == "";
                        }
                        else if (asSplit.Length > 1 && asSplit.First().Equals("providers"))
                        {
                            currentToken.isSubSuc = currentConstant.Equals("/subscriptions/");
                            currentToken.isRgSuc = currentConstant.Equals("/resourceGroups/");
                            currentToken.isFullProvider = true;
                            currentToken.location = idx - canidate.Length;
                            currentToken.tokenValue = canidate;
                            currentToken.noPred = currentConstant == "";
                        }
                        currentConstant = canidate;
                    }
                    canidate = "";
                }
                else if (ch == '}')
                {
                    if (canidate != "" && currentToken.tokenValue != "")
                    {
                        currentToken.hasReferenceSuccessor = currentConstant == currentToken.tokenValue;
                        tokens.Add(currentToken);
                        currentToken = new ProviderToken();
                    }
                    canidate = "";
                }
                else
                {
                    canidate += ch;
                }
                idx++;
            }

            if (canidate != "")
            {
                var asSplit = canidate.Split('/', StringSplitOptions.RemoveEmptyEntries);
                if (asSplit.Length > 1 && asSplit.First().Equals("providers"))
                {
                    currentToken.isSubSuc = currentConstant.Equals("/subscriptions/");
                    currentToken.isRgSuc = currentConstant.Equals("/resourceGroups/");
                    currentToken.noPred = currentConstant == "";
                    currentToken.isFullProvider = true;
                    currentToken.location = idx - canidate.Length;
                    tokens.Add(currentToken);
                }
            }
            return tokens;
        }

        private static bool IsExtension(List<List<ProviderToken>> tokens, List<PathSegment[]> segments)
        {

            //pseudo code based on comment from mark:
            //      I had asked the RM folks if Extensions could be limited by target resource type, and the answer was unequivocally no.  
            // check if find the following:
            //      has : {scope}/ (although blueprint may be a counter example? Although pretty sure it is one)
            //      or
            //      or has a provider/miscrosoft.{rp}/{resourceName} with the following parents in the URI of some operation
            //      a resource group
            //      a subscription
            //      no parent
            //
            //
            //      example: ManagementLocks resource in resources.json has the following URIs in operations 
            //       "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/locks": {: // resourceGroup
            //        ""/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/locks/{lockName}": ": // subscription
            //      /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/locks" :// providers
            // 
            //  question, do need a parentless provider as well??
            bool fullProviderAfterAbProvider = false;
            bool attachedToRg = false;
            bool attachedToSubscription = false;
            bool hasSpecialScope = false;
            bool tenant = false;
            for (int j = 0; j < tokens.Count; j++)
            {
                var tokenList = tokens[j];
                bool providerWithReference = false;
                for (int i = 0; i < tokenList.Count; i++)
                {
                    var token = tokenList[i];
                    if (token.hasReferenceSuccessor && !token.isFullProvider && !providerWithReference && !token.noPred)
                    {
                        providerWithReference = true;
                    }
                    if (token.isFullProvider && providerWithReference)
                    {
                        fullProviderAfterAbProvider = true;
                    }
                    if (token.isFullProvider && token.isSubSuc)
                    {
                        attachedToSubscription = true;
                    }
                    if (token.isFullProvider && token.isRgSuc)
                    {
                        attachedToRg = true;
                    }
                    if (!token.isFullProvider && token.noPred)
                    {
                        tenant = true;
                    }
                }
                hasSpecialScope = !hasSpecialScope ? (segments[j].Length > 0 ? (segments[j].First().Value.IsConstant ? false : true) : false) : true;
            }
            Console.WriteLine("had tenant " + tenant);
            return (fullProviderAfterAbProvider && attachedToRg && attachedToSubscription) || hasSpecialScope;
        }

        private string PrintParent(Dictionary<string, string> hier, string key)
        {
            string? returnString = null;
            if (hier == null)
            {
                return null;
            }
            foreach (var parentChild in hier)
            {
                returnString = ProcessOpKey(key, parentChild.Key, parentChild.Value);
                if (returnString != null)
                {
                    return returnString;
                }
            }
            return returnString;
        }

        private string ProcessOpKey(string opKey, string canidateOpKey, string key2Value)
        {
            if (compareKeys(opKey, canidateOpKey))
            {
                return (opKey + "'s parent is " + key2Value);
            }

            var removePlural = opKey.Substring(0, opKey.Length - 1);
            if (compareKeys(removePlural, canidateOpKey))
            {
                return (opKey + "'s parent is " + key2Value);
            }
            var types = "type";
            var match = canidateOpKey.EndsWith(types, StringComparison.OrdinalIgnoreCase) ? compareKeys(canidateOpKey.Substring(0, canidateOpKey.Length - types.Length), opKey) : false;
            if (match)
            {
                return (opKey + "'s parent is " + key2Value);
            }

            return null;

        }

        private bool compareKeys(string key1, string key2)
        {
            return key2.Contains(key1, StringComparison.OrdinalIgnoreCase) || key1.Contains(key2, StringComparison.OrdinalIgnoreCase);
        }
        private static Dictionary<string, string> ParsePost(PathSegment[] segments)
        {
            if (!segments.Last().Value.IsConstant)
            {
                throw new ArgumentException("could not parse post ending in a reference ");
            }
            var dic = new Dictionary<string, string>();
            string? child = null;
            bool skip = false;

            for (int i = segments.Length - 1; i > -1; i--)
            {
                var segement = segments[i];
                if (!skip)
                {
                    var val = segement.Value.IsConstant ? segement.Value.Constant.Value : segement.Value.Reference.Name;
                    string[] parsed = val.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);
                    bool isProvider = parsed.First() == "providers";
                    string parent = isProvider ? parsed.Last().Trim('{').Trim('}') : parsed.First().Trim('{').Trim('}');
                    if (child != null)
                    {
                        //Console.WriteLine(child + "'s parent is : " + parent);
                        dic.Add(child, parent);
                    }
                    skip = true;
                    child = parent;
                }
                else
                {
                    skip = false;
                    // Assert not skipping constants, only references;
                    if (segement.Value.IsConstant)
                    {
                        throw new ArgumentException("could not parse unexpected reference when expecting a constant in post. ");
                    }
                }
            }
            return dic;
        }
        private static Dictionary<string, string> ParseList(PathSegment[] segments)
        {
            if (!segments.Last().Value.IsConstant)
            {
                throw new ArgumentException("could not parse list ending in a reference ");
            }
            var dic = new Dictionary<string, string>();
            string? child = null;
            bool skip = false;

            for (int i = segments.Length - 1; i > -1; i--)
            {
                var segement = segments[i];
                if (!skip)
                {
                    var val = segement.Value.IsConstant ? segement.Value.Constant.Value : segement.Value.Reference.Name;
                    string[] parsed = val.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);
                    bool isProvider = parsed[0] == "providers";
                    string parent = parsed.Last().Trim('{').Trim('}');
                    if (child != null)
                    {
                        //Console.WriteLine(child + "'s parent is : " + parent);
                        dic.Add(child, parent);
                    }
                    skip = true;
                    child = parent;
                }
                else
                {
                    skip = false;
                    // Assert not skipping constants, only references;
                    Debug.Assert(!segement.Value.IsConstant);
                }
            }
            return dic;
        }
        private static Dictionary<string, string> ParsePutOrGet(PathSegment[] segments)
        {
            var dic = new Dictionary<string, string>();

            // for put last item must be reference not a constant and not null name
            if (segments.Last().Value.IsConstant || segments.Last().Value.Reference.Name == null)
            {
                throw new ArgumentException("could not parse put or get ending in a constant ");
            }
            string? child = null;
            bool skip = true;

            // for put pair every other (regardless of reference or constant) as parent. 
            // Note references can have parents, see trafficmanger endpoints
            // https://github.com/Azure/azure-rest-api-specs/blob/a03508f020d0cc08f42d7a640149b6ffb1981593/specification/trafficmanager/resource-manager/Microsoft.Network/stable/2017-05-01/trafficmanager.json#L18
            // https://github.com/Azure/azure-rest-api-specs/blob/490bfe0d0c278bb97f5185748c9767dc831d2935/specification/privatedns/resource-manager/Microsoft.Network/stable/2018-09-01/privatedns.json#L744
            //
            // For reference types, the real child or parent name will be pulled from the operation id
            for (int i = segments.Length - 1; i > -1; i--)
            {
                var segement = segments[i];
                if (!skip)
                {
                    var val = segement.Value.IsConstant ? segement.Value.Constant.Value : segement.Value.Reference.Name;
                    string[] parsed = val.ToString().Split('/', StringSplitOptions.RemoveEmptyEntries);
                    bool isProvider = parsed[0] == "providers";
                    string parent = parsed.Last().Trim('{').Trim('}');
                    if (child != null)
                    {
                        //Console.WriteLine(child + "'s parent is : " + parent);
                        dic.Add(child, parent);
                    }
                    skip = true;
                    child = parent;
                }
                else
                {
                    skip = false;
                    // Assert not skipping constants, only references;
                    if (segement.Value.IsConstant)
                    {
                        throw new ArgumentException("could not parse unexpected reference when expecting a constant in get. ");
                    }
                }
            }

            return dic;
        }

        private (RestClientMethod method, methodType httpType) GetBestMethod(RestClientMethod[] Methods)
        {
            RestClientMethod? canidate = null;
            methodType httptype = methodType.none;
            foreach (var method in Methods)
            {
                if (method.Request.HttpMethod.Method == "PUT")
                {
                    return (method, methodType.put);
                }
                else if (string.Equals(method.Request.HttpMethod.Method, "GET", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.Equals(method.Name.Split('_').Last(), "get", StringComparison.OrdinalIgnoreCase))
                    {
                        canidate = method;
                        httptype = methodType.get_get;
                    }
                    else if (method.Name.Split('_').Last().Contains("list", StringComparison.OrdinalIgnoreCase))
                    {
                        canidate ??= method;
                        if (httptype == methodType.none)
                        {
                            httptype = methodType.get_list;
                        }
                    }
                }
                else if (string.Equals(method.Request.HttpMethod.Method, "POST", StringComparison.OrdinalIgnoreCase))
                {
                    canidate ??= method;
                    if (httptype == methodType.none)
                    {
                        httptype = methodType.post;
                    }
                }
            }

            return (canidate, httptype);
        }

        public TypeProvider FindTypeForSchema(Schema schema)
        {
            return SchemaMap[schema];
        }

        private Dictionary<Schema, TypeProvider> SchemaMap => _models ??= BuildModels();

        private Dictionary<Schema, TypeProvider> BuildModels()
        {
            var allSchemas = _codeModel.Schemas.Choices.Cast<Schema>()
                .Concat(_codeModel.Schemas.SealedChoices)
                .Concat(_codeModel.Schemas.Objects)
                .Concat(_codeModel.Schemas.Groups);

            return allSchemas.ToDictionary(schema => schema, BuildModel);
        }

        private TypeProvider BuildModel(Schema schema) => schema switch
        {
            SealedChoiceSchema sealedChoiceSchema => (TypeProvider)new EnumType(sealedChoiceSchema, _context),
            ChoiceSchema choiceSchema => new EnumType(choiceSchema, _context),
            ObjectSchema objectSchema => new ObjectType(objectSchema, _context),
            _ => throw new NotImplementedException()
        };

        public LongRunningOperation FindLongRunningOperation(Operation operation)
        {
            Debug.Assert(operation.IsLongRunning);

            return EnsureLongRunningOperations()[operation];
        }

        public Client? FindClient(OperationGroup operationGroup)
        {
            EnsureClients().TryGetValue(operationGroup, out var client);
            return client;
        }

        public RestClient FindRestClient(OperationGroup operationGroup)
        {
            return EnsureRestClients()[operationGroup];
        }

        public ResponseHeaderGroupType? FindHeaderModel(Operation operation)
        {
            EnsureHeaderModels().TryGetValue(operation, out var model);
            return model;
        }
    }
}
