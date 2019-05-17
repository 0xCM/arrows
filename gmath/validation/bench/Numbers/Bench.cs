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

    public partial class NumbersBench : BenchContext<MetricKind>
    {
        public static NumbersBench Create(IRandomizer random, BenchConfig config = null)
            => new NumbersBench(random, config);

        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T11);

        static readonly BenchConfig Config1 = new BenchConfig(Cycles: Pow2.T11, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T09);

        NumbersBench(IRandomizer random, BenchConfig config = null)
            : base(MetricKind.Numbers, random, config ?? Config0)
        {
            LeftSrc = ArraySampler.Sample(random, Config.SampleSize);   
            RightSrc = ArraySampler.Sample(random, Config.SampleSize);
            NonZeroSrc = ArraySampler.Sample(random, Config.SampleSize,true);

        }

        readonly ArraySampler LeftSrc;   

        readonly ArraySampler RightSrc;   


        readonly ArraySampler NonZeroSrc;   

        int SampleSize
            => Config.SampleSize;

        ReadOnlySpan<T> LeftSample<T>(OpId<T> op = default)
            where T : struct
                => LeftSrc.Sampled<T>();

        ReadOnlySpan<T> RightSample<T>(OpId<T> op = default)
            where T : struct
                => RightSrc.Sampled<T>();

        ReadOnlySpan<T> NonZeroSample<T>(OpId<T> op = default)
            where T : struct
                => NonZeroSrc.Sampled<T>();

        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Numbers<T>();

        T[] Target<T>(OpId<T> op = default)
            where T : struct
                => array<T>(SampleSize);


    }

}