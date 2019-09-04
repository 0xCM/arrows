//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using Microsoft.Diagnostics.Tracing;
    using Microsoft.Diagnostics.Tracing.Session;
    using static zfunc;

    public sealed class SystemEventSink : EventSink
    {        
        public static IServiceAgent Define(AgentContext Context, AgentIdentity Identity)
            => new SystemEventSink(Context, Identity);

        SystemEventSink(AgentContext Context, AgentIdentity Identity)
            : base(Context, Identity)
        {

        }

        TraceEventSession Session;
        
        ConcurrentQueue<EventIdentity> RecieptQueue = new ConcurrentQueue<EventIdentity>();


        void OnPulse(TraceEvent data)
        {
            EventIdentity identity = data.EventIdentity();            
            magenta($"Received event {identity}");

            RecieptQueue.Enqueue(identity);
        }

        void OnAgentTransitioned(TraceEvent data)
        {
            var adapter = data.Adapt<AgentTransitioned>();
            var body = adapter.Body;
            magenta($"Received transition event: {body}");
        }

        void OnUnhandled(TraceEvent data)
        {
            if ((int)data.ID != 0xFFFE)         // The EventSource manifest events show up as unhanded, filter them out.
                babble("GOT UNHANDLED EVENT: " + data.Dump());
        }

        void ConfigureCallbacks()
        {
            Session.Source.Dynamic.AddCallbackForProviderEvent(SystemEventWriter.SourceName, "Pulse", OnPulse);
            Session.Source.Dynamic.AddCallbackForProviderEvent(SystemEventWriter.SourceName, "AgentTransitioned", OnAgentTransitioned);            
        }

        protected override void OnStart()
        {
            Session = new TraceEventSession(nameof(SystemEventSink));
            var restarted = Session.EnableProvider(SystemEventWriter.SourceName);
            if(restarted)
                warn($"Session was already in progress");            

            Console.CancelKeyPress += delegate (object sender, ConsoleCancelEventArgs e) { OnStop(); };
            Session.Source.UnhandledEvents += OnUnhandled;
            ConfigureCallbacks();
        }

        protected override void OnRun()
        {
            Task.Factory.StartNew(() => 
            {
                babble("Processing events");
                Session.Source.Process();
                babble("Finished processing events");

            });
        }

        protected override void OnStop()
        {
            Dispose();
        }

        protected override void OnTerminate()
        {
            Session?.Source.Dispose();

            Session?.Dispose();
        }
    }
}