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
        public static sbyte xor(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static byte xor(byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static short xor(short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static ushort xor(ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static int xor(int lhs, int rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static uint xor(uint lhs, uint rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static long xor(long lhs, long rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static ulong xor(ulong lhs, ulong rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public static ref sbyte xor(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte xor(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short xor(ref short lhs, short rhs)
        {
            lhs = (short)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort xor(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs ^ rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int xor(ref int lhs, int rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint xor(ref uint lhs, uint rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long xor(ref long lhs, long rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong xor(ref ulong lhs, ulong rhs)
        {
            lhs = lhs ^ rhs;
            return ref lhs;
        }

        public static Span<sbyte> xor(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<byte> xor(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<short> xor(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ushort> xor(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }
        
        public static Span<int> xor(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<uint> xor(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<long> xor(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ulong> xor(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = xor(lhs[i], rhs[i]);
            return dst;
        }
 


    }
}