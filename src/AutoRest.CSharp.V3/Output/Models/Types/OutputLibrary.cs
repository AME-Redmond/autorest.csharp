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

        private static HashSet<string> OpKeys = new HashSet<string>() { "resourcegroups", "subscriptions" };
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
                OpKeys.Add(operationGroup.Key);
            }
            uint suc = 0;
            List<(string child, string parent)> parentChildCanidates = new List<(string child, string parent)>();
            foreach (var operationGroup in _codeModel.OperationGroups)
            {
                var xyz = new RestClient(operationGroup, _context);
                List<List<ProviderToken>> tokens = new List<List<ProviderToken>>();
                var segments = new List<PathSegment[]>();
                string fortest = "List<string> tests" + operationGroup.Key + " = \n{\n";
                foreach (var method in xyz.Methods)
                {
                    fortest += "\"" + method.Request.plainTextSegment + "\",\n";
                    tokens.Add(tokenize(method.Request.plainTextSegment));
                    segments.Add(method.Request.segments);
                }
                fortest += "};\n";

                var isExtension = IsExtension(tokens, operationGroup.Key);
                var isTenantOnly = IsTenantOnly(tokens, operationGroup.Key);
                // if (isExtension)
                //{
                //System.IO.File.WriteAllText(@"C:\Users\stevens\Documents\TestStrings\" + operationGroup.Key + "_isExtensions.txt", fortest + "bool expected = true;\n");
                // Console.WriteLine("resource extension found: " + operationGroup.Key);
                //}
                if (!isExtension && !isTenantOnly)
                {
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
                            dic = parseMethod(req.segments);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("\ncould not parse : " + e.ToString() + " uri is : " + req.ToString());
                        }
                    }
                    else if (tuple.httpType == methodType.get_list || tuple.httpType == methodType.post)
                    {
                        try
                        {
                            dic = parseMethod(req.segments);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("\ncould not parse list or post: " + e.ToString() + " uri is : " + req.ToString());
                        }

                    }

                    var childParentTuple = Validate(dic, operationGroup.Key);
                    if (childParentTuple.parent == null)
                    {
                        Console.WriteLine("could not parse" + " operations " + operationGroup.Key + "\nuri: " + method.Request.ToString());
                    }
                    else
                    {
                        //Console.WriteLine(childParentTuple.child + "'s parent is " + childParentTuple.parent);
                        parentChildCanidates.Add(childParentTuple);
                    }
                    //System.IO.File.WriteAllText(@"C:\Users\stevens\Documents\TestStrings\" + operationGroup.Key + "_isNotExtensions.txt", fortest + "bool expected = false;\n");
                    //Console.WriteLine("not a resource extensions: " + operationGroup.Key);
                }
                else if (isExtension)
                {
                    Console.WriteLine("resource extension found: " + operationGroup.Key);
                    suc++;
                }
                else if (isTenantOnly)
                {
                    Console.WriteLine("tenant only found: " + operationGroup.Key);
                    suc++;
                }
                Console.WriteLine("\n-----------------------------------------\n");
            }

            foreach (var tuple in parentChildCanidates)
            {
                if (OpKeys.Contains(tuple.parent.ToLower()))
                {
                    Console.WriteLine("PASS: " + tuple.child + "'s parent is " + tuple.parent);
                    suc++;
                }
                else
                {
                    Console.WriteLine("FAIL: could not validate parent as an operation " + tuple.parent + " for child " + tuple.child);
                }
            }
            Console.WriteLine("\n--------------------------------------------\n");
            Console.WriteLine("total resources " + _codeModel.OperationGroups.Count);
            Console.WriteLine("Succesfully parsed resources " + suc);
            Console.WriteLine("Resources failed to parse " + (_codeModel.OperationGroups.Count - suc));


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
            internal bool hadSpecialReference;
            internal bool isLastProvider;
            internal ProviderToken()
            {
                location = -1;
                noPred = false;
                isRgSuc = false;
                isSubSuc = false;
                hasReferenceSuccessor = false;
                tokenValue = "";
                isFullProvider = false;
                isLastProvider = false;
                hadSpecialReference = false;
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
                    else if (currentToken.tokenValue == "" && currentConstant == "") // asuming never /{}/{}
                    {
                        currentToken.hadSpecialReference = true;
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
                    currentToken.tokenValue = canidate;
                    tokens.Add(currentToken);
                }
            }
            return tokens;
        }

        private static bool IsExtension(List<List<ProviderToken>> tokens, string operationKey)
        {
            //pseudo code 
            // check if find the following:
            //      start with reference 
            //            {any string}/provider/Microsoft.<curent resource namespace>/<current resource type>/
            //            <curent resource namespace>= last name space in the path. /
            //             <current resource typy>= comes from operationGroup.key 
            //      or
            //          based on this doc: https://armwiki.azurewebsites.net/rp_onboarding/ResourceProviderRegistrationRoutingTypes.html?q=routing
            //          we will look for any */provider/*/{}/* before : provider/Microsoft.<curent resource namespace>/<current resource type>/
            //      and 
            //      match operationKey with <current resource type> 
            //      due to poorname, match begins or ends with. 
            //
            // 
            //  
            bool foundExtension = false;
            for (int j = 0; j < tokens.Count && !foundExtension; j++)
            {
                var tokenList = tokens[j];
                bool providerBefore = false;
                for (int i = 0; i < tokenList.Count && !foundExtension; i++)
                {
                    var token = tokenList[i];
                    if (token.isFullProvider && (token.hadSpecialReference || providerBefore))
                    {
                        foundExtension = VerifyOperation(operationKey, token.tokenValue);
                    }
                    providerBefore = !providerBefore ? token.hasReferenceSuccessor : providerBefore; // once true don't unset
                }
            }
            return foundExtension;
        }

        private static bool IsTenantOnly(List<List<ProviderToken>> tokens, string operationKey)
        {
            bool foundTenant = false;
            bool foundNonTenant = false;
            for (int j = 0; j < tokens.Count && (!foundTenant || !foundNonTenant); j++)
            {
                var tokenList = tokens[j];
                for (int i = 0; i < tokenList.Count && (!foundTenant || !foundNonTenant); i++)
                {
                    var token = tokenList[i];
                    foundNonTenant = !foundNonTenant ? token.isFullProvider && !token.noPred && VerifyOperation(operationKey, token.tokenValue) : true;
                    foundTenant = !foundTenant ? token.isFullProvider && token.noPred && VerifyOperation(operationKey, token.tokenValue) : true;
                }
            }
            return foundTenant && !foundNonTenant;
        }

        private static bool VerifyOperation(string operationKey, string tokenValue)
        {
            var asSplit = tokenValue.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (asSplit.Length < 3)
            {
                throw new ArgumentException("full provider name is not formatted as expected " + tokenValue);
            }
            return ProcessOpKey(operationKey, tokenValue);
        }

        private (string child, string parent) Validate(Dictionary<string, string> hier, string key)
        {
            foreach (var parentChild in hier)
            {
                if (ProcessOpKey(key, parentChild.Key))
                {
                    return (key, parentChild.Value.Split('/', StringSplitOptions.RemoveEmptyEntries).Last());
                }
            }
            return (null, null);
        }

        private static bool ProcessOpKey(string opKey, string canidateOpKey)
        {
            Dictionary<string, string> ComputeKnownAliases = new Dictionary<string, string>()
            {
                {"VirtualMachineImages", "vmimage"},
                {"VirtualMachineExtensionImages", "vmextension"},
                {"VirtualMachineExtensions", "extensions"},
                {"VirtualMachineSizes", "vmSizes"}
            };
            var keys = canidateOpKey.Split('/', StringSplitOptions.RemoveEmptyEntries);
            foreach (var key in keys)
            {
                if (compareKeys(key, opKey))
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }
                if (ComputeKnownAliases.ContainsKey(opKey) && ComputeKnownAliases[opKey].Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    OpKeys.Add(ComputeKnownAliases[opKey].ToLower());
                    return true;
                }
                var types = "type";
                var typeMathc = key.EndsWith(types, StringComparison.OrdinalIgnoreCase) ? compareKeys(key.Substring(0, key.Length - types.Length), opKey) : false;
                if (typeMathc)
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }

                var removePlural = opKey.Substring(0, opKey.Length - 1);
                if (compareKeys(key, removePlural))
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }
                removePlural = key.Substring(0, key.Length - 1);
                if (compareKeys(removePlural, opKey))
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }
                removePlural = opKey.Substring(0, opKey.Length - 2); // es
                if (compareKeys(key, removePlural))
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }
                removePlural = key.Substring(0, key.Length - 2);
                if (compareKeys(removePlural, opKey))
                {
                    OpKeys.Add(key.ToLower());
                    return true;
                }

            }
            return false;

        }

        private static bool compareKeys(string key1, string key2)
        {
            return key2.Contains(key1, StringComparison.OrdinalIgnoreCase) || key1.Contains(key2, StringComparison.OrdinalIgnoreCase);
        }

        private static Dictionary<string, string> parseMethod(PathSegment[] segments)
        {
            var skip = !segments.Last().Value.IsConstant;
            var dic = new Dictionary<string, string>();
            string? child = null;

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
                        dic.Add(child, val.ToString());
                    }
                    skip = true;
                    child = val.ToString();
                }
                else
                {
                    skip = false;
                    if (segement.Value.IsConstant)
                    {
                        throw new ArgumentException("could not parse unexpected reference when expecting a constant in post. ");
                    }
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
                        dic.Add(child, val.ToString());
                    }
                    skip = true;
                    child = val.ToString();
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
                    if (method.Name.Split('_').Last().StartsWith("get", StringComparison.OrdinalIgnoreCase))
                    {
                        canidate = method;
                        httptype = methodType.get_get;
                    }
                    else if (method.Name.Split('_').Last().StartsWith("list", StringComparison.OrdinalIgnoreCase))
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
