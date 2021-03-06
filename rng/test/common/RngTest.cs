//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using Z0.Test;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public abstract class RngTest<R> : UnitTest<R>
        where R : RngTest<R>, new()
    {
        protected override int CycleCount  => Pow2.T08;

        protected override int SampleSize => Pow2.T15;

        protected OpTime Benchmark<T>(ISampler<T> sampler)
            where T : unmanaged
        {

            var opname = $"{sampler.RngKind}<{type<T>().DisplayName()}>[{sampler.DistKind}]";            
            return Benchmark(sampler as IPointSource<T>,opname);

        }

        protected OpTime Benchmark<T>(IPointSource<T> src, string opname = null)
            where T : struct
        {
            var last = default(T);
            var sw = stopwatch();

            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var i=0; i<SampleSize; i++)
                last = src.Next();
            
            OpTime time = (CycleCount*SampleSize, sw, opname ?? $"{src.RngKind}<{type<T>().DisplayName()}>");
            Collect(time);
            return time;
        }

    }
}