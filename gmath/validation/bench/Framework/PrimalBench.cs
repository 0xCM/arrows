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

        protected static readonly BenchConfig Config0 = new BenchConfig(Cycles: Pow2.T11, Reps: 1, SampleSize: Pow2.T11, AnnounceRate: Pow2.T09);

        protected static readonly BenchConfig Config1 = new BenchConfig(Cycles: Pow2.T13, Reps: 1, SampleSize: Pow2.T12, AnnounceRate: Pow2.T11);

        protected static readonly BenchConfig Config2 = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T13, AnnounceRate: Pow2.T11);


        protected PrimalBench(IRandomizer random, BenchConfig config = null)
            : base(random, config ?? Config1)
        {
            LeftSrc = ArraySampler.Sample(random, Config.SampleSize);   
            RightSrc = ArraySampler.Sample(random, Config.SampleSize);
            NonZeroSrc = ArraySampler.Sample(random, Config.SampleSize,true);
            Baselines = BaselineMetrics.Create(LeftSrc, RightSrc, NonZeroSrc, Z0.Randomizer.define(RandSeeds.BenchSeed), config);

        }

        protected PrimalBench(ArraySampler LeftSrc, ArraySampler RightSrc, ArraySampler NonZeroSrc, IRandomizer random, BenchConfig config = null)
            : base(random, config ?? Config1)
        {
            this.LeftSrc = LeftSrc;
            this.RightSrc = RightSrc;
            this.NonZeroSrc = NonZeroSrc;
        }

        protected int SampleSize
            => Config.SampleSize;

        protected OpMetrics SampleTime(Duration workTime)
                => (SampleSize, workTime);

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

        protected T[] LeftTarget<T>(OpId<T> op = default, bool fill = true)
            where T : struct, IEquatable<T>
        {
            var target = alloc<T>(SampleSize);
            if(fill)
                LeftSample(op).Copy(target);
            return target;
        }

        protected T[] RightTarget<T>(OpId<T> op = default, bool fill = true)
            where T : struct, IEquatable<T>
        {
            var target = alloc<T>(SampleSize);
            if(fill)
                RightSample(op).Copy(target);
            return target;
        }

        protected (T[] Left,T[] Right) Sampled<T>(OpId<T> opid = default, bool nonzero = false)
            where T : struct, IEquatable<T>
                => (LeftSrc.Sampled(opid),  nonzero ? NonZeroSrc.Sampled(opid) : RightSrc.Sampled(opid));

        protected (T[] Left,T[] Right) Targets<T>(OpId<T> opid = default)
            where T : struct, IEquatable<T>
                => ArrayTargets<T>();

        protected (T[] Left,T[] Right) FilledTargets<T>(OpId<T> opid = default, bool nonzero = false)
            where T : struct, IEquatable<T>
        {
            var targets = Targets(opid);
            var sampled = Sampled(opid,nonzero);
            sampled.Left.CopyTo(targets.Left, 0);
            sampled.Right.CopyTo(targets.Right);
            return targets;
        }            
        protected abstract OpId<T> Id<T>(OpKind op, bool generic = false)
            where T : struct, IEquatable<T>;

        protected BaselineMetrics Baselines {get;}

        protected readonly ArraySampler LeftSrc;   

        protected readonly ArraySampler RightSrc;   

        protected readonly ArraySampler NonZeroSrc;   


    }


}