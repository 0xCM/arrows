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
    /// Encapsulates the set of all rules (initial : S, input : I) -> target : S 
    /// that define state machine transitions
    /// </summary>
    public class TransFunc<I,S>
    {
        public TransFunc(IEnumerable<TransRule<I,S>> rules)
        {
            this.RuleIndex = rules.Select(x => (TransRuleKey.Define(x.Input,x.Source), x)).ToDictionary();
        }
        
        Dictionary<TransRuleKey<I,S>,TransRule<I,S>> RuleIndex;

        public S Apply(I input, S source)
        {
            var key = TransRuleKey.Define(input,source);
            if(RuleIndex.TryGetValue(key, out TransRule<I,S> rule))
                return rule.Target;
            else
                return source;
        }

    }

    public static class TransFuncX
    {
        public static TransFunc<I,S> ToFunction<I,S>(this IEnumerable<TransRule<I,S>> rules)
            => new TransFunc<I, S>(rules);
    }

}