//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
     using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> add(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> add(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,float> add<N>(Vector<N,float> lhs, Vector<N,float> rhs, ref Vector<N,float> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vsAdd(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,double> add<N>(Vector<N,double> lhs, Vector<N,double> rhs, ref Vector<N,double> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vdAdd(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> sub(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> sub(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,float> sub<N>(Vector<N,float> lhs, Vector<N,float> rhs, ref Vector<N,float> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vsSub(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,double> sub<N>(Vector<N,double> lhs, Vector<N,double> rhs, ref Vector<N,double> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vdSub(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> mul(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> mul(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,float> mul<N>(Vector<N,float> lhs, Vector<N,float> rhs, ref Vector<N,float> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vsMul(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<N,double> mul<N>(Vector<N,double> lhs, Vector<N,double> rhs, ref Vector<N,double> dst)
            where N : ITypeNat, new()
        {
            VmlImport.vdMul(nati<N>(), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> div(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> div(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> mod(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }
        
		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> mod(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,float> mod<M,N>(Matrix<M,N,float> A, Matrix<M,N,float> B, ref Matrix<M,N,float> X)
            where N : ITypeNat, new()
            where M : ITypeNat, new()

        {
            VmlImport.vsFmod(Matrix<M,N,float>.CellCount, ref head(A), ref head(B), ref head(X));
            return ref X;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,double> mod<M,N>(Matrix<M,N,double> lhs, Matrix<M,N,double> rhs, ref Matrix<M,N,double> dst)
            where N : ITypeNat, new()
            where M : ITypeNat, new()

        {
            VmlImport.vdFmod(Matrix<M,N,float>.CellCount, ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> truncRem(Vector<float> src, Vector<float> trunc, ref Vector<float> rem)
        {
            VmlImport.vsModf(length(src, trunc), ref head(src), ref head(trunc), ref head(rem));
            return ref rem;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> truncRem(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdModf(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }
        

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> rem(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> rem(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> frac(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsFrac(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> frac(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdFrac(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> square(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsSqr(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> square(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdSqr(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> sqrt(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsSqrt(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> sqrt(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdSqrt(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = |src[i]| for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> abs(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsAbs(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i = 0...n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> abs(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdAbs(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> min(Vector<float> a, Vector<float> b, ref Vector<float> dst)
        {
            VmlImport.vsFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> min(Vector<double> a, Vector<double> b, ref Vector<double> dst)
        {
            VmlImport.vdFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> max(Vector<float> a, Vector<float> b, ref Vector<float> dst)
        {
            VmlImport.vsFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> max(Vector<double> a, Vector<double> b, ref Vector<double> dst)
        {
            VmlImport.vdFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }


        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> maxAbs(Vector<float> a, Vector<float> b, ref Vector<float> dst)
        {
            VmlImport.vsMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> maxAbs(Vector<double> a, Vector<double> b, ref Vector<double> dst)
        {
            VmlImport.vdMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> minAbs(Vector<float> a, Vector<float> b, ref Vector<float> dst)
        {
            VmlImport.vsMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> minAbs(Vector<double> a, Vector<double> b, ref Vector<double> dst)
        {
            VmlImport.vdMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vector<float> copySign(Vector<float> a, Vector<float> b, ref Vector<float> dst)        
        {
            VmlImport.vsCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vector<double> copySign(Vector<double> a, Vector<double> b, ref Vector<double> dst)        
        {
            VmlImport.vdCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = src[i] + epsilon
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> next(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsNextAfter(dst.Length, ref head(src), ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = src[i] + epsilon
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> next(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdNextAfter(dst.Length, ref head(src), ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =round(src[i]) for i=0..n-1 where "round" maps the input to the nearest integral value
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> round(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =round(src[i]) for i=0..n-1 where "round" maps the input to the nearest integral value
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> round(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,float> round<M,N>(ref Matrix<M,N,float> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vsRound(Matrix<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,double> round<M,N>(ref Matrix<M,N,double> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {

            VmlImport.vdRound(Matrix<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> trunc(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> trunc(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,double> trunc<M,N>(ref Matrix<M,N,double> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vdTrunc(Matrix<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,float> trunc<M,N>(ref Matrix<M,N,float> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vsTrunc(Matrix<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> floor(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsFloor(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> floor(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdFloor(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> ceil(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsCeil(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> ceil(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdCeil(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> recip(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> recip(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> pow(Vector<float> lhs, Vector<float> rhs, ref Vector<float> dst)
        {
            VmlImport.vsPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> pow(Vector<double> lhs, Vector<double> rhs, ref Vector<double> dst)
        {
            VmlImport.vdPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> pow(Vector<float> src, float exp, ref Vector<float> dst)
        {
            VmlImport.vsPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> pow(Vector<double> src, double exp, ref Vector<double> dst)
        {
            VmlImport.vdPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> exp(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsExp(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> exp(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdExp(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
       
 		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> exp2(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsExp2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> exp2(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdExp2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> exp10(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsExp10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> exp10(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdExp10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> ln(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsLn(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> ln(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdLn(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> log2(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsLog2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> log2(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdLog2(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> log10(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsLog10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> log10(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdLog10(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> erf(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsErf(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> erf(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdErf(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

 		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> erfInv(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsErfInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> erfInv(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdErfInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> erfc(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsErfc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
 
		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> erfc(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdErfc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
 
		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> erfcInv(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsErfcInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> erfcInv(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdErfcInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> expInt(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsExpInt1(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> expInt(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdExpInt1(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> cdfNorm(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsCdfNorm(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> cdfNorm(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdCdfNorm(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> cdfNormInv(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsCdfNormInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> cdfNormInv(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdCdfNormInv(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes the gamma function: dst[i] = gamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> gamma(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsTGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes the gamma function: dst[i] = gamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> gamma(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdTGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> lgamma(Vector<float> src, ref Vector<float> dst)        
        {
            VmlImport.vsLGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }
            
		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> lgamma(Vector<double> src, ref Vector<double> dst)        
        {
            VmlImport.vdLGamma(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

        /// <summary>
        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<float> hypot(Vector<float> a, Vector<float> b, ref Vector<float> dst)
        {
            VmlImport.vsHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector<double> hypot(Vector<double> a, Vector<double> b, ref Vector<double> dst)
        {
            VmlImport.vdHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }
    }

}