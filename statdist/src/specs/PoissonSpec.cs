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
    public readonly struct PoissonSpec<T> : IDistributionSpec<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static PoissonSpec<T> Define(T p)
            => new PoissonSpec<T>(p);
        
        [MethodImpl(Inline)]
        public static implicit operator PoissonSpec<T>(T p)
            => Define(p);

        [MethodImpl(Inline)]
        public static implicit operator T(PoissonSpec<T> p)
            => p.Success;

        [MethodImpl(Inline)]
        public PoissonSpec(T lambda)
        {
            this.Success = lambda;
        }
        
        /// <summary>
        /// Specifies a value within the unit interval [0,1] that represents the probability of success
        /// </summary>
        public readonly T Success;
    }
}