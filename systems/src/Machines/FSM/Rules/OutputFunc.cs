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
    /// Encapsulates rules of the form(source : S, target : S) -> output : O that define state 
    /// machine output values predicated on state transitions
    /// </summary>
    public class OutputFunc<S,O>
    {
        public OutputFunc(IEnumerable<OutputRule<S,O>> Rules)
        {
            RuleIndex = Rules.Select(x => (RuleKey.OutputRule(x.Source, x.Target),x)).ToDictionary();
        }
        
        Dictionary<OutputRuleKey<S>,OutputRule<S,O>> RuleIndex;        

        public Option<O> Output(S source, S target)
        {
            var key = RuleKey.OutputRule(source, target);
            if(RuleIndex.TryGetValue(key, out OutputRule<S,O> rule))
                return rule.Output;
            else
                return default;
        }

    }

}