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

    public delegate void InputReceipt<E>(E input);
    
    public delegate void Transitioned<S>(S prior, S current);

    public delegate void Completed<S>(S endstate, bool asPlanned);

    public delegate void ErrorRaised(Exception error);


    public static class Fsm
    {
        public static Fsm<I,S> Define<I,S>(S s0, S sZ, TransFunc<I,S> f)
                =>  new Fsm<I, S>(s0, sZ, f);
    }


    public sealed class Fsm<E,S>
    {
        public Fsm(S GroundState, S EndState, TransFunc<E,S> Transition)
        {
            this.CurrentState = GroundState;
            this.EndState = EndState;
            this.Error = none<Exception>();
            this.Transition = Transition;
            this.StartTime = SystemTime.Timestamp();
        }

        TransFunc<E,S> Transition {get;}

        /// <summary>
        /// The endstate which implicitly signals processing completion
        /// </summary>
        S EndState {get;}

        /// <summary>
        /// The current state
        /// </summary>
        S CurrentState;        
                        
        /// <summary>
        /// An arror that occurred, if any, prior to normal completion
        /// </summary>
        Option<Exception> Error;

        /// <summary>
        /// Fires when input is received
        /// </summary>
        public event InputReceipt<E> InputReceipt;

        /// <summary>
        /// Fires when a transition occurs from one state to a different state
        /// </summary>
        public event Transitioned<S> Transitioned;

        /// <summary>
        /// Fires when the machine has reached endstate
        /// </summary>
        public event Completed<S> Completed;

        /// <summary>
        /// Fires when an error is trapped
        /// </summary>
        public event ErrorRaised Oops;

        /// <summary>
        /// Indicates whether the machine has finished
        /// </summary>
        public bool Finished
            => CurrentState.Equals(EndState) || Error.IsSome();

        public ulong StartTime {get;}

        public ulong EndTime {get; private set;}

        /// <summary>
        /// Submits input to the machine
        /// </summary>
        /// <param name="input">The input data</param>
        public bool Submit(E input)
        {
            if(!Finished)
            {
                try
                {                    
                    OnReceipt(input);
                    var prior = CurrentState;
                    CurrentState = Transition.Apply(input, CurrentState);
                    
                    if(!prior.Equals(CurrentState))
                        OnTransition(prior, CurrentState);
                    
                    if(Finished)
                        OnComplete(true);
                    return true;
                }
                catch(Exception e)
                {
                    Error = e;
                    OnError(e);
                    OnComplete(false);
                }
            }
            
            return false;            
        }

        void OnComplete(bool asPlanned)
        {
            EndTime = SystemTime.Timestamp();
            Completed?.Invoke(CurrentState, asPlanned);
        }

        void OnTransition(S s0, S s1)
            => Transitioned?.Invoke(s0, s1);

        void OnReceipt(E input)
            => InputReceipt?.Invoke(input);            

        void OnError(Exception e)
            => Oops?.Invoke(e);
    }

}