// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    internal static partial class FieldValueTypeExtensions
    {
        public static string ToSerialString(this FieldValueType value) => value switch
        {
            FieldValueType.String => "string",
            FieldValueType.Date => "date",
            FieldValueType.Time => "time",
            FieldValueType.PhoneNumber => "phoneNumber",
            FieldValueType.Number => "number",
            FieldValueType.Integer => "integer",
            FieldValueType.Array => "array",
            FieldValueType.Object => "object",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FieldValueType value.")
        };

        public static FieldValueType ToFieldValueType(this string value)
        {
            if (string.Equals(value, "string", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.String;
            if (string.Equals(value, "date", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Date;
            if (string.Equals(value, "time", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Time;
            if (string.Equals(value, "phoneNumber", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.PhoneNumber;
            if (string.Equals(value, "number", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Number;
            if (string.Equals(value, "integer", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Integer;
            if (string.Equals(value, "array", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Array;
            if (string.Equals(value, "object", StringComparison.InvariantCultureIgnoreCase)) return FieldValueType.Object;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FieldValueType value.");
        }
    }
}
