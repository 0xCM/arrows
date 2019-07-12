//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
 
    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
        public static VslStream stream(BRNG brng, uint seed)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng, seed).ThrowOnError();
            return stream;
        }

        public static Span<int> uniform(VslStream stream, Interval<int> range, Span<int> dst)
        {
            VSL.viRngUniform(0,stream, dst.Length, ref dst[0], range.Left, range.Right).ThrowOnError();
            return dst;
        }

        public static Span<float> uniform(VslStream stream, Interval<float> range, Span<float> dst)
        {
            VSL.vsRngUniform(0,stream, dst.Length, ref dst[0], range.Left, range.Right).ThrowOnError();
            return dst;
        }

        public static Span<double> uniform(VslStream stream, Interval<double> range, Span<double> dst)
        {
            VSL.vdRngUniform(0,stream, dst.Length, ref dst[0], range.Left, range.Right).ThrowOnError();
            return dst;
        }

        /// <summary>
        /// Generates uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dst">The receiver</param>
        public static Span<uint> ubits(VslStream stream, Span<uint> dst)
        {
            VSL.viRngUniformBits32(0,stream, dst.Length, ref dst[0]).ThrowOnError();
            return dst;
        }

        /// <summary>
        /// Generates uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dst">The receiver</param>
        public static Span<ulong> ubits(VslStream stream, Span<ulong> dst)
        {
            VSL.viRngUniformBits64(0,stream, dst.Length, ref dst[0]).ThrowOnError();
            return dst;
        }

        public static Span<int> geometric(VslStream stream, double p, Span<int> dst)
        {
            VSL.viRngGeometric(0, stream, dst.Length, ref dst[0], p);
            return dst;
        }

        public static Span<Bit> bernoulli(VslStream stream, double p, Span<Bit> dst)
        {
            Span<int> tmp = stackalloc int[dst.Length];
            VSL.viRngBernoulli(0, stream, dst.Length, ref tmp[0],p);
            for(var i=0; i < dst.Length; i++)
                dst[i] =tmp[i];
            return dst;
        }
    }

}