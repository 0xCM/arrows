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


    public interface IFsmRuleKey
    {
        IEnumerable<object> KeyComponents {get;}
    }

    public abstract class FsmRuleKey<S> : IFsmRuleKey
    {
        public S State {get;}

        protected FsmRuleKey(S State)
        {
            this.State = State;
        }

        public override string ToString() 
            => State.ToString();

        public virtual IEnumerable<object> KeyComponents 
            => items((object)State);

    }



}