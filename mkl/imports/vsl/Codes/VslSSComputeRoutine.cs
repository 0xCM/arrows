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

    [Flags]
    enum VslSSComputeRoutine : long
    {        
        /// <summary>        
        /// Computes the array of means.
        /// </summary>
        [MklCode("Computes the array of means")]
        VSL_SS_MEAN = 0x0000000000000001,
        
        /// <summary>        
        /// Computes the array of the 2nd order raw moments
        /// </summary>
        [MklCode("Computes the array of the 2nd order raw moments")]
        VSL_SS_2R_MOM = 0x0000000000000002,

        /// <summary>        
        /// Computes the array of the 3rd order raw moments
        /// </summary>
        [MklCode("Computes the array of the 3rd order raw moments")]
        VSL_SS_3R_MOM = 0x0000000000000004,
        
        /// <summary>        
        /// Computes the array of the 4th order raw moments
        /// </summary>
        [MklCode("Computes the array of the 4th order raw moments")]
        VSL_SS_4R_MOM = 0x0000000000000008,
        
        /// <summary>        
        /// Computes the array of central sums of the 2nd order
        /// </summary>
        [MklCode("Computes the array of central sums of the 2nd order")]
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
        [MklCode("Computes the array of sums")]
        VSL_SS_SUM =  0x0000000002000000,
        
        /// <summary>        
        /// Computes the array of raw sums of the 2nd order
        /// </summary>
        [MklCode("Computes the array of raw sums of the 2nd order")]
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
        [MklCode("Computes the array of kurtosis values")]
        VSL_SS_KURTOSIS = 0x0000000000000080,
        
        /// <summary>        
        /// Computes the array of skewness values
        /// </summary>
        [MklCode("")]
        VSL_SS_SKEWNESS = 0x0000000000000100,
        
        /// <summary>        
        /// Computes the array of variation coefficients
        /// </summary>
        [MklCode("Computes the array of variation coefficients")]
        VSL_SS_VARIATION = 0x0000000000000200,
        
        /// <summary>        
        /// For each dimension, finds the minimum sample value
        /// </summary>
        [MklCode("For each dimension, finds the minimum sample value")]
        VSL_SS_MIN =  0x0000000000000400, 
        
        /// <summary>        
        /// For each dimension, finds the maximum sample value
        /// </summary>
        [MklCode("For each dimension, finds the maximum sample value")]
        VSL_SS_MAX =  0x0000000000000800,
        
        /// <summary>        
        /// Computes a covariance matrix.
        /// </summary>
        [MklCode("Computes a covariance matrix")]
        VSL_SS_COV =  0x0000000000001000,
        
        /// <summary>        
        /// Computes a correlation matrix. The main diagonal of the correlation matrix holds 
        /// variances of the random vector components
        /// </summary>
        [MklCode("Computes a correlation matrix")]
        VSL_SS_COR =  0x0000000000002000,
        
        /// <summary>        
        /// Computes a cross-product matrix
        /// </summary>
        [MklCode("Computes a cross-product matrix")]
        VSL_SS_CP =   0x0000000100000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_POOLED_COV = 0x0000000000004000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_GROUP_COV = 0x0000000000008000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_POOLED_MEAN = 0x0000000800000000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_GROUP_MEAN = 0x0000001000000000,
        
        /// <summary>        
        /// Computes quantiles
        /// </summary>
        [MklCode("")]
        VSL_SS_QUANTS = 0x0000000000010000,
        
        /// <summary>        
        /// Computes order statistics
        /// </summary>
        [MklCode("")]
        VSL_SS_ORDER_STATS = 0x0000000000020000,
        
        /// <summary>        
        ///
        /// </summary>
        [MklCode("")]
        VSL_SS_SORTED_OBSERV = 0x0000008000000000,
        
        /// <summary>        
        /// Computes a robust covariance matrix
        /// </summary>
        [MklCode("")]
        VSL_SS_ROBUST_COV = 0x0000000000040000,
        
        /// <summary>        
        /// Detects outliers in the dataset
        /// </summary>
        [MklCode("")]
        VSL_SS_OUTLIERS = 0x0000000000080000,
        
        /// <summary>        
        /// Computes a partial covariance matrix.
        /// </summary>
        [MklCode("")]
        VSL_SS_PARTIAL_COV = 0x0000000000100000,
        
        /// <summary>        
        /// Computes a partial correlation matrix
        /// </summary>
        [MklCode("Computes a partial correlation ")]
        VSL_SS_PARTIAL_COR = 0x0000000000200000,
        
        /// <summary>        
        /// Supports missing values in datasets.
        /// </summary>
        [MklCode("Supports missing values in datasets.")]
        VSL_SS_MISSING_VALS = 0x0000000000400000,
        
        /// <summary>        
        /// Computes a parameterized correlation matrix.
        /// </summary>
        [MklCode("Computes a parameterized correlation matrix.")]
        VSL_SS_PARAMTR_COR = 0x0000000000800000,
        
        /// <summary>        
        /// Computes quantiles for streaming data.
        /// </summary>
        [MklCode("Computes quantiles for streaming data.")]
        VSL_SS_STREAM_QUANTS = 0x0000000001000000,
        
        /// <summary>        
        /// Computes median absolute deviation
        /// </summary>
        [MklCode("Computes median absolute deviation")]
        VSL_SS_MDAD = 0x0000000200000000,
        
        /// <summary>        
        /// Computes mean absolute deviation
        /// </summary>
        [MklCode("Computes mean absolute deviation")]
        VSL_SS_MNAD = 0x0000000400000000,

   }    
}