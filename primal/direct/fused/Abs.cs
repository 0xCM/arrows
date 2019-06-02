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
        public static Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        public static Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        public static Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        public static Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        public static Span<float> abs(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        public static Span<double> abs(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<sbyte> abs(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }

        public static Span<short> abs(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }

        public static Span<int> abs(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }

        public static Span<long> abs(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }

        public static Span<float> abs(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }

        public static Span<double> abs(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return io;
        }
 
        [MethodImpl(Inline)]
        public static Span<sbyte> abs(ReadOnlySpan<sbyte> src)
            => abs(src, span<sbyte>(src.Length));

        [MethodImpl(Inline)]
        public static Span<short> abs(ReadOnlySpan<short> src)
            => abs(src, span<short>(src.Length));


        [MethodImpl(Inline)]
        public static Span<int> abs(ReadOnlySpan<int> src)
            => abs(src, span<int>(src.Length));

        [MethodImpl(Inline)]
        public static Span<long> abs(ReadOnlySpan<long> src)
            => abs(src, span<long>(src.Length));

        [MethodImpl(Inline)]
        public static Span<float> abs(ReadOnlySpan<float> src)
            => abs(src, span<float>(src.Length));

        [MethodImpl(Inline)]
        public static Span<double> abs(ReadOnlySpan<double> src)
            => abs(src, span<double>(src.Length));

    }
}