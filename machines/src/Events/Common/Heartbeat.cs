//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Captures an instant in time with respect to a server/agent
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct Heartbeat
    {
        public static implicit operator Heartbeat((uint server, uint agent, ulong time) src)
            => new Heartbeat(src.server, src.agent, src.time);

        public Heartbeat(uint ServerId, uint AgentId, ulong Timestamp)
            : this()
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
            this.Timestamp = Timestamp;
        }

        /// <summary>
        /// The originating server
        /// </summary>
        [FieldOffset(0)]
        public readonly uint ServerId;

        /// <summary>
        /// The originating agent
        /// </summary>
        [FieldOffset(4)]
        public readonly uint AgentId;

        /// <summary>
        /// Represents the time at which the event originated
        /// </summary>
        [FieldOffset(8)]
        public readonly ulong Timestamp;

        /// <summary>
        /// Specifies the point at which the hearbeat occurred
        /// </summary>
        [FieldOffset(0)]
        public readonly Origin Source;

        public override string ToString() 
            => $"({ServerId},{AgentId},{Timestamp})";
    }

}