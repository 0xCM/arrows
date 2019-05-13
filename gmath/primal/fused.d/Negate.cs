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

    
    using static mfunc;
    using static zfunc;

    partial class math
    {

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void negate(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = negate(src[i]);
        }

        [MethodImpl(NotInline)]
        public static ref Span<sbyte> negate(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<short> negate(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<int> negate(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<long> negate(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<float> negate(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io; 
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> negate(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                negate(ref io[i]);
            return ref io;
        }        
   }
}