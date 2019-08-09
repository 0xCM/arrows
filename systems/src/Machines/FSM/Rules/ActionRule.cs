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
    /// Characterizes an action that that executes per machine rules
    /// </summary>
    public readonly struct ActionRule<S,A> : IActionRule<S,A>
    {
        /// <summary>
        /// Constructs a rule from a source/action pair
        /// </summary>
        /// <param name="src">The source state</param>
        /// <param name="action">The action</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="A">The action tyep</typeparam>
        public static implicit operator ActionRule<S,A>((S src, A action) x)
            => new ActionRule<S,A>(x.src, x.action);

        public ActionRule(S source, A action)
        {
            this.Source = source;
            this.Action= action;
            this.Key = new ActionRuleKey<S>(source);
        }

        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        public readonly S Source {get;}
        
        /// <summary>
        /// The action invoked
        /// </summary>
        public readonly A Action {get;}

        /// <summary>
        /// The key that identifies the rule
        /// </summary>
        public readonly ActionRuleKey<S> Key {get;}

        public readonly int RuleId 
            => Key.Hash;

        public readonly override string ToString() 
            => $"({Source}) -> {Action}";
    }
}