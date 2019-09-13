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
    /// Characterizes a Poisson distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Poisson_distribution</remarks>
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct PoissonSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static PoissonSpec<T> Define(double rate)
            => new PoissonSpec<T>(rate);
        
        [MethodImpl(Inline)]
        public static implicit operator PoissonSpec<T>(double rate)
            => Define(rate);

        [MethodImpl(Inline)]
        public static implicit operator double(PoissonSpec<T> spec)
            => spec.Rate;

        [MethodImpl(Inline)]
        public PoissonSpec(double rate)
        {
            this.Rate = rate;
        }
        
        /// <summary>
        /// Specifies the event frequency
        /// </summary>
        public readonly double Rate;
 
         /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind DistKind 
            => DistKind.Poisson;
   }
}