//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
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

        public static Span<ulong> uniform(VslStream stream, Span<ulong> dst)
        {
            VSL.viRngUniformBits64(0,stream, dst.Length, ref dst[0]).ThrowOnError();
            return dst;
        }
            
        public static Span<uint> uniform(VslStream stream, Span<uint> dst)
        {
            VSL.viRngUniformBits32(0,stream, dst.Length, ref dst[0]).ThrowOnError();
            return dst;
        }


    }

}