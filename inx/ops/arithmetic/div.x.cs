//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    using static zfunc;
    using static dinx;

    partial class dinxx
    {
        [MethodImpl(Inline)]
        public static Vec128<float> Div(this Vec128<float> lhs, in Vec128<float> rhs)
            => dinx.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> Div(this Vec128<double> lhs, in Vec128<double> rhs)
            => dinx.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void Div(this Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => dinx.div(in lhs, in rhs, ref dst);        

        [MethodImpl(Inline)]
        public static void Div(this Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => dinx.div(in lhs, in rhs, ref dst);        

        [MethodImpl(Inline)]
        public static Vec256<float> Div(this Vec256<float> lhs, in Vec256<float> rhs)
            => dinx.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> Div(this Vec256<double> lhs, in Vec256<double> rhs)
            => dinx.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void Div(this Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => dinx.div(in lhs, in rhs, ref dst);        

        [MethodImpl(Inline)]
        public static void Div(this Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => dinx.div(in lhs, in rhs, ref dst);        

        public static Span128<float> Div(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Divide(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<double> Div(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Divide(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<float> Div(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Divide(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<double> Div(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                dinx.store(Divide(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }    

    }

}