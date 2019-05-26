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
    using static Spans;
    using static As;


    partial class dinx
    {


        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Divide(lhs, rhs);


        static Vec128<T> ToVec128<T>(this Vector128<T> src)
            where T : struct
            => src;

        public static unsafe ref Span128<float> div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec128.load(ref asRef(in lhs[i]));
                var y = Vec128.load(ref asRef(in rhs[i]));
                store(Divide(x,y).ToVec128(), ref dst[i]);
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<double> div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec128.load(ref asRef(in lhs[i]));
                var y = Vec128.load(ref asRef(in rhs[i]));
                store(Divide(x,y).ToVec128(), ref dst[i]);
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<float> div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec256.load(ref asRef(in lhs[i]));
                var y = Vec256.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return ref dst;

        }

        public static unsafe ref Span256<double> div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = Vec256.load(ref asRef(in lhs[i]));
                var y = Vec256.load(ref asRef(in rhs[i]));
                store(Divide(x,y), ref dst[i]);
            }
            
            return ref dst;
        }    
    }
}