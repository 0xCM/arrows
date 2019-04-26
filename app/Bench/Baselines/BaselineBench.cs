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

        static IEnumerable<BenchResult> RunEach(BenchConfig Config)
        {

            // yield return BenchResult.Define("primal/add",BaselineBench.RunPrimalAdd(Config));
            // yield return BenchResult.Define("intrisics/add", BaselineBench.RunInXAdd(Config));
            // yield return BenchResult.Define("intrisics-g/add", BaselineBench.RunInXAddG(Config));            
            
            yield return BenchResult.Define("primal/sum", BaselineBench.RunPrimalSum(Config));
            yield return BenchResult.Define("intrisics/sum", BaselineBench.RunInXSum(Config));
            yield return BenchResult.Define("intrisics-g/sum", BaselineBench.RunInXSumG(Config));
        }

        static Index<BenchResult> Force(IEnumerable<BenchResult> results)
            => results.ToIndex();

        public static void Run(BenchConfig config = null)
        {
            var sw = stopwatch();
            var Config = config ?? BenchConfig.Default;
            var results = Force(RunEach(Config));

            foreach(var result in results)
                inform(result);

            var msTotal = results.Select(x => x.Duration).Sum();

            inform($"Total Runtime              = {sw.ElapsedMilliseconds}ms");
            inform($"Total Benchtime            = {msTotal}ms");
        }
    }
}