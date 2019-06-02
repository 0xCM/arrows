//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    partial class math
    {
        public static void negate(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static void negate(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static void negate(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static void negate(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static void negate(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static void negate(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        public static Span<sbyte> negate(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        public static Span<short> negate(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        public static Span<int> negate(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        public static Span<long> negate(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }

        public static Span<float> negate(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io; 
        }

        public static Span<double> negate(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return io;
        }        
   }
}