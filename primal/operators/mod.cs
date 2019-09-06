//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        
        [MethodImpl(Inline)]
        public static sbyte mod(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        [MethodImpl(Inline)]
        public static byte mod(byte lhs, byte rhs)
            => (byte)(lhs % rhs);

        [MethodImpl(Inline)]
        public static short mod(short lhs, short rhs)
            => (short)(lhs % rhs);

        [MethodImpl(Inline)]
        public static ushort mod(ushort lhs, ushort rhs)
            => (ushort)(lhs % rhs);

        [MethodImpl(Inline)]
        public static int mod(int lhs, int rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static uint mod(uint lhs, uint rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static long mod(long lhs, long rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static ulong mod(ulong lhs, ulong rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public static ref sbyte mod(ref sbyte lhs, in sbyte rhs)
        {
            lhs = (sbyte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte mod(ref byte lhs, in byte rhs)
        {
            lhs = (byte)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short mod(ref short lhs, in short rhs)
        {
            lhs = (short)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort mod(ref ushort lhs, in ushort rhs)
        {
            lhs = (ushort)(lhs % rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int mod(ref int lhs, in int rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint mod(ref uint lhs, in uint rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long mod(ref long lhs, in long rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong mod(ref ulong lhs, in ulong rhs)
        {
            lhs = lhs % rhs;
            return ref lhs;
        }

        public static Span<sbyte> mod(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> mod(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
            return dst;
        }

        public static void mod(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static void mod(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mod(lhs[i], rhs[i]);
        }

        public static Span<sbyte> mod(Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<byte> mod(Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<short> mod(Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<ushort> mod(Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<int> mod(Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<uint> mod(Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<long> mod(Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }

        public static Span<ulong> mod(Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] %= rhs[i];
            return lhs;
        }


        public static Span<sbyte> mod(Span<sbyte> lhs, sbyte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<byte> mod(Span<byte> lhs, byte rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<short> mod(Span<short> lhs, short rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<ushort> mod(Span<ushort> lhs, ushort rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<int> mod(Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<uint> mod(Span<uint> lhs, uint rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<long> mod(Span<long> lhs, long rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

        public static Span<ulong> mod(Span<ulong> lhs, ulong rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] %= rhs;
            return lhs;
        }

    }
}