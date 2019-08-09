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

    /// <summary>
    /// Defines a set of rules that define actions associated with a state
    /// </summary>
    public class StateAction<S,A>
    {
        public StateAction(IEnumerable<IActionRule<A>> rules)
        {
            this.RuleIndex = rules.Select(rule => (rule.RuleId, rule)).ToDictionary();
        }
        
        readonly Dictionary<int, IActionRule<A>> RuleIndex;

        public Option<A> Apply(S source)
        {
            var key = Fsm.EntryRuleKey(source);
            if(RuleIndex.TryGetValue(key.Hash, out IActionRule<A> rule))
                return rule.Action;
            else
                return default;
        }

    }

 
}