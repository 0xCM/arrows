//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System.Runtime.InteropServices;

    public enum EventKind : ushort
    {
        PulseEvent = 10,
    }

    /// <summary>
    /// Represents a pulse/tick/heartbeat relative to some frequency
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public readonly struct PulseEvent
    {
        public const EventKind Kind = EventKind.PulseEvent;

    
        public static PulseEvent Define(uint ServerId, uint AgentId, ulong Timestamp)
            => new PulseEvent(new EventIdentity(ServerId, AgentId, Timestamp, (ulong)Kind));

        PulseEvent(EventIdentity Identity)
        {
            this.Identity = Identity;
        }

        [FieldOffset(0)]
        public readonly EventIdentity Identity;
    }
}