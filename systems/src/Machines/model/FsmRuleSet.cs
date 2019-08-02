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


    public abstract class FsmRuleSet<K,S>
        where K : IFsmRuleKey
    {
        protected IReadOnlyDictionary<K, S> RuleIndex;
    }


}