//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a binomial distribution
    /// </summary>
    /// <typeparam name="T">The (integral) sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Binomial_distribution</remarks>
    public readonly struct BinomialSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static BinomialSpec<T> Define(T n, double p)
            => new BinomialSpec<T>(n,p);
    
        [MethodImpl(Inline)]
        public static implicit operator (T n, double p)(BinomialSpec<T> spec)
            => (spec.Trials, spec.Success);

        [MethodImpl(Inline)]
        public static implicit operator BinomialSpec<T>((T n, double p) spec)
            => (spec.n, spec.p);

        
        [MethodImpl(Inline)]
        public BinomialSpec(T n, double p)
        {
            this.Trials = n;
            this.Success = p;
        }
        
        public readonly T Trials;

        public readonly double Success;
 
         /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind Kind 
            => DistKind.Binomial;

    }
}