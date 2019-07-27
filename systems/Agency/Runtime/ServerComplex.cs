//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Z0.Events;

    using static zfunc;

    /// <summary>
    /// Agent that manages a collection of servers
    /// </summary>
    public class ServerComplex : ServiceAgent
    {
        static Option<ServerComplex> Complex {get; set;}

        /// <summary>
        /// Starts a new complex or returns the existing complex
        /// </summary>
        /// <param name="context">The context that the complex will inherit</param>
        /// <param name="servers"></param>
        public static async Task<ServerComplex> Start(AgentContext context)
        {
            if(Complex.IsSome())
                return Complex.ValueOrDefault();

            var servers = 20;
            var complex = ServerComplex.Define(context);                
            var configs = new List<ServerConfig>();
            var processors = Environment.ProcessorCount;
            inform(appMsg($"Server complex using {processors} processor cores"));
            
            for(uint i = 0, corenum = 1; i <= servers; i++, corenum++)
            {
                var sid = IdentityPools.NextServerId();
                var config = new ServerConfig(sid, $"Server{sid}", corenum);
                babble(appMsg($"Defined configuration for {config}"));
                configs.Add(config);
                if(corenum == processors)
                    corenum = 0;
            }
            
            var eventSink = SystemEventSink.Define(context, (complex.ServerId, complex.AgentId));
            complex.Configure(configs, eventSink);
            await complex.Start();
            Complex = complex;
            return complex;
        }


        static readonly AgentIdentity Identity = (UInt32.MaxValue, UInt32.MaxValue);
        
        public static ServerComplex Define(AgentContext Context)
            => new ServerComplex(Context);

        ServerComplex(AgentContext Context)
            : base(Context, Identity)
        {
            Servers = new SystemServer[]{};
        }

        public void Configure(IEnumerable<ServerConfig> Configs, IServiceAgent EventSink)
        {
            var configs = Configs.ToArray();
            Servers = new SystemServer[configs.Length];
            for(var i=0; i<configs.Length; i++)
                Servers[i] = SystemServer.Define(Context, configs[i]);
         
            this.EventSink = EventSink;
        }

        SystemServer[] Servers;

        IServiceAgent EventSink;

        protected override async void OnStart()
        {
            await EventSink.Start();
            Servers.Select(x => x.Start()).ToList();
        }

        protected override async void OnStop()
        {
            Servers.Select(x => x.Stop()).ToList();
            await EventSink?.Stop();
        }

        protected override void OnTerminate()
            => EventSink.Dispose();

        public override void Dispose()
        {
            Stop().Wait();
            Terminate().Wait();
        }
    }
}