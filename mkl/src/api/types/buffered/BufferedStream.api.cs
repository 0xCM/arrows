//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;
    using static As;

    public static class RngStreams
    {
        /// <summary>
        /// Creates a buffered stream over a uniform distribution of int, float or double values
        /// </summary>
        /// <param name="brng">The rng to use</param>
        /// <param name="min">The min stream value</param>
        /// <param name="max">The max stream value</param>
        /// <param name="seed">The initial rng state</param>
        /// <param name="bufferLen">The length of the buffer to use</param>
        /// <typeparam name="T">Either int, float or double</typeparam>
        [MethodImpl(Inline)]
        public static ISampleBuffer<T> UniformBuffer<T>(this RngStream src, T min, T max, int? bufferLen = null)
            where T : unmanaged
                => new UniformBuffer<T>(src, (min, max), bufferLen);

        /// <summary>
        /// Creates a buffered stream over a uniform distribution of int, float or double values
        /// </summary>
        /// <param name="brng">The rng to use</param>
        /// <param name="min">The min stream value</param>
        /// <param name="max">The max stream value</param>
        /// <param name="seed">The initial rng state</param>
        /// <param name="bufferLen">The length of the buffer to use</param>
        /// <typeparam name="T">Either int, float or double</typeparam>
        [MethodImpl(Inline)]
        public static ISampleBuffer<T> UniformBuffer<T>(this RngStream src, Interval<T> domain, int? bufferLen = null)
            where T : unmanaged
                => new UniformBuffer<T>(src, (domain.Left, domain.Right), bufferLen);

        /// <summary>
        /// Creates a buffered stream over a bitwisise uniform distribution uint or ulong values
        /// </summary>
        /// <param name="brng">The rng to use</param>
        /// <param name="min">The min stream value</param>
        /// <param name="max">The max stream value</param>
        /// <param name="seed">The initial rng state</param>
        /// <param name="bufferLen">The length of the buffer to use</param>
        /// <typeparam name="T">Either uint or ulong</typeparam>
        [MethodImpl(Inline)]
        public static ISampleBuffer<T> UniformBitBuffer<T>(this RngStream src, int? bufferLen = null)
            where T : unmanaged
                => new UniformBitsBuffer<T>(src, bufferLen);

        [MethodImpl(Inline)]
        public static ISampleBuffer<int> BernoulliBuffer(this RngStream src, double p, int? bufferLen = null)
            => new BernoulliBuffer<int>(src, p, bufferLen);


    }
}