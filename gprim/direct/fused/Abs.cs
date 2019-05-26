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

        [MethodImpl(NotInline)]
        public static Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> abs(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> abs(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<sbyte> abs(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<short> abs(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }


        [MethodImpl(NotInline)]
        public static ref Span<int> abs(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }


        [MethodImpl(NotInline)]
        public static ref Span<long> abs(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<float> abs(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> abs(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                abs(ref io[i]);
            return ref io;
        }
    }
}