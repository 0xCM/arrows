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
    /// Characterizes a bernouli distribution
    /// </summary>    
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Bernoulli_distribution</remarks>
    public readonly struct BernoulliSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static BernoulliSpec<T> Define(double p)
            => new BernoulliSpec<T>(p);
        
        [MethodImpl(Inline)]
        public static implicit operator BernoulliSpec<T>(double p)
            => Define(p);

        [MethodImpl(Inline)]
        public static implicit operator double(BernoulliSpec<T> p)
            => p.Success;
        
        [MethodImpl(Inline)]
        public BernoulliSpec(double p)
        {
            this.Success = p;
        }
        
        /// <summary>
        /// Specifies a value within the unit interval [0,1] that represents the probability of success
        /// </summary>
        public readonly double Success;

        public DistKind Kind 
            => DistKind.Bernoulli;
    }
}