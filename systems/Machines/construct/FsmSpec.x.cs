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

    public static class FsmSpecX
    {
        public static TransRules<S,I> ToRuleSet<S,I>(this IEnumerable<TransRule<S,I>> Rules)
            => FsmSpec.transitions(Rules.ToArray());
    }


}