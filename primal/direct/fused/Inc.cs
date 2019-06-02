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
        public static Span<sbyte> inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<byte> inc(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<short> inc(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> inc(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> inc(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static  Span<uint> inc(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<long> inc(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> inc(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> inc(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> inc(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<sbyte> inc(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<byte> inc(Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<short> inc(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> inc(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<int> inc(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<uint> inc(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<long> inc(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> inc(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

       [MethodImpl(NotInline)]
        public static Span<float> inc(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        [MethodImpl(NotInline)]
        public static Span<double> inc(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

    }
}