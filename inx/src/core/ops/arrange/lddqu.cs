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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
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


        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> lddqu128(in byte src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> lddqu128(in sbyte src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> lddqu128(in short src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> lddqu128(in ushort src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> lddqu128(in int src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> lddqu128(in uint src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> lddqu128(in long src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> lddqu128(in ulong src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> lddqu256(in byte src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> lddqu256(in sbyte src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<short> lddqu256(in short src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> lddqu256(in ushort src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> lddqu256(in int src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> lddqu256(in uint src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> lddqu256(in long src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> lddqu256(in ulong src)
            => LoadDquVector256(constptr(in src));


        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> load128(in byte src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> load128(in sbyte src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> load128(in short src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> load128(in ushort src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> load128(in int src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> load128(in uint src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> load128(in long src)
            => LoadAlignedVector128(constptr(in src));
 
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> load128(in ulong src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> load256(in byte src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> load256(in sbyte src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<short> load256(in short src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> load256(in ushort src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> load256(in int src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> load256(in uint src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> load256(in long src)
            => LoadAlignedVector256(constptr(in src));
 
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> load256(in ulong src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static void load256(in byte ymem0, out Vector256<byte> ymm0)
        {
            ymm0 = dinx.load256(ymem0);
        }


        [MethodImpl(Inline)]
        public static void load256(in int ymem0, out Vector256<int> ymm0)
        {
            ymm0 = dinx.load256(ymem0);
        }

        [MethodImpl(Inline)]
        public static void load256(in byte ymem0, in byte ymem1, out Vector256<byte> ymm0, out Vector256<byte> ymm1)
        {
            load256(ymem0, out ymm0);
            load256(ymem1, out ymm1);
        }

        [MethodImpl(Inline)]
        public static void load256(in byte ymem0, in byte ymem1, in byte ymem2, in byte ymem3, 
            out Vector256<byte> ymm0, out Vector256<byte> ymm1, out Vector256<byte> ymm2, out Vector256<byte> ymm3)
        {
            load256(in ymem0, in ymem1, out ymm0, out ymm1);
            load256(in ymem2, in ymem3, out ymm2, out ymm3);
        }

        [MethodImpl(Inline)]
        public static void load256(in int ymem0, in int ymem1, out Vector256<int> ymm0, out Vector256<int> ymm1)
        {
            ymm0 = dinx.load256(ymem0);
            ymm1 = dinx.load256(ymem1);
        }

    }
}