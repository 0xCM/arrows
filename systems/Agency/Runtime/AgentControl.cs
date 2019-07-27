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

    using static zfunc;


    public struct AgentStats
    {
        public int AgentCount;
    }


    class AgentControl : AppService<IAgentControl,IAgentContext>, IAgentControl
    {
        public static IAgentControl FromContext(IContext Context)
            => new AgentControl(Context);
        
        public AgentControl(IContext Context)
            : base(Context)
        {


        }

        IAgentContext AgentContext;        

        AgentStats Stats;

        public AgentStats SummaryStats 
            => Stats;

        void UpdateAgentContext(IAgentContext AgentContext)
        {
            this.AgentContext = AgentContext;
            Stats.AgentCount = AgentContext.Memberhsip.Count();
        }

        protected override async Task Configure(IAgentContext AgentContext)
        {
            await Task.Factory.StartNew(() => UpdateAgentContext(AgentContext));
        }

    }
}