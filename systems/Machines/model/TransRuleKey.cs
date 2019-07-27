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

    public class TransRuleKey<S,I> : FsmRuleKey<S>
    {
        public TransRuleKey(S state, I input)
            : base(state)
        {
            this.Input = input;
        }


        public I Input {get;}

        public override IEnumerable<object> KeyComponents
            => items<object>(State,Input);
         

        public override string ToString() 
            => $"({State}, {Input})";
    }

}