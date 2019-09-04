//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes an action that that executes per machine rules
    /// </summary>
    public readonly struct ActionRule<S,A> : IFsmActionRule<S,A>
    {
        /// <summary>
        /// Constructs a rule from a source/action pair
        /// </summary>
        /// <param name="src">The source state</param>
        /// <param name="action">The action</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="A">The action tyep</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator ActionRule<S,A>((S src, A action) x)
            => new ActionRule<S,A>(x.src, x.action);

        [MethodImpl(Inline)]
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
        /// The rule key
        /// </summary>
        public readonly ActionRuleKey<S> Key {get;}

        /// <summary>
        /// The rule identifier
        /// </summary>
        public readonly int RuleId 
        {
            [MethodImpl(Inline)]
            get => Key.Hash;
        }

        public readonly override string ToString() 
            => $"({Source}) -> {Action}";
    }
}