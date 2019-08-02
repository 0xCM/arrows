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

    public static class FsmExecutor
    {
        public static FsmExecutor<S,I> Start<S,I>(FsmSpec<S,I> spec)
            => FsmExecutor<S,I>.Start(spec);
    }

    public class FsmExecutor<S,I>
    {
        public static FsmExecutor<S,I> Start(FsmSpec<S,I> spec)
            => new FsmExecutor<S,I>(spec);

        FsmExecutor(FsmSpec<S,I> spec)
        {
            this.Spec = spec;
            this.CurrentState = spec.Initial;
            this.StartTime = (ulong)now().Ticks;
        }

        public ulong StartTime {get;}

        public ulong EndTime {get; private set;}

        public Option<S> EndState {get; private set;}

        public bool Completed
            => EndState.IsSome();

        S current;


        readonly FsmSpec<S,I> Spec;

        public S CurrentState
        {
            get => current;
            private set
            {
                //ignore transitions to self
                if(!current.Equals(value))
                {
                    current = value;
                    if(Spec.EndStates.Contains(value))
                    {
                        EndState = value;                            
                        EndTime = (ulong)now().Ticks;
                    }
                }
            }
        }

        Option<S> TryAccept(I input)
        {
            if(Completed)
                return none<S>();

            return Spec.Transitions.Next(CurrentState, input).OnSome(x => CurrentState = x);
                
        }

        /// <summary>
        /// Submits input to the state machine and returns the resultant state if accepted
        /// </summary>
        /// <param name="input">The input data</param>
        public Option<S> Submit(I input)        
            => TryAccept(input);
    }
}