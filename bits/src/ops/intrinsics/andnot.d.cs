//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
 
    using static zfunc;
    
    public static partial class Bits
    {                
        [MethodImpl(Inline)]
        public static byte andnot(in byte lhs, in byte rhs) 
            => (byte)Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ushort andnot(in ushort lhs, in ushort rhs)
            => (ushort)Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint andnot(in uint lhs, in uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ulong andnot(in ulong lhs, in ulong rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> andnot(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> andnot(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> andnot(in Vec128<short> lhs, in Vec128<short> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> andnot(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> andnot(in Vec128<int> lhs, in Vec128<int> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> andnot(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> andnot(in Vec128<long> lhs, in Vec128<long> rhs)
            => AndNot(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<ulong> andnot(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => AndNot(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<float> andnot(in Vec128<float> lhs, in Vec128<float> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> andnot(in Vec128<double> lhs, in Vec128<double> rhs)
            => AndNot(lhs, rhs);        
    
        [MethodImpl(Inline)]
        public static Vec256<sbyte> andnot(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> andnot(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> andnot(in Vec256<short> lhs, in Vec256<short> rhs)
            => AndNot(lhs, rhs);

        /// <intrisic>__m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> andnot(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> andnot(in Vec256<int> lhs, in Vec256<int> rhs)
            => AndNot(lhs, rhs);

        /// <intrinsic> __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> andnot(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => AndNot(lhs, rhs);

        /// <intrinsic> __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> andnot(in Vec256<long> lhs, in Vec256<long> rhs)
            => AndNot(lhs, rhs);

        /// <intrinsic> __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> andnot(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> andnot(in Vec256<float> lhs, in Vec256<float> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> andnot(in Vec256<double> lhs, in Vec256<double> rhs)
            => AndNot(lhs, rhs);


    }
}