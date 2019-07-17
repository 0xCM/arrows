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

        void Permute()
        {
            var subject = Vec256.define(11u, 13u, 17u, 19u, 27u, 31u, 37u, 39u);
            var control = Vec256.define(7u, 5u, 6u, 4u, 3u, 2u, 1u, 0u);
            var result = dinx.permute(subject,control);
            inform($"{subject} >> {control} = {result}");
            Claim.eq(dinx.reverse(subject), result);
        }

        void Swap()
        {
            var subject = Vec256.define(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = dinx.swap(subject, 2, 3);
            var expect = Vec256.define(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        void Shuffle()
        {
            var v1 = Vec128.define(1,2,3,4);
            var v2 = dinx.shuffle(v1, 0b01010101);
            print(v2.ToString());
        }
        protected override void RunTests(string filter)
        {     
            Swap();       
            //base.RunTests("InXAddTest");
            //base.RunTests("NatModTest");
        }

        public static void Main(params string[] args)
            => Run(args);
    
    }
}