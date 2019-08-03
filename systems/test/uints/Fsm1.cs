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
    using Z0.Test;

    using static zfunc;

    using static Fsm1.States;
    using static Fsm1.Events;
    using static Fsm1.Outputs;
    
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

        public enum Outputs : byte
        {
            
            O0, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10
        }

        public static IEnumerable<OutputRule<States,Outputs>> OutputRules()
        {
            yield return (S0, S1, O0);
            yield return (S1, S2, O1);
            yield return (S2, S3, O2);
            yield return (S3, S4, O3);
            yield return (S4, S5, O4);


        }
        public static IEnumerable<TransRule<Events,States>> TransRules()
        {
            yield return (E1, S0, S1);
            yield return (E1, S1, S2);
            yield return (E1, S2, S3);
            yield return (E1, S3, S4);
            yield return (E1, S4, S5);
        }
        
        public static TransFunc<Events,States> Function()
            => TransRules().ToFunction();

        public static Fsm<Events,States> Machine()
            => Fsm.Define(S0, S5, Function());


        sealed class Observer : FsmObserver<Events,States>
        {
            public Observer(Fsm<Events,States> fsm, bool trace = false)
                : base(fsm,trace)
            {


            }
        }

        void Run(int machines)
        {
            
            for(var i=0; i<machines; i++)
            {
                var m = Machine();
                var o = new Observer(m);
                var events = Random.EnumStream<Events>();
                while(!m.Finished)
                    m.Submit(events.First());
            }
        }

        public void Run()
        {
            Run(Pow2.T08);
        }


        public void VerifyEnums()
        {
            var lv = GEnum.LabeledValues<States>();
            Claim.eq(6,lv.Length);
            Claim.eq(S0, lv[0].value);
            Claim.eq(S1, lv[1].value);
            Claim.eq(S2, lv[2].value);
            Claim.eq(S3, lv[3].value);  

            Claim.eq(S0, GEnum.Parse<States>(S0.ToString()).Require());          
            Claim.eq(S1, GEnum.Parse<States>(S1.ToString()).Require());          
            Claim.eq(S2, GEnum.Parse<States>(S2.ToString()).Require());          
            Claim.eq(S3, GEnum.Parse<States>(S3.ToString()).Require());          

            Claim.eq(S0, S0.ToGeneric().Value);
            Claim.eq(S0.ToString(), S0.ToGeneric().Label);

            Claim.eq(S1, S1.ToGeneric().Value);
            Claim.eq(S1.ToString(), S1.ToGeneric().Label);

            Claim.eq(S2, S2.ToGeneric().Value);
            Claim.eq(S2.ToString(), S2.ToGeneric().Label);

            var ls = GEnum.LabeledScalars<States,byte>();
            Claim.eq((byte)0, ls[0].scalar);
            Claim.eq((byte)1, ls[1].scalar);
            Claim.eq((byte)2, ls[2].scalar);
            Claim.eq((byte)3, ls[3].scalar);

            Claim.eq(S0.ToString(), ls[0].label);
            Claim.eq(S1.ToString(), ls[1].label);
            Claim.eq(S2.ToString(), ls[2].label);
            Claim.eq(S3.ToString(), ls[3].label);



        }
    }
}