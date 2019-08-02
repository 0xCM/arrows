//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;


    using static zfunc;

    public static class ContextExtensions
    {
        /// <summary>
        /// Determines the identiy of an agent
        /// </summary>
        /// <param name="agent">The agent</param>
        public static AgentIdentity Identity(this IServiceAgent agent)
            => (agent.ServerId, agent.AgentId);
   
        /// <summary>
        /// Searches a context for an active agent wth a specified identity
        /// </summary>
        /// <param name="context">The context to search</param>
        /// <param name="identity">The identity to match</param>
        public static Option<IServiceAgent> Agent(this IAgentContext context, AgentIdentity identity)
        {
            var agent = context.Memberhsip.FirstOrDefault(a => a.AgentId == identity.AgentId && a.ServerId == identity.ServerId);
            return agent != null ? some(agent) : none<IServiceAgent>();
        }



    }
}