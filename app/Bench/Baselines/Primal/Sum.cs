//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    
    partial class BaselineBench
    {
        static TimedAggregateOp<T> PrimalSumOp<T>()
                where T : struct, IEquatable<T>
                    => PrimalSumBaseline.Operator<T>();

        static BenchResult RunPrimalSum<T>(BenchConfig config = null)
            where T : struct, IEquatable<T>        
                => AggregateBenchmark.Runner<T>("primal/sum", config).Run(PrimalSumOp<T>());

        static IEnumerable<BenchResult> RunPrimalSum(BenchConfig config = null)
        {
            yield return RunPrimalSum<short>(config);
            yield return RunPrimalSum<int>(config);
            yield return RunPrimalSum<float>(config);
            yield return RunPrimalSum<double>(config);
        }

        class PrimalSumBaseline 
        {


            public static TimedAggregateOp<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => Operators.lookup<T, TimedAggregateOp<T>>();

            public static readonly PrimalIndex Operators 
                = PrimKinds.index<object>
                    (   @short : new TimedAggregateOp<short>(Sum),
                        @int: new TimedAggregateOp<int>(Sum),
                        @float: new TimedAggregateOp<float>(Sum),
                        @double: new TimedAggregateOp<double>(Sum)
                    );

            static long Sum(Index<short> src, out short dst)
            {            
                var sw = stopwatch();
                dst = 0;
                for(var i =0; i< src.Count; i++)
                    dst += src[i];
                return elapsed(sw);
            }

            static long Sum(Index<int> src, out int dst)
            {            
                var sw = stopwatch();
                dst = 0;
                for(var i =0; i< src.Count; i++)
                    dst += src[i];
                return elapsed(sw);
            }

            static long Sum(Index<float> src, out float dst)
            {            
                var sw = stopwatch();
                dst = 0;
                for(var i =0; i< src.Count; i++)
                    dst += src[i];
                return elapsed(sw);
            }

            static long Sum(Index<double> src, out double dst)
            {            
                var sw = stopwatch();
                dst = 0;
                for(var i =0; i< src.Count; i++)
                    dst += src[i];
                return elapsed(sw);
            }
        
        }
    }
}