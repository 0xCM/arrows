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
            VML.vsAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vdAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vsSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vdSub(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vsMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vdMul(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vsDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes the quotient lhs/rhs
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        [MethodImpl(Inline)]
        public static float div(float lhs, float rhs)
        {
            var z = 0f;
            VML.vsDiv(1, ref lhs, ref rhs, ref z);
            return z;
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
            VML.vdDiv(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

        /// <summary>
        /// Computes the quotient lhs/rhs
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        [MethodImpl(Inline)]
        public static double div(double lhs, double rhs)
        {
            var z = 0d;
            VML.vdDiv(1, ref lhs, ref rhs, ref z);
            return z;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> fmod(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VML.vsFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static float fmod(float lhs, float rhs)
        {
            var z = 0f;
            VML.vsModf(1, ref lhs, ref rhs, ref z);
            return z;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] % rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> fmod(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VML.vdFmod(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vsRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vdRemainder(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vsSqrt(src.Length, ref head(src), ref head(dst));
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
            VML.vdSqrt(src.Length, ref head(src), ref head(dst));
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
            VML.vsSqr(src.Length, ref head(src), ref head(dst));
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
            VML.vdSqr(src.Length, ref head(src), ref head(dst));
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
            VML.vsAbs(src.Length, ref head(src), ref head(dst));
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
            VML.vdAbs(src.Length, ref head(src), ref head(dst));
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
            VML.vsInv(src.Length, ref head(src), ref head(dst));
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
            VML.vdInv(src.Length, ref head(src), ref head(dst));
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
            VML.vsCdfNorm(src.Length, ref head(src), ref head(dst));
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
            VML.vdCdfNorm(src.Length, ref head(src), ref head(dst));
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
            VML.vsPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
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
            VML.vdPow(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> pow(Span<float> lhs, float rhs, Span<float> dst)
        {
            VML.vsPowx(length(lhs,dst), ref head(lhs), rhs, ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i]^rhs for i = 0...n-1 
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right scalar</param>
		/// <param name="dst">The caller-allocated target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> pow(Span<double> lhs, double rhs, Span<double> dst)
        {
            VML.vdPowx(length(lhs,dst), ref head(lhs), rhs, ref head(dst));
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
            VML.vsExp(src.Length, ref head(src), ref head(dst));
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
            VML.vdExp(src.Length, ref head(src), ref head(dst));
            return dst;
        }


    }

}