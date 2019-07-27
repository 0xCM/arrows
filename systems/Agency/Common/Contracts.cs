//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IAppService : IDisposable
    {
        Task Configure(dynamic config);
        
    }

    public interface IAppService<TConfig> : IAppService
    {
        Task Configure(TConfig config);

        event Action<TConfig> Configured;

    }

    /// <summary>
    /// Defines a means by which agents can be queried and directed
    /// </summary>
    public interface IAgentControl : IAppService<IAgentContext>
    {
        AgentStats SummaryStats {get;}        
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class AppServiceAttribute : Attribute
    {
        public static string GetLabel(Type host)
            => host.CustomAttribute<AppServiceAttribute>().TryMap(x => x.Label).ValueOrDefault(string.Empty);
            
        public AppServiceAttribute(string Label = null)
        {
            this.Label = Label ?? string.Empty;
        }

        public string Label {get;}
    }

    
    public interface IAppService<TContract,TConfig> : IAppService<TConfig>
    {
        ServiceDesignator ServiceId
            => new ServiceDesignator(typeof(TContract), AppServiceAttribute.GetLabel(GetType()));
    }

    public delegate void OnAgentTransition(in AgentTransition transition);

    public interface IServiceAgent : IAppService
    {
        uint ServerId {get;}

        uint AgentId {get;}            
        
        Task Start();

        Task Stop();

        AgentState State {get;}

        /// <summary>
        /// Signals when the agents transitions from its current state to a different state
        /// </summary>
        event OnAgentTransition StateChanged;
    }

    public interface IServiceAgent<C> : IServiceAgent, IAppService<C>
    {
        
    }
    
    public interface IAgentContext : IContext
    {
        IEnumerable<IServiceAgent> Memberhsip {get;}   
    }
    

}