// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct PrivateEndpointConnectionProvisioningState : IEquatable<PrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static PrivateEndpointConnectionProvisioningState Succeeded { get; } = new PrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static PrivateEndpointConnectionProvisioningState Creating { get; } = new PrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static PrivateEndpointConnectionProvisioningState Deleting { get; } = new PrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static PrivateEndpointConnectionProvisioningState Failed { get; } = new PrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PrivateEndpointConnectionProvisioningState left, PrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PrivateEndpointConnectionProvisioningState left, PrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator PrivateEndpointConnectionProvisioningState(string value) => new PrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
