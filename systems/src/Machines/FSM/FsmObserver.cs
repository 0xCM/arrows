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


    public abstract class FsmObserver<E,S>
    {
        protected FsmObserver(Fsm<E,S> machine, bool trace = true)
        {
            machine.Completed += OnComplete;
            machine.Transitioned += OnTransition;
            machine.Oops += OnError;
            machine.InputReceipt += OnReceipt;
            this.EmitTrace = trace;
        }

        bool EmitTrace;
        
        void Trace(string message)
        {
            if(EmitTrace)
                print(appMsg(message, SeverityLevel.Babble));
        }
        
        protected virtual void OnComplete(S endstate, bool asPlanned)
        {
            Trace($"Completed with endstate {endstate}" + (asPlanned ? " as planned" : " abnormally"));
        }

        protected virtual void OnTransition(S s0, S s1)
        {
            Trace($"Transitioned {s0} -> {s1}");
        }

        protected virtual void OnReceipt(E input)
        {
            Trace($"Received {input}");

        }

        protected virtual void OnError(Exception e)
        {
            print(errorMsg(e));
        }

    }


}