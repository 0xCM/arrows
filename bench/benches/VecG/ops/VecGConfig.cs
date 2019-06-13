//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class VecGX
    {

        public static VecGContext VecGContext(this MetricConfig config, IRandomSource random = null)  
            => new VecGContext(config,random);
    }
    
    public sealed class VecGContext : BenchContext<MetricConfig>
    {
        public VecGContext(MetricConfig config, IRandomSource random = null)
            : base(config, random)
        {


        }

        public PrimalDContext ToPrimalD()
            => new PrimalDContext(PrimalDConfig.Define(Config), Random);

        public Metrics<T> CaptureMetrics<T>(OpId<T> OpId, Duration WorkTime, ReadOnlySpan<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)Config.Cycles) * ((long)results.Length), WorkTime, results.ToArray());

    }
}