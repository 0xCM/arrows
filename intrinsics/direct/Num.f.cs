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
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;    

    public static class dinxs
    {
        [MethodImpl(Inline)]
        public static ref Num128<float> add(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = AddScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static unsafe ref float add(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
        {
            var result = AddScalar(lhs,rhs);
            StoreScalar(As.pfloat32(ref dst), result);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref Num128<double> add(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = AddScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static unsafe ref double add(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
        {
            var result = AddScalar(lhs,rhs);
            StoreScalar(As.pfloat64(ref dst), result);
            return ref dst;

        }

        [MethodImpl(Inline)]
        public static ref Num128<float> sub(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = SubtractScalar(lhs, rhs);
            return ref lhs;
        }
            
        [MethodImpl(Inline)]
        public static ref Num128<double> sub(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = SubtractScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> mul(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = MultiplyScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<double> mul(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = MultiplyScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> div(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = DivideScalar(lhs, rhs);
            return ref lhs;
        }
            
        [MethodImpl(Inline)]
        public static ref Num128<double> div(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = DivideScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> max(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = MaxScalar(lhs, rhs);
            return ref lhs;
        }
            
        [MethodImpl(Inline)]
        public static ref Num128<double> max(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = MaxScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> min(ref Num128<float> lhs, in Num128<float> rhs)
        {
            lhs = MinScalar(lhs, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Num128<double> min(ref Num128<double> lhs, in Num128<double> rhs)
        {
            lhs = MinScalar(lhs, rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Num128<float> sqrt(ref Num128<float> src)
        {
            src = SqrtScalar(src);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Num128<double> sqrt(ref Num128<double> src)
        {
            src = SqrtScalar(src);
            return ref src;
        }

        // dst = x*y + z
        [MethodImpl(Inline)]
        public static ref Num128<float> mulAdd(ref Num128<float> x, in Num128<float> y, in Num128<float> z)
        {
            x = MultiplyAddScalar(x,y,z);
            return ref x;
        }
            
        
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static ref Num128<double> mulAdd(ref Num128<double> x, in Num128<double> y, in Num128<double> z)
        {
            x = MultiplyAddScalar(x,y,z);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref Num128<float> recip(ref Num128<float> src)
        {
            src = ReciprocalScalar(src);
            return ref src;
        }

 
        [MethodImpl(Inline)]
        public static ref Num128<float> recipsqrt(ref Num128<float> src)
        {
            src = ReciprocalSqrtScalar(src);
            return ref src;
        }



        [MethodImpl(Inline)]
        public static ref Num128<float> ceiling(ref Num128<float> src)
        {
            src = CeilingScalar(src);
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref Num128<double> ceiling(ref Num128<double> src)
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

        [MethodImpl(Inline)]
        public static bool lt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);                

        [MethodImpl(Inline)]
        public static bool lt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool lteq(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.CompareScalarOrderedLessThanOrEqual(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedLessThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool gt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool gteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => CompareScalarOrderedEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => CompareScalarOrderedEqual(lhs, rhs);

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
        public static bool cmpf(in Num128<float> lhs, in Num128<float> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs,mode).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<double> lhs, in Num128<double> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs, mode).IsNaN(0);


        [MethodImpl(Inline)]
        public static unsafe ref Num128<float> load(float src, out Num128<float> dst)
        {
             dst = LoadScalarVector128(As.pfloat32(ref src));
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Num128<double> load(double src, out Num128<double> dst)
        {
             dst = LoadScalarVector128(As.pfloat64(ref src));
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref float store(in Num128<float> src, ref float dst)
        {
             StoreScalar(As.pfloat32(ref dst), src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref double store(Num128<double> src, ref double dst)
        {
             StoreScalar(As.pfloat64(ref dst), src);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<sbyte> broadcast(in Num128<sbyte> src, out Vec128<sbyte> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<short> broadcast(in Num128<short> src, out Vec128<short> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ushort> broadcast(in Num128<ushort> src, out Vec128<ushort> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<int> broadcast(in Num128<int> src, out Vec128<int> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<uint> broadcast(in Num128<uint> src, out Vec128<uint> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<long> broadcast(in Num128<long> src, out Vec128<long> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ulong> broadcast(in Num128<ulong> src, out Vec128<ulong> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<float> broadcast(in Num128<float> src, out Vec128<float> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<double> broadcast(in Num128<double> src, out Vec128<double> dst)
        {
            dst = BroadcastScalarToVector128(src);
            return ref dst;
        }

   }

}