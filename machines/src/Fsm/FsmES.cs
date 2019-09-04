//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using System.Diagnostics;

    /// <summary>
    /// Defines a state machine with minimal feature-set
    /// </summary>
    /// <typeparam name="E">The incoming event type</typeparam>
    /// <typeparam name="S">The state type</typeparam>
    public class Fsm<E,S>
    {
        public Fsm(string Id, IFsmContext context, S GroundState, S EndState, IFsmFunction<E,S> transition)
        {
            this.Id = Id;
            this.Context = context;
            this.CurrentState = GroundState;
            this.EndState = EndState;
            this.Error = none<Exception>();
            this.Transition = transition;
            this.ReceiptCount = 0;
            this.TransitionCount = 0;
            this.Runtime = stopwatch(false);
        }

        /// <summary>
        /// Records the time spent actively running
        /// </summary>
        Stopwatch Runtime {get;}


        /// <summary>
        /// The machine transition function
        /// </summary>
        IFsmFunction<E,S> Transition {get;}

        /// <summary>
        /// The number of events that have been received
        /// </summary>
        public ulong ReceiptCount {get; private set;}

        /// <summary>
        /// The number of state transtions that have occurred
        /// </summary>
        public uint TransitionCount {get; private set;}

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
        /// The machine context
        /// </summary>
        public IFsmContext Context {get;}

        /// <summary>
        /// Identifies the machine within the process
        /// </summary>
        public string Id {get;}
        
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
        public event Completed Completed;

        /// <summary>
        /// Fires when an error is trapped
        /// </summary>
        public event MachineError Oops;

        /// <summary>
        /// Specifies the events that the machine can accept
        /// </summary>
        public IEnumerable<E> Triggers
            => Transition.Triggers;

        /// <summary>
        /// Indicates whether the machine has finished
        /// </summary>
        public bool Finished
            => CurrentState.Equals(EndState) || Error.IsSome();

        /// <summary>
        /// Records the time at which the machine was started
        /// </summary>
        public ulong? StartTime {get; private set;}

        /// <summary>
        /// Records the time at which the machine stopped
        /// </summary>
        public ulong? EndTime {get; private set;}

        /// <summary>
        /// Specifies whether the machine has started
        /// </summary>
        public bool Started 
            => StartTime.HasValue;

        /// <summary>
        /// Specifies the maximum number of events that will be accept prior
        /// to forceful termination
        /// </summary>        
        ulong ReceiptLimit
            => Context.ReceiptLimit ?? UInt64.MaxValue;

        public FsmStats QueryStats()
            => new FsmStats
            {
                MachineId = Id,
                StartTime = StartTime,
                EndTime = EndTime,
                ReceiptCount = ReceiptCount,
                Runtime = snapshot(Runtime),
                TransitionCount = TransitionCount                            
            };

        /// <summary>
        /// Begins machine execution
        /// </summary>
        public void Start()
        {
            StartTime = SystemTime.Timestamp();
        }

        bool CanProcess()
        {
            if(Finished)    
            {
                RaiseWarning(FsmMessages.ReceiptAfterFinish(Id));
                return false;
            }

            if(!Started)
            {
                RaiseWarning(FsmMessages.ReceiptBeforeStart(Id));
                return false;
            }
            
            if(ReceiptCount > ReceiptLimit)
            {
                RaiseError(ReceiptLimitExceeded.Define(Id, ReceiptLimit));
                return false;
            }

            return true;
        }

        /// <summary>
        /// Submits input to the machine
        /// </summary>
        /// <param name="input">The input data</param>
        public void Submit(E input)
        {        
            Runtime.Start();

            try
            {                    
                if(CanProcess())
                {
                    OnReceipt(input);
                    var prior = CurrentState;
                    CurrentState = Transition.Eval(input, CurrentState).ValueOrElse(CurrentState);
                    
                    if(!prior.Equals(CurrentState))
                        OnTransition(prior, CurrentState);
                    
                    if(Finished)
                        OnComplete(true);
                }                
            }
            catch(Exception e)
            {
                OnError(e);
            }
                    
            Runtime.Stop();
                        
        }

        void OnComplete(bool asPlanned)
        {
            EndTime = SystemTime.Timestamp();
            Runtime.Stop();
            Completed?.Invoke(QueryStats(), asPlanned);
        }

        void OnTransition(S s0, S s1)
        {
            Transitioned?.Invoke(s0, s1);
            OnExit(s0);
            OnEntry(s1);
            TransitionCount++;
        }


        /// <summary>
        /// Called upon state entry
        /// </summary>
        /// <param name="entry">The entry state</param>
        protected virtual void OnEntry(S entry){ }

        /// <summary>
        /// Called upon state exit
        /// </summary>
        /// <param name="exit">The exit state</param>
        protected virtual void OnExit(S exit) { }

        void RaiseWarning(AppMsg msg) 
        {
            OnWarning(msg);
        }
        
        void RaiseError(AppException e)
        {
            OnError(e);
        }

        void OnReceipt(E input)        
        {
            ReceiptCount++;
            Try(() => InputReceipt?.Invoke(input));            

        }

        void OnWarning(AppMsg msg)
        {

        }

        void OnError(Exception e)  
        {       
            Error = e;
                       
            Try(() => Oops?.Invoke(e));

            OnComplete(false);

        }
                     
    }

    
    public class ReceiptLimitExceeded : AppException
    {
        public static ReceiptLimitExceeded Define(string machine, ulong limit)
            => new ReceiptLimitExceeded(machine, limit);

        public ReceiptLimitExceeded(string machine, ulong limit)
            : base(AppMsg.Define($"{machine} Event receipt limit of {limit} was exeeded", SeverityLevel.Warning))
        {

        }
    }
}