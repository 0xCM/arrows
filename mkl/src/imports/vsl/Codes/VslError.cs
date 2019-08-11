//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;


    public enum VslError 
    {

        [MklCode("Everying is OK")]
        VSL_ERROR_OK = 0,
        
        [MklCode("Feature invoked is not implemented")]
        VSL_ERROR_FEATURE_NOT_IMPLEMENTED = -1,
        
        [MklCode("Unknown error")]
        VSL_ERROR_UNKNOWN = -2,
        
        [MklCode("Input argument value is not valid")]
        VSL_ERROR_BADARGS = -3,
        
        [MklCode("System cannot allocate memory")]
        VSL_ERROR_MEM_FAILURE = -4,
        
        [MklCode("Input pointer argument is NULL.")]
        VSL_ERROR_NULL_PTR = -5,
        
        [MklCode("CPU version is not supported")]
        VSL_ERROR_CPU_NOT_SUPPORTED = -6,
    }



}