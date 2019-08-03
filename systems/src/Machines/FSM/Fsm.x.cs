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
        public static TransFunc<E,S> ToFunction<E,S>(this IEnumerable<TransRule<E,S>> rules)
            => new TransFunc<E, S>(rules);

        /// <summary>
        /// Forms an entry function from a sequence of entry rules
        /// </summary>
        /// <param name="rules">The individual rules that will comprise the function</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static EntryFunc<S,A> ToFunction<S,A>(IEnumerable<EntryRule<S,A>> rules)
            => new EntryFunc<S,A>(rules);

        /// <summary>
        /// Defines an entry rule key
        /// </summary>
        /// <param name="rule">The rule for which a key will be defined</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        [MethodImpl(Inline)]
        public static EntryRuleKey<S> Key<S,A>(this EntryRule<S,A> rule)
            => RuleKey.EntryRule(rule.Source);
        
        /// <summary>
        /// Defines an entry rule key
        /// </summary>
        /// <param name="rule">The rule for which a key will be defined</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The source state type</typeparam>
        [MethodImpl(Inline)]
        public static TransRuleKey<E,S> Key<E,S>(this TransRule<E,S> rule)
            => RuleKey.TransRule(rule.Input, rule.Source);
    }


}