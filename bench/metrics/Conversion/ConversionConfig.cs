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


    public class ConversionConfig : MetricConfig
    {
        public ConversionConfig(MetricKind Metric, int Runs, int Cycles, int Samples, PrimalKind SrcType, PrimalKind DstType)
            : base(Metric, Runs, Cycles, Samples)
        {
            this.SrcType = SrcType;
            this.DstType = DstType;
        }

        public PrimalKind SrcType {get;}

        public PrimalKind DstType {get;}

        public OpId<T> Id<S,T>()
            where S : struct
            where T : struct
                => OpKind.Convert.OpId<T>(
                    NumericSystem.Primal, 
                    generic: Metric.Genericity()
                        );

    }

}