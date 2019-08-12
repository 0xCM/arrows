
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
    /// Characterizes a Cauchy distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Cauchy_distribution</remarks>
    public readonly struct CauchySpec<T> : IDistributionSpec<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static CauchySpec<T> Define(T loc, T scale)
            => new CauchySpec<T>(loc, scale);

        [MethodImpl(Inline)]
        public static implicit operator (T loc, T scale)(CauchySpec<T> spec)
            => (spec.Location, spec.Scale);


        [MethodImpl(Inline)]
        public static implicit operator CauchySpec<T>((T loc, T scale) x)
            => Define(x.loc,x.scale);

        
        [MethodImpl(Inline)]
        public CauchySpec(T loc, T scale)
        {
            this.Location = loc;
            this.Scale = scale;
        }

        /// <summary>
        /// The distribution mean
        /// </summary>
        public readonly T Location;

        /// <summary>
        /// The distribution scale
        /// </summary>
        public readonly T Scale;


    }

}