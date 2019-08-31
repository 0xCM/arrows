//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static ObserverTrace;

    public static class FsmX
    {
        /// <summary>
        /// Forms a transition function from a sequence of transition rules
        /// </summary>
        /// <param name="rules">The individual rules that will comprise the function</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static MachineTransition<E,S> ToFunction<E,S>(this IEnumerable<TransitionRule<E,S>> rules)
            => new MachineTransition<E, S>(rules);

 
        /// <summary>
        /// Specifies whether an observer should be notified when a machine transitions from
        /// one state to a different state
        /// </summary>
        /// <param name="trace">The trace specification</param>
        [MethodImpl(Inline)]
        public static bool TraceTransitions(this ObserverTrace trace)
            => (trace & Transitions) == Transitions;

        /// <summary>
        /// Specifies whether an observer should be notified when a machine receives an event
        /// </summary>
        /// <param name="trace">The trace specification</param>
        [MethodImpl(Inline)]
        public static bool TraceEvents(this ObserverTrace trace)
            => (trace & Events) == Events;

        /// <summary>
        /// Specifies whether an observer should be notified when a machine attains the completion state
        /// </summary>
        /// <param name="trace">The trace specification</param>
        [MethodImpl(Inline)]
        public static bool TraceCompletions(this ObserverTrace trace)
            => (trace & Completions) == Completions;

        /// <summary>
        /// Specifies whether an observer should be notified when an error condition is detected
        /// </summary>
        /// <param name="trace">The trace specification</param>
        public static bool TraceErrors(this ObserverTrace trace)
            => (trace & Errors) == Errors;

    }
}