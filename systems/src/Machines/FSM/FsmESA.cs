//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

   /// <summary>
   /// Defines a state machine that supports state entry actions
   /// </summary>
   /// <typeparam name="E">The incoming event type</typeparam>
   /// <typeparam name="S">The state type</typeparam>
   /// <typeparam name="A">The action type</typeparam>
    public class Fsm<E,S,A> : Fsm<E,S>
    {
        internal Fsm(string Id, IFsmContext context, S GroundState, S EndState, MachineTransition<E,S> Transition, StateAction<S,A> Entry)
            : base(Id, context, GroundState, EndState, Transition)
        {
            this.EntryFunc = Entry;   
        }

        readonly StateAction<S,A> EntryFunc;
        
        void OnTransition(S s0, S s1)
        {
            EntryFunc.Apply(s1).OnSome(action => OnEntryRule(s1, action));
        }

        void OnEntryRule(S entry, A action)
        {
            StatedEntered?.Invoke(entry,action);
        }

        /// <summary>
        /// Event that signals state entry
        /// </summary>
        public event StateEntry<S,A> StatedEntered;
    }


}