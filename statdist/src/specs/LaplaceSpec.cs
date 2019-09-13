
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
    /// Characterizes a Laplace distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Laplace_distribution</remarks>
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct LaplaceSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static LaplaceSpec<T> Define(T loc, T scale)
            => new LaplaceSpec<T>(loc, scale);

        [MethodImpl(Inline)]
        public static implicit operator (T loc, T scale)(LaplaceSpec<T> spec)
            => (spec.Location, spec.Scale);


        [MethodImpl(Inline)]
        public static implicit operator LaplaceSpec<T>((T loc, T scale) x)
            => Define(x.loc,x.scale);

        
        [MethodImpl(Inline)]
        public LaplaceSpec(T loc, T scale)
        {
            this.Location = loc;
            this.Scale = scale;
        }

        /// <summary>
        /// The distribution mean
        /// </summary>
        public readonly T Location;

        /// <summary>
        /// The standard deviation
        /// </summary>
        public readonly T Scale;

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind DistKind 
            => DistKind.Laplace;

    }

}