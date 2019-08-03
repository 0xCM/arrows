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
    /// Encapsulates the set of all rules (input : E, source : S) -> target : S 
    /// that define state machine transitions
    /// </summary>
    public class EntryFunc<S,A>
    {
        public EntryFunc(IEnumerable<EntryRule<S,A>> rules)
        {
            this.RuleIndex = rules.Select(rule => (rule.Key(), rule)).ToDictionary();
        }
        
        Dictionary<EntryRuleKey<S>, EntryRule<S,A>> RuleIndex;

        public Option<A> Apply(S source)
        {
            var key = RuleKey.EntryRule(source);
            if(RuleIndex.TryGetValue(key, out EntryRule<S,A> rule))
                return rule.Action;
            else
                return default;
        }

    }

 
}