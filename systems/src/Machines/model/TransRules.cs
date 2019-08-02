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

    public class TransRules<S,I> : FsmRuleSet<TransRuleKey<S,I>, S>
    {
        public TransRules(IEnumerable<TransRule<S,I>> Rules)
        {
            RuleIndex = Rules.Select(x => (FsmSpec.transkey(x.Source, x.Input), x.Target)).ToDictionary();
        }
        
        public Option<S> Next(S s, I i)
        {
            if(RuleIndex.TryGetValue(FsmSpec.transkey(s,i), out S next))
                return next;
            else
                return none<S>();
        }

        public IEnumerable<S> States
            => RuleIndex.Values.Union(RuleIndex.Keys.Select(k => k.State));

        public IEnumerable<I> Input
            => RuleIndex.Keys.Select(k => k.Input).Distinct();
    }


 
}