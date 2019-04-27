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
    
    // partial class BaselineBench
    // {
    //     static BenchResult RunInXSum<T>(BenchConfig config = null)
    //         where T : struct, IEquatable<T>        
    //             => AggregateBenchmark.Runner<T>("intrinsics/sum", config).Run(InXSum.Operator<T>());

    //     static IEnumerable<BenchResult> RunInXSum(BenchConfig config = null)
    //     {
    //         yield return RunInXSum<short>(config);
    //         yield return RunInXSum<int>(config);
    //         yield return RunInXSum<float>(config);
    //         yield return RunInXSum<double>(config);
    //     }

    //     static BenchResult RunInXSumG<T>(BenchConfig config = null)
    //         where T : struct, IEquatable<T>        
    //             => AggregateBenchmark.Runner<T>("intrinsics-g/sum",config).Run(InXSum.OperatorG<T>());

    //     static IEnumerable<BenchResult> RunInXSumG(BenchConfig config = null)
    //     {
    //         yield return RunInXSumG<short>(config);
    //         yield return RunInXSumG<int>(config);
    //         yield return RunInXSumG<float>(config);
    //         yield return RunInXSumG<double>(config);
    //     }

    //     class InXSum
    //     {
    //         public static readonly PrimalIndex Operators 
    //             = PrimKinds.index<object>
    //                 (
    //                     @short: new TimedAggOp<short>(Sum),
    //                     @int: new TimedAggOp<int>(Sum),
    //                     @float: new TimedAggOp<float>(Sum),
    //                     @double: new TimedAggOp<double>(Sum)
    //                 );

    //         static long SumG<T>(Index<T> lhs, out T dst)
    //             where T : struct, IEquatable<T>
    //         {
    //             var sw = stopwatch();
    //             dst = InXFusionOps.sum(lhs);
    //             return elapsed(sw);
    //         }

    //         public static TimedAggOp<T> OperatorG<T>()
    //             where T : struct, IEquatable<T>
    //                 => SumG;
    //         public static TimedAggOp<T> Operator<T>()
    //             where T : struct, IEquatable<T>
    //                 => Operators.lookup<T, TimedAggOp<T>>();

    //         static long Sum(Index<short> src, out short dst)
    //         {
    //             var sw = stopwatch();
    //             dst = src.InXSum();
    //             return elapsed(sw);
    //         }        

    //         static long Sum(Index<int> src, out int dst)
    //         {
    //             var sw = stopwatch();
    //             dst = src.InXSum();
    //             return elapsed(sw);
    //         }                    

    //         static long Sum(Index<float> src, out float dst)
    //         {
    //             var sw = stopwatch();
    //             dst = src.InXSum();
    //             return elapsed(sw);
    //         }        

    //         static long Sum(Index<double> src, out double dst)
    //         {
    //             var sw = stopwatch();
    //             dst = src.InXSum();
    //             return elapsed(sw);
    //         }        

    //     }
    // }
}