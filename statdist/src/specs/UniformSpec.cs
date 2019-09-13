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
    /// Defines operations specific to uniform distributions
    /// </summary>
    public static class UniformSpec
    {
        /// <summary>
        /// Interprets a supplied spec as a uniform spec; an error
        /// is raised if the spec does not define a uniform distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformSpec<T> From<T>(IDistributionSpec<T> spec)
            where T : unmanaged
                => (UniformSpec<T>)spec;

        /// <summary>
        /// Defines a unform distribution bound between lower and upper bounds
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define<T>(T min, T max)
            where T : unmanaged
                => UniformSpec<T>.Define(min,max);        

        /// <summary>
        /// Defines a uniform distribution bound to an interval domain
        /// </summary>
        /// <param name="domain">The potential range of sample values</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define<T>(Interval<T> domain)
            where T : unmanaged
                => UniformSpec<T>.Define(domain);        
        
    }

    /// <summary>
    /// Characterizes a uniform distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Uniform_distribution</remarks>
    public readonly struct UniformSpec<T> :  IDistributionSpec<T>
        where T : unmanaged
    {   
        /// <summary>
        /// Defines a unform distribution bound between lower and upper bounds
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        [MethodImpl(Inline)]
        public static UniformSpec<T> Define(T min, T max)
            => new UniformSpec<T>(min,max);        

        /// <summary>
        /// Defines a uniform distribution bound to an interval domain
        /// </summary>
        /// <param name="domain">The potential range of sample values</param>
        /// <typeparam name="T">The sample element type</typeparam>
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
 
         /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind DistKind 
            => DistKind.Uniform;


        [MethodImpl(Inline)]
        public UniformSpec<int> ToInt32()
            => new UniformSpec<int>(convert<T,int>(Min), convert<T,int>(Max));

        [MethodImpl(Inline)]
        public UniformSpec<float> ToFloat32()
            => new UniformSpec<float>(convert<T,float>(Min), convert<T,float>(Max));

        [MethodImpl(Inline)]
        public UniformSpec<double> ToFloat64()
            => new UniformSpec<double>(convert<T,double>(Min), convert<T,double>(Max));

   }
}