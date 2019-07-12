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
        public const int VSL_BRNG_SHIFT = 20;

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
        
        VSL_ERROR_UNKNOWN = -2,
        
        VSL_ERROR_BADARGS = -3,
        
        VSL_ERROR_MEM_FAILURE = -4,
        
        VSL_ERROR_NULL_PTR = -5,
        
        VSL_ERROR_CPU_NOT_SUPPORTED = -6,
    }


    public enum VslRngStatus
    {
        VSL_ERROR_OK = 0,

        VSL_ERROR_MEM_FAILURE  = -4,

        VSL_RNG_ERROR_INVALID_BRNG_INDEX = - 1000,
    
        VSL_RNG_ERROR_LEAPFROG_UNSUPPORTED      = - 1002,
    
        VSL_RNG_ERROR_SKIPAHEAD_UNSUPPORTED     = - 1003,
    
        VSL_RNG_ERROR_BRNGS_INCOMPATIBLE = - 1005,
    
        VSL_RNG_ERROR_BAD_STREAM         = - 1006,
    
        VSL_RNG_ERROR_BRNG_TABLE_FULL    = - 1007,
    
        VSL_RNG_ERROR_BAD_STREAM_STATE_SIZE     = - 1008,
    
        VSL_RNG_ERROR_BAD_WORD_SIZE = - 1009,
    
        VSL_RNG_ERROR_BAD_NSEEDS = - 1010,
    
        VSL_RNG_ERROR_BAD_NBITS = - 1011,
    
        VSL_RNG_ERROR_QRNG_PERIOD_ELAPSED = - 1012,
    
        VSL_RNG_ERROR_LEAPFROG_NSTREAMS_TOO_BIG = - 1013,
    
        VSL_RNG_ERROR_BRNG_NOT_SUPPORTED = - 1014,

        /* abstract stream related errors */
        VSL_RNG_ERROR_BAD_UPDATE = - 1120,
        
        VSL_RNG_ERROR_NO_NUMBERS = - 1121,
        
        VSL_RNG_ERROR_INVALID_ABSTRACT_STREAM   = - 1122,

        /* non determenistic stream related errors */
        VSL_RNG_ERROR_NONDETERM_NOT_SUPPORTED     = - 1130,
        VSL_RNG_ERROR_NONDETERM_NRETRIES_EXCEEDED = - 1131,

        /* ARS5 stream related errors */
        VSL_RNG_ERROR_ARS5_NOT_SUPPORTED        = - 1140,

        /* Multinomial distribution probability array related errors */
        VSL_DISTR_MULTINOMIAL_BAD_PROBABILITY_ARRAY    = - 1150,

        /* read/write stream to file errors */
        VSL_RNG_ERROR_FILE_CLOSE = - 1100,
        
        VSL_RNG_ERROR_FILE_OPEN = - 1101,
        
        VSL_RNG_ERROR_FILE_WRITE = - 1102,
        
        VSL_RNG_ERROR_FILE_READ = - 1103,

        VSL_RNG_ERROR_BAD_FILE_FORMAT = - 1110,
        
        VSL_RNG_ERROR_UNSUPPORTED_FILE_VER = - 1111,

        VSL_RNG_ERROR_BAD_MEM_FORMAT = - 1200

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
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER = 0, /* vsl{d,s}RngGaussian */

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
        VSL_RNG_METHOD_GAUSSIAN_ICDF = 2, /* vsl{d,s}RngGaussian */

    }

    enum SSTaskEdit
    {
        VSL_SS_ED_DIMEN = 1,

        VSL_SS_ED_OBSERV_N = 2,

        VSL_SS_ED_OBSERV = 3,

        VSL_SS_ED_OBSERV_STORAGE = 4,

        VSL_SS_ED_INDC = 5,

        VSL_SS_ED_WEIGHTS = 6,
        
        VSL_SS_ED_MEAN = 7,
        
        VSL_SS_ED_2R_MOM = 8,
        
        VSL_SS_ED_3R_MOM = 9,
        
        VSL_SS_ED_4R_MOM = 10,
        
        VSL_SS_ED_2C_MOM = 11,
        
        VSL_SS_ED_3C_MOM = 12,
                
        VSL_SS_ED_4C_MOM = 13,
        
        VSL_SS_ED_SUM = 67,
        
        VSL_SS_ED_2R_SUM = 68,
        
        VSL_SS_ED_3R_SUM = 69,
        
        VSL_SS_ED_4R_SUM = 70,
        
        VSL_SS_ED_2C_SUM = 71,
        
        VSL_SS_ED_3C_SUM = 72,
        
        VSL_SS_ED_4C_SUM = 73,
        
        VSL_SS_ED_KURTOSIS = 14,
        
        VSL_SS_ED_SKEWNESS = 15,
        
        VSL_SS_ED_MIN = 16,
        
        VSL_SS_ED_MAX = 17,
        
        VSL_SS_ED_VARIATION = 18,
        
        VSL_SS_ED_COV = 19,
        
        VSL_SS_ED_COV_STORAGE = 20,
        
        VSL_SS_ED_COR = 21,
        
        VSL_SS_ED_COR_STORAGE = 22,
        
        VSL_SS_ED_CP = 74,
        
        VSL_SS_ED_CP_STORAGE = 75,
        
        VSL_SS_ED_ACCUM_WEIGHT = 23,
        
        VSL_SS_ED_QUANT_ORDER_N = 24,
        
        VSL_SS_ED_QUANT_ORDER = 25,
        
        VSL_SS_ED_QUANT_QUANTILES = 26,
        
        VSL_SS_ED_ORDER_STATS = 27,
        
        VSL_SS_ED_GROUP_INDC = 28,
        
        VSL_SS_ED_POOLED_COV_STORAGE = 29,
        
        VSL_SS_ED_POOLED_MEAN = 30,
        
        VSL_SS_ED_POOLED_COV = 31,
        
        VSL_SS_ED_GROUP_COV_INDC = 32,
        
        VSL_SS_ED_REQ_GROUP_INDC = 32,
        
        VSL_SS_ED_GROUP_MEAN = 33,
        
        VSL_SS_ED_GROUP_COV_STORAGE = 34,
        
        VSL_SS_ED_GROUP_COV = 35,
        
        VSL_SS_ED_ROBUST_COV_STORAGE = 36,
        
        VSL_SS_ED_ROBUST_COV_PARAMS_N = 37,
        
        VSL_SS_ED_ROBUST_COV_PARAMS = 38,
        
        VSL_SS_ED_ROBUST_MEAN = 39,
        
        VSL_SS_ED_ROBUST_COV = 40,
        
        VSL_SS_ED_OUTLIERS_PARAMS_N = 41,
        
        VSL_SS_ED_OUTLIERS_PARAMS = 42,
        
        VSL_SS_ED_OUTLIERS_WEIGHT = 43,
        
        VSL_SS_ED_ORDER_STATS_STORAGE = 44,
        
        VSL_SS_ED_PARTIAL_COV_IDX = 45,
        
        VSL_SS_ED_PARTIAL_COV = 46,
        
        VSL_SS_ED_PARTIAL_COV_STORAGE = 47,
        
        VSL_SS_ED_PARTIAL_COR = 48,
        
        VSL_SS_ED_PARTIAL_COR_STORAGE = 49,
        
        VSL_SS_ED_MI_PARAMS_N = 50,
        
        VSL_SS_ED_MI_PARAMS = 51,
        
        VSL_SS_ED_MI_INIT_ESTIMATES_N = 52,
        
        VSL_SS_ED_MI_INIT_ESTIMATES = 53,
        
        VSL_SS_ED_MI_SIMUL_VALS_N = 54,
        
        VSL_SS_ED_MI_SIMUL_VALS = 55,
        
        VSL_SS_ED_MI_ESTIMATES_N = 56,
        
        VSL_SS_ED_MI_ESTIMATES = 57,
        
        VSL_SS_ED_MI_PRIOR_N = 58,
        
        VSL_SS_ED_MI_PRIOR = 59,
        
        VSL_SS_ED_PARAMTR_COR = 60,
        
        VSL_SS_ED_PARAMTR_COR_STORAGE = 61,
        
        VSL_SS_ED_STREAM_QUANT_PARAMS_N = 62,
        
        VSL_SS_ED_STREAM_QUANT_PARAMS = 63,
        
        VSL_SS_ED_STREAM_QUANT_ORDER_N = 64,
        
        VSL_SS_ED_STREAM_QUANT_ORDER = 65,
        
        VSL_SS_ED_STREAM_QUANT_QUANTILES = 66,
        
        VSL_SS_ED_MDAD = 76,
        
        VSL_SS_ED_MNAD = 77,
        
        VSL_SS_ED_SORTED_OBSERV = 78,
        
        VSL_SS_ED_SORTED_OBSERV_STORAGE = 79,
    }

    enum SSComputeRoutine : ulong
    {
        VSL_SS_MEAN = 0x0000000000000001,
        VSL_SS_2R_MOM = 0x0000000000000002,
        VSL_SS_3R_MOM = 0x0000000000000004,
        VSL_SS_4R_MOM = 0x0000000000000008,
        VSL_SS_2C_MOM = 0x0000000000000010,
        VSL_SS_3C_MOM = 0x0000000000000020,
        VSL_SS_4C_MOM = 0x0000000000000040,
        VSL_SS_SUM =  0x0000000002000000,
        VSL_SS_2R_SUM = 0x0000000004000000,
        VSL_SS_3R_SUM = 0x0000000008000000,
        VSL_SS_4R_SUM = 0x0000000010000000,
        VSL_SS_2C_SUM = 0x0000000020000000,
        VSL_SS_3C_SUM = 0x0000000040000000,
        VSL_SS_4C_SUM = 0x0000000080000000,
        VSL_SS_KURTOSIS = 0x0000000000000080,
        VSL_SS_SKEWNESS = 0x0000000000000100,
        VSL_SS_VARIATION = 0x0000000000000200,
        VSL_SS_MIN =  0x0000000000000400, 
        VSL_SS_MAX =  0x0000000000000800,
        VSL_SS_COV =  0x0000000000001000,
        VSL_SS_COR =  0x0000000000002000,
        VSL_SS_CP =   0x0000000100000000,
        VSL_SS_POOLED_COV = 0x0000000000004000,
        VSL_SS_GROUP_COV = 0x0000000000008000,
        VSL_SS_POOLED_MEAN = 0x0000000800000000,
        VSL_SS_GROUP_MEAN = 0x0000001000000000,
        VSL_SS_QUANTS = 0x0000000000010000,
        VSL_SS_ORDER_STATS = 0x0000000000020000,
        VSL_SS_SORTED_OBSERV = 0x0000008000000000,
        VSL_SS_ROBUST_COV = 0x0000000000040000,
        VSL_SS_OUTLIERS = 0x0000000000080000,
        VSL_SS_PARTIAL_COV = 0x0000000000100000,
        VSL_SS_PARTIAL_COR = 0x0000000000200000,
        VSL_SS_MISSING_VALS = 0x0000000000400000,
        VSL_SS_PARAMTR_COR = 0x0000000000800000,
        VSL_SS_STREAM_QUANTS = 0x0000000001000000,
        VSL_SS_MDAD = 0x0000000200000000,
        VSL_SS_MNAD = 0x0000000400000000,

   }    

    public static class VslCodeX
    {
        public static bool IsError(this VslRngStatus status)
            => status != VslRngStatus.VSL_ERROR_OK;

        public static bool ThrowOnError(this VslRngStatus status)
            =>!status.IsError() ? false : throw new Exception($"VSL Error Code {status}");

    }
}