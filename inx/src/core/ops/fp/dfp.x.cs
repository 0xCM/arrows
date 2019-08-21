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
        
    using static zfunc;    

    public static class dfpx
    {
        public static Span256<double> sqrt(this Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<float> sqrt(this Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public static Vec128<float> Div(this Vec128<float> lhs, in Vec128<float> rhs)
            => dfp.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> Div(this Vec128<double> lhs, in Vec128<double> rhs)
            => dfp.div(in lhs, in rhs);


        [MethodImpl(Inline)]
        public static Vec256<float> Div(this Vec256<float> lhs, in Vec256<float> rhs)
            => dfp.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> Div(this Vec256<double> lhs, in Vec256<double> rhs)
            => dfp.div(in lhs, in rhs);

        public static Span128<float> Div(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.div(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span128<double> Div(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.div(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<float> Div(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.div(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<double> Div(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.div(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }     

        public static Span128<float> Mul(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span128<double> Mul(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<float> Mul(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        public static Span256<double> Mul(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dfp.mul(lhs.LoadVec256(block), lhs.LoadVec256(block)), ref dst.Block(block));
            return dst;            
        }

        [MethodImpl(Inline)]
        public static Span128<double> mul(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
            => lhs.Mul(rhs, dst);
        
        [MethodImpl(Inline)]
        public static Span256<float> mul(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
            => lhs.Mul(rhs, dst);

        [MethodImpl(Inline)]
        public static Span256<double> mul(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
            => lhs.Mul(rhs, dst);

    }
}