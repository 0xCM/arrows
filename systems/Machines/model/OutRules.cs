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

    public class OutRules<S,I,O> : FsmRuleSet<OutRuleKey<S,I>, O>
    {
        public OutRules(IEnumerable<OutRule<S,I,O>> Rules)
        {
            RuleIndex = Rules.Select(x => (FsmSpec.outkey(x.Source, x.Input),x.Output)).ToDictionary();
        }
        
        public Option<O> Output(S antecedent, I input)
        {
            if(RuleIndex.TryGetValue(FsmSpec.outkey(antecedent,input), out O next))
                return next;
            else
                return none<O>();
        }

        public IEnumerable<I> Input
            => RuleIndex.Keys.Select(k => k.Input).Distinct();
    }

}