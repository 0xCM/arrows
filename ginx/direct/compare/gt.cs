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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {
        public static Span<Bit> gt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
        {
            var len = Vec128<sbyte>.Length;
            Span<sbyte> src = stackalloc sbyte[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> gt(in Vec128<short> lhs, in Vec128<short> rhs)
        {
            var len = Vec128<short>.Length;
            Span<short> src = stackalloc short[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> gt(in Vec128<int> lhs, in Vec128<int> rhs)
        {
            var len = Vec128<int>.Length;
            Span<int> src = stackalloc int[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> gt(in Vec128<float> lhs, in Vec128<float> rhs)
        {
            var len = Vec128<float>.Length;
            Span<float> src = stackalloc float[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i] == 1;
            return dst;
        }
        
        public static Span<Bit> gt(in Vec128<double> lhs, in Vec128<double> rhs)
        {
            var len = Vec128<double>.Length;
            Span<double> src = stackalloc double[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i] == 1;
            return dst;
        }
 
        public static Span<Bit> gt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
         {
            var len = Vec256<sbyte>.Length;
            Span<sbyte> src = stackalloc sbyte[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> gt(in Vec256<short> lhs, in Vec256<short> rhs)
         {
            var len = Vec256<short>.Length;
            Span<short> src = stackalloc short[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }

        public static Span<Bit> gt(in Vec256<int> lhs, in Vec256<int> rhs)
        {
            var len = Vec256<int>.Length;
            Span<int> src = stackalloc int[len];
            store(CompareGreaterThan(lhs, rhs), ref src[0]);
            var dst = span<Bit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = src[i];
            return dst;
        }
    }
}