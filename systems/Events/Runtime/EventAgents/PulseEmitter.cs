//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Timers;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    public class PulseEmitter : EventEmitter<PulseEvent>
    {        
        public static PulseEmitter Define(AgentContext Context, AgentIdentity Identity, PulseEmitterConfig Config)  
            => new PulseEmitter(Context, Identity, Config);

        PulseEmitter(AgentContext Context, AgentIdentity Identity, PulseEmitterConfig Config)  
            : base(Context,Identity)      
        {
            this.Timer = new Timer(Config.Frequency.TotalMilliseconds);
            this.Timer.AutoReset = true;
            this.Timer.Elapsed += OnPulse;
        }
        
        void OnPulse(object sender, ElapsedEventArgs args)
        {
            var e = PulseEvent.Define(ServerId, AgentId, SystemTime.Timestamp());            
            SystemEventWriter.Log.Pulse(e);
        }

        Timer Timer {get;}
        
        protected override void OnStart()
        {
            Timer.Start();
        }
        
        protected override void OnStop()
        {
            Timer.Stop();
        }

        protected override void OnTerminate()
            => Timer.Dispose();
    }
}