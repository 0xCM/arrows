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
    using static global::mfunc;

    using Aligned = Span128;

    public partial class Vec128Bench : BenchContext
    {   
        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T12, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T11);        
        
        public static Vec128Bench Create(IRandomizer random, BenchConfig config = null)
            => new Vec128Bench(random, config ?? Config0);
        
        Vec128Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {

            LeftSamples = Span128Sampler.Sample(random, config.SampleSize);   
            RightSamples = Span128Sampler.Sample(random, config.SampleSize);            
        }


        protected UnaryOpData<T> UnaryOpInit<T>(bool nonzero = false)                
            where T : struct
        {
            GC.Collect();
            return new UnaryOpData<T>(
                Sample<T>(Config.SampleSize, nonzero), 
                alloc<T>(Config.SampleSize),
                alloc<T>(Config.SampleSize)
            );
        }

        readonly Span128Sampler LeftSamples;   

        readonly Span128Sampler RightSamples;   

        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Vec128OpId<T>();

        Span128<T>  LeftSample<T>(OpId<T> opid = default)
            where T : struct
                => LeftSamples.Sampled<T>();

        Span128<T>  RightSample<T>(OpId<T> opid = default)
            where T : struct
                => RightSamples.Sampled<T>();

        Span128<T> Target<T>(OpId<T> opid = default)
            where T : struct
                => Span128.blockalloc<T>(Config.SampleSize);

        (T[] Left,T[] Right) Targets<T>(OpId<T> opid)
            where T : struct
                => (Span128.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span128.blockalloc<T>(Config.SampleSize).ToArray());                

        (T[] Left,T[] Right) Targets<T>(T specimen = default(T))
            where T : struct
                => (Span128.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span128.blockalloc<T>(Config.SampleSize).ToArray());                
    
    }
}