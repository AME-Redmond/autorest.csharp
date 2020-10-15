// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace azure_proto_core
{
    /// <summary>
    /// TODO: foolow the full guidelines for these immutable types (IComparable, IEquatable, operator overloads, etc.)
    /// </summary>
    public class Location : IEquatable<Location>, IEquatable<string>, IComparable<Location>, IComparable<string>
    {
#pragma warning disable CS8618, CS8604, CS8602, SA1400, CS8767
        public static ref readonly Location Default => ref WestUS;
        public static readonly Location WestUS = new Location { Name = "WestUS", CanonicalName = "west-us", DisplayName = "West US" };
        public string Name { get; internal set; }
        public string CanonicalName { get; internal set; }
        public string DisplayName { get; internal set; }

        internal Location()
        {
        }

        public Location(string location)
        {
            Name = GetDefaultName(location);
            CanonicalName = GetCanonicalName(location);
            DisplayName = GetDisplayName(location);
        }

        public bool Equals(Location other)
        {
            return CanonicalName == other.CanonicalName;
        }

        public bool Equals(string other)
        {
            return CanonicalName == GetCanonicalName(other);
        }

        public override string ToString()
        {
            return DisplayName;
        }

        public static string GetCanonicalName(string name)
        {
            return name;
        }

        public static string GetDisplayName(string name)
        {
            return name;
        }

        public static string GetDefaultName(string name)
        {
            return name;
        }

        public int CompareTo(Location other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(string other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO => Implement these and standard comparison operators for all of these immutable types
        /// </summary>
        /// <param name="other"></param>
        public static implicit operator string(Location other) => other.DisplayName;
        public static implicit operator Location(string other) => new Location(other);
    }
}
