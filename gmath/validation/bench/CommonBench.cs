//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    using static mfunc;

    public class CommonBench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T12, Reps: Pow2.T12, SampleSize: Pow2.T11, AnnounceRate: Pow2.T10);        
        
        public static CommonBench Create(IRandomizer random, BenchConfig config = null)
            => new CommonBench(random, config ?? DefaultConfig);
        
        CommonBench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {
        
        }

        public IBenchComparison MeasureIterator()
        {
            var start = 0;
            var finish = 1000;
            long For()
            {
                var opcount = 0;
                for(var i = start; i< finish; i++)
                    opcount++;
                return opcount;
            }

            long Iterator()
            {
                var opcount = 0;
                var it = It.Define(start,finish);
                while(it++)
                    opcount++;
                return opcount;
            }

            var lhs = DefineMeasure("for", For);
            var rhs = DefineMeasure("it", For);
            var compare = Measure("for", lhs, "it", rhs);
            
            return compare;
        }
    }

}

