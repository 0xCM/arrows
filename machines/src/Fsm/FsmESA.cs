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
        internal Fsm(string Id, IFsmContext context, S GroundState, S EndState, 
                MachineTransition<E,S> Transition, EntryFunction<S,A> Entry, ExitFunction<S,A> Exit)
            : base(Id, context, GroundState, EndState, Transition)
        {
            this.EntryFunc = Entry;   
            this.ExitFunc = Exit;
        }

        /// <summary>
        /// The function to evaluate upon state entry to determine the associated action, if any
        /// </summary>
        readonly EntryFunction<S,A> EntryFunc;

        /// <summary>
        /// The function to evaluate upon state exit to determine the associated action, if any
        /// </summary>
        readonly ExitFunction<S,A> ExitFunc;

        /// <summary>
        /// The entry action
        /// </summary>
        public StateEntry<S,A> EntryAction;

        /// <summary>
        /// The exit action
        /// </summary>
        public StateExit<S,A> ExitAction;
        
        protected override void OnEntry(S s)
        {
            EntryFunc.Eval(s).OnSome(action => EntryAction?.Invoke(s, action));
        }

        protected override void OnExit(S s)
        {
            ExitFunc.Eval(s).OnSome(action => ExitAction?.Invoke(s,action));
        }

    }
}