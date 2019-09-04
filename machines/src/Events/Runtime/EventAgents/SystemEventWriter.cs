//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.Tracing;
    using System.Collections.Generic;
    using static zfunc;

    using Z0.Events;
    
    public interface ISystemEvents
    {
        void Pulse(PulseEvent e);
        
        void AgentTransitioned(AgentTransition data);
    }

    [EventSource(Name = SourceName)]    
    public sealed class SystemEventWriter : EventWriter, ISystemEvents
    {
        public const string SourceName = "zsyn/system-events";

        public static readonly ISystemEvents Log = new SystemEventWriter();
                
        SystemEventWriter()
        {

        }

        protected override void OnEventCommand(EventCommandEventArgs command)        
            => inform($"Received the {command.Command} command");    


        void Pulse(ulong EventKind, uint ServerId, uint AgentId, ulong Timestamp)
            => WriteEvent(1, EventKind, ServerId, AgentId, Timestamp);    
        
        void AgentTransitioned(ulong EventKind, uint ServerId, uint AgentId, ulong Timestamp, byte[] Body)
            => WriteEvent(2, EventKind, ServerId, AgentId, Timestamp, Body);

        /// <summary>
        /// Writes a system heartbeat event
        /// </summary>
        /// <param name="e">The event to write</param>    
        void ISystemEvents.Pulse(PulseEvent e)
            => Pulse(e.Identity.EventKind, e.Identity.ServerId, e.Identity.AgentId, e.Identity.Timestamp);

        void ISystemEvents.AgentTransitioned(AgentTransition data)        
            => AgentTransitioned(2, data.Agent.ServerId, data.Agent.AgentId, data.Timestamp, ByteSpan.FromValue(data).ToArray());               
    }

    public sealed class AgentTransitioned : TraceEventAdapter<AgentTransitioned,AgentTransition>
    {

    }

    public sealed class PulseAdapter : TraceEventAdapter<PulseAdapter>
    {


    }

}