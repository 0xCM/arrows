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

    using Aligned = Span128;

    public partial class InX128Bench : BenchContext<MetricKind>
    {   
       public static IOpMetrics MeasureIntrinsicGeneric(OpKind op, PrimalKind primal, InXMetricConfig config)
       {
            var metric = MetricKind.Vec128;
            var measure = metric.Run(op, primal, config, Genericity.Generic);
            zfunc.print(measure.Describe(true));
            return measure;
       }


       public static IOpMetrics MeasureIntrinsicDirect(OpKind op, PrimalKind primal, InXMetricConfig config)
       {
            var metric = MetricKind.Vec128;
            var measure = metric.Run(op, primal, config, Genericity.Direct);
            zfunc.print(measure.Describe(true));
            return measure;
       }

        public static IEnumerable<BenchComparisonRecord> CompareIntrinsics(OpKind op, PrimalKind primal, InXMetricConfig config)
        {
            var m1 = MeasureIntrinsicDirect(op, primal,config);
            var m2 = MeasureIntrinsicGeneric(op, primal,config);
            var compare = m1.Compare(m2);
            var record = compare.ToRecord();
            yield return record;
        }

        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T12, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T11);        
        
        public static InX128Bench Create(IRandomizer random, BenchConfig config = null)
            => new InX128Bench(random, config ?? Config0);
        
        InX128Bench(IRandomizer random, BenchConfig config)
            : base(MetricKind.Vec128, random, config)
        {

            LeftSrc = Span128Sampler.Sample(random, config.SampleSize);   
            RightSrc = Span128Sampler.Sample(random, config.SampleSize);   
            NonZeroSrc = Span128Sampler.Sample(random, config.SampleSize,true);
        }

        readonly Span128Sampler LeftSrc;   

        readonly Span128Sampler RightSrc;   

        protected readonly Span128Sampler NonZeroSrc;   

        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Vec128OpId<T>();

        Span128<T>  LeftSample<T>(OpId<T> opid = default)
            where T : struct
                => LeftSrc.Sampled<T>();

        Span128<T>  RightSample<T>(OpId<T> opid = default)
            where T : struct
                => RightSrc.Sampled<T>();

        Span128<T> Target<T>(OpId<T> opid = default)
            where T : struct
                => Span128.alloc<T>(Config.SampleSize);

        (T[] Left,T[] Right) Targets<T>(OpId<T> opid)
            where T : struct
                => (Span128.alloc<T>(Config.SampleSize).ToArray(),
                    Span128.alloc<T>(Config.SampleSize).ToArray());                

        (T[] Left,T[] Right) Targets<T>(T specimen = default(T))
            where T : struct
                => (Span128.alloc<T>(Config.SampleSize).ToArray(),
                    Span128.alloc<T>(Config.SampleSize).ToArray());                
    
    }
}