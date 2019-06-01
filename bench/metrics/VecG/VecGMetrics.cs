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


    public static class VecGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, 
                        numKind : NumericKind.VecG, 
                        generic: Genericity.Generic, 
                        fusion : OpFusion.Fused);

        public const MetricKind Metric = MetricKind.VecG;

        public static int Cycles(VecGConfig config)
            => Metric.Configure(config).Cycles;
        
        public static int length<S,T>(VecG<S> x, VecG<T> y)
            where S : struct
            where T : struct
        {
            if(x.Length == y.Length)
                return x.Length;
            else
                throw Errors.LengthMismatch(x.Length, y.Length);
            
        }

        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, VecGConfig config, Duration WorkTime, Span<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results);


    }

}