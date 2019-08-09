//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

    using static ObserverTrace;

    [Flags]
    public enum ObserverTrace
    {
        None = 0,

        Transitions = 1,

        Events = 2,

        Completions = 4,

        Errors = 8,

        All = Transitions | Events | Completions | Errors
    }


    public static class ObserverTraceX
    {
        public static bool TraceTransitions(this ObserverTrace trace)
            => (trace & Transitions) == Transitions;

        public static bool TraceEvents(this ObserverTrace trace)
            => (trace & Events) == Events;

        public static bool TraceCompletions(this ObserverTrace trace)
            => (trace & Completions) == Completions;

        public static bool TraceErrors(this ObserverTrace trace)
            => (trace & Errors) == Errors;
        
    }

 
}