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
    /// Characterizes a Gamma distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Gamma_distribution</remarks>
    public readonly struct GammaSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static GammaSpec<T> Define(T alpha, T dx, T beta)
            => new GammaSpec<T>(alpha : alpha, dx : MathUtil.recip(beta), beta : beta);

        [MethodImpl(Inline)]
        GammaSpec(T alpha, T dx, T beta)
        {
            this.Alpha = alpha;
            this.Dx = dx;
            this.Beta = beta;
        }

        public readonly T Alpha;

        public readonly T Dx;

        public readonly T Beta;

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind Kind 
            => DistKind.Gamma;
    }


    static class MathUtil
    {
        [MethodImpl(Inline)]
        public static T recip<T>(T value)
            where T : struct
        {
            var x = convert<T,double>(value);
            var r = 1.0/x;
            return convert<T>(r);
        }
    }

}
