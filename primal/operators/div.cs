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
    using System.Numerics;
    
    using static zfunc;    
    
    partial class math
    {

        [MethodImpl(Inline)]
        public static sbyte div(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static byte div(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static short div(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        public static ushort div(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        public static int div(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static uint div(uint lhs, uint rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static long div(long lhs, long rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ulong div(ulong lhs, ulong rhs)
            => lhs / rhs;

 
        [MethodImpl(Inline)]
        public static ref sbyte div(ref sbyte lhs, in sbyte rhs)
        {
            lhs = (sbyte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte div(ref byte lhs, in byte rhs)
        {
            lhs = (byte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short div(ref short lhs, in short rhs)
        {
            lhs = (short)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort div(ref ushort lhs, in ushort rhs)
        {
            lhs = (ushort)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int div(ref int lhs, in int rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint div(ref uint lhs, in uint rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long div(ref long lhs, in long rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong div(ref ulong lhs, in ulong rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }


        public static Span<sbyte> div(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> div(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<short> div(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ushort> div(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<int> div(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<uint> div(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<long> div(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ulong> div(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = div(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<sbyte> div(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<byte> div(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<short> div(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<ushort> div(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<int> div(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<uint> div(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<long> div(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<ulong> div(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }
   }
}