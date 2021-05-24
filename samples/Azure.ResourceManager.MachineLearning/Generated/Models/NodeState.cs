// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> State of the compute node. Values are idle, running, preparing, unusable, leaving and preempted. </summary>
    public readonly partial struct NodeState : IEquatable<NodeState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NodeState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NodeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IdleValue = "idle";
        private const string RunningValue = "running";
        private const string PreparingValue = "preparing";
        private const string UnusableValue = "unusable";
        private const string LeavingValue = "leaving";
        private const string PreemptedValue = "preempted";

        /// <summary> idle. </summary>
        public static NodeState Idle { get; } = new NodeState(IdleValue);
        /// <summary> running. </summary>
        public static NodeState Running { get; } = new NodeState(RunningValue);
        /// <summary> preparing. </summary>
        public static NodeState Preparing { get; } = new NodeState(PreparingValue);
        /// <summary> unusable. </summary>
        public static NodeState Unusable { get; } = new NodeState(UnusableValue);
        /// <summary> leaving. </summary>
        public static NodeState Leaving { get; } = new NodeState(LeavingValue);
        /// <summary> preempted. </summary>
        public static NodeState Preempted { get; } = new NodeState(PreemptedValue);
        /// <summary> Determines if two <see cref="NodeState"/> values are the same. </summary>
        public static bool operator ==(NodeState left, NodeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NodeState"/> values are not the same. </summary>
        public static bool operator !=(NodeState left, NodeState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NodeState"/>. </summary>
        public static implicit operator NodeState(string value) => new NodeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NodeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NodeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
