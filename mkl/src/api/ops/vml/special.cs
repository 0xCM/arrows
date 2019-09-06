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

    public static class special
    {            
        /// <summary>
        /// The error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float erf(float src)
        {
            var dst = 0f;
            VmlImport.vsErf(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double erf(double src)
        {
            var dst = 0d;
            VmlImport.vdErf(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The inverse error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float erfInv(float src)
        {
            var dst = 0f;
            VmlImport.vsErfInv(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The inverse error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double erfInv(double src)
        {
            var dst = 0d;
            VmlImport.vdErfInv(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The complementary error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float erfc(float src)
        {
            var dst = 0f;
            VmlImport.vsErfc(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The complementary error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double erfc(double src)
        {
            var dst = 0d;
            VmlImport.vdErfc(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The inverse complementary error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float erfcInv(float src)
        {
            var dst = 0f;
            VmlImport.vsErfcInv(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The inverse complementary error function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double erfcInv(double src)
        {
            var dst = 0d;
            VmlImport.vdErfcInv(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The cdf norm function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float cdfNorm(float src)
        {
            var dst = 0f;
            VmlImport.vsCdfNorm(1, ref src, ref dst);
            return dst;
        }

        /// <summary>
        /// The cdf norm function
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double cdfNorm(double src)
        {
            var dst = 0d;
            VmlImport.vdCdfNorm(1, ref src, ref dst);
            return dst;
        }
    }
}