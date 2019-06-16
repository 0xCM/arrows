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
    using static VslRngConstants;
    
    static class VslRngConstants
    {
        public const int VSL_BRNG_SHIFT =   20;

        public const int  VSL_BRNG_INC = 1 << VSL_BRNG_SHIFT;

    }

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
        

    /*
    // Common errors (-1..-999)
    */

    public enum VslError 
    {
        VSL_ERROR_OK = 0,
        VSL_ERROR_FEATURE_NOT_IMPLEMENTED = -1,
        VSL_ERROR_UNKNOWN                 = -2,
        VSL_ERROR_BADARGS                 = -3,
        VSL_ERROR_MEM_FAILURE             = -4,
        VSL_ERROR_NULL_PTR                = -5,
        VSL_ERROR_CPU_NOT_SUPPORTED       = -6,

    }

    public enum VslRngStatus
    {
        VSL_ERROR_OK = 0,

        VSL_ERROR_MEM_FAILURE             = -4,

        VSL_RNG_ERROR_INVALID_BRNG_INDEX        = - 1000,
        VSL_RNG_ERROR_LEAPFROG_UNSUPPORTED      = - 1002,
        VSL_RNG_ERROR_SKIPAHEAD_UNSUPPORTED     = - 1003,
        VSL_RNG_ERROR_BRNGS_INCOMPATIBLE        = - 1005,
        VSL_RNG_ERROR_BAD_STREAM                = - 1006,
        VSL_RNG_ERROR_BRNG_TABLE_FULL           = - 1007,
        VSL_RNG_ERROR_BAD_STREAM_STATE_SIZE     = - 1008,
        VSL_RNG_ERROR_BAD_WORD_SIZE             = - 1009,
        VSL_RNG_ERROR_BAD_NSEEDS                = - 1010,
        VSL_RNG_ERROR_BAD_NBITS                 = - 1011,
        VSL_RNG_ERROR_QRNG_PERIOD_ELAPSED       = - 1012,
        VSL_RNG_ERROR_LEAPFROG_NSTREAMS_TOO_BIG = - 1013,
        VSL_RNG_ERROR_BRNG_NOT_SUPPORTED        = - 1014,

        /* abstract stream related errors */
        VSL_RNG_ERROR_BAD_UPDATE                = - 1120,
        VSL_RNG_ERROR_NO_NUMBERS                = - 1121,
        VSL_RNG_ERROR_INVALID_ABSTRACT_STREAM   = - 1122,

        /* non determenistic stream related errors */
        VSL_RNG_ERROR_NONDETERM_NOT_SUPPORTED     = - 1130,
        VSL_RNG_ERROR_NONDETERM_NRETRIES_EXCEEDED = - 1131,

        /* ARS5 stream related errors */
        VSL_RNG_ERROR_ARS5_NOT_SUPPORTED        = - 1140,

        /* Multinomial distribution probability array related errors */
        VSL_DISTR_MULTINOMIAL_BAD_PROBABILITY_ARRAY    = - 1150,

        /* read/write stream to file errors */
        VSL_RNG_ERROR_FILE_CLOSE                = - 1100,
        VSL_RNG_ERROR_FILE_OPEN                 = - 1101,
        VSL_RNG_ERROR_FILE_WRITE                = - 1102,
        VSL_RNG_ERROR_FILE_READ                 = - 1103,

        VSL_RNG_ERROR_BAD_FILE_FORMAT           = - 1110,
        VSL_RNG_ERROR_UNSUPPORTED_FILE_VER      = - 1111,

        VSL_RNG_ERROR_BAD_MEM_FORMAT            = - 1200

    }

    public enum VslRngMethod
    {
        VSL_RNG_METHOD_UNIFORM_STD = 0, /* vsl{s,d,i}RngUniform */
        
        VSL_RNG_METHOD_UNIFORMBITS32_STD = 0, /* vsliRngUniformBits32 */
        
        VSL_RNG_METHOD_UNIFORMBITS64_STD = 0, /* vsliRngUniformBits64 */
        

        /// <summary>
        /// Generates normally distributed random number x thru the pair of uniformly distributed numbers u1 and u2 according to the formula:
        /// x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER  = 0, /* vsl{d,s}RngGaussian */

        /// <summary>
        /// generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly dustributed numbers u1 and u2
        /// according to the formula 
        /// x1=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// NOTE: implementation correctly works with odd vector lengths
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2 = 1, /* vsl{d,s}RngGaussian */

        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_ICDF     =   2, /* vsl{d,s}RngGaussian */

    }

    public static class VslCodeX
    {
        public static bool IsError(this VslRngStatus status)
            => status != VslRngStatus.VSL_ERROR_OK;

        public static bool ThrowOnError(this VslRngStatus status)
            =>!status.IsError() ? false : throw new Exception($"VSL Error Code {status}");

    }
}