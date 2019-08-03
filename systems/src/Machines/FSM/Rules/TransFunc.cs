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
    public class TransFunc<E,S>
    {
        public TransFunc(IEnumerable<TransRule<E,S>> rules)
        {
            this.RuleIndex = rules.Select(x => (RuleKey.TransRule(x.Input,x.Source), x)).ToDictionary();
        }
        
        Dictionary<TransRuleKey<E,S>,TransRule<E,S>> RuleIndex;

        public S Apply(E input, S source)
        {
            var key = RuleKey.TransRule(input,source);
            if(RuleIndex.TryGetValue(key, out TransRule<E,S> rule))
                return rule.Target;
            else
                return source;
        }

    }

 
}