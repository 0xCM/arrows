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
        /// Computes the quotient lhs/rhs
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        [MethodImpl(Inline)]
        public static float div(float lhs, float rhs)
        {
            var z = 0f;
            VmlImport.vsDiv(1, ref lhs, ref rhs, ref z);
            return z;
        }

        /// <summary>
        /// Computes the quotient of the operands and returns the result
        /// </summary>
        /// <param name="lhs">The left scalar</param>
        /// <param name="rhs">The right scalar</param>
        [MethodImpl(Inline)]
        public static double div(double lhs, double rhs)
        {
            var z = 0d;
            VmlImport.vdDiv(1, ref lhs, ref rhs, ref z);
            return z;
        }

        /// <summary>
        /// Computes the square of a source scalar and returns the result
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static float square(float src)
        {
            var dst = 0f;
            VmlImport.vsSqr(1, ref src, ref dst);
            return dst;
        }
 
        /// <summary>
        /// Computes the square of a source scalar and writes the result to a target scalar
        /// </summary>
        /// <param name="src">The source scalar</param>
        /// <param name="dst">The target scalar</param>
        [MethodImpl(Inline)]
        public static void square(float src, out float dst)
        {
            dst = 0;
            VmlImport.vsSqr(1, ref src, ref dst);
        }

        /// <summary>
        /// Computes the square of a source scalar and returns the result
        /// </summary>
        /// <param name="src">The source scalar</param>
        [MethodImpl(Inline)]
        public static double square(double src)
        {
            var dst = 0d;
            VmlImport.vdSqr(1, ref src, ref dst);
            return dst;
        }
 
        /// <summary>
        /// Computes the square of a source scalar and writes the result to a target scalar
        /// </summary>
        /// <param name="src">The source scalar</param>
        /// <param name="dst">The target scalar</param>
        [MethodImpl(Inline)]
        public static void square(double src, out double dst)
        {
            dst = 0;
            VmlImport.vdSqr(1, ref src, ref dst);
        }

 


    }

}