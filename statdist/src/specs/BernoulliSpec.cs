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
    /// Defines operations specific to Bernoulli distributions
    /// </summary>
    public static class BernoulliSpec
    {
        /// <summary>
        /// Interprets a supplied spec as a Bernoulli spec; an error
        /// is raised if the spec does not define a Bernoulli distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static BernoulliSpec<T> From<T>(IDistributionSpec<T> src)
            where T : unmanaged
            => (BernoulliSpec<T>)src;
        
        /// <summary>
        /// Defines a Bernoulli distribution predicated on the probability of trial success
        /// </summary>
        /// <param name="p">The probability of success</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static BernoulliSpec<T> Define<T>(double p)
            where T : unmanaged
                => BernoulliSpec<T>.Define(p);
    }

    /// <summary>
    /// Characterizes a bernouli distribution
    /// </summary>    
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Bernoulli_distribution</remarks>
    public readonly struct BernoulliSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {        
        
        /// <summary>
        /// Defines a Bernoulli distribution predicated on the probability of trial success
        /// </summary>
        /// <param name="p">The probability of success</param>
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

        public DistKind DistKind 
            => DistKind.Bernoulli;
    }
}