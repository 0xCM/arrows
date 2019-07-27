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

    public class OutRuleKey<S> : FsmRuleKey<S>
    {
        public OutRuleKey(S state)
            : base(state)
        {

        }
    }

    public class OutRuleKey<S,I> : OutRuleKey<S>
    {
        public OutRuleKey(S state, I input)
            : base(state)
        {
            this.Input = input;
        }

        public I Input {get;}

        public override string ToString() 
            => $"({State}, {Input})";

        public override IEnumerable<object> KeyComponents
            => items<object>(State,Input);
    }

}