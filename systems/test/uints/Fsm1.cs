//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines.Test
{        
    using System;
    using System.Linq;
    using System.Threading;
    using System.Collections.Generic;
    using static zfunc;
    using Z0.Test;

    using static Fsm1.States;
    using static Fsm1.Events;
    
    public class Fsm1 : UnitTest<Fsm1>
    {

        public enum States : byte
        {
            S0, S1, S2, S3, S4, S5
        }

        public enum Events: byte
        {
            E1 , E2, E3, E4, E5, E6, E7
        }

        public static IEnumerable<TransRule<Events,States>> Rules()
        {
            yield return TransRule.Define(E1, S0, S1);
            yield return TransRule.Define(E1, S1, S2);
            yield return TransRule.Define(E1, S2, S3);
            yield return TransRule.Define(E1, S3, S4);
            yield return TransRule.Define(E1, S4, S5);
        }
        
        public static TransFunc<Events,States> Function()
            => Rules().ToFunction();

        public static Fsm<Events,States> Machine()
            => Fsm.Define(S0, S5, Function());


        sealed class Observer : FsmObserver<Events,States>
        {
            public Observer(Fsm<Events,States> fsm)
                : base(fsm)
            {


            }
        }

        public void Run()
        {
            var m = Machine();
            var o = new Observer(m);
            var events = Random.Stream<byte>(closed((byte)E1, (byte)(E7 + 1))).Cast<Events>();
            while(!m.Finished)
            {
                m.Submit(events.First());
            }
            
        }

    }
}