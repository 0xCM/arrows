//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class MathX
    {
        [MethodImpl(Inline)]
        public static ref sbyte Flip(this ref sbyte src)
        {
            src = (sbyte)(~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte Flip(this ref byte src)
        {
            src = (byte)(~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short Flip(this ref short src)
        {
            src = (short)(~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort Flip(this ref ushort src)
        {
            src = (ushort)(~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int Flip(this ref int src)
        {
            src = (~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint Flip(this ref uint src)
        {
            src = (~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long Flip(this ref long src)
        {
            src = (~src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong Flip(this ref ulong src)
        {
            src = (~src);
            return ref src;
        }

        //~ opgroup     :: Flip: this | Span[T] -> Span[T]
        //~ opname      :: Flip
        //~ facets      :: public | static | nongeneric
        //~ T           :: sbyte | byte | short | ushort | int | uint | long | ulong

        [MethodImpl(Inline)]
        public static Span<sbyte> Flip(this Span<sbyte> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<byte> Flip(this Span<byte> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<short> Flip(this Span<short> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<ushort> Flip(this Span<ushort> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<int> Flip(this Span<int> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<uint> Flip(this Span<uint> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<long> Flip(this Span<long> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<ulong> Flip(this Span<ulong> src)
            => math.flip(ref src);

        [MethodImpl(Inline)]
        public static Span<sbyte> Flip(this ReadOnlySpan<sbyte> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<byte> Flip(this ReadOnlySpan<byte> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<short> Flip(this ReadOnlySpan<short> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<ushort> Flip(this ReadOnlySpan<ushort> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<int> Flip(this ReadOnlySpan<int> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<long> Flip(this ReadOnlySpan<long> src)
            => math.flip(src);

        [MethodImpl(Inline)]
        public static Span<ulong> Flip(this ReadOnlySpan<ulong> src)
            => math.flip(src);
    }
}