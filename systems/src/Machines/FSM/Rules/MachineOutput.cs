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

    /// <summary>
    /// Defines a partial state machine output function of the form 
    /// (source : S, target : S) -> output : Option[O]
    /// for source/target pairs in the domain. If an input value (s1:S, s2:S) 
    /// is not in the function domain, en empty option is returned
    /// </summary>
    public class MachineOutput<E,S,O> : IFsmFunction
    {
        readonly Dictionary<int,IOutputRule<E,S,O>> RuleIndex;        

        [MethodImpl(Inline)]
        public MachineOutput(IEnumerable<IOutputRule<E,S,O>> Rules)
        {
            RuleIndex = Rules.Select(x => (Fsm.OutputRuleKey(x.Trigger, x.Source).Hash,x)).ToDictionary();
        }
        
        /// <summary>
        /// Computes the output value, if any, for a specified source state and event
        /// </summary>
        /// <param name="trigger">The incoming event</param>
        /// <param name="source">The source state</param>
        [MethodImpl(Inline)]
        public Option<O> Output(E trigger, S source)
            => Rule(Fsm.OutputRuleKey(trigger, source)).TryMap(r => r.Output);

        /// <summary>
        /// Searches for the output rule given a key
        /// </summary>
        /// <param name="key">The rule key</param>
        public Option<IOutputRule<E,S,O>> Rule(IRuleKey key)
        {
            if(RuleIndex.TryGetValue(key.Hash, out IOutputRule<E,S,O> dst))
                return some(dst);
            else
                return default;
        }

        [MethodImpl(Inline)]
        Option<IRule> IFsmFunction.Rule(IRuleKey key)
            => Rule(key).TryMap(r => r as IRule);
    }

}