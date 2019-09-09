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
        public static sbyte idiv(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static byte idiv(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        public static short idiv(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        public static ushort idiv(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        public static int idiv(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static uint idiv(uint lhs, uint rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static long idiv(long lhs, long rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ulong idiv(ulong lhs, ulong rhs)
            => lhs / rhs;

 
        [MethodImpl(Inline)]
        public static ref sbyte idiv(ref sbyte lhs, in sbyte rhs)
        {
            lhs = (sbyte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte idiv(ref byte lhs, in byte rhs)
        {
            lhs = (byte)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short idiv(ref short lhs, in short rhs)
        {
            lhs = (short)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort idiv(ref ushort lhs, in ushort rhs)
        {
            lhs = (ushort)(lhs / rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int idiv(ref int lhs, in int rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint idiv(ref uint lhs, in uint rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long idiv(ref long lhs, in long rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong idiv(ref ulong lhs, in ulong rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }


        public static Span<sbyte> idiv(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> idiv(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<short> idiv(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ushort> idiv(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<int> idiv(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<uint> idiv(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<long> idiv(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ulong> idiv(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = idiv(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<sbyte> idiv(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<byte> idiv(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<short> idiv(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<ushort> idiv(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<int> idiv(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<uint> idiv(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<long> idiv(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }

        public static Span<ulong> idiv(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] /= rhs[i];
            return lhs;
        }
   }
}