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

        public static Span<uint> Div(this Span<uint> io, uint rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }

        [MethodImpl(Inline)]
        public static Span<uint> Div(this ReadOnlySpan<uint> src, uint rhs)
            => src.Replicate().Div(rhs);

        public static Span<float> Div(this Span<float> io, float rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }

        [MethodImpl(Inline)]
        public static Span<float> Div(this ReadOnlySpan<float> src, float rhs)
            => src.Replicate().Div(rhs);

        public static Span<double> Div(this Span<double> io, double rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }

        [MethodImpl(Inline)]
        public static Span<double> Div(this ReadOnlySpan<double> io, double rhs)
            => io.Replicate().Div(rhs);

        [MethodImpl(Inline)]
        public static Span256<float> Div(this Span256<float> src, float rhs)
        {
            src.Unblocked.Div(rhs);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span256<double> Div(this Span256<double> src, double rhs)
        {
            src.Unblocked.Div(rhs);
            return src;
        }
    }
}