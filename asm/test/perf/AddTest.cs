//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Test
{
    using System;
    using System.Linq;
    using Z0.Test;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Security;

    using static zfunc;

    public class AddTest : UnitTest<AddTest>
    {
        static readonly AsmBinOp<int> add = AsmOps.Add<int>();      

        public AddTest()
        {
            var src = Random.Stream<int>();
            Lhs = src.TakeArray(Samples);
            Rhs = src.TakeArray(Samples);
        }

        int[] Lhs {get;}

        int[] Rhs {get;}


        public void VerifyIL()
        {                        
            for(var i=0; i<Samples; i++)
                Claim.eq(Lhs[i] + Rhs[i], add(Lhs[i], Rhs[i]));                                        
        }


        public void Measure()
        {
            var result = 0;

            var sw0 = stopwatch();
            for(var j=0; j<Cycles; j++)
            for(var i=0; i<Samples; i++)
                result = Lhs[i] + Rhs[i];
            TracePerf("add/direct", snapshot(sw0), Cycles, Samples);


            var sw2 = stopwatch();
            for(var j=0; j<Cycles; j++)
            for(var i=0; i<Samples; i++)
                result = add(Lhs[i], Rhs[i]);                                        
            TracePerf("add/IL", snapshot(sw2), Cycles, Samples);
        }

    }

}