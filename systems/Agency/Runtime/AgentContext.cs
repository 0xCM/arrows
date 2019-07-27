//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a shared context for a set of agents
    /// </summary>
    public class AgentContext : Context, IAgentContext
    {
        ConcurrentDictionary<ulong, IServiceAgent> Agents {get;}
            = new ConcurrentDictionary<ulong, IServiceAgent>();

        public AgentContext(IRandomSource random)
            : base(random)
        {

        }

        public AgentContext()
            : base(RNG.XOrShift1024(Seed1024.AppSeed))
        {


        }

        public void Register(IServiceAgent agent)
        {
            Agents.TryAdd(agent.Identity(), agent);
        }
        

        IEnumerable<IServiceAgent> IAgentContext.Memberhsip 
            => Agents.Values;        
    }
}