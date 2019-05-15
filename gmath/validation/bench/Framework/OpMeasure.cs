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



    public abstract class OpMeasure<T>
        where T : struct
    {
        protected OpMeasure(OpId<T> OpId, ArraySampler LeftSrc, ArraySampler RightSrc, ArraySampler NonZeroSrc)
        {   
            this.OpId = OpId;
            this.LeftSrc = LeftSrc;
            this.RightSrc = RightSrc;
            this.NonZeroSrc = NonZeroSrc;
        }

        protected OpMeasure(OpId<T> OpId, IRandomizer random, int SampleSize)
            : this(OpId, 
                ArraySampler.Sample(random, SampleSize), 
                ArraySampler.Sample(random, SampleSize), 
                ArraySampler.Sample(random, SampleSize,true)
                )
        {

        }

        readonly ArraySampler LeftSrc;   

        readonly ArraySampler RightSrc;   

        readonly ArraySampler NonZeroSrc;   

        protected int SampleSize {get;}

        public OpId<T> OpId {get;}

        protected ReadOnlySpan<T> LeftSample()
            => LeftSrc.Sampled<T>();

        protected ReadOnlySpan<T> RightSample()
            => RightSrc.Sampled<T>();

        protected ReadOnlySpan<T> NonZeroSample()
            => NonZeroSrc.Sampled<T>();

        protected T[] Target()
            => array<T>(SampleSize);

        protected (T[] Left, T[] Right) Targets()
            => (array<T>(SampleSize), array<T>(SampleSize));

    }

    public static class AddMeasure
    {
        public static AddMeasure<T> DefineMeasure<T>(OpId<T> OpId, IRandomizer random, int SampleSize)
          where T : struct
                => new AddMeasure<T>(OpId, random, SampleSize);

    }
    public class AddMeasure<T> : OpMeasure<T>
         where T : struct
    {
        public AddMeasure(OpId<T> OpId, IRandomizer random, int SampleSize)
            : base(OpId, random, SampleSize)
        {

        }

        OpMetrics<T> addNumbers()
        {
            var lhs = numbers(LeftSample());
            var rhs = numbers(RightSample());
            
            var sw = stopwatch();
            var result = lhs + rhs;   
            var time = snapshot(sw);                    

            return(OpId,SampleSize, time, result.ToArray());
        }
        
        public OpMetrics<T> Measure()
        {
            return addNumbers();
        }

    }
 


}