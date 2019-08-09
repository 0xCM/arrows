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

    public interface IRule
    {
        int RuleId {get;}
    }

    public interface IRuleKey
    {
        int Hash {get;}

    }

    public interface IRule<S> : IRule
    {

    }

    public interface IRule<K,S> : IRule<S>
        where K : IRuleKey
    {
        K Key {get;}
    }
    
    public interface IActionRule<A> : IRule
    {

        /// <summary>
        /// The action invoked
        /// </summary>
        A Action {get;}


    }

    public interface IActionRule<S,A> : IActionRule<A>, IRule<S>
    {
        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        S Source {get;}

    }

    public interface ITransitionRule<E,S> : IRule<S>
    {
        /// <summary>
        /// The triggering event
        /// </summary>
        E Trigger {get;}

        /// <summary>
        /// The source state
        /// </summary>
        S Source {get;}

        /// <summary>
        /// The target state
        /// </summary>
        S Target {get;}

        TransitionRuleKey<E,S> Key {get;}

    }

    /// <summary>
    /// Characterizes a rule that defines an output predicated on a state transition
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="O">The output type</typeparam>
    public interface IOutputRule<E,S,O> : IRule<S>
    {
        /// <summary>
        /// The triggering event
        /// </summary>
        E Trigger {get;}

        /// <summary>
        /// The source state
        /// </summary>
        S Source {get;}

        /// <summary>
        /// The output produced
        /// </summary>
        O Output {get;}

        /// <summary>
        /// The key that identifies the rule
        /// </summary>
        OutputRuleKey<E,S> Key {get;}
    }

    public interface IMachineFunction
    {
        Option<IRule> Rule(IRuleKey key);
    }
}