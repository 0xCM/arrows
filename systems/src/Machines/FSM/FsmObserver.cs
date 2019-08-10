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
            CompletionCounter = 0;
            
        }

        Fsm<E,S> Machine;

        string Id => Machine.Id;

        readonly ObserverTrace Tracing;

        readonly int ReceiptEmitRate;

        int ReceiptCounter;

        int TransitionCount;

        int CompletionCounter;

        readonly int CompletionEmitRate;

        ulong TotalReceipts;
        
        void Trace(AppMsg msg)
        {
            print(msg);
        }

        protected virtual void OnComplete(FsmStats stats, bool asPlanned)
        {
            if(Tracing.TraceCompletions())
            {
                Trace(FsmMessages.Completed(Id, stats, asPlanned));
                CompletionCounter = 0;
            }
        }

        /// <summary>
        /// Receives notification that a transition has occurred
        /// </summary>
        /// <param name="s0">The source state</param>
        /// <param name="s1">The target state</param>
        protected virtual void OnTransition(S s0, S s1)
        {
            if(Tracing.TraceTransitions())
                Trace(FsmMessages.Transition(Id,s0,s1));
        }

        /// <summary>
        /// Receives notification that an event has ben submitted
        /// </summary>
        /// <param name="input">The input event</param>
        protected virtual void OnReceipt(E input)
        {
            ++TotalReceipts;

            if(ReceiptCounter == ReceiptEmitRate && Tracing.TraceEvents())
            {
                Trace(FsmMessages.Receipt(Id, input, TotalReceipts));
                ReceiptCounter = 0;
            }
            
            ReceiptCounter++;

        }

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