//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public class App : TestApp<App>
    {                    
        Duration Mul256u64(int blocks)
        {
            var domain = closed(0ul, UInt32.MaxValue);
            var lhs = Random.Span256<ulong>(blocks, domain);
            var rhs = Random.Span256<ulong>(blocks, domain);
            
            var sw = stopwatch();

            for(var block=0; block<blocks; block++)
            {
                var x = lhs.LoadVec256(block);
                var y = rhs.LoadVec256(block);
                dinx.vumul256(x,y); 
            }
            return snapshot(sw);

        }


        void Shuffle()
        {
            var v1 = Vec128.define(1,2,3,4);
            var v2 = dinx.shuffle(v1, 0b01010101);
            print(v2.ToString());
        }
        protected override void RunTests(params string[] filters)
        {     
            //base.RunTests("BitPosTest");
            //base.RunTests("NatModTest");
            base.RunTests("BitMatrix");
        }

        public static void Main(params string[] args)
            => Run(args);
    
    }
}