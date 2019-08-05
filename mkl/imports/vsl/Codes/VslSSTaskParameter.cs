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

    enum VslSSTaskParameter
    {
        /// <summary>
        /// Address of a variable that holds the task dimension
        /// </summary>
        [MklCode("Address of a variable that holds the task dimension")]
        VSL_SS_ED_DIMEN = 1,

        /// <summary>
        /// Address of a variable that holds the number of observations
        /// </summary>
        [MklCode("Address of a variable that holds the number of observations")]
        VSL_SS_ED_OBSERV_N = 2,

        /// <summary>
        /// Address of the observation matrix
        /// </summary>
        [MklCode("Address of the observation matrix")]
        VSL_SS_ED_OBSERV = 3,

        /// <summary>
        /// Address of a variable that holds the storage format for the observation matrix
        /// </summary>
        [MklCode("Address of a variable that holds the storage format for the observation matrix")]
        VSL_SS_ED_OBSERV_STORAGE = 4,

        /// <summary>
        /// Address of the array of indices
        /// </summary>
        [MklCode("Address of the array of indices")]
        VSL_SS_ED_INDC = 5,

        /// <summary>
        /// Address of the array of observation weights
        /// </summary>
        [MklCode("Address of the array of observation weights")]
        VSL_SS_ED_WEIGHTS = 6,
        
        /// <summary>
        /// Address of the array of means
        /// </summary>
        [MklCode("Address of the array of means")]
        VSL_SS_ED_MEAN = 7,
        
        /// <summary>
        /// Address of an array of raw moments of the second order
        /// </summary>
        [MklCode("Address of an array of raw moments of the second order")]
        VSL_SS_ED_2R_MOM = 8,
        
        /// <summary>
        /// Address of an array of raw moments of the third order
        /// </summary>
        [MklCode("Address of an array of raw moments of the third order")]
        VSL_SS_ED_3R_MOM = 9,
        
        /// <summary>
        /// Address of an array of raw moments of the fourth order
        /// </summary>
        [MklCode("Address of an array of raw moments of the fourth order")]
        VSL_SS_ED_4R_MOM = 10,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_2C_MOM = 11,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_3C_MOM = 12,
                
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_4C_MOM = 13,
        
        /// <summary>
        /// Address of array of sums
        /// </summary>
        [MklCode("Address of array of sums")]
        VSL_SS_ED_SUM = 67,
        
        /// <summary>
        /// Address of array of raw sums of 2nd order
        /// </summary>
        [MklCode("Address of array of raw sums of 2nd order")]
        VSL_SS_ED_2R_SUM = 68,
        
        /// <summary>
        /// Address of array of raw sums of 3rd order
        /// </summary>
        [MklCode("Address of array of raw sums of 3rd order")]
        VSL_SS_ED_3R_SUM = 69,
        
        /// <summary>
        /// Address of array of raw sums of 4th order
        /// </summary>
        [MklCode("Address of array of raw sums of 4th order")]
        VSL_SS_ED_4R_SUM = 70,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_2C_SUM = 71,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_3C_SUM = 72,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_4C_SUM = 73,
        
        /// <summary>
        /// Address of the array of kurtosis estimates
        /// </summary>
        [MklCode("Address of the array of kurtosis estimates")]
        VSL_SS_ED_KURTOSIS = 14,
        
        /// <summary>
        /// Address of the array of skewness estimates
        /// </summary>
        [MklCode("Address of the array of skewness estimates")]
        VSL_SS_ED_SKEWNESS = 15,
        
        /// <summary>
        /// Address of the array of minimum estimates
        /// </summary>
        [MklCode("Address of the array of minimum estimates")]
        VSL_SS_ED_MIN = 16,
        
        /// <summary>
        /// Address of the array of maximum estimates
        /// </summary>
        [MklCode("Address of the array of maximum estimates")]
        VSL_SS_ED_MAX = 17,

        /// <summary>
        /// Address of the array of variation coefficients
        /// </summary>
        [MklCode("Address of the array of variation coefficients")]
        VSL_SS_ED_VARIATION = 18,
        
        /// <summary>
        /// Address of a covariance matrix
        /// </summary>
        [MklCode("Address of a covariance matrix")]
        VSL_SS_ED_COV = 19,
        
        /// <summary>
        /// Address of the variable that holds the storage format for a covariance matrix
        /// </summary>
        [MklCode("Address of the variable that holds the storage format for a covariance matrix")]
        VSL_SS_ED_COV_STORAGE = 20,
        
        /// <summary>
        /// Address of a correlation matrix 
        /// </summary>
        [MklCode("Address of a correlation matrix")]
        VSL_SS_ED_COR = 21,
        
        /// <summary>
        /// Address of the variable that holds the storage format for a correlation matrix
        /// </summary>
        [MklCode("Address of the variable that holds the storage format for a correlation matrix")]
        VSL_SS_ED_COR_STORAGE = 22,
        
        /// <summary>
        /// Address of cross-product matrix
        /// </summary>
        [MklCode("Address of cross-product matrix")]
        VSL_SS_ED_CP = 74,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_CP_STORAGE = 75,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ACCUM_WEIGHT = 23,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_QUANT_ORDER_N = 24,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_QUANT_ORDER = 25,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_QUANT_QUANTILES = 26,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ORDER_STATS = 27,
        
        [MklCode("")]
        VSL_SS_ED_GROUP_INDC = 28,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_POOLED_COV_STORAGE = 29,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_POOLED_MEAN = 30,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_POOLED_COV = 31,
        
        /// <summary>
        /// Address of an array of indices for which covariance/means should be computed
        /// </summary>
        [MklCode("Address of an array of indices for which covariance/means should be computed")]
        VSL_SS_ED_GROUP_COV_INDC = 32,

        /// <summary>
        /// Address of an array of indices for which group estimates such as covariance or means are requested
        /// </summary>
        [MklCode("Address of an array of indices for which group estimates such as covariance or means are requested")]
        VSL_SS_ED_REQ_GROUP_INDC = 32,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_GROUP_MEAN = 33,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_GROUP_COV_STORAGE = 34,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_GROUP_COV = 35,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ROBUST_COV_STORAGE = 36,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ROBUST_COV_PARAMS_N = 37,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ROBUST_COV_PARAMS = 38,
        
        /// <summary>
        /// Address of an array of robust means
        /// </summary>
        [MklCode("Address of an array of robust means")]
        VSL_SS_ED_ROBUST_MEAN = 39,
        
        /// <summary>
        /// Address of a robust covariance matrix
        /// </summary>
        [MklCode("Address of a robust covariance matrix")]
        VSL_SS_ED_ROBUST_COV = 40,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_OUTLIERS_PARAMS_N = 41,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_OUTLIERS_PARAMS = 42,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_OUTLIERS_WEIGHT = 43,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_ORDER_STATS_STORAGE = 44,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARTIAL_COV_IDX = 45,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARTIAL_COV = 46,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARTIAL_COV_STORAGE = 47,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARTIAL_COR = 48,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARTIAL_COR_STORAGE = 49,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_PARAMS_N = 50,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_PARAMS = 51,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_INIT_ESTIMATES_N = 52,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_INIT_ESTIMATES = 53,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_SIMUL_VALS_N = 54,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_SIMUL_VALS = 55,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_ESTIMATES_N = 56,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_ESTIMATES = 57,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_PRIOR_N = 58,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MI_PRIOR = 59,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARAMTR_COR = 60,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_PARAMTR_COR_STORAGE = 61,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_STREAM_QUANT_PARAMS_N = 62,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_STREAM_QUANT_PARAMS = 63,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_STREAM_QUANT_ORDER_N = 64,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_STREAM_QUANT_ORDER = 65,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_STREAM_QUANT_QUANTILES = 66,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MDAD = 76,
        
        /// <summary>
        /// 
        /// </summary>
        [MklCode("")]
        VSL_SS_ED_MNAD = 77,
        
        /// <summary>
        /// Address of the array that stores sorted results
        /// </summary>
        [MklCode("Address of the array that stores sorted results")]
        VSL_SS_ED_SORTED_OBSERV = 78,
        
        /// <summary>
        /// Address of a variable that holds the storage format of an output matrix
        /// </summary>
        [MklCode("Address of a variable that holds the storage format of an output matrix")]
        VSL_SS_ED_SORTED_OBSERV_STORAGE = 79,
    }
}