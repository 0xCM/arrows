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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static long dot(Vec256<int> lhs, Vec256<int> rhs)
        {
            var product = mul(lhs,rhs);
            var v1 = lo(product);
            var v2 = hi(product);
            var sum = add(v1,v2);
            var span = sum.ToSpan128();
            return span[0] + span[1];
        }


        // [MethodImpl(Inline)]
        // public static ulong dot(Vec256<uint> lhs, Vec256<uint> rhs)
        // {
        //     var product = mul(lhs,rhs);
        //     var v1 = lo(product);
        //     var v2 = hi(product);
        //     var sum = add(v1,v2);
        //     var span = sum.ToSpan128();
        //     return span[0] + span[1];
        // }

        // [MethodImpl(Inline)]
        // public static ulong dot(Vec256<ulong> lhs, Vec256<ulong> rhs)
        // {
        //     var product = mul(lhs,rhs);
        //     var v1 = lo(product);
        //     var v2 = hi(product);
        //     var sum = add(v1,v2);
        //     var span = sum.ToSpan128();
        //     return span[0] + span[1];
        // }

        [MethodImpl(Inline)]
        public static Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
            => DotProduct(lhs, rhs,0xFF);
        
        [MethodImpl(Inline)]
        public static Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
            => DotProduct(lhs, rhs,0xFF);

        [MethodImpl(Inline)]
        public static Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs)
            => DotProduct(lhs, rhs,0xff);

        /// <intrinsic>__m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static void dot(Vec128<float> lhs, Vec128<float> rhs, ref float dst)
            => vstore(DotProduct(lhs, rhs,0), ref dst);
        
        [MethodImpl(Inline)]
        public static void dot(Vec128<double> lhs, Vec128<double> rhs, ref double dst)
            => vstore(DotProduct(lhs, rhs, 0), ref dst);

        [MethodImpl(Inline)]
        public static void dot(Vec256<float> lhs, Vec256<float> rhs, ref float dst)
            => vstore(DotProduct(lhs, rhs,0), ref dst);


    }

}