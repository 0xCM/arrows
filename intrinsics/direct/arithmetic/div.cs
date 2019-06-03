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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
        
    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<float> div(in Num128<float> lhs, in Num128<float> rhs)
            => DivideScalar(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Num128<double> div(in Num128<double> lhs, in Num128<double> rhs)
            => DivideScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe ref float div(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
        {
            var result = DivideScalar(lhs,rhs);
            StoreScalar(pfloat32(ref dst), result);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref double div(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
        {
            var result = DivideScalar(lhs,rhs);
            StoreScalar(pfloat64(ref dst), result);
            return ref dst;
        }

        public static Span128<float> div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec128.load(ref asRef(in lhs[i]));
                var y = Vec128.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return dst;
        }

        public static Span128<double> div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec128.load(ref asRef(in lhs[i]));
                var y = Vec128.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return dst;
        }

        public static Span256<float> div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec256.load(ref asRef(in lhs[i]));
                var y = Vec256.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return dst;
        }

        public static Span256<double> div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec256.load(ref asRef(in lhs[i]));
                var y = Vec256.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return dst;
        }    
    }
}