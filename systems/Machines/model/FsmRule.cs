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
    /// Characterizes rules that are predicated on a a source state
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    public abstract class FsmRule<S>
    {
        protected FsmRule(S Source)
        {
            this.Source = Source;
        }

        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public S Source {get;}

    }
}