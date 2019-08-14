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
        [MethodImpl(Inline)]
        public static sbyte inc(sbyte src)
            => ++src;

        [MethodImpl(Inline)]
        public static byte inc(byte src)
            => ++src;

        [MethodImpl(Inline)]
        public static short inc(short src)
            => ++src;

        [MethodImpl(Inline)]
        public static ushort inc(ushort src)
            => ++src;

        [MethodImpl(Inline)]
        public static int inc(int src)
            => ++src;

        [MethodImpl(Inline)]
        public static uint inc(uint src)
            => ++src;

        [MethodImpl(Inline)]
        public static long inc(long src)
            => ++src;

        [MethodImpl(Inline)]
        public static ulong inc(ulong src)
            => ++src;

        [MethodImpl(Inline)]
        public static float inc(float src)
            => ++src;

        [MethodImpl(Inline)]
        public static double inc(double src)
            => ++src;

        [MethodImpl(Inline)]
        public static ref sbyte inc(sbyte src, out sbyte dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte inc(byte src, out byte dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short inc(short src, out short dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort inc(ushort src, out ushort dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int inc(int src, out int dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint inc(uint src, out uint dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long inc(long src, out long dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong inc(ulong src, out ulong dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float inc(float src, out float dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double inc(double src, out double dst)
        {
            dst = ++src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref sbyte inc(ref sbyte src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte inc(ref byte src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short inc(ref short src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort inc(ref ushort src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int inc(ref int src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint inc(ref uint src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long inc(ref long src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong inc(ref ulong src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref float inc(ref float src)
        {
            src++;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double inc(ref double src)
        {
            src++;
            return ref src;
        }

        public static Span<sbyte> inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<byte> inc(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

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

        public static Span<short> inc(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<ushort> inc(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<int> inc(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<uint> inc(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<long> inc(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<ulong> inc(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<float> inc(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

        public static Span<double> inc(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                inc(ref io[i]);
            return io;
        }

    }
}