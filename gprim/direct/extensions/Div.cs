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
    
    partial class MathX
    {

        [MethodImpl(Inline)]
        public static ref sbyte Div(this ref sbyte lhs, sbyte rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte Div(this ref byte lhs, byte rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short Div(this ref short lhs, short rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort Div(this ref ushort lhs, ushort rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int Div(this ref int lhs, int rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint Div(this ref uint lhs, uint rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long Div(this ref long lhs, long rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong Div(this ref ulong lhs, ulong rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float Div(this ref float lhs, float rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double Div(this ref double lhs, float rhs)
        {
            lhs /= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<byte> Div(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.div(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> Div(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.div(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> Div(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.div(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> Div(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.div(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> Div(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.div(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> Div(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.div(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> Div(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.div(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> Div(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.div(lhs, rhs, span<ulong>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<float> Div(this ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => math.div(lhs, rhs, span<float>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<double> Div(this ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => math.div(lhs, rhs, span<double>(length(lhs,rhs)));

    }
}