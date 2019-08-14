//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static nfunc;
    using static Nats;
    public class VectorAddTest : UnitTest<VectorAddTest>
    {
        OpTimePair Add<N,T>(int cycles, T min, T max, N n = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var domain = closed(min, max);
            var v1 = Vector.Alloc<N,T>();
            var v2 = Vector.Alloc<N,T>();
            var v3 = Vector.Alloc<N,T>();
            var e3 = Vector.Alloc<N,T>();
            var sw1 = stopwatch(false);            
            var sw2 = stopwatch(false);

            for(var cycle = 0; cycle <cycles; cycle++)
            {
                Random.Fill(domain, ref v1);
                Random.Fill(domain, ref v2);

                sw1.Start();
                VectorRefOps.Add(v1, v2, ref v3);
                sw1.Stop();

                sw2.Start();
                VectorRefOps.Add(v1, v2, ref e3);
                sw2.Stop();
                Claim.eq(e3.Unsized,v3.Unsized);
            }
            
            var label = $"add<{n},{PrimalKinds.kind<T>()}>";            
            return (
                (cycles, sw1,$"{label}/subject"), 
                (cycles, sw2, $"{label}/ref")
            );
        }

        public void Add()
        {
            var labelPad = 30;
            var cycles = Pow2.T08;
            TracePerf(Add(cycles, 0ul, 2048ul, N5), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N16), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N32), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N64), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N128), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N256), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N512), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N1024), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N2048), labelPad);
            TracePerf(Add(cycles, 0ul, 2048ul, N4096), labelPad);

            TracePerf(Add(cycles, 0d, 2048d, N5), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N16), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N32), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N64), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N128), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N256), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N512), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N1024), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N2048), labelPad);
            TracePerf(Add(cycles, 0d, 2048d, N4096), labelPad);



           
        }


    }

}