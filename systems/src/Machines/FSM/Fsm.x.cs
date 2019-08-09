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
        /// Forms an entry function from a sequence of entry rules
        /// </summary>
        /// <param name="rules">The individual rules that will comprise the function</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static StateAction<S,A> ToFunction<S,A>(IEnumerable<IActionRule<S,A>> rules)
            => new StateAction<S,A>(rules);

        
    }


}