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

        protected OpTime Benchmark<T>(IPointSource<T> rng)
            where T : unmanaged
        {
            var last = default(T);
            var sw = stopwatch();

            for(var cycle = 0; cycle < CycleCount; cycle++)
            for(var i=0; i<SampleSize; i++)
                last = rng.Next();
            
            OpTime time = (CycleCount*SampleSize, sw, $"{rng.RngKind}");
            Collect(time);
            return time;

        }

    }


}