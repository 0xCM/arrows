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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static Span256;
    using static Span128;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static unsafe void mul(uint lhs, uint rhs, out uint lo, out uint hi)
        {
            fixed(uint* pLo = &lo)
                hi = Bmi2.MultiplyNoFlags(lhs, rhs, pLo);
        }

        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<ulong> x, in Vec256<ulong> y)    
        {
            ref var m = ref Vec1024.Merge(in x, in y, out Vec1024<uint>  _);
            ref var xh = ref m.At(3);
            ref var xl = ref m.At(2);
            ref var yh = ref m.At(1);
            ref var yl = ref m.At(0);

            var xh_yl = dinx.mul(xh, yl);
            var hl = dinx.shiftl(xh_yl, 32);

            var xh_mh = dinx.mul(xh, yh);
            var lh = dinx.shiftl(xh_mh, 32);

            var xl_yl = dinx.mul(xl, yl);

            var hl_lh = dinx.add(hl, lh);
            var z = dinx.add(xl_yl, hl_lh);
            return z;
        }

        /// <summary>
        /// Effects multiplication of the form (lhs:ulong, rhs:ulong) -> result:ulong where
        /// there result is obtained from the hi 64 bits of the 128-bit product
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong umulh(ulong lhs, ulong rhs)
            => umul128(lhs, rhs, out UInt128 _).hi;

        /// <summary>
        /// Effects multiplication of the form (lhs:ulong, rhs:ulong) -> result:uint128
        /// </summary>
        /// <param name="lhs">The left 64-bit operand</param>
        /// <param name="rhs">The right 64-bit operand</param>
        /// <param name="dst">The 128 bit result</param>
        [MethodImpl(Inline)]
        public static unsafe ref UInt128 umul128(ulong lhs, ulong rhs, out UInt128 dst)
        {
            dst = default;
            fixed(ulong* pLo = &dst.lo)
                dst.hi = Bmi2.X64.MultiplyNoFlags(lhs, rhs, pLo);
            return ref dst;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="control"></param>
        /// <intrinsic>__m128i _mm_clmulepi64_si128 (__m128i a, __m128i b, const int imm8) PCLMULQDQ xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static void mul(in Vec128<int> lhs, in Vec128<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<int> lhs, in Vec256<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
            =>  MultiplyScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
            =>  MultiplyScalar(lhs, rhs);

    }
}