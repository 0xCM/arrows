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
    using static VslRngMethod;
    
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
        [MklCode("A 31-bit multiplicative congruential generator.")]
        VSL_BRNG_MCG31 = VSL_BRNG_INC,

        /// <summary>
        /// A generalized feedback shift register generator.
        /// </summary>
        [MklCode("A generalized feedback shift register generator.")]
        VSL_BRNG_R250 = VSL_BRNG_MCG31 + VSL_BRNG_INC,
        
        /// <summary>
        /// A combined multiple recursive generator with two components of order 3.
        /// </summary>
        [MklCode("A combined multiple recursive generator with two components of order 3.")]
        VSL_BRNG_MRG32K3A = VSL_BRNG_R250 + VSL_BRNG_INC,

        /// <summary>
        /// A 59-bit multiplicative congruential generator.
        /// </summary>
        [MklCode("A 59-bit multiplicative congruential generator.")]
        VSL_BRNG_MCG59 = VSL_BRNG_MRG32K3A + VSL_BRNG_INC,
        
        /// <summary>
        /// A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        [MklCode("A set of 273 Wichmann-Hill combined multiplicative congruential generators.")]
        VSL_BRNG_WH = VSL_BRNG_MCG59 + VSL_BRNG_INC,
        
        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// User-defined dimensions are also available
        /// </summary>
        [MklCode("A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40")]
        VSL_BRNG_SOBOL = VSL_BRNG_WH + VSL_BRNG_INC,

        /// <summary>
        /// A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318.
        /// User-defined dimensions are also available.
        /// </summary>
        [MklCode("A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 318.")]
        VSL_BRNG_NIEDERR = VSL_BRNG_SOBOL + VSL_BRNG_INC,
        
        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        [MklCode("A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.")]
        VSL_BRNG_MT19937 = VSL_BRNG_NIEDERR + VSL_BRNG_INC,

        /// <summary>
        /// A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        [MklCode("A set of 6024 Mersenne Twister pseudorandom number generators")]
        VSL_BRNG_MT2203 = VSL_BRNG_MT19937 + VSL_BRNG_INC,
        
        /// <summary>
        /// An abstract random number generator for integer arrays.
        /// </summary>
        [MklCode("An abstract random number generator for integer arrays.")]
        VSL_BRNG_IABSTRACT = VSL_BRNG_MT2203 + VSL_BRNG_INC,
        
        /// <summary>
        /// An abstract random number generator for double precision floating-point arrays.
        /// </summary>
        [MklCode("An abstract random number generator for double precision floating-point arrays.")]
        VSL_BRNG_DABSTRACT = VSL_BRNG_IABSTRACT + VSL_BRNG_INC,

        /// <summary>
        /// An abstract random number generator for single precision floating-point arrays.
        /// </summary>
        [MklCode("An abstract random number generator for single precision floating-point arrays.")]
        VSL_BRNG_SABSTRACT = VSL_BRNG_DABSTRACT + VSL_BRNG_INC,

        /// <summary>
        /// A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        [MklCode("A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.")]
        VSL_BRNG_SFMT19937 = VSL_BRNG_SABSTRACT+ VSL_BRNG_INC,

        /// <summary>
        /// A non-deterministic random number generator.
        /// </summary>
        [MklCode("A non-deterministic random number generator.")]
        VSL_BRNG_NONDETERM = VSL_BRNG_SFMT19937+ VSL_BRNG_INC,

        /// <summary>
        /// An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set
        /// </summary>
        [MklCode("An ARS-5 counter-based pseudorandom number generator that uses instructions from the AES-NI set")]
        VSL_BRNG_ARS5 = VSL_BRNG_NONDETERM+ VSL_BRNG_INC,

        /// <summary>
        /// A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        [MklCode("A Philox4x32-10 counter-based pseudorandom number generator.")]
        VSL_BRNG_PHILOX4X32X10  = VSL_BRNG_ARS5     + VSL_BRNG_INC            
    }
        
    public enum VslError 
    {
        VSL_ERROR_OK = 0,
        
        [MklCode("")]
        VSL_ERROR_FEATURE_NOT_IMPLEMENTED = -1,
        
        [MklCode("")]
        VSL_ERROR_UNKNOWN = -2,
        
        [MklCode("")]
        VSL_ERROR_BADARGS = -3,
        
        [MklCode("")]
        VSL_ERROR_MEM_FAILURE = -4,
        
        [MklCode("")]
        VSL_ERROR_NULL_PTR = -5,
        
        [MklCode("")]
        VSL_ERROR_CPU_NOT_SUPPORTED = -6,
    }

    public enum VslSSMatrixStorage
    {
        /// <summary>
        /// Observation vectors are organized by rows. For example, 10 observations
        /// in dimension 3 will conform to a 10 row 3 column matrix
        /// </summary>
        [MklCode("")]
        VSL_SS_MATRIX_STORAGE_ROWS  =    0x00010000,
        
        /// <summary>
        /// Observation vectors are organized by columns. For example, 10 observations
        /// in dimension 3 will conform to a 3 row by 10 column matrix
        /// </summary>
        [MklCode("")]
        VSL_SS_MATRIX_STORAGE_COLS  =   0x00020000

    }

    public enum VslRngStatus
    {
        VSL_ERROR_OK = 0,

        VSL_ERROR_MEM_FAILURE  = -4,

        VSL_RNG_ERROR_INVALID_BRNG_INDEX = - 1000,
    
        VSL_RNG_ERROR_LEAPFROG_UNSUPPORTED = - 1002,
    
        VSL_RNG_ERROR_SKIPAHEAD_UNSUPPORTED = - 1003,
    
        VSL_RNG_ERROR_BRNGS_INCOMPATIBLE = - 1005,
    
        VSL_RNG_ERROR_BAD_STREAM = - 1006,
    
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
        
        VSL_RNG_ERROR_INVALID_ABSTRACT_STREAM = - 1122,

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
        VSL_RNG_METHOD_UNIFORM_STD = 0,
        
        VSL_RNG_METHOD_UNIFORMBITS32_STD = 0, 
        
        VSL_RNG_METHOD_UNIFORMBITS64_STD = 0,

        /// <summary>
        /// Generates normally distributed random number x thru the pair of uniformly distributed numbers u1 and u2 according to the formula:
        /// x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER = 0,

        /// <summary>
        /// Generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly distributed numbers u1 and u2
        /// according to the formula 
        /// x1=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// NOTE: implementation correctly works with odd vector lengths
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2 = 1, 

        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_ICDF = 2,

        VSL_RNG_METHOD_ACCURACY_FLAG  = (1<<30),

        VSL_RNG_METHOD_GAMMA_GNORM = 0,

        VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE = VSL_RNG_METHOD_GAMMA_GNORM | VSL_RNG_METHOD_ACCURACY_FLAG,

    }

    enum VslGaussianMethod
    {
        BoxMuller1 = 0,

        BoxMuller2 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2,

        IDCF = VSL_RNG_METHOD_GAUSSIAN_ICDF,
    }

    enum VslGammaMethod
    {
        GNorm = VSL_RNG_METHOD_GAMMA_GNORM,

        GNormAccurate = VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE
    }


    enum SSTaskParameter
    {
        /// <summary>
        /// Address of a variable that holds the task dimension
        /// </summary>
        VSL_SS_ED_DIMEN = 1,

        /// <summary>
        /// Address of a variable that holds the number of observations
        /// </summary>
        VSL_SS_ED_OBSERV_N = 2,

        /// <summary>
        /// Address of the observation matrix
        /// </summary>
        VSL_SS_ED_OBSERV = 3,

        /// <summary>
        /// Address of a variable that holds the storage format for the observation matrix
        /// </summary>
        VSL_SS_ED_OBSERV_STORAGE = 4,

        /// <summary>
        /// Address of the array of indices
        /// </summary>
        VSL_SS_ED_INDC = 5,

        /// <summary>
        /// Address of the array of observation weights
        /// </summary>
        VSL_SS_ED_WEIGHTS = 6,
        
        /// <summary>
        /// Address of the array of means
        /// </summary>
        VSL_SS_ED_MEAN = 7,
        
        /// <summary>
        /// Address of an array of raw moments of the second order
        /// </summary>
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

        /// <summary>
        /// Address of the array of variation coefficients
        /// </summary>
        VSL_SS_ED_VARIATION = 18,
        
        /// <summary>
        /// Address of a covariance matrix
        /// </summary>
        VSL_SS_ED_COV = 19,
        
        /// <summary>
        /// Address of the variable that holds the storage format for a covariance matrix
        /// </summary>
        VSL_SS_ED_COV_STORAGE = 20,
        
        /// <summary>
        /// Address of a correlation matrix 
        /// </summary>
        VSL_SS_ED_COR = 21,
        
        /// <summary>
        /// Address of the variable that holds the storage format for a correlation matrix
        /// </summary>
        VSL_SS_ED_COR_STORAGE = 22,
        
        /// <summary>
        /// Address of cross-product matrix
        /// </summary>
        VSL_SS_ED_CP = 74,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_CP_STORAGE = 75,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ACCUM_WEIGHT = 23,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_QUANT_ORDER_N = 24,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_QUANT_ORDER = 25,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_QUANT_QUANTILES = 26,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ORDER_STATS = 27,
        
        VSL_SS_ED_GROUP_INDC = 28,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_POOLED_COV_STORAGE = 29,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_POOLED_MEAN = 30,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_POOLED_COV = 31,
        

        /// <summary>
        /// Address of an array of indices for which covariance/means should be computed
        /// </summary>
        VSL_SS_ED_GROUP_COV_INDC = 32,

        /// <summary>
        /// Address of an array of indices for which group estimates such as covariance or means are requested        
        /// </summary>
        VSL_SS_ED_REQ_GROUP_INDC = 32,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_GROUP_MEAN = 33,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_GROUP_COV_STORAGE = 34,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_GROUP_COV = 35,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ROBUST_COV_STORAGE = 36,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ROBUST_COV_PARAMS_N = 37,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ROBUST_COV_PARAMS = 38,
        
        /// Address of an array of robust means
        VSL_SS_ED_ROBUST_MEAN = 39,
        
        /// Address of a robust covariance matrix
        VSL_SS_ED_ROBUST_COV = 40,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_OUTLIERS_PARAMS_N = 41,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_OUTLIERS_PARAMS = 42,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_OUTLIERS_WEIGHT = 43,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_ORDER_STATS_STORAGE = 44,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARTIAL_COV_IDX = 45,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARTIAL_COV = 46,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARTIAL_COV_STORAGE = 47,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARTIAL_COR = 48,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARTIAL_COR_STORAGE = 49,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_PARAMS_N = 50,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_PARAMS = 51,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_INIT_ESTIMATES_N = 52,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_INIT_ESTIMATES = 53,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_SIMUL_VALS_N = 54,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_SIMUL_VALS = 55,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_ESTIMATES_N = 56,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_ESTIMATES = 57,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_PRIOR_N = 58,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MI_PRIOR = 59,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARAMTR_COR = 60,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_PARAMTR_COR_STORAGE = 61,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_STREAM_QUANT_PARAMS_N = 62,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_STREAM_QUANT_PARAMS = 63,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_STREAM_QUANT_ORDER_N = 64,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_STREAM_QUANT_ORDER = 65,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_STREAM_QUANT_QUANTILES = 66,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MDAD = 76,
        
        /// <summary>
        /// 
        /// </summary>
        VSL_SS_ED_MNAD = 77,
        
        /// <summary>
        /// Address of the array that stores sorted results
        /// </summary>
        VSL_SS_ED_SORTED_OBSERV = 78,
        
        /// <summary>
        /// Address of a variable that holds the storage format of an output matrix
        /// </summary>
        VSL_SS_ED_SORTED_OBSERV_STORAGE = 79,
    }

    /// <summary>
    /// SS routines provide computation of basic statistical estimates
    /// (central/raw moments up to 4th order, variance-covariance,
    ///  minimum, maximum, skewness/kurtosis) using the following methods
    /// </summary>
    [Flags]
    enum SSComputeMethod
    {
        /// <summary>
        /// Estimates are computed for price of one or two passes over observations using highly optimized Intel(R) MKL routines
        /// </summary>
        VSL_SS_METHOD_FAST =                    0x00000001,

        /// <summary>
        /// Estimate is computed for price of one pass of the observations
        /// </summary>
        VSL_SS_METHOD_1PASS =                  0x00000002,

        /// <summary>
        /// Estimates are computed for price of one or two passes over observations given user defined mean for central moments, covariance and correlation
        /// </summary>
        VSL_SS_METHOD_FAST_USER_MEAN =          0x00000100,

        /// <summary>
        /// Convert cross-product matrix to variance-covariance/correlation matrix 
        /// </summary>
        VSL_SS_METHOD_CP_TO_COVCOR =            0x00000200,

        /// <summary>
        /// Convert raw/central sums to raw/central moments
        /// </summary>
        VSL_SS_METHOD_SUM_TO_MOM =              0x00000400,

        /// <summary>
        /// Parametrization of correlation matrix using SPECTRAL DECOMPOSITION (SD) method
        /// </summary>
        VSL_SS_METHOD_SD = 0x00000004,

        /// <summary>
        /// Robust estimation of variance-covariance matrix and mean supports Rocke algorithm, TBS-estimator
        /// </summary>
        VSL_SS_METHOD_TBS =0x00000008,

        /// <summary>
        /// SS routine for estimation of missing values supports Multiple Imputation (MI) method
        /// </summary>
        VSL_SS_METHOD_MI = 0x00000010,

        /// <summary>
        /// SS provides routine for detection of outliers, BACON method
        /// </summary>
        VSL_SS_METHOD_BACON = 0x00000020,

        /// <summary>
        /// Streaming: intermediate estimates of quantiles during processing the next block are computed
        /// </summary>
        VSL_SS_METHOD_SQUANTS_ZW = 0x00000040,

        /// <summary>
        /// Streaming: intermediate estimates of quantiles during processing the next block are not computed
        /// </summary>
        VSL_SS_METHOD_SQUANTS_ZW_FAST = 0x00000080,

        /// <summary>
        /// Radix sorting
        /// </summary>
        VSL_SS_METHOD_RADIX = 0x00100000,
    }
    
    [Flags]
    enum SSComputeRoutine : ulong
    {        
        /// <summary>        
        /// Computes the array of means.
        /// </summary>
        [MklCode("Computes the array of means")]
        VSL_SS_MEAN = 0x0000000000000001,
        
        /// <summary>        
        /// Computes the array of the 2nd order raw moments
        /// </summary>
        [MklCode("")]
        VSL_SS_2R_MOM = 0x0000000000000002,

        /// <summary>        
        /// Computes the array of the 3rd order raw moments
        /// </summary>
        [MklCode("")]
        VSL_SS_3R_MOM = 0x0000000000000004,
        
        /// <summary>        
        /// Computes the array of the 4th order raw moments
        /// </summary>
        [MklCode("")]
        VSL_SS_4R_MOM = 0x0000000000000008,
        
        /// <summary>        
        /// Computes the array of central sums of the 2nd order
        /// </summary>
        [MklCode("")]
        VSL_SS_2C_MOM = 0x0000000000000010,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_3C_MOM = 0x0000000000000020,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_4C_MOM = 0x0000000000000040,

        /// <summary>        
        /// Computes the array of sums        
        /// </summary>
        [MklCode("")]
        VSL_SS_SUM =  0x0000000002000000,
        
        /// <summary>        
        /// Computes the array of raw sums of the 2nd order
        /// </summary>
        [MklCode("")]
        VSL_SS_2R_SUM = 0x0000000004000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_3R_SUM = 0x0000000008000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_4R_SUM = 0x0000000010000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_2C_SUM = 0x0000000020000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_3C_SUM = 0x0000000040000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_4C_SUM = 0x0000000080000000,
        
        /// <summary>        
        /// Computes the array of kurtosis values
        /// </summary>
        [MklCode("")]
        VSL_SS_KURTOSIS = 0x0000000000000080,
        
        /// <summary>        
        /// Computes the array of skewness values
        /// </summary>
        VSL_SS_SKEWNESS = 0x0000000000000100,
        
        /// <summary>        
        /// Computes the array of variation coefficients
        /// </summary>
        VSL_SS_VARIATION = 0x0000000000000200,
        
        /// <summary>        
        /// Computes the array of minimum values
        /// </summary>
        VSL_SS_MIN =  0x0000000000000400, 
        
        /// <summary>        
        /// Computes the array of maximum values
        /// </summary>
        VSL_SS_MAX =  0x0000000000000800,
        
        /// <summary>        
        /// Computes a covariance matrix.
        /// </summary>
        VSL_SS_COV =  0x0000000000001000,
        
        /// <summary>        
        /// Computes a correlation matrix. The main diagonal of the correlation matrix holds 
        /// variances of the random vector components
        /// </summary>
        VSL_SS_COR =  0x0000000000002000,
        
        /// <summary>        
        /// Computes a cross-product matrix
        /// </summary>
        VSL_SS_CP =   0x0000000100000000,
        
        /// <summary>        
        ///
        /// </summary>
        VSL_SS_POOLED_COV = 0x0000000000004000,
        
        /// <summary>        
        ///
        /// </summary>
        VSL_SS_GROUP_COV = 0x0000000000008000,
        
        /// <summary>        
        ///
        /// </summary>
        VSL_SS_POOLED_MEAN = 0x0000000800000000,
        
        /// <summary>        
        ///
        /// </summary>
        VSL_SS_GROUP_MEAN = 0x0000001000000000,
        
        /// <summary>        
        /// Computes quantiles
        /// </summary>
        VSL_SS_QUANTS = 0x0000000000010000,
        
        /// <summary>        
        /// Computes order statistics
        /// </summary>
        VSL_SS_ORDER_STATS = 0x0000000000020000,
        
        /// <summary>        
        ///
        /// </summary>
        VSL_SS_SORTED_OBSERV = 0x0000008000000000,
        
        /// <summary>        
        /// Computes a robust covariance matrix
        /// </summary>
        VSL_SS_ROBUST_COV = 0x0000000000040000,
        
        /// <summary>        
        /// Detects outliers in the dataset
        /// </summary>
        VSL_SS_OUTLIERS = 0x0000000000080000,
        
        /// <summary>        
        /// Computes a partial covariance matrix.
        /// </summary>
        VSL_SS_PARTIAL_COV = 0x0000000000100000,
        
        /// <summary>        
        /// Computes a partial correlation matrix
        /// </summary>
        VSL_SS_PARTIAL_COR = 0x0000000000200000,
        
        /// <summary>        
        /// Supports missing values in datasets.
        /// </summary>
        VSL_SS_MISSING_VALS = 0x0000000000400000,
        
        /// <summary>        
        /// Computes a parameterized correlation matrix.
        /// </summary>
        VSL_SS_PARAMTR_COR = 0x0000000000800000,
        
        /// <summary>        
        /// Computes quantiles for streaming data.
        /// </summary>
        VSL_SS_STREAM_QUANTS = 0x0000000001000000,
        
        /// <summary>        
        /// Computes median absolute deviation
        /// </summary>
        VSL_SS_MDAD = 0x0000000200000000,
        
        /// <summary>        
        /// Computes mean absolute deviation
        /// </summary>
        VSL_SS_MNAD = 0x0000000400000000,

   }    

    /// <summary>
    /// Defines summary statistic status codes
    /// </summary>
    public enum SSStatus
    {
        
        /// <summary>
        /// Everything is OK
        /// </summary>        
        [MklCode("")]
        VSL_SS_OK = VslError.VSL_ERROR_OK,

        /// <summary>
        /// Correlation matrix is not of full rank.
        /// </summary>        
        [MklCode("")]
        VSL_SS_NOT_FULL_RANK_MATRIX = 4028,

        /// <summary>
        /// Correlation matrix passed into the parameterization function is semi-definite.
        /// </summary>        
        [MklCode("")]
        VSL_SS_SEMIDEFINITE_COR = 4029,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_ALLOCATION_FAILURE = -4000,
        
        /// <summary>
        /// Dimension value is invalid.
        /// </summary>
        [MklCode("")]
        VSL_SS_ERROR_BAD_DIMEN = -4001,
        
        /// <summary>
        /// Invalid number (zero or negative) of observations was obtained
        /// </summary>
        [MklCode("")]
        VSL_SS_ERROR_BAD_OBSERV_N = -4002,

        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_STORAGE_NOT_SUPPORTED = -4003,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_INDC_ADDR = -4004,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_WEIGHTS = -4005,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MEAN_ADDR = -4006,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_2R_MOM_ADDR = -4007,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_3R_MOM_ADDR = -4008,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_4R_MOM_ADDR = -4009,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_2C_MOM_ADDR = -4010,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_3C_MOM_ADDR = -4011,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_4C_MOM_ADDR = -4012,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_KURTOSIS_ADDR = -4013,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_SKEWNESS_ADDR = -4014,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MIN_ADDR = -4015,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MAX_ADDR = -4016,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_VARIATION_ADDR = -4017,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_COV_ADDR = -4018,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_COR_ADDR = -4019,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_ACCUM_WEIGHT_ADDR = -4020,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_QUANT_ORDER_ADDR = -4021,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_QUANT_ORDER = -4022,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_QUANT_ADDR = -4023,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_ORDER_STATS_ADDR = -4024,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MOMORDER_NOT_SUPPORTED = -4025,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_ALL_OBSERVS_OUTLIERS = -4026,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_ROBUST_COV_ADDR = -4027,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_ROBUST_MEAN_ADDR = -4028,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_METHOD_NOT_SUPPORTED = -4029,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_GROUP_INDC_ADDR = -4030,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_NULL_TASK_DESCRIPTOR = -4031,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_OBSERV_ADDR = -4032,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_SINGULAR_COV = -4033,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_POOLED_COV_ADDR = -4034,
        
       /// <summary>
       /// 
       /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_POOLED_MEAN_ADDR = -4035,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_GROUP_COV_ADDR = -4036,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_GROUP_MEAN_ADDR = -4037,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_GROUP_INDC = -4038,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_OUTLIERS_PARAMS_ADDR = -4039,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_OUTLIERS_PARAMS_N_ADDR = -4040,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_OUTLIERS_WEIGHTS_ADDR = -4041,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_ROBUST_COV_PARAMS_ADDR  = -4042,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_ROBUST_COV_PARAMS_N_ADDR = -4043,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_STORAGE_ADDR = -4044,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_PARTIAL_COV_IDX_ADDR = -4045,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_PARTIAL_COV_ADDR = -4046,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_PARTIAL_COR_ADDR = -4047,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_PARAMS_ADDR = -4048,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_PARAMS_N_ADDR = -4049,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_BAD_PARAMS_N = -4050,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_PARAMS = -4051,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_INIT_ESTIMATES_N_ADDR = -4052,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_INIT_ESTIMATES_ADDR  = -4053,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_ADDR = -4054,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_N_ADDR = -4055,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_ESTIMATES_N_ADDR = -4056,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_ESTIMATES_ADDR = -4057,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_N = -4058,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_ESTIMATES_N = -4059,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_OUTPUT_PARAMS = -4060,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_PRIOR_N_ADDR = -4061,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_PRIOR_ADDR = -4062,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_MI_MISSING_VALS_N = -4063,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS_N_ADDR = -4064,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS_ADDR = -4065,
        
        /// <summary>
        /// 
        /// </summary>        
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS_N = -4066,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS = -4067,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_ORDER_ADDR = -4068,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_ORDER = -4069,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_ADDR = -4070,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_PARAMTR_COR_ADDR = -4071,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_COR = -4072,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_PARTIAL_COV_IDX = -4073,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_SUM_ADDR = -4074,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_2R_SUM_ADDR = -4075,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_3R_SUM_ADDR = -4076,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_4R_SUM_ADDR = -4077,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_2C_SUM_ADDR = -4078,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_3C_SUM_ADDR = -4079,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_4C_SUM_ADDR = -4080,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_CP_ADDR = -4081,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MDAD_ADDR = -4082,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MNAD_ADDR = -4083,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_SORTED_OBSERV_ADDR = -4084,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_INDICES_NOT_SUPPORTED = -4085,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_ROBCOV_INTERN_C1 = -5000,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_PARTIALCOV_INTERN_C1 = -5010,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_PARTIALCOV_INTERN_C2 = -5011,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MISSINGVALS_INTERN_C1 = -5021,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MISSINGVALS_INTERN_C2 = -5022,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MISSINGVALS_INTERN_C3 = -5023,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MISSINGVALS_INTERN_C4 = -5024,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_MISSINGVALS_INTERN_C5 = -5025,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_PARAMTRCOR_INTERN_C1 = -5030,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_COVRANK_INTERNAL_ERROR_C1 = -5040,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_INVCOV_INTERNAL_ERROR_C1 = -5041,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_INVCOV_INTERNAL_ERROR_C2 = -5042,

    }

    public static class VslCodeX
    {
        [MethodImpl(Inline)]
        public static bool IsError(this VslRngStatus status)
            => status != VslRngStatus.VSL_ERROR_OK;

        [MethodImpl(Inline)]
        public static bool ThrowOnError(this VslRngStatus status)
            =>!status.IsError() ? false : throw new Exception($"VSL Error Code {status}");

    }
}