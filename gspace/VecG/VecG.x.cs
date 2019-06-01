//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;


    public static class VecGX
    {
        [MethodImpl(Inline)]
        public static VecG<sbyte> ToVecG(this ReadOnlySpan<sbyte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<byte> ToVecG(this ReadOnlySpan<byte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<short> ToVecG(this ReadOnlySpan<short> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ushort> ToVecG(this ReadOnlySpan<ushort> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<int> ToVecG(this ReadOnlySpan<int> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<uint> ToVecG(this ReadOnlySpan<uint> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<long> ToVecG(this ReadOnlySpan<long> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ulong> ToVecG(this ReadOnlySpan<ulong> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<float> ToVecG(this ReadOnlySpan<float> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<double> ToVecG(this ReadOnlySpan<double> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<sbyte> ToVecG(this Span<sbyte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<byte> ToVecG(this Span<byte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<short> ToVecG(this Span<short> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ushort> ToVecG(this Span<ushort> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<int> ToVecG(this Span<int> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<uint> ToVecG(this Span<uint> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<long> ToVecG(this Span<long> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ulong> ToVecG(this Span<ulong> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<float> ToVecG(this Span<float> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<double> ToVecG(this Span<double> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<sbyte> ToVecG(this Span256<sbyte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<byte> ToVecG(this Span256<byte> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<short> ToVecG(this Span256<short> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ushort> ToVecG(this Span256<ushort> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<int> ToVecG(this Span256<int> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<uint> ToVecG(this Span256<uint> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<long> ToVecG(this Span256<long> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<ulong> ToVecG(this Span256<ulong> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<float> ToVecG(this Span256<float> src)
            => VecG.load(src);

        [MethodImpl(Inline)]
        public static VecG<double> ToVecG(this Span256<double> src)
            => VecG.load(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this VecG<T> src)
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this VecG<T> src)
            where T : struct
            => src;

    }

}