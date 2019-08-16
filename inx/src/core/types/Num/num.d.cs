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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    using static System.Runtime.Intrinsics.X86.Fma;    
    
    using static zfunc;

    public partial class dinx
    {

       [MethodImpl(Inline)]
        public static Num128<float> max(in Num128<float> lhs, in Num128<float> rhs)
            => MaxScalar(lhs, rhs);            
        
        [MethodImpl(Inline)]
        public static Num128<double> max(in Num128<double> lhs, in Num128<double> rhs)
            => MaxScalar(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Num128<float> min(in Num128<float> lhs, in Num128<float> rhs)
            => MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> min(in Num128<double> lhs, in Num128<double> rhs)
            => MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
            => vstore(AddScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
            => vstore(AddScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void sub(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
            => vstore(SubtractScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
            => vstore(SubtractScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => SubtractScalar(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => SubtractScalar(lhs, rhs);
     
        [MethodImpl(Inline)]
        public static Num128<float> div(in Num128<float> lhs, in Num128<float> rhs)
            => DivideScalar(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Num128<double> div(in Num128<double> lhs, in Num128<double> rhs)
            => DivideScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void div(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
            => vstore(DivideScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void div(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
            => vstore(DivideScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<float> lhs, in Num128<float> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs,mode).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<double> lhs, in Num128<double> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs, mode).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool lt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);                

        [MethodImpl(Inline)]
        public static bool lt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> gteq(Vec128<float> lhs, Vec128<float> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gteq(Vec128<double> lhs, Vec128<double> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool gteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool gt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool lteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool neq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedNotEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool neq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedNotEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool ngt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarNotGreaterThan(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool ngt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarNotGreaterThan(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool nlt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarNotLessThan(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool nlt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarNotLessThan(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static ref Num128<float> ceil(ref Num128<float> src)
        {
            src = CeilingScalar(src);
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref Num128<double> ceil(ref Num128<double> src)
        {
            src = CeilingScalar(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> floor(ref Num128<float> src)
        {
            src = FloorScalar(src);
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref Num128<double> floor(ref Num128<double> src)
        {
            src = FloorScalar(src);
            return ref src;
        }

        /// <intrinsic>__m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32</intrinsic>
        [MethodImpl(Inline)]
        public static Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
            =>  MultiplyScalar(lhs, rhs);

        /// <intrinsic>__m128d _mm_mul_sd (__m128d a, __m128d b) MULSD xmm, xmm/m64</intrinsic>
        [MethodImpl(Inline)]
        public static Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
            =>  MultiplyScalar(lhs, rhs);

         // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<float> mulAdd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
            => MultiplyAddScalar(x,y,z);
                    
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<double> mulAdd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
            => MultiplyAddScalar(x,y,z);


        [MethodImpl(Inline)]
        public static Vec128<float> recipsqrt(Vec128<float> src)
            => Avx2.ReciprocalSqrt(src);
    
     
        [MethodImpl(Inline)]
        public static ref Num128<float> recipsqrt(ref Num128<float> src)
        {
            src = ReciprocalSqrtScalar(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Vec128<float> recip(Vec128<float> src)
            => Reciprocal(src);


        [MethodImpl(Inline)]
        public static Vec256<float> recip(Vec256<float> src)
            => Reciprocal(src);


        [MethodImpl(Inline)]
        public static ref Num128<float> recip(ref Num128<float> src)
        {
            src = ReciprocalScalar(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static Num128<float> sqrt(in Num128<float> src)
            => SqrtScalar(src);

        [MethodImpl(Inline)]
        public static Num128<double> sqrt(in Num128<double> src)
            => SqrtScalar(src);

    }
}