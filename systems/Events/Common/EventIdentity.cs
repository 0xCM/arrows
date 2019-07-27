//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines logical event identity
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct EventIdentity
    {
        /// <summary>
        /// Constructs an event identity from a (kind,server,agent,time) tuple
        /// </summary>
        /// <param name="loc">The location of occurence</param>
        /// <param name="time">The time of occurrence</param>
        /// <param name="kind">The kind of event that occurred</param>
        public static implicit operator EventIdentity((uint server, uint agent, ulong time, ulong kind) src)
            => new EventIdentity(src.server, src.agent, src.time,src.kind);

        public EventIdentity(uint ServerId, uint AgentId, ulong Timestamp, ulong Kind)
        {
            this.ServerId = ServerId;
            this.AgentId = AgentId;
            this.Timestamp = Timestamp;
            this.EventKind = Kind;
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
        /// The event classifier/discriminator
        /// </summary>        
        [FieldOffset(16)]
        public readonly ulong EventKind;

        public ulong Location
            => ((ulong)ServerId << 32) & AgentId; 

        /// <summary>
        /// Specifies the spacetime event origin
        /// </summary>
        public Origin Origin
            => (Location, Timestamp);

        public void Deconstruct(out ulong kind, out uint server, out uint agent, out ulong time)
        {
            kind = EventKind;
            server = ServerId;
            agent = AgentId;
            time = Timestamp;
        }

        public override string ToString() 
            => $"{EventKind}/{ServerId}/{AgentId}/{Timestamp}";
    }
}