//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Events
{
    using System;
    using System.Threading.Tasks;

    using static zfunc;

    /// <summary>
    /// Originates events
    /// </summary>
    public abstract class EventEmitter : ServiceAgent, IEventEmitter
    {        

        protected EventEmitter(AgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {
            
        }

    }

    /// <summary>
    /// Originates events of a specific type
    /// </summary>
    public abstract class EventEmitter<E> : EventEmitter
    {
        protected EventEmitter(AgentContext Context, AgentIdentity Identity)
            :base(Context,Identity)
        {
            
        }

    }
}