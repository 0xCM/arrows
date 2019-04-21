//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;

    public static class Benchmarks
    {
        public static long Run<T>(BenchConfig config = null)        
            where T : struct, IEquatable<T>
        {
            try
            {
                return InXAddBench.Run<T>(config ?? BenchConfig.Default);
            }
            catch(Exception e)
            {
                error(e);
                return 0;
            }

        }
    }

    public static class InXAddBench
    {

        public static long Run<T>(BenchConfig config)
            where T : struct, IEquatable<T>
        {            
            var duration = 0L;
            var benchmark = new InXAddBench<T>(config);
            hilite($"Executing {config.Cycles} cycles", SeverityLevel.HiliteCL);
            iter(config.Cycles, _ => duration += benchmark.Run());
            hilite($"Executed {config.Cycles} cycles for a total duration of {duration}ms", SeverityLevel.HiliteCL);
            return duration;
        }

    }

    public class InXAddBench<T> : InXBinOpBench<T>
        where T : struct, IEquatable<T>
    {
        public InXAddBench(BenchConfig config)
            : base("add",config)
        {


        }

        public long Run()
        {
            var duration = 0L;
            duration += Measure(InXG.Add<T>());
            //duration += Measure(InXG.AddOut<T>());
            return duration;
        }
            
        

    }


}