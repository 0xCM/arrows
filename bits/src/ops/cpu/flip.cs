//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;    

    partial class Bits
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> flip(in Vec128<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<byte> flip(in Vec128<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<short> flip(in Vec128<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<ushort> flip(in Vec128<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<int> flip(in Vec128<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<uint> flip(in Vec128<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<long> flip(in Vec128<long> src)
            => Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec128<ulong> flip(in Vec128<ulong> src)
            => Vec128.FromParts(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> flip(in Vec256<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<byte> flip(in Vec256<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<short> flip(in Vec256<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ushort> flip(in Vec256<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<int> flip(in Vec256<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<uint> flip(in Vec256<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<long> flip(in Vec256<long> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ulong> flip(in Vec256<ulong> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Span<sbyte> flip(Span<sbyte> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<byte> flip(Span<byte> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<short> flip(Span<short> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<ushort> flip(Span<ushort> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<int> flip(Span<int> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<uint> flip(Span<uint> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<long> flip(Span<long> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<ulong> flip(Span<ulong> src)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(ref src[i]);
            return src;
        }

        [MethodImpl(Inline)]
        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<byte> flip(ReadOnlySpan<byte> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<short> flip(ReadOnlySpan<short> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<ushort> flip(ReadOnlySpan<ushort> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<int> flip(ReadOnlySpan<int> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<uint> flip(ReadOnlySpan<uint> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<long> flip(ReadOnlySpan<long> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<ulong> flip(ReadOnlySpan<ulong> src)
            => Bits.flip(src.Replicate());            

        [MethodImpl(Inline)]
        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            for(var i=0; i< src.Length; i++)
                math.flip(in src[i], ref dst[i]);
            return dst;
        }

    }
}