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

    public class OutFunc<I,S,O>
    {
        public OutFunc(IEnumerable<OutputRule<I,S,O>> Rules)
        {
            RuleIndex = Rules.Select(x => (OutRuleKey.Define(x.Input, x.Source),x)).ToDictionary();
        }
        
        Dictionary<OutRuleKey<I,S>,OutputRule<I,S,O>> RuleIndex;        

        public Option<O> Output(I input, S source)
        {
            var key = OutRuleKey.Define(input,source);
            if(RuleIndex.TryGetValue(key, out OutputRule<I,S,O> rule))
                return rule.Output;
            else
                return default;
        }

    }

}