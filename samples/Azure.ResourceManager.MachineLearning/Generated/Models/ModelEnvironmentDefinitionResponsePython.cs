// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> Settings for a Python environment. </summary>
    public partial class ModelEnvironmentDefinitionResponsePython : ModelPythonSection
    {
        /// <summary> Initializes a new instance of ModelEnvironmentDefinitionResponsePython. </summary>
        public ModelEnvironmentDefinitionResponsePython()
        {
        }

        /// <summary> Initializes a new instance of ModelEnvironmentDefinitionResponsePython. </summary>
        /// <param name="interpreterPath"> The python interpreter path to use if an environment build is not required. The path specified gets used to call the user script. </param>
        /// <param name="userManagedDependencies"> True means that AzureML reuses an existing python environment; False means that AzureML will create a python environment based on the Conda dependencies specification. </param>
        /// <param name="condaDependencies"> A JObject containing Conda dependencies. </param>
        /// <param name="baseCondaEnvironment"> . </param>
        internal ModelEnvironmentDefinitionResponsePython(string interpreterPath, bool? userManagedDependencies, object condaDependencies, string baseCondaEnvironment) : base(interpreterPath, userManagedDependencies, condaDependencies, baseCondaEnvironment)
        {
        }
    }
}
