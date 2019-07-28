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
    
    using static zfunc;

    public class DivRemTest : UnitTest<DivRemTest>
    {

        // public void VerifyInt32()
        // {
        //     var count = Pow2.T14;
        //     var srcA = Random.Stream<int>().Take(count).ToArray();
        //     var srcB = Random.NonZeroStream<int>().Take(count).ToArray();
        //     var q = 0;
        //     var r = 0;


        //     for(var k= 0; k< Pow2.T04; k++)
        //     {
        //         var sw1 = stopwatch();
        //         for(var i=0; i<count; i++)
        //             AsmOps.DivRem(srcA[i], srcB[i], out q, out r);      
        //         TracePerf($"{snapshot(sw1)}");

        //         var sw2 = stopwatch();
        //         for(var i=0; i<count; i++)
        //             r = Math.DivRem(srcA[i], srcB[i], out q);
        //         TracePerf($"{snapshot(sw2)}");
        //     }

        // }
    }

}