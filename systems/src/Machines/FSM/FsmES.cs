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
    /// Defines a state machine with minimal feature-set
    /// </summary>
    /// <typeparam name="E">The incoming event type</typeparam>
    /// <typeparam name="S">The state type</typeparam>
    public class Fsm<E,S>
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

        /// <summary>
        /// Records the time at which execution began
        /// </summary>
        public ulong StartTime {get;}

        public ulong? EndTime {get; private set;}

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
        {
            Transitioned?.Invoke(s0, s1);
            OnExit(s0);
            OnEntry(s1);
        }

        /// <summary>
        /// Called upon state entry
        /// </summary>
        /// <param name="entry">The entry state</param>
        protected virtual void OnEntry(S entry){}

        /// <summary>
        /// Called upon state exit
        /// </summary>
        /// <param name="exit">The exit state</param>
        protected virtual void OnExit(S exit)
        {

        }

        void OnReceipt(E input)
            => InputReceipt?.Invoke(input);            

        void OnError(Exception e)
            => Oops?.Invoke(e);
    }

 
}