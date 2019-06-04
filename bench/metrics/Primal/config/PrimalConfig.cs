//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public static class CmpExt
    {
        public static T[] ToScalars<T>(this bool[] src, OpId<T> opid)
            where T : struct
                => src.ToScalars<T>();
    }

    public abstract class PrimalConfig : MetricConfig
    {
        protected PrimalConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }                

        public PrimalDConfig ToDirect()
            => new PrimalDConfig(Metric, Runs, Cycles, Samples);

        public PrimalGConfig ToGeneric()
            => new PrimalGConfig(Metric, Runs, Cycles, Samples);
    }
        
}