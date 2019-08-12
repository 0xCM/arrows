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
    /// <remarks>See https://en.wikipedia.org/wiki/Beta_distribution</remarks>
    public readonly struct BetaSpec<T> :  IDistributionSpec<T>
        where T : struct
    {   
        [MethodImpl(Inline)]
        public static implicit operator (T alpha, T beta)(BetaSpec<T> spec)
            => (spec.Alpha, spec.Beta);

        [MethodImpl(Inline)]
        public static implicit operator BetaSpec<T>((T alpha, T beta) x )
            => Define(x.alpha, x.beta);

        [MethodImpl(Inline)]
        public static BetaSpec<T> Define(T alpha, T beta)
            => new BetaSpec<T>(alpha,beta);        

        [MethodImpl(Inline)]
        public BetaSpec(T alpha, T beta)
        {
            this.Alpha = alpha;
            this.Beta = beta;
        }
        
        [Symbol(Greek.alpha)]
        public readonly T Alpha;

        [Symbol(Greek.beta)]
        public readonly T Beta;
    }
}