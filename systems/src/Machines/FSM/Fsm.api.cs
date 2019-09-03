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
    using System.Threading.Tasks;

    using static zfunc;

    public static class Fsm
    {
        /// <summary>
        /// Defines a single state transition rule of the form (trigger : E, source : S) -> target : S 
        /// </summary>
        /// <param name="trigger">The incoming event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransitionRule<E,S> TransitionRule<E,S>(E trigger, S source, S target)
            => new TransitionRule<E, S>(trigger,source,target);            

        /// <summary>
        /// Defines a machine transition function (trigger : E, source: S) -> target : S 
        /// that determines machine transition behavior
        /// </summary>
        /// <param name="rules">The rules that comprise the function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static MachineTransition<E,S> TransitionFunction<E,S>(IEnumerable<ITransitionRule<E,S>> rules)
            => new MachineTransition<E, S>(rules);

        /// <summary>
        /// Defines an output rule of the form (trigger : E, source : S) -> output : O
        /// that specifies that output to emit when an input is received when in the source state
        /// </summary>
        /// <param name="trigger">The triggering event</param>
        /// <param name="source">The source state</param>
        /// <param name="output">The output value</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static OutputRule<E,S,O> OutputRule<E,S,O>(E trigger, S source, O output)
            => (trigger, source, output);

        /// <summary>
        /// Defines a machine transition function (trigger : E, source: S) -> target : S 
        /// that determines machine transition behavior
        /// </summary>
        /// <param name="rules"></param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static MachineOutput<E,S,O> OutputFunction<E,S,O>(IEnumerable<IOutputRule<E,S,O>> rules)
            => new MachineOutput<E, S, O>(rules);

        /// <summary>
        /// Defines an action that fires upon state entry
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The the entry action</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        public static ActionRule<S,A> EntryRule<S,A>(S source, A action)
            => new ActionRule<S,A>(source,action);            

        /// <summary>
        /// Defines an entry action function
        /// </summary>
        /// <param name="rules">The state entry rules</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        public static EntryFunction<S,A> EntryFunction<S,A>(IEnumerable<IFsmActionRule<S,A>> rules)
            => new EntryFunction<S, A>(rules);

        /// <summary>
        /// Defines an action that fires upon state exit
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The the exit action</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        public static ActionRule<S,A> ExitRuleRule<S,A>(S source, A action)
            => new ActionRule<S,A>(source,action);            

        /// <summary>
        /// Defines an exit action function
        /// </summary>
        /// <param name="rules">The state exit rules</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        public static ExitFunction<S,A> ExitFunction<S,A>(IEnumerable<IFsmActionRule<S,A>> rules)
            => new ExitFunction<S, A>(rules);

        /// <summary>
        /// Defines the most basic FSM, predicated only on ground-state, end-state and transition function
        /// </summary>
        /// <param name="id">Identifies the machine within the context of the executing process</param>
        /// <param name="s0">The ground-state</param>
        /// <param name="sZ">The end-state</param>
        /// <param name="f">The transiion function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static Fsm<E,S> Machine<E,S>(string id, IFsmContext context, S s0, S sZ, MachineTransition<E,S> f)
            =>  new Fsm<E, S>(id, context, s0, sZ, f);

        /// <summary>
        /// Defines an output rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        public static OutputRuleKey<E,S> OutputRuleKey<E,S>(E trigger, S source)
            => (trigger,source);
    
        /// <summary>
        /// Defines an entry rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static ActionRuleKey<S> EntryRuleKey<S>(S source)
            => source;

        /// <summary>
        /// Defines an exit rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static ActionRuleKey<S> ExitRuleKey<S>(S source)
            => source;

        /// <summary>
        /// Defines a key for a transition rule
        /// </summary>
        /// <param name="trigger">The triggering event</param>
        /// <param name="source">The source state</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static TransitionRuleKey<E,S> TransitionRuleKey<E,S>(E trigger, S source)
            => (trigger,source);

        /// <summary>
        /// Defines a machine that supports entry/exit actions on a per-state basis
        /// </summary>
        /// <param name="id">Identifies the machine within the context of the executing process</param>
        /// <param name="s0">The ground-state</param>
        /// <param name="sZ">The end-state</param>
        /// <param name="t">The transition function</param>
        /// <param name="entry">The entry function</param>
        /// <param name="exit">The exit function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The entry action type</typeparam>
        public static Fsm<E,S,A> Machine<E,S,A>(string id, IFsmContext context, S s0, S sZ, MachineTransition<E,S> t, EntryFunction<S,A> entry, ExitFunction<S,A> exit)
            =>  new Fsm<E,S,A>(id, context, s0, sZ, t, entry,exit);

        /// <summary>
        /// Creates a default machine observer 
        /// </summary>
        /// <param name="fsm">The machine under observation</param>
        /// <param name="trace">Whether to emit trace messages</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static FsmObserver<E,S> DefaultObserver<E,S>(Fsm<E,S> fsm, ObserverTrace? tracing = null)
            => new FsmObserver<E, S>(fsm, tracing);
 
        /// <summary>
        /// Creates a machine context
        /// </summary>
        /// <param name="random">The random source</param>
        public static IFsmContext CreateContext(IPolyrand random, ulong? receiptLimit = null)
            => new FsmContext(random, receiptLimit);

        /// <summary>
        /// Runs a machine
        /// </summary>
        /// <param name="context">The machine context</param>
        /// <param name="machine">The specified machine</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state tyep</typeparam>
        public static Task<Option<FsmStats>> Run<E,S>(Fsm<E,S> machine)
            => Task.Factory.StartNew(() => RunMachine(machine));

        static Option<FsmStats> RunMachine<E,S>(Fsm<E,S> machine)
        {
            try
            {
                var random = machine.Context.Polyrand;
                var o = Fsm.DefaultObserver(machine, ObserverTrace.Completions | ObserverTrace.Errors);
                var events = machine.Triggers.ToArray();
                var domain = closed(0, events.Length);
                var eventstream = random.Stream(domain).Select(i => events[i]);
                machine.Start();
                while(!machine.Finished)
                    machine.Submit(eventstream.First());
                return machine.QueryStats();
            }
            catch(Exception error)
            {
                print(errorMsg(error));
                return default;
            }

        }

    }
}