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
        public static ref BlockVector<float> add(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> add(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<N,float> add<N>(BlockVector<N,float> lhs, BlockVector<N,float> rhs, ref BlockVector<N,float> dst)
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
        public static ref BlockVector<N,double> add<N>(BlockVector<N,double> lhs, BlockVector<N,double> rhs, ref BlockVector<N,double> dst)
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
        public static ref BlockVector<float> sub(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> sub(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<N,float> sub<N>(BlockVector<N,float> lhs, BlockVector<N,float> rhs, ref BlockVector<N,float> dst)
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
        public static ref BlockVector<N,double> sub<N>(BlockVector<N,double> lhs, BlockVector<N,double> rhs, ref BlockVector<N,double> dst)
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
        public static ref BlockVector<float> mul(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> mul(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<N,float> mul<N>(BlockVector<N,float> lhs, BlockVector<N,float> rhs, ref BlockVector<N,float> dst)
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
        public static ref BlockVector<N,double> mul<N>(BlockVector<N,double> lhs, BlockVector<N,double> rhs, ref BlockVector<N,double> dst)
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
        public static ref BlockVector<float> div(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> div(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> mod(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> mod(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockMatrix<M,N,float> mod<M,N>(BlockMatrix<M,N,float> A, BlockMatrix<M,N,float> B, ref BlockMatrix<M,N,float> X)
            where N : ITypeNat, new()
            where M : ITypeNat, new()

        {
            VmlImport.vsFmod(BlockMatrix<M,N,float>.CellCount, ref head(A), ref head(B), ref head(X));
            return ref X;
        }

		/// <summary>
		/// Computes X[i,j] = A[i,j] % B[i,j] for each row/col index i/j
		/// </summary>
		/// <param name="A">The left vector</param>
  		/// <param name="B">The right vector</param>
		/// <param name="X">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,double> mod<M,N>(BlockMatrix<M,N,double> lhs, BlockMatrix<M,N,double> rhs, ref BlockMatrix<M,N,double> dst)
            where N : ITypeNat, new()
            where M : ITypeNat, new()

        {
            VmlImport.vdFmod(BlockMatrix<M,N,float>.CellCount, ref head(lhs), ref head(rhs), ref head(dst));
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
        public static ref BlockVector<float> truncRem(BlockVector<float> src, BlockVector<float> trunc, ref BlockVector<float> rem)
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
        public static ref BlockVector<double> truncRem(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> rem(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> rem(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> frac(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> frac(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> square(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> square(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> sqrt(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> sqrt(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> abs(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> abs(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> min(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> min(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> max(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> max(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> maxAbs(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> maxAbs(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> minAbs(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> minAbs(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)
        {
            VmlImport.vdMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<float> copySign(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)        
        {
            VmlImport.vsCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref BlockVector<double> copySign(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> next(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> next(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> round(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> round(BlockVector<double> src, ref BlockVector<double> dst)        
        {
            VmlImport.vdRound(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,float> round<M,N>(ref BlockMatrix<M,N,float> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vsRound(BlockMatrix<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards the nearest integral value
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,double> round<M,N>(ref BlockMatrix<M,N,double> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {

            VmlImport.vdRound(BlockMatrix<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =truncate(src[i]) for i=0..n-1 where "truncate" rounds the input value towards 0
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref BlockVector<float> trunc(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> trunc(BlockVector<double> src, ref BlockVector<double> dst)        
        {
            VmlImport.vdTrunc(src.Length, ref head(src), ref head(dst));
            return ref dst;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,double> trunc<M,N>(ref BlockMatrix<M,N,double> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vdTrunc(BlockMatrix<M,N,double>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Rounds each element towards zero
		/// </summary>
		/// <param name="src">The source/target matrix</param>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,float> trunc<M,N>(ref BlockMatrix<M,N,float> A)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            VmlImport.vsTrunc(BlockMatrix<M,N,float>.CellCount, ref head(A), ref head(A));
            return ref A;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static ref BlockVector<float> floor(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> floor(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> ceil(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> ceil(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> recip(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> recip(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> pow(BlockVector<float> lhs, BlockVector<float> rhs, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> pow(BlockVector<double> lhs, BlockVector<double> rhs, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> pow(BlockVector<float> src, float exp, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> pow(BlockVector<double> src, double exp, ref BlockVector<double> dst)
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
        public static ref BlockVector<float> exp(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> exp(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> exp2(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> exp2(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> exp10(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> exp10(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> ln(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> ln(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> log2(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> log2(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> log10(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> log10(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> erf(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> erf(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> erfInv(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> erfInv(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> erfc(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> erfc(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> erfcInv(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> erfcInv(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> expInt(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> expInt(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> cdfNorm(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> cdfNorm(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> cdfNormInv(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> cdfNormInv(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> gamma(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> gamma(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> lgamma(BlockVector<float> src, ref BlockVector<float> dst)        
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
        public static ref BlockVector<double> lgamma(BlockVector<double> src, ref BlockVector<double> dst)        
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
        public static ref BlockVector<float> hypot(BlockVector<float> a, BlockVector<float> b, ref BlockVector<float> dst)
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
        public static ref BlockVector<double> hypot(BlockVector<double> a, BlockVector<double> b, ref BlockVector<double> dst)
        {
            VmlImport.vdHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return ref dst;
        }
    }

}