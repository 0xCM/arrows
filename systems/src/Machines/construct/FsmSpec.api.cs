//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines an api for state machine specification
    /// </summary>
    public static class FsmSpec
    {
        /// <summary>
        /// Specifies a transition rule from a state s1 to a state s2 predicated on supplied input
        /// </summary>
        /// <param name="s">The source state</param>
        /// <param name="i">The input value</param>
        /// <param name="t">The target state</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The input symbol type</typeparam>
        public static TransRule<S,I> transition<S,I>(S s, I i, S t)
            => new TransRule<S, I>(s, i, t);
        
        /// <summary>
        /// Specifies a state's output rule
        /// </summary>
        /// <param name="s">The state upon which the output is predicated</param>
        /// <param name="o">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="O">The output symbol type</typeparam>
        public static OutRule<S,O> output<S,O>(S s, O o)
            => new OutRule<S, O>(s,o);

        /// <summary>
        /// Specifies a state's output rule
        /// </summary>
        /// <param name="s">The state upon which the output value is predicated, otherwise known as the source state</param>
        /// <param name="i">The input value upon which the output value is predicated</param>
        /// <param name="o">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The input symbol type</typeparam>
        /// <typeparam name="O">The output symbol type</typeparam>
        public static OutRule<S,I,O> output<S,I,O>(S s, I i, O o)
            => new OutRule<S, I, O>(s,i, o);

        /// <summary>
        /// Specifies a transition rule key
        /// </summary>
        /// <param name="s">The antecedent state</param>
        /// <param name="i">The intput value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The input symbol type</typeparam>
        public static TransRuleKey<S,I> transkey<S,I>(S s, I i)
            => new TransRuleKey<S,I>(s, i);

        /// <summary>
        /// Specifies an input-independent output rule key
        /// </summary>
        /// <param name="s">The source state</param>
        /// <typeparam name="S">The state type</typeparam>
        public static OutRuleKey<S> outkey<S>(S s)
            => new OutRuleKey<S>(s);

        /// <summary>
        /// Specifies an input-dependent output rule key
        /// </summary>
        /// <param name="state">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The output symbol type</typeparam>
        public static OutRuleKey<S,I> outkey<S,I>(S state, I input)
            => new OutRuleKey<S,I>(state, input);

        /// <summary>
        /// Defines a transition rule set
        /// </summary>
        /// <param name="rules">The rules from which to form a set</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="I">The input symbol type</typeparam>
        public static TransRules<S,I> transitions<S,I>(params TransRule<S,I>[] rules)
            => new TransRules<S,I>(rules);

    }

}