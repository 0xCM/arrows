//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;
    using static Examples;

    public class VSquareTest : UnitTest<VSquareTest>
    {
        
        public void SqureVectorsF64()
        {        
            void Perf()
            {
                var src = Random.Stream<double>(closed(-2500000d,2500000d)).TakeSpan(Samples);
                Span<double> dst = new double[Samples];

                var sw1 = stopwatch();
                for(var cycle = 0; cycle < Cycles; cycle++)
                    src.Square(dst);
                var time1 = snapshot(sw1);

                var sw2 = stopwatch();
                for(var cycle = 0; cycle < Cycles; cycle++)
                    mkl.square(src, dst);
                var time2 = snapshot(sw2);

                TracePerf($"src.Square(dst)",time1, Cycles, Samples);
                TracePerf($"mkl.pow(src, dst)", time2, Cycles, Samples);
            }

            Perf();

        }

    }

}
