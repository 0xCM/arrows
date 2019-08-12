//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a beta distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Uniform_distribution</remarks>
    public readonly struct UniformSpec<T> :  IDistributionSpec<T>
        where T : struct
    {   
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define(T min, T max)
            => new UniformSpec<T>(min,max);        

        [MethodImpl(Inline)]
        public static UniformSpec<T> Define(Interval<T> src)
            => new UniformSpec<T>(src.Left,src.Right);        
        
        [MethodImpl(Inline)]
        public static implicit operator (T min, T max)(UniformSpec<T> spec)
            => (spec.Min, spec.Max);

        [MethodImpl(Inline)]
        public static implicit operator UniformSpec<T>((T min, T max) x )
            => Define(x.min, x.max);

        [MethodImpl(Inline)]
        public static implicit operator UniformSpec<T>(Interval<T> x)
            => Define(x.Left, x.Right);

        [MethodImpl(Inline)]
        public static implicit operator Interval<T>(UniformSpec<T> x)
            => Define(x.Min, x.Max);


        [MethodImpl(Inline)]
        public UniformSpec(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }
        
        public readonly T Min;

        public readonly T Max;
    }
}