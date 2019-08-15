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
    using System.Collections.Generic;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    
    using static zfunc;


    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> blend(in Vec128<short> lhs, in Vec128<short> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<ushort> blend(in Vec128<ushort> lhs, in Vec128<ushort> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<int> blend(in Vec128<int> lhs, in Vec128<int> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<uint> blend(in Vec128<uint> lhs, in Vec128<uint> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<float> blend(in Vec128<float> lhs, in Vec128<float> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<double> blend(in Vec128<double> lhs, in Vec128<double> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<short> blend(in Vec256<short> lhs, in Vec256<short> rhs, byte control)        
            => Blend(lhs,rhs,control);

        /// <intrinsic>__m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> blend(in Vec256<ushort> lhs, in Vec256<ushort> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<int> blend(in Vec256<int> lhs, in Vec256<int> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<uint> blend(in Vec256<uint> lhs, in Vec256<uint> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<float> blend(in Vec256<float> lhs, in Vec256<float> rhs, byte control)        
            => Blend(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<double> blend(in Vec256<double> lhs, in Vec256<double> rhs, byte control)        
            => Blend(lhs,rhs,control);


        /// <intrinsic> __m256i _mm256_blendv_epi8 (__m256i a, __m256i b, __m256i mask) VPBLENDVB ymm, ymm, ymm/m256, ymm
        [MethodImpl(Inline)]
        public static Vec256<byte> blend(in Vec256<byte> lhs, in Vec256<byte> rhs, in Vec256<byte> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> blend(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, in Vec256<sbyte> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<short> blend(in Vec256<short> lhs, in Vec256<short> rhs, in Vec256<short> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ushort> blend(in Vec256<ushort> lhs, in Vec256<ushort> rhs, in Vec256<ushort> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<int> blend(in Vec256<int> lhs, in Vec256<int> rhs, in Vec256<int> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<uint> blend(in Vec256<uint> lhs, in Vec256<uint> rhs, in Vec256<uint> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<long> blend(in Vec256<long> lhs, in Vec256<long> rhs, in Vec256<long> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<ulong> blend(in Vec256<ulong> lhs, in Vec256<ulong> rhs, in Vec256<ulong> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<float> blend(in Vec256<float> lhs, in Vec256<float> rhs, in Vec256<float> control)        
            => BlendVariable(lhs,rhs,control);

        [MethodImpl(Inline)]
        public static Vec256<double> blend(in Vec256<double> lhs, in Vec256<double> rhs, in Vec256<double> control)        
            => BlendVariable(lhs,rhs,control);


    }


}