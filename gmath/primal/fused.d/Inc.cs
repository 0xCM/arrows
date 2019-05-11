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

    partial class math
    {

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }


        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static void inc(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
        }

        [MethodImpl(NotInline)]
        public static ref Span<sbyte> inc(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<byte> inc(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<short> inc(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ushort> inc(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<int> inc(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<uint> inc(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<long> inc(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ulong> inc(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

       [MethodImpl(NotInline)]
        public static ref Span<float> inc(ref Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> inc(ref Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                io[i] = inc(io[i]);
            return ref io;
        }

    }
}