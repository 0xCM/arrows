//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

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

    /// <summary>
    /// Characterizes a Gamma distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Gamma_distribution</remarks>
    public readonly struct GammaSpec<T> : IDistributionSpec<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static GammaSpec<T> FromShapeAndScale(T alpha, T theta)
            => new GammaSpec<T>(alpha : alpha, theta : theta, beta : MathUtil.recip(theta));        

        [MethodImpl(Inline)]
        public static GammaSpec<T> FromShapeAndRate(T alpha, T beta)
            => new GammaSpec<T>(alpha : alpha, theta : MathUtil.recip(beta), beta : beta);

        [MethodImpl(Inline)]
        GammaSpec(T alpha, T theta, T beta)
        {
            this.Shape = alpha;
            this.Scale = theta;
            this.Rate = beta;
        }

        [Symbol(Greek.alpha)]
        public readonly T Shape;

        [Symbol(Greek.theta)]
        public readonly T Scale;

        [Symbol(Greek.beta)]
        public readonly T Rate;
    }
}
