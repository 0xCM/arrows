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
        public static Span<float> add(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> add(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> sub(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] - rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> sub(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> mul(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] * rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> mul(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> div(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] / rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> div(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> mod(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }
        
		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> mod(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static Span<float> truncRem(Span<float> src, Span<float> trunc, Span<float> rem)
        {
            VmlImport.vsModf(length(src,trunc), ref head(src), ref head(trunc), ref head(rem));
            return rem;
        }

        /// <summary>
        /// Truncates the source vector and deposits the result in trunc and the fractional part 
        /// that was removed when producing the truncation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="trunc">The vector that receives the truncated components</param>
        /// <param name="rem">The vector that receives the fractional remainders</param>
        [MethodImpl(Inline)]
        public static Span<double> truncRem(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdModf(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }
        

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> rem(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = remainder(lhs[i] / rhs[i]) for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> rem(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> frac(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsFrac(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes the fractional part of each component
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> frac(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdFrac(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> square(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsSqr(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^2 for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> square(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdSqr(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> sqrt(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsSqrt(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = (src[i])^(1/2) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> sqrt(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdSqrt(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = |src[i]| for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> abs(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i = 0...n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> abs(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> min(Span<float> a, Span<float> b, Span<float> dst)
        {
            VmlImport.vsFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = min(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> min(Span<double> a, Span<double> b, Span<double> dst)
        {
            VmlImport.vdFmin(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> max(Span<float> a, Span<float> b, Span<float> dst)
        {
            VmlImport.vsFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = max(a[i], b[i]) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> max(Span<double> a, Span<double> b, Span<double> dst)
        {
            VmlImport.vdFmax(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }


        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> maxAbs(Span<float> a, Span<float> b, Span<float> dst)
        {
            VmlImport.vsMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = max(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> maxAbs(Span<double> a, Span<double> b, Span<double> dst)
        {
            VmlImport.vdMaxMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> minAbs(Span<float> a, Span<float> b, Span<float> dst)
        {
            VmlImport.vsMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = min(|a[i]|, |b[i]|) for i = 0...n-1
        /// </summary>
        /// <param name="a">The first source vector</param>
        /// <param name="b">The second source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> minAbs(Span<double> a, Span<double> b, Span<double> dst)
        {
            VmlImport.vdMinMag(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<float> copySign(Span<float> a, Span<float> b, Span<float> dst)        
        {
            VmlImport.vsCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<double> copySign(Span<double> a, Span<double> b, Span<double> dst)        
        {
            VmlImport.vdCopySign(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<double> inc(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdNextAfter(dst.Length, ref head(src), ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> floor(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsFloor(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] =floor(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> floor(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdFloor(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> ceil(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsCeil(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = ceil(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> ceil(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdCeil(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> recip(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 1/src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> recip(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> pow(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VmlImport.vsPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> pow(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VmlImport.vdPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> pow(Span<float> src, float exp, Span<float> dst)
        {
            VmlImport.vsPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = src[i]^exp for i = 0...n-1 
		/// </summary>
		/// <param name="src">The left vector</param>
  		/// <param name="exp">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> pow(Span<double> src, double exp, Span<double> dst)
        {
            VmlImport.vdPowx(length(src,dst), ref head(src), exp, ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> exp(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsExp(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = e^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> exp(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdExp(src.Length, ref head(src), ref head(dst));
            return dst;
        }
       
 		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> exp2(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsExp2(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 2^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> exp2(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdExp2(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> exp10(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsExp10(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = 10^src[i] for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> exp10(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdExp10(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> ln(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsLn(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] =ln(src[i]) for i=0..n-1 where ln denotes the natural log
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> ln(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdLn(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> log2(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsLog2(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log2(src[i]) for i=0..n-1 where log2 denotes the base 2 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> log2(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdLog2(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> log10(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsLog10(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] =log10(src[i]) for i=0..n-1 where log10 denotes the base 10 log
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> log10(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdLog10(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> erf(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsErf(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes the error function dst[i] =erf(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> erf(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdErf(src.Length, ref head(src), ref head(dst));
            return dst;
        }

 		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> erfInv(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsErfInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes the inverse error function dst[i] =erfInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> erfInv(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdErfInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> erfc(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsErfc(src.Length, ref head(src), ref head(dst));
            return dst;
        }
 
		/// <summary>
		/// Computes the complementary error function dst[i] =erfc(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> erfc(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdErfc(src.Length, ref head(src), ref head(dst));
            return dst;
        }
 
		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> erfcInv(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsErfcInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes the inverse complementary error function dst[i] =erfcInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> erfcInv(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdErfcInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> expInt(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsExpInt1(src.Length, ref head(src), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes the exponential integral function dst[i] = E(src[i]) for i=0..n-1 where
        /// E(x) = ∫[x, ∞](e^(-t)/t)dt = ∫[1, ∞](e^(-xt)/t)dt
        /// </summary>
        /// <param name="src">The source vector containing the lower integration bounds</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> expInt(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdExpInt1(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> cdfNorm(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsCdfNorm(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnorm(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> cdfNorm(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdCdfNorm(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> cdfNormInv(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsCdfNormInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = cdfnormInv(src[i]) for i=0..n-1
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> cdfNormInv(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdCdfNormInv(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes the gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> gamma(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsTGamma(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes the gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> gamma(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdTGamma(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vectro</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> lgamma(Span<float> src, Span<float> dst)        
        {
            VmlImport.vsLGamma(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes of natural logarithm of the absolute value of gamma function: dst[i] = lgamma(src[i])
		/// </summary>
		/// <param name="src">The source vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> lgamma(Span<double> src, Span<double> dst)        
        {
            VmlImport.vdLGamma(src.Length, ref head(src), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> hypot(Span<float> a, Span<float> b, Span<float> dst)
        {
            VmlImport.vsHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }

        /// Computes dst[i] = sqrt(a[i]^2 + b[i]^2)
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> hypot(Span<double> a, Span<double> b, Span<double> dst)
        {
            VmlImport.vdHypot(dst.Length, ref head(a), ref head(b), ref head(dst));
            return dst;
        }
    }

}