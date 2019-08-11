//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    /// <summary>
    /// Defines summary statistic status codes
    /// </summary>
    public enum VslSSStatus
    {
        
        /// <summary>
        /// Everything is OK
        /// </summary>        
        [MklCode("Everything is OK")]
        VSL_SS_OK = VslError.VSL_ERROR_OK,

        /// <summary>
        /// Correlation matrix is not of full rank.
        /// </summary>        
        [MklCode("Correlation matrix is not of full rank.")]
        VSL_SS_NOT_FULL_RANK_MATRIX = 4028,

        /// <summary>
        /// Correlation matrix passed into the parameterization function is semi-definite.
        /// </summary>        
        [MklCode("Correlation matrix passed into the parameterization function is semi-definite.")]
        VSL_SS_SEMIDEFINITE_COR = 4029,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_ALLOCATION_FAILURE = -4000,
        
        /// <summary>
        /// Dimension value is invalid.
        /// </summary>
        [MklCode("Dimension value is invalid.")]
        VSL_SS_ERROR_BAD_DIMEN = -4001,
        
        /// <summary>
        /// Invalid number (zero or negative) of observations was obtained
        /// </summary>
        [MklCode("Invalid number (zero or negative) of observations was obtained")]
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
        [MklCode("")]
        VSL_SS_ERROR_BAD_ROBUST_COV_PARAMS_N_ADDR = -4043,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STORAGE_ADDR = -4044,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_PARTIAL_COV_IDX_ADDR = -4045,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_PARTIAL_COV_ADDR = -4046,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_PARTIAL_COR_ADDR = -4047,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_PARAMS_ADDR = -4048,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_PARAMS_N_ADDR = -4049,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_BAD_PARAMS_N = -4050,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_PARAMS = -4051,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_INIT_ESTIMATES_N_ADDR = -4052,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_INIT_ESTIMATES_ADDR  = -4053,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_ADDR = -4054,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_N_ADDR = -4055,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_ESTIMATES_N_ADDR = -4056,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_ESTIMATES_ADDR = -4057,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_SIMUL_VALS_N = -4058,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_ESTIMATES_N = -4059,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_OUTPUT_PARAMS = -4060,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_PRIOR_N_ADDR = -4061,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_PRIOR_ADDR = -4062,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_MI_MISSING_VALS_N = -4063,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS_N_ADDR = -4064,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
        VSL_SS_ERROR_BAD_STREAM_QUANT_PARAMS_ADDR = -4065,
        
        /// <summary>
        /// 
        /// </summary>        
        [MklCode("")]
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

}