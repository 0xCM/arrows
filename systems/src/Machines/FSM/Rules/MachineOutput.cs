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
    public class MachineOutput<E,S,O> : IMachineFunction
    {
        public MachineOutput(IEnumerable<IOutputRule<E,S,O>> Rules)
        {
            RuleIndex = Rules.Select(x => (Fsm.OutputRuleKey(x.Trigger, x.Source).Hash,x)).ToDictionary();
        }
        
        readonly Dictionary<int,IOutputRule<E,S,O>> RuleIndex;        

        public Option<O> Output(E trigger, S source)
        {
            var key = Fsm.OutputRuleKey(trigger, source);
            if(RuleIndex.TryGetValue(key.Hash, out IOutputRule<E,S,O> rule))
                return rule.Output;
            else
                return default;
        }

        public Option<IOutputRule<E,S,O>> Rule(IRuleKey key)
        {
            if(RuleIndex.TryGetValue(key.Hash, out IOutputRule<E,S,O> dst))
                return some(dst);
            else
                return default;
        }

        Option<IRule> IMachineFunction.Rule(IRuleKey key)
            => Rule(key).TryMap(r => r as IRule);
    }

}