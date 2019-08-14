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
            => Vec128.define(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec128<ulong> flip(in Vec128<ulong> src)
            => Vec128.define(~src[0], ~src[1]);

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
        public static void flip(in Vec128<sbyte> src, ref sbyte dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<byte> src, ref byte dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<short> src, ref short dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<ushort> src, ref ushort dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<int> src, ref int dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<uint> src, ref uint dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<long> src, ref long dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<ulong> src, ref ulong dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<sbyte> src, ref sbyte dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<byte> src, ref byte dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<short> src, ref short dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<ushort> src, ref ushort dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<int> src, ref int dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<uint> src, ref uint dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<long> src, ref long dst)
            => vstore(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<ulong> src, ref ulong dst)
            => vstore(flip(in src), ref dst);

        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<byte> flip(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;
        }

        public static Span<short> flip(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<ushort> flip(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<int> flip(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<uint> flip(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<long> flip(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static Span<ulong> flip(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.flip(src[i]);
            return dst;                
        }

        public static ref Span<sbyte> flip(ref Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<byte> flip(ref Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<short> flip(ref Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<ushort> flip(ref Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<int> flip(ref Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<uint> flip(ref Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<long> flip(ref Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        public static ref Span<ulong> flip(ref Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.flip(ref io[i]);
            return ref io;
        }

        [MethodImpl(Inline)]
        public static Span<sbyte> flip(ReadOnlySpan<sbyte> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<byte> flip(ReadOnlySpan<byte> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<short> flip(ReadOnlySpan<short> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<ushort> flip(ReadOnlySpan<ushort> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<int> flip(ReadOnlySpan<int> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<uint> flip(ReadOnlySpan<uint> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<long> flip(ReadOnlySpan<long> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

        [MethodImpl(Inline)]
        public static Span<ulong> flip(ReadOnlySpan<ulong> src)
        {
            var dst = src.Replicate();
            return Bits.flip(ref dst);            
        }

    }
}