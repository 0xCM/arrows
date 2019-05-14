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

    public partial class Vec256Bench : BenchContext
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T13);

        public static Vec256Bench Create(IRandomizer random, BenchConfig config = null)
            => new Vec256Bench(random, config ?? DefaultConfig);
        
        Vec256Bench(IRandomizer random, BenchConfig config)
            : base(random, config)
        {

            LeftSrc = Span256Sampler.Sample(random, config.SampleSize);   
            RightSrc = Span256Sampler.Sample(random, config.SampleSize);

        }

       static OpId<T> Id<T>(OpKind op)
            where T : struct, IEquatable<T>
                => op.Vec256OpId<T>();

        readonly Span256Sampler LeftSrc;   

        readonly Span256Sampler RightSrc;   

        (T[] Left,T[] Right) Targets<T>(OpId<T> id = default)
            where T : struct, IEquatable<T>
                => (Span256.blockalloc<T>(Config.SampleSize).ToArray(),
                    Span256.blockalloc<T>(Config.SampleSize).ToArray());                

    
    }
}