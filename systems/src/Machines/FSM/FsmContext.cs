//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IFsmContext : IContext
    {
        ulong? ReceiptLimit {get;}
    }
    
    class FsmContext : Context<FsmContext>, IFsmContext
    {

        public FsmContext(IRandomSource random, ulong? receiptLimit = null)
            : base(random)
        {
            this.ReceiptLimit = receiptLimit ?? (ulong)Pow2.T14;
        }

        /// <summary>
        /// If specified, the maximum number of event submissions the machine
        /// will accept prior to forced termination
        /// </summary>
        public ulong? ReceiptLimit {get;}

        /// <summary>
        /// Retrieves the start state for machine with which context is associated
        /// </summary>
        /// <typeparam name="S">The state type</typeparam>
        S GroundState<S>()
        {
            return default;
        }

        E EndState<E>()
        {
            return default;
        }


        MachineTransition<E,S> Transition<E,S>()
        {
            return default;
        }

        Option<TransitionRule<E,S>> TransitionRule<E,S>(E trigger, S source)
        {
            return default;
        }

        Option<OutputRule<E,S,O>> OutputRule<E,S,O>(E trigger, S source)
        {
            return default;
        }


        /// <summary>
        /// Retrieves a sequence of actions to be unconditionally executed upon 
        /// entry to a specified state
        /// </summary>
        /// <param name="state">The state</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        IEnumerable<StateAction<S,A>> OnEntry<S,A>(S state)
        {
            return default;
        }

        /// <summary>
        /// Retrieves a sequence of actions to be unconditionally executed upon 
        /// exit from a specified state
        /// </summary>
        /// <param name="state">The state</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        IEnumerable<StateAction<S,A>> OnExit<S,A>(S state)
        {
            return default;
        }

    }

}