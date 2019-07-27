//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Timers;
    using System.Threading.Tasks;
    using static zfunc;
    
    public abstract class EventSink : ServiceAgent, IEventSink
    {
        protected EventSink(AgentContext Context, AgentIdentity Identity)
            : base(Context, Identity)
        {
            
        }
    }
}