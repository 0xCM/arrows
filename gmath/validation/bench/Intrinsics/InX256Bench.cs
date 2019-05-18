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
    using Aligned = Span256;

    public partial class InX256Bench : BenchContext<MetricKind>
    {   

       public static IOpMetrics MeasureIntrinsicGeneric(OpKind op, PrimalKind primal, InXMetricConfig config)
       {
            var metric = MetricKind.Vec256;
            var measure = metric.Run(op, primal, config, Genericity.Generic);
            zfunc.print(measure.Describe(true));
            return measure;
       }

       public static IOpMetrics MeasureIntrinsicDirect(OpKind op, PrimalKind primal, InXMetricConfig config)
       {
            var metric = MetricKind.Vec256;
            var measure = metric.Run(op, primal, config, Genericity.Direct);
            zfunc.print(measure.Describe(true));
            return measure;
       }

        public static IEnumerable<BenchComparisonRecord> CompareIntrinsics(OpKind op, PrimalKind primal, InXMetricConfig config)
        {
            var m1 = MeasureIntrinsicDirect(op, primal, config);
            var m2 = MeasureIntrinsicGeneric(op, primal, config);
            var compare = m1.Compare(m2);
            var record = compare.ToRecord();
            yield return record;

        }

        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T13);

        public static InX256Bench Create(IRandomizer random, BenchConfig config = null)
            => new InX256Bench(random, config ?? DefaultConfig);
        
        InX256Bench(IRandomizer random, BenchConfig config)
            : base(MetricKind.Vec256,random, config)
        {

            LeftSrc = Span256Sampler.Sample(random, config.SampleSize);   
            RightSrc = Span256Sampler.Sample(random, config.SampleSize);

        }

       static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Vec256OpId<T>();

        readonly Span256Sampler LeftSrc;   

        Span256<T> LeftSample<T>(OpId<T> op)
            where T : struct
            => LeftSrc.Sampled<T>();

        Span256<T> RightSample<T>(OpId<T> op)
            where T : struct
            => RightSrc.Sampled<T>();

        readonly Span256Sampler RightSrc;   

        (T[] Left,T[] Right) Targets<T>(OpId<T> id = default)
            where T : struct
                => (Span256.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span256.blockalloc<T>(Config.SampleSize).ToArray());                

    
    }
}