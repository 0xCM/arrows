//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using Z0;
 
    using static zfunc;
    using static As;

    public static class Bytes
    {

        [MethodImpl(Inline)]
        public static T read<T>(byte[] src, in int offset = 0)
            where T : struct
                =>  Unsafe.ReadUnaligned<T>(ref src[offset]);

        [MethodImpl(Inline)]
        public static T read<T>(in Span<byte> src, in int offset = 0)
            where T : struct
                =>  Unsafe.ReadUnaligned<T>(ref src[offset]);

        [MethodImpl(Inline)]
        public static ref T read<T>(in Span<byte> src, in int offset, out T dst)
            where T : struct
        {
            dst = Unsafe.ReadUnaligned<T>(ref src[offset]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> write<T>(in T src, ref Span<byte> dst, in int offset)
            where T : struct
        {
            As.generic<T>(ref dst[offset]) = src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> write<T>(in T src, out Span<byte> dst)
            where T : struct
        {
            dst = span<byte>(Unsafe.SizeOf<T>());
            As.generic<T>(ref dst[0]) = src;
            return ref dst;
        }

        [MethodImpl(Inline)]   
        public static ref readonly ReadOnlySpan<byte> write<T>(in ReadOnlySpan<T> src, int offset, out ReadOnlySpan<byte> dst)
            where T : struct
        {
            dst = MemoryMarshal.AsBytes(src.Slice(offset));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> bytes<T>(in T src, out Span<byte> dst)
            where T : struct
        {
            dst = span<byte>(Unsafe.SizeOf<T>());            
            As.generic<T>(ref dst[0]) = src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
        {
            var dst = span<byte>(Unsafe.SizeOf<T>());            
            As.generic<T>(ref dst[0]) = src;
            return dst;
        }

        [MethodImpl(Optimize)]
        public static ulong pop(in Span<byte> src)
        {
            var count = U64Zero;
            var blocksize = Pow2.T03;
            math.quorem(src.Length, blocksize, out Quorem<int> qr);
            for(var i = 0; i < src.Length; i+=blocksize)
            {
                read(src, i, out ulong data);
                count += Popcnt.X64.PopCount(data);
            }
            return count;
        }
    }
}