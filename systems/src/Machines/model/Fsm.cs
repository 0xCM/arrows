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

    public abstract class Fsm<E,S>
        where E : Enum
        where S : Enum
    {
        protected Fsm(S GroundState, S TerminalState)
        {
            this.CurrentState = GroundState;
            this.TerminalState = TerminalState;
            this.Error = none<Exception>();
        }

        public bool TryAccept(E ev)
        {
            if(!Finished)
            {
                try
                {                    
                    OnEvent(ev);
                    var prior = CurrentState;
                    CurrentState = Analyze(CurrentState, ev);
                    
                    if(!prior.Equals(CurrentState))
                        OnTransition(prior, CurrentState);
                    
                    if(Finished)
                        OnComplete();
                    return true;
                }
                catch(Exception e)
                {
                    Error = e;
                    OnError(e);
                }
            }
            
            return false;
            
        }

        readonly S TerminalState;

        S CurrentState;        
                        
        Option<Exception> Error;

        bool Finished
            => CurrentState.Equals(TerminalState) || Error.IsSome();

        protected abstract S Analyze(S current, E received);


        protected virtual void OnComplete()
        {
            inform("Complete");
        }       
        protected virtual void OnTransition(S s0, S s1)
        {
            inform($"{s0} -> {s1}");
        }

        protected virtual void OnEvent(E received)
        {
            inform($"{received}");
        }

        protected virtual void OnError(Exception e)
        {
            error(e);
        }
    }

}