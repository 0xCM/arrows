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
        public static ref sbyte Abs(this ref sbyte src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref short Abs(this ref short src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref int Abs(this ref int src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref long Abs(this ref long src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref float Abs(this ref float src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref double Abs(this ref double src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static Span<sbyte> Abs(this Span<sbyte> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<short> Abs(this Span<short> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<int> Abs(this Span<int> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<long> Abs(this Span<long> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<float> Abs(this Span<float> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<double> Abs(this Span<double> io)
            => math.abs(io);

        [MethodImpl(Inline)]
        public static Span<sbyte> Abs(this ReadOnlySpan<sbyte> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static Span<short> Abs(this ReadOnlySpan<short> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static Span<int> Abs(this ReadOnlySpan<int> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static Span<long> Abs(this ReadOnlySpan<long> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static Span<float> Abs(this ReadOnlySpan<float> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static Span<double> Abs(this ReadOnlySpan<double> src)
            => math.abs(src);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> Abs(this ReadOnlySpan<short> src, Span<short> dst)
            => math.abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> Abs(this ReadOnlySpan<int> src, Span<int> dst)
            => math.abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> Abs(this ReadOnlySpan<long> src, Span<long> dst)
            => math.abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Abs(this ReadOnlySpan<float> src, Span<float> dst )
            => math.abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Abs(this ReadOnlySpan<double> src, Span<double> dst )
            => math.abs(src,dst);            
    }
}