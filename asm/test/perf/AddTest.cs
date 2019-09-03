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
            var src = Polyrand.Stream<int>();
            Lhs = src.TakeArray(SampleSize);
            Rhs = src.TakeArray(SampleSize);
        }

        int[] Lhs {get;}

        int[] Rhs {get;}


        public void VerifyIL()
        {                        
            for(var i=0; i<SampleSize; i++)
                Claim.eq(Lhs[i] + Rhs[i], add(Lhs[i], Rhs[i]));                                        
        }


        public void Measure()
        {
            var result = 0;

            var sw0 = stopwatch();
            for(var j=0; j<CycleCount; j++)
            for(var i=0; i<SampleSize; i++)
                result = Lhs[i] + Rhs[i];
            TracePerf("add/direct", snapshot(sw0), CycleCount, SampleSize);


            var sw2 = stopwatch();
            for(var j=0; j<CycleCount; j++)
            for(var i=0; i<SampleSize; i++)
                result = add(Lhs[i], Rhs[i]);                                        
            TracePerf("add/IL", snapshot(sw2), CycleCount, SampleSize);
        }

    }

}