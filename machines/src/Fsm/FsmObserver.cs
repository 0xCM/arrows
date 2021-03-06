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
    /// Receives notifications from an active machine
    /// </summary>
    /// <typeparam name="E">The input event type</typeparam>
    /// <typeparam name="S">The state type</typeparam>
    public class FsmObserver<E,S>
    {
        public FsmObserver(Fsm<E,S> machine, ObserverTrace? tracing = null, int? receiptEmitRate = null)
        {
            Machine = machine;
            machine.Transitioned += OnTransition;
            machine.Oops += OnError;
            machine.InputReceipt += OnReceipt;
            machine.Completed += OnComplete;
            Tracing = tracing  ?? ObserverTrace.All;
            ReceiptEmitRate = receiptEmitRate ?? Pow2.T20;
            TransitionCount = 0;
            CompletionCount = 0;
            
        }

        Fsm<E,S> Machine;

        string Id => Machine.Id;

        readonly ObserverTrace Tracing;

        readonly int ReceiptEmitRate;

        int ReceiptCounter;

        int TransitionCount;

        int CompletionCount;

        ulong ReceiptCount;
        
        void Trace(AppMsg msg)
        {
            print(msg);
        }

        /// <summary>
        /// Receives notification that a state machine has attained its endstate
        /// </summary>
        protected virtual void OnComplete(FsmStats stats, bool asPlanned)
        {
            CompletionCount++;
            if(Tracing.TraceCompletions())
            {
                Trace(FsmMessages.Completed(Id, stats, asPlanned));
                CompletionCount = 0;
            }
        }

        /// <summary>
        /// Receives notification that a transition has occurred
        /// </summary>
        /// <param name="s0">The source state</param>
        /// <param name="s1">The target state</param>
        protected virtual void OnTransition(S s0, S s1)
        {
            TransitionCount++;
            if(Tracing.TraceTransitions())
                Trace(FsmMessages.Transition(Id,s0,s1));
        }

        /// <summary>
        /// Receives notification that an event has ben submitted
        /// </summary>
        /// <param name="input">The input event</param>
        protected virtual void OnReceipt(E input)
        {
            ++ReceiptCount;

            if(ReceiptCounter == ReceiptEmitRate && Tracing.TraceEvents())
            {
                Trace(FsmMessages.Receipt(Id, input, ReceiptCount));
                ReceiptCounter = 0;
            }
            
            ReceiptCounter++;
        }

        /// <summary>
        /// Receives notification that an error has occurred
        /// </summary>
        /// <param name="e">The trapped exception</param>
        protected virtual void OnError(Exception e)
        {
            if(Tracing.TraceErrors())
            {
                switch(e)
                {
                    case AppException ae:
                        Trace(ae.Message);
                        break;
                    default:
                        Trace(FsmMessages.Error(Id, e));
                    break;
                }
            }            
        }
    }
}