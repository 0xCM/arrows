//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    using static zfunc;

    public static class RuleKey
    {
        /// <summary>
        /// Specifies an output rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        public static OutputRuleKey<S> OutputRule<S>(S source, S target)
            => (source,target);
    
        /// <summary>
        /// Specifies an entry rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static EntryRuleKey<S> EntryRule<S>(S source)
            => source;
    
        /// <summary>
        /// Defines a key for a transition rule
        /// </summary>
        /// <param name="input">The intput value</param>
        /// <param name="source">The source state</param>
        /// <typeparam name="I">The input symbol type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransRuleKey<I,S> TransRule<I,S>(I input, S source)
            => (input,source);


    }


}