//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;
	using System.Linq;

    /// <summary>
    /// SS routines provide computation of basic statistical estimates
    /// (central/raw moments up to 4th order, variance-covariance,
    ///  minimum, maximum, skewness/kurtosis) using the following methods
    /// </summary>
    [Flags]
    enum VslSSComputeMethod : int
    {
        /// <summary>
        /// Estimates are computed for price of one or two passes over observations using highly optimized Intel(R) MKL routines
        /// </summary>
        [MklCode("Estimates are computed for price of one or two passes over observations using highly optimized Intel(R) MKL routines")]
        VSL_SS_METHOD_FAST = 0x00000001,

        /// <summary>
        /// Estimate is computed for price of one pass of the observations
        /// </summary>
        [MklCode("Estimate is computed for price of one pass of the observations")]
        VSL_SS_METHOD_1PASS = 0x00000002,

        /// <summary>
        /// Estimates are computed for price of one or two passes over observations given user defined mean for central moments, covariance and correlation
        /// </summary>
        [MklCode("Estimates are computed for price of one or two passes over observations given user defined mean for central moments, covariance and correlation")]
        VSL_SS_METHOD_FAST_USER_MEAN = 0x00000100,

        /// <summary>
        /// Convert cross-product matrix to variance-covariance/correlation matrix 
        /// </summary>
        [MklCode("Convert cross-product matrix to variance-covariance/correlation matrix ")]
        VSL_SS_METHOD_CP_TO_COVCOR = 0x00000200,

        /// <summary>
        /// Convert raw/central sums to raw/central moments
        /// </summary>
        [MklCode("Convert raw/central sums to raw/central moments")]
        VSL_SS_METHOD_SUM_TO_MOM = 0x00000400,

        /// <summary>
        /// Parametrization of correlation matrix using spectral decomposition method
        /// </summary>
        [MklCode("Parametrization of correlation matrix using spectral decomposition method")]
        VSL_SS_METHOD_SD = 0x00000004,

        /// <summary>
        /// Robust estimation of variance-covariance matrix and mean supports Rocke algorithm, TBS-estimator
        /// </summary>
        [MklCode("Robust estimation of variance-covariance matrix and mean supports Rocke algorithm, TBS-estimator")]
        VSL_SS_METHOD_TBS =0x00000008,

        /// <summary>
        /// SS routine for estimation of missing values supports Multiple Imputation (MI) method
        /// </summary>
        [MklCode("SS routine for estimation of missing values supports Multiple Imputation (MI) method")]
        VSL_SS_METHOD_MI = 0x00000010,

        /// <summary>
        /// SS provides routine for detection of outliers, BACON method
        /// </summary>
        [MklCode("SS provides routine for detection of outliers, BACON method")]
        VSL_SS_METHOD_BACON = 0x00000020,

        /// <summary>
        /// Streaming: intermediate estimates of quantiles during processing the next block are computed
        /// </summary>
        [MklCode("Streaming: intermediate estimates of quantiles during processing the next block are computed")]
        VSL_SS_METHOD_SQUANTS_ZW = 0x00000040,

        /// <summary>
        /// Streaming: intermediate estimates of quantiles during processing the next block are not computed
        /// </summary>
        [MklCode("Streaming: intermediate estimates of quantiles during processing the next block are not computed")]
        VSL_SS_METHOD_SQUANTS_ZW_FAST = 0x00000080,

        /// <summary>
        /// Sorting using the radix method
        /// </summary>
        [MklCode("Radix sorting")]
        VSL_SS_METHOD_RADIX = 0x00100000,
    }

}