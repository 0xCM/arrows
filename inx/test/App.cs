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
                dinx.mul(x,y); 
            }
            return snapshot(sw);
        }

        protected override void RunTests(params string[] filters)
        {     
            base.RunTests(filters);
        }

        public static void Main(params string[] args)
            => Run(args);
    
    }
}