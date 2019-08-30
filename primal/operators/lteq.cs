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
        public static bool lteq(sbyte lhs, sbyte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(byte lhs, byte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(short lhs, short rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(ushort lhs, ushort rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(int lhs, int rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(uint lhs, uint rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(long lhs, long rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(ulong lhs, ulong rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(float lhs, float rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bool lteq(double lhs, double rhs)
            => lhs <= rhs;        
 
         public static Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }
 
        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));
 
    }
}