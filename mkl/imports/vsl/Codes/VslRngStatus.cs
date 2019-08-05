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

    public enum VslRngStatus
    {
        [MklCode("")]
        VSL_ERROR_OK = 0,

        [MklCode("")]
        VSL_ERROR_MEM_FAILURE  = -4,

        [MklCode("")]
        VSL_RNG_ERROR_INVALID_BRNG_INDEX = - 1000,
    
        [MklCode("")]
        VSL_RNG_ERROR_LEAPFROG_UNSUPPORTED = - 1002,
    
        [MklCode("")]
        VSL_RNG_ERROR_SKIPAHEAD_UNSUPPORTED = - 1003,
    
        [MklCode("")]
        VSL_RNG_ERROR_BRNGS_INCOMPATIBLE = - 1005,
    
        [MklCode("")]
        VSL_RNG_ERROR_BAD_STREAM = - 1006,
    
        [MklCode("")]
        VSL_RNG_ERROR_BRNG_TABLE_FULL    = - 1007,
    
        [MklCode("")]
        VSL_RNG_ERROR_BAD_STREAM_STATE_SIZE     = - 1008,
    
        [MklCode("")]
        VSL_RNG_ERROR_BAD_WORD_SIZE = - 1009,
    
        [MklCode("")]
        VSL_RNG_ERROR_BAD_NSEEDS = - 1010,
    
        [MklCode("")]
        VSL_RNG_ERROR_BAD_NBITS = - 1011,
    
        [MklCode("")]
        VSL_RNG_ERROR_QRNG_PERIOD_ELAPSED = - 1012,
    
        [MklCode("")]
        VSL_RNG_ERROR_LEAPFROG_NSTREAMS_TOO_BIG = - 1013,
    
        [MklCode("")]
        VSL_RNG_ERROR_BRNG_NOT_SUPPORTED = - 1014,

        /* abstract stream related errors */
        [MklCode("")]
        VSL_RNG_ERROR_BAD_UPDATE = - 1120,
        
        [MklCode("")]
        VSL_RNG_ERROR_NO_NUMBERS = - 1121,
        
        [MklCode("")]
        VSL_RNG_ERROR_INVALID_ABSTRACT_STREAM = - 1122,

        /* non determenistic stream related errors */
        [MklCode("")]
        VSL_RNG_ERROR_NONDETERM_NOT_SUPPORTED     = - 1130,

        [MklCode("")]
        VSL_RNG_ERROR_NONDETERM_NRETRIES_EXCEEDED = - 1131,

        /* ARS5 stream related errors */
        [MklCode("")]
        VSL_RNG_ERROR_ARS5_NOT_SUPPORTED        = - 1140,

        /* Multinomial distribution probability array related errors */
        [MklCode("")]
        VSL_DISTR_MULTINOMIAL_BAD_PROBABILITY_ARRAY    = - 1150,

        /* read/write stream to file errors */
        [MklCode("")]
        VSL_RNG_ERROR_FILE_CLOSE = - 1100,
        
        [MklCode("")]
        VSL_RNG_ERROR_FILE_OPEN = - 1101,
        
        [MklCode("")]
        VSL_RNG_ERROR_FILE_WRITE = - 1102,
        
        [MklCode("")]
        VSL_RNG_ERROR_FILE_READ = - 1103,

        [MklCode("")]
        VSL_RNG_ERROR_BAD_FILE_FORMAT = - 1110,
        
        [MklCode("")]
        VSL_RNG_ERROR_UNSUPPORTED_FILE_VER = - 1111,

        [MklCode("")]
        VSL_RNG_ERROR_BAD_MEM_FORMAT = - 1200
    }
}