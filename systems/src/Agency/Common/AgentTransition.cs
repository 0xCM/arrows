//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Specifies a transition that occurred 
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct AgentTransition
    {
        public AgentTransition(AgentIdentity Agent, ulong Timestamp, AgentState SourceState, AgentState TargetState)
        {
            this.Agent = Agent;
            this.Timestamp = Timestamp;
            this.SourceState = SourceState;
            this.TargetState = TargetState;
        }
        /// <summary>
        /// Specifies the agent that experienced the transition
        /// </summary>
        [FieldOffset(0)]
        public readonly AgentIdentity Agent;

        /// <summary>
        /// Indicates the relative time at which the transition ocurred
        /// </summary>
        [FieldOffset(8)]
        public readonly ulong Timestamp;
        
        /// <summary>
        /// Specifies the state of the agent before the transition
        /// </summary>
        [FieldOffset(16)]
        public readonly AgentState SourceState;

        /// <summary>
        /// Specifies the state of the agent ater the transition
        /// </summary>
        [FieldOffset(18)]
        public readonly AgentState TargetState;

        public override string ToString()
            => $"Agent {Agent}: {SourceState} -> {TargetState}";
    }

}