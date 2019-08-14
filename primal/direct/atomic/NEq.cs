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
        public static bool neq(sbyte lhs, sbyte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(byte lhs, byte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(short lhs, short rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ushort lhs, ushort rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(int lhs, int rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(uint lhs, uint rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(long lhs, long rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(ulong lhs, ulong rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(float lhs, float rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bool neq(double lhs, double rhs)
            => lhs != rhs;

         public static Span<bool> neq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> neq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = neq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> neq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => neq(lhs,rhs, span<bool>(length(lhs,rhs)));
       
    }


}