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

    using static zfunc;

    /// <summary>
    /// Uniquely identifies an agent throughout a server complex
    /// </summary>
    
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public readonly struct AgentIdentity
    {
        /// <summary>
        /// A value that uniquely identifies the logical event source
        /// </summary>
        [FieldOffset(0)]
        public readonly uint ServerId;

        /// <summary>
        /// The time of occurrence, expressed as number of elapsed units
        /// from some fixed point in time
        /// </summary>
        [FieldOffset(4)]
        public readonly uint AgentId;

        /// <summary>
        /// A value that confers complex-wide agent identity
        /// </summary>
        [FieldOffset(0)]
        public readonly ulong Identifier;

        /// <summary>
        /// Constructs an identity from server and agent id's
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="time">The time of occurrence</param>
        public static implicit operator AgentIdentity((uint server, uint agent) src)
            => new AgentIdentity(src.server,src.agent);
        
        public static implicit operator ulong(AgentIdentity identity)
            => identity.Identifier;

        public AgentIdentity(uint ServerId, uint AgentId)
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
            this.Identifier = ((ulong)ServerId << 32) | AgentId;
        }

        public AgentIdentity(ulong Identifier)
        {
            this.Identifier = Identifier;
            this.ServerId = (uint)(Identifier >> 32);
            this.AgentId = (uint)(Identifier);
        }

        public void Deconstruct(out uint server, out uint agent)
        {
            server = ServerId;
            agent = AgentId;
        }    

        public override string ToString()
            => $"{ServerId}/{AgentId}";
    }
}