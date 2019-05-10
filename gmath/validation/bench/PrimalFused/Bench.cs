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

    public partial class PrimalFusedBench : BenchContext
    {
        public static PrimalFusedBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalFusedBench(random, config);

        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T11);

        static readonly BenchConfig Config1 = new BenchConfig(Cycles: Pow2.T11, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T09);

        PrimalFusedBench(IRandomizer random, BenchConfig config = null)
            : base(random, config ?? Config1)
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
            where T : struct, IEquatable<T>
                => LeftSrc.Sampled<T>();

        ReadOnlySpan<T> RightSample<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => RightSrc.Sampled<T>();

        ReadOnlySpan<T> NonZeroSample<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => NonZeroSrc.Sampled<T>();

        (T[] Left,T[] Right) Sampled<T>(OpId<T> opid = default)
            where T : struct, IEquatable<T>
                => (LeftSrc.Sampled(opid), RightSrc.Sampled(opid));

        static OpId<T> Id<T>(OpKind op, bool generic = false)
            where T : struct, IEquatable<T>
                => op.PrimalFused<T>(generic);

        (T[] Left,T[] Right) Targets<T>(OpId<T> opid = default)
            where T : struct, IEquatable<T>
                => ArrayTargets<T>();

    }
}