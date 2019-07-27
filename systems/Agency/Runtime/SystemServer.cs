//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Z0.Events;
    
    /// <summary>
    /// Defines a server within a complex
    /// </summary>
    public class SystemServer : ServiceAgent
    {        
        public static SystemServer Define(AgentContext Context, ServerConfig Config)
            => new SystemServer(Context, Config);

        ServerConfig Config {get;}

        ServerProcess Worker {get; }

        SystemServer(AgentContext Context, ServerConfig Config)
            : base(Context, (Config.ServerId, 0u))
        {
            this.Config = Config;
            var hearbeat = PulseEmitter.Define(Context, 
                IdentityPools.NextAgentId(ServerId), 
                new PulseEmitterConfig(new TimeSpan(0,0,1)));            
            this.Worker = ServerProcess.Define(Context, ServerId, Config.CoreNumber, new IServiceAgent[]{hearbeat});
        }

        protected override async void OnStart()
        {
            await Worker.Start();
        }

        protected override async void OnStop()
        {
            await Worker.Stop();
        }
    }
}