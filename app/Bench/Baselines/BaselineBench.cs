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

    using static zcore;
    
    partial class BaselineBench
    {

        public static void Run(BenchConfig config = null)
        {
            var sw = stopwatch();
            var Config = config ?? BenchConfig.Default;

            //var primal = BenchResult.Define("primal/add", BaselineBench.RunPrimalAdd(Config));
            //inform($"Primal Benchmark           = {primal.Duration}ms");
            var intrinsic =   BenchResult.Define("intrinsics/add", BaselineBench.RunInXAdd(Config));
            var intrinsicG =   BenchResult.Define("intrinsics-g/add", BaselineBench.RunInXAddG(Config));
            inform($"Total Runtime              = {sw.ElapsedMilliseconds}ms");
            inform($"Total Benchtime            = {(intrinsic + intrinsicG).Duration}ms");
            inform($"Intrinsics Benchmark       = {intrinsic.Duration}ms");            
            inform($"Intrinsics Benchmark (G)   = {intrinsicG.Duration}ms");
        }
    }
}