//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;

    using static zfunc;


    /// <summary>
    /// Delegate for event that fires when an input event has been received
    /// </summary>
    /// <param name="input">The input event</param>
    /// <typeparam name="E">The input event type</typeparam>
    public delegate void InputReceipt<E>(E input);
    
    /// <summary>
    /// Delegate for event that fires when a state transition occurs
    /// </summary>
    /// <param name="source">The source/antecdent state</param>
    /// <param name="target">The target state</param>
    /// <typeparam name="S">The state type</typeparam>
    public delegate void Transitioned<S>(S source, S target);

    /// <summary>
    /// Delegate for event that fires when a machine attains endstate
    /// </summary>
    /// <param name="endstate"></param>
    /// <param name="asPlanned"></param>
    /// <typeparam name="S"></typeparam>
    public delegate void Completed(FsmStats stats, bool asPlanned);

    /// <summary>
    /// Delegate for error event
    /// </summary>
    /// <param name="error">The trapped exception</param>
    public delegate void MachineError(Exception error);

    /// <summary>
    /// Delegate that fires upon state entry
    /// </summary>
    /// <param name="entry"></param>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="A">The action type</typeparam>
    public delegate void StateEntry<S,A>(S entry, A action);

    /// <summary>
    /// Delegate that fires upon state exit
    /// </summary>
    /// <param name="entry"></param>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="A">The action type</typeparam>
    public delegate void StateExit<S,A>(S exit, A action);

    /// <summary>
    /// Defines context specialization for FSM
    /// </summary>
    public interface IFsmContext : IContext
    {
        ulong? ReceiptLimit {get;}
    }

    

    public interface IRuleKey
    {
        int Hash {get;}

    }

    public interface IRuleKey<E,S> : IRuleKey
    {
        /// <summary>
        /// The triggering event
        /// </summary>
        E Trigger {get;}
    
        /// <summary>
        /// The source state
        /// </summary>
        S Source {get;}

    }


    public interface IFsmRule : IRule
    {

    }


    
    public interface IFsmActionRule<A> : IFsmRule
    {
        /// <summary>
        /// The action invoked
        /// </summary>
        A Action {get;}

    }

    /// <summary>
    ///  Characterizes a state machine rule predicated wholly or in part on a source state
    /// </summary>
    public interface IFsmStateRule<S> : IFsmRule
    {
        /// <summary>
        /// The source state
        /// </summary>
        S Source {get;}

    }

    /// <summary>
    ///  Characterizes a state machine rule predicated wholly or in part on an input event
    /// </summary>
    public interface IFsmEventRule<E> : IFsmRule
    {
        /// <summary>
        /// The triggering event
        /// </summary>
        E Trigger {get;}

    }

    public interface IFsmActionRule<S,A> : IFsmActionRule<A>
    {
        /// <summary>
        /// The state upon which the rule is predicated
        /// </summary>
        S Source {get;}

    }

    /// <summary>
    ///  Characterizes a state machine rule predicated on an input event and source state
    /// </summary>
    /// <typeparam name="E">The input event type</typeparam>
    /// <typeparam name="S">The source state</typeparam>
    public interface IFsmRule<E,S> : IFsmEventRule<E>, IFsmStateRule<S>
    {
        /// <summary>
        /// The rule key for hash-based lookups
        /// </summary>
        IRuleKey<E,S> Key {get;}
    }


    /// <summary>
    ///  Characterizes a rule of the form (input : E, source : S) -> target : S 
    /// </summary>
    /// <typeparam name="E">The input event type</typeparam>
    /// <typeparam name="S">The source state</typeparam>
    public interface ITransitionRule<E,S> : IFsmRule<E,S>
    {
        /// <summary>
        /// The target state
        /// </summary>
        S Target {get;}

    }

    /// <summary>
    ///  Characterizes a rule of the form (input : E, source : S) -> output : S 
    /// </summary>
    /// <typeparam name="S">The state type</typeparam>
    /// <typeparam name="O">The output type</typeparam>
    public interface IOutputRule<E,S,O> : IFsmRule<E,S>
    {
        /// <summary>
        /// The output produced
        /// </summary>
        O Output {get;}

    }

    /// <summary>
    /// Charaterizes a state machine partial function
    /// </summary>
    public interface IFsmFunction
    {        
        Option<IRule> Rule(IRuleKey key);
    }

    public interface IFsmFunction<E,S> : IFsmFunction
    {
        Option<S> Eval(E input, S state);

        IEnumerable<E> Triggers {get;}                    
    }


}