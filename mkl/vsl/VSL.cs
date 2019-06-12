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
	using System.Runtime.InteropServices;

	using static zfunc;
    
    public static partial class VSL
    {
        const string MklDll = "mkl_rt.dll";


        const CallingConvention Cdecl = CallingConvention.Cdecl;
        
        const int VSL_BRNG_SHIFT =   20;

        const int  VSL_BRNG_INC = 1 << VSL_BRNG_SHIFT;
        
        public enum BRNG
        {
            /// <summary>
            /// A 31-bit multiplicative congruential generator.
            /// </summary>
            VSL_BRNG_MCG31 = VSL_BRNG_INC,

            /// <summary>
            /// A generalized feedback shift register generator.
            /// </summary>
            VSL_BRNG_R250 = VSL_BRNG_MCG31 + VSL_BRNG_INC,
            
            /// <summary>
            /// A combined multiple recursive generator with two components of order 3.
            /// </summary>
            VSL_BRNG_MRG32K3A = VSL_BRNG_R250 + VSL_BRNG_INC,

            /// <summary>
            /// A 59-bit multiplicative congruential generator.
            /// </summary>
            VSL_BRNG_MCG59 = VSL_BRNG_MRG32K3A + VSL_BRNG_INC,
            
            /// <summary>
            /// A set of 273 Wichmann-Hill combined multiplicative congruential generators.
            /// </summary>
            VSL_BRNG_WH = VSL_BRNG_MCG59 + VSL_BRNG_INC,
            
            /// <summary>
            /// A 32-bit Gray code-based generator producing low-discrepancy sequences 
            /// for dimensions 1 ≤ s ≤ 40; user-defined dimensions are also available
            /// </summary>
            VSL_BRNG_SOBOL = VSL_BRNG_WH + VSL_BRNG_INC,

            /// <summary>
            /// A 32-bit Gray code-based generator producing low-discrepancy sequences 
            /// for dimensions 1 ≤ s ≤ 318; user-defined dimensions are also available.
            /// </summary>
            VSL_BRNG_NIEDERR = VSL_BRNG_SOBOL + VSL_BRNG_INC,
            
            /// <summary>
            /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
            /// </summary>
            VSL_BRNG_MT19937 = VSL_BRNG_NIEDERR + VSL_BRNG_INC,

            /// <summary>
            /// A set of 6024 Mersenne Twister pseudorandom number generators
            /// </summary>
            VSL_BRNG_MT2203 = VSL_BRNG_MT19937 + VSL_BRNG_INC,
            
            /// <summary>
            /// An abstract random number generator for integer arrays.
            /// </summary>
            VSL_BRNG_IABSTRACT = VSL_BRNG_MT2203 + VSL_BRNG_INC,
            
            /// <summary>
            /// An abstract random number generator for double precision floating-point arrays.
            /// </summary>
            VSL_BRNG_DABSTRACT = VSL_BRNG_IABSTRACT + VSL_BRNG_INC,

            /// <summary>
            /// An abstract random number generator for single precision floating-point arrays.
            /// </summary>
            VSL_BRNG_SABSTRACT = VSL_BRNG_DABSTRACT + VSL_BRNG_INC,

            /// <summary>
            /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
            /// </summary>
            VSL_BRNG_SFMT19937 = VSL_BRNG_SABSTRACT+ VSL_BRNG_INC,

            /// <summary>
            /// A non-deterministic random number generator.
            /// </summary>
            VSL_BRNG_NONDETERM = VSL_BRNG_SFMT19937+ VSL_BRNG_INC,

            /// <summary>
            /// An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
            /// </summary>
            VSL_BRNG_ARS5 = VSL_BRNG_NONDETERM+ VSL_BRNG_INC,

            /// <summary>
            /// A Philox4x32-10 counter-based pseudorandom number generator.
            /// </summary>
            VSL_BRNG_PHILOX4X32X10  = VSL_BRNG_ARS5     + VSL_BRNG_INC            
        }
        

        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int vslNewStream(IntPtr state, BRNG brng, uint seed);
    }

}