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
    using static System.Runtime.Intrinsics.X86.Fma;
    
    using static zcore;
    using static mfunc;

    partial class dinx
    {

        #region add

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<float> lhs, in Num128<float> rhs, out Num128<float> dst)
            => dst = AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Num128<double> lhs, in Num128<double> rhs, out Num128<double> dst)
            => dst = AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs, void* dst)
            => StoreScalar((float*)dst,Avx2.AddScalar(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<double> lhs, in Num128<double> rhs, void* dst)
            => StoreScalar((double*)dst, AddScalar(lhs, rhs));

        #endregion

        #region sub

        [MethodImpl(Inline)]
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => SubtractScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => SubtractScalar(lhs, rhs);

        #endregion

        #region mul

        [MethodImpl(Inline)]
        public static Num128<float> mul(in Num128<float> lhs, in Num128<float> rhs)
            => MultiplyScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> mul(in Num128<double> lhs, in Num128<double> rhs)
            => MultiplyScalar(lhs, rhs);


        #endregion

        #region div

        [MethodImpl(Inline)]
        public static Num128<float> div(in Num128<float> lhs, in Num128<float> rhs)
            => DivideScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> div(in Num128<double> lhs, in Num128<double> rhs)
            => DivideScalar(lhs, rhs);


        #endregion


        #region compare

        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => CompareEqualScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => CompareEqualScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool neq(Num128<float> lhs, Num128<float> rhs)
            => CompareNotEqualScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool neq(Num128<double> lhs, Num128<double> rhs)
            => CompareNotEqualScalar(lhs, rhs).IsNaN(0);


        [MethodImpl(Inline)]
        public static bool gt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareGreaterThanScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool gt(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.CompareGreaterThanScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool gteq(Num128<float> lhs, Num128<float> rhs)
            => CompareGreaterThanOrEqualScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool gteq(Num128<double> lhs, Num128<double> rhs)
            => CompareGreaterThanOrEqualScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool lt(Num128<float> lhs, Num128<float> rhs)
            => CompareLessThanScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool lt(Num128<double> lhs, Num128<double> rhs)
            => CompareLessThanScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool ngt(Num128<float> lhs, Num128<float> rhs)
            => CompareNotGreaterThanScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool ngt(Num128<double> lhs, Num128<double> rhs)
            => CompareNotGreaterThanScalar(lhs, rhs).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool lteq(Num128<float> lhs, Num128<float> rhs)
            => CompareLessThanOrEqualScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool lteq(Num128<double> lhs, Num128<double> rhs)
            => CompareLessThanOrEqualScalar(lhs, rhs).IsNaN(0);


        [MethodImpl(Inline)]
        public static bool nlt(Num128<float> lhs, Num128<float> rhs)
            => CompareNotLessThanScalar(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool nlt(Num128<double> lhs, Num128<double> rhs)
            => CompareNotLessThanScalar(lhs, rhs).IsNaN(0);


        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<float> lhs, in Num128<float> rhs, FloatCompareKind mode)
            => CompareScalar(lhs,rhs,(FloatComparisonMode)mode).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<double> lhs,in Num128<double> rhs, FloatCompareKind mode)
            => CompareScalar(lhs,rhs,(FloatComparisonMode)mode).IsNaN(0);

        #endregion

        #region aggregate

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

        #endregion

        #region composite

        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<float> mulAdd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
            => MultiplyAddScalar(x,y,z);
        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Num128<double> mulAdd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
            => MultiplyAddScalar(x,y,z);

        #endregion

        #region special
        
        [MethodImpl(Inline)]
        public static Num128<float> recip(Num128<float> src)
            => ReciprocalScalar(src);

 
        [MethodImpl(Inline)]
        public static Num128<float> recipsqrt(Num128<float> src)
            => ReciprocalSqrtScalar(src);


        [MethodImpl(Inline)]
        public static Num128<float> sqrt(Num128<float> src)
            => Avx2.SqrtScalar(src);

        [MethodImpl(Inline)]
        public static Num128<double> sqrt(Num128<double> src)
            => SqrtScalar(src);


        [MethodImpl(Inline)]
        public static Num128<float> ceiling(Num128<float> src)
            => CeilingScalar(src);
        
        [MethodImpl(Inline)]
        public static Num128<double> ceiling(Num128<double> src)
            => CeilingScalar(src);

        [MethodImpl(Inline)]
        public static Num128<float> floor(Num128<float> src)
            => FloorScalar(src);
        
        [MethodImpl(Inline)]
        public static Num128<double> floor(Num128<double> src)
            => FloorScalar(src);

        #endregion

        #region store

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<float> src, void* dst)
            => StoreScalar((float*)dst,src);            

        [MethodImpl(Inline)]
        public static unsafe void store(in Num128<double> src, void* dst)
            => StoreScalar((double*)dst,src);            

        
        [MethodImpl(Inline)]
        public static unsafe ref float store(Num128<float> src, ref float dst)
        {
            fixed (float* pDst = &dst)
            {                
                StoreScalar(pDst, src);
                return ref dst;
            }                
        }

        [MethodImpl(Inline)]
        public static unsafe ref double store(Num128<double> src, ref double dst)
        {
            fixed (double* pDst = &dst)
            {                
                StoreScalar(pDst, src);
                return ref dst;
            }                
        }


        #endregion
    }

}