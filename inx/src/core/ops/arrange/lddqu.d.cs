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

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class dinx
    {

        ///<intrinsic>__m128i _mm_lddqu_si128 (__m128i const* mem_addr) LDDQU xmm, m128</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe ref Vec128<sbyte> lddqu(in sbyte src, out Vec128<sbyte> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<byte> lddqu(in byte src, out Vec128<byte> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<short> lddqu(in short src, out Vec128<short> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<ushort> lddqu(in ushort src, out Vec128<ushort> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<int> lddqu(in int src, out Vec128<int> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<uint> lddqu(in uint src, out Vec128<uint> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<long> lddqu(in long src, out Vec128<long> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec128<ulong> lddqu(in ulong src, out Vec128<ulong> dst)
        {
            dst = LoadDquVector128(constptr(in src));
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static unsafe ref Vec256<sbyte> lddqu(in sbyte src, out Vec256<sbyte> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<byte> lddqu(in byte src, out Vec256<byte> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<short> lddqu(in short src, out Vec256<short> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<ushort> lddqu(in ushort src, out Vec256<ushort> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<int> lddqu(in int src, out Vec256<int> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<uint> lddqu(in uint src, out Vec256<uint> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<long> lddqu(in long src, out Vec256<long> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vec256<ulong> lddqu(in ulong src, out Vec256<ulong> dst)
        {
            dst = LoadDquVector256(constptr(in src));
            return ref dst;
        }
    }
}