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
    using System.Collections.Concurrent;
    using Microsoft.Diagnostics.Tracing;
    using Microsoft.Diagnostics.Tracing.Session;
    using System.Linq.Expressions;
    using static zfunc;

    public static class TraceEventAdapter
    {
        public static T Payload<T>(this TraceEvent e, string name)
            => (T)e.PayloadByName(name);

        public static dynamic Payload<T>(this TraceEvent e, Expression<Func<T,dynamic>> selector)
            => e.PayloadByName(selector.GetAccessedProperty().Name);

        public static EventIdentity EventIdentity(this TraceEvent data)         
                => (
                data.Payload<uint>("ServerId"), 
                data.Payload<uint>("AgentId"), 
                data.Payload<ulong>("Timestamp"),
                data.Payload<ulong>("EventKind") 
                );

        public static A Adapt<A>(this TraceEvent e)
            where A : TraceEventAdapter<A>, new()
        {
            var adapter = new A();
            adapter.Subject = e;
            return adapter;
        }
    }

    public abstract class TraceEventAdapter<A>
        where A : TraceEventAdapter<A>, new()
    {
        public TraceEvent Subject {get; set;}

        public EventIdentity EventIdentity
            => Subject.EventIdentity();

        public T Field<T>(string Name)
            => Subject.Payload<T>(Name);
    }

    public abstract class TraceEventAdapter<A,T> : TraceEventAdapter<A>
        where A : TraceEventAdapter<A,T>, new()
        where T : struct
    {
        public virtual T Body
            => Subject.Payload<byte[]>(nameof(Body)).ToSpan().ReadValue<T>();
    }
}