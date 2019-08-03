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
    /// Characterizes an action that fires when a specified state has been entered
    /// </summary>
    public readonly struct EntryRule<S,A>
    {
        /// <summary>
        /// Constructs an entry rule from a source/action pair
        /// </summary>
        /// <param name="src">The source state</param>
        /// <param name="action">The action</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="A">The action tyep</typeparam>
        public static implicit operator EntryRule<S,A>((S src, A action) x)
            => new EntryRule<S,A>(x.src, x.action);

        public EntryRule(S source, A action)
        {
            this.Source = source;
            this.Action= action;
        }

        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public readonly S Source;        

        
        /// <summary>
        /// The action invoked upon entry
        /// </summary>
        public readonly A Action;
        

        public override string ToString() 
            => $"({Source}) -> {Action}";
    }
}