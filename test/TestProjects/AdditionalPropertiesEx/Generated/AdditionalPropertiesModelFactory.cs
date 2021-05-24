// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using AdditionalPropertiesEx.Models;

namespace AdditionalPropertiesEx
{
    /// <summary> Model factory for AdditionalProperties read-only models. </summary>
    public static partial class AdditionalPropertiesModelFactory
    {
        /// <summary> Initializes new instance of OutputAdditionalPropertiesModel class. </summary>
        /// <param name="id"> . </param>
        /// <param name="additionalProperties"> . </param>
        /// <returns> A new <see cref="Models.OutputAdditionalPropertiesModel"/> instance for mocking. </returns>
        public static OutputAdditionalPropertiesModel OutputAdditionalPropertiesModel(int id = default, IReadOnlyDictionary<string, string> additionalProperties = default)
        {
            additionalProperties ??= new Dictionary<string, string>();
            return new OutputAdditionalPropertiesModel(id, additionalProperties);
        }

        /// <summary> Initializes new instance of OutputAdditionalPropertiesModelStruct structure. </summary>
        /// <param name="id"> . </param>
        /// <param name="additionalProperties"> . </param>
        /// <returns> A new <see cref="Models.OutputAdditionalPropertiesModelStruct"/> instance for mocking. </returns>
        public static OutputAdditionalPropertiesModelStruct OutputAdditionalPropertiesModelStruct(int id = default, IReadOnlyDictionary<string, string> additionalProperties = default)
        {
            additionalProperties ??= new Dictionary<string, string>();
            return new OutputAdditionalPropertiesModelStruct(id, additionalProperties);
        }
    }
}
