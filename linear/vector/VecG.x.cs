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
        public static Vector<sbyte> ToVecG(this ReadOnlySpan<sbyte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<byte> ToVecG(this ReadOnlySpan<byte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<short> ToVecG(this ReadOnlySpan<short> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ushort> ToVecG(this ReadOnlySpan<ushort> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<int> ToVecG(this ReadOnlySpan<int> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<uint> ToVecG(this ReadOnlySpan<uint> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<long> ToVecG(this ReadOnlySpan<long> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ulong> ToVecG(this ReadOnlySpan<ulong> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<float> ToVecG(this ReadOnlySpan<float> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<double> ToVecG(this ReadOnlySpan<double> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<sbyte> ToVecG(this Span<sbyte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<byte> ToVecG(this Span<byte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<short> ToVecG(this Span<short> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ushort> ToVecG(this Span<ushort> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<int> ToVecG(this Span<int> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<uint> ToVecG(this Span<uint> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<long> ToVecG(this Span<long> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ulong> ToVecG(this Span<ulong> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<float> ToVecG(this Span<float> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<double> ToVecG(this Span<double> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<sbyte> ToVecG(this Span256<sbyte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<byte> ToVecG(this Span256<byte> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<short> ToVecG(this Span256<short> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ushort> ToVecG(this Span256<ushort> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<int> ToVecG(this Span256<int> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<uint> ToVecG(this Span256<uint> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<long> ToVecG(this Span256<long> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<ulong> ToVecG(this Span256<ulong> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<float> ToVecG(this Span256<float> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static Vector<double> ToVecG(this Span256<double> src)
            => Vector.Load(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vector<T> src)
            where T : struct
                => src;

        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vector<T> src)
            where T : struct
            => src;

    }

}