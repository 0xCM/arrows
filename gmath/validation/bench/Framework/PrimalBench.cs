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

    public abstract class PrimalBench : BenchContext
    {

        static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T13, Reps: 1, SampleSize: Pow2.T12, AnnounceRate: Pow2.T11);
        
        static readonly BenchConfig Config1 = new BenchConfig(Cycles: Pow2.T11, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T09);

        protected PrimalBench(IRandomizer random, BenchConfig config = null)
            : base(random, config ?? Config0)
        {
            LeftSrc = ArraySampler.Sample(random, Config.SampleSize);   
            RightSrc = ArraySampler.Sample(random, Config.SampleSize);
            NonZeroSrc = ArraySampler.Sample(random, Config.SampleSize,true);

        }

        protected int SampleSize
            => Config.SampleSize;

        protected ReadOnlySpan<T> LeftSample<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => LeftSrc.Sampled<T>();

        protected ReadOnlySpan<T> RightSample<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => RightSrc.Sampled<T>();

        protected ReadOnlySpan<T> NonZeroSample<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => NonZeroSrc.Sampled<T>();

        protected Span<T> Target<T>(OpId<T> op = default)
            where T : struct, IEquatable<T>
                => span<T>(SampleSize);

        protected (T[] Left,T[] Right) Sampled<T>(OpId<T> opid = default, bool nonzero = false)
            where T : struct, IEquatable<T>
                => (LeftSrc.Sampled(opid),  nonzero ? NonZeroSrc.Sampled(opid) : RightSrc.Sampled(opid));

        protected (T[] Left,T[] Right) Targets<T>(OpId<T> opid = default)
            where T : struct, IEquatable<T>
                => ArrayTargets<T>();

        protected abstract OpId<T> Id<T>(OpKind op, bool generic = false)
            where T : struct, IEquatable<T>;

        protected readonly ArraySampler LeftSrc;   

        protected readonly ArraySampler RightSrc;   

        protected readonly ArraySampler NonZeroSrc;   


    }


}