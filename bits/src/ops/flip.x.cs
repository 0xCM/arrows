//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static dinx;

    partial class BitsX
    {
        [MethodImpl(Inline)]
        public static Vec128<T> Flip<T>(this Vec128<T> src)
            where T : struct
                => gbits.flip(in src);

        [MethodImpl(Inline)]
        public static Vec256<T> Flip<T>(this Vec256<T> src)
            where T : struct
                => gbits.flip(in src);

        [MethodImpl(Inline)]
        public static void Flip<T>(this Vec128<T> lhs, ref T dst)
            where T : struct
                => gbits.flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip<T>(this Vec256<T> lhs, ref T dst)
            where T : struct
                => gbits.flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static ref Vector<T> Flip<T>(ref Vector<T> src)
            where T : struct
        {
            gbits.flip(src.Unblocked, src.Unblocked);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Span<sbyte> Flip(this Span<sbyte> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> Flip(this Span<byte> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<short> Flip(this Span<short> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<ushort> Flip(this Span<ushort> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<int> Flip(this Span<int> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<uint> Flip(this Span<uint> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<long> Flip(this Span<long> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<ulong> Flip(this Span<ulong> src)
            => Bits.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<sbyte> Flip(this ReadOnlySpan<sbyte> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<byte> Flip(this ReadOnlySpan<byte> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<short> Flip(this ReadOnlySpan<short> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<ushort> Flip(this ReadOnlySpan<ushort> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<int> Flip(this ReadOnlySpan<int> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<long> Flip(this ReadOnlySpan<long> src)
            => Bits.flip(src);

        [MethodImpl(Inline)]
        public static Span<ulong> Flip(this ReadOnlySpan<ulong> src)
            => Bits.flip(src); 
    }
}