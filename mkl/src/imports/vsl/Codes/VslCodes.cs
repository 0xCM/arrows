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
    using static VslRngMethod;
            
    public enum VslSSMatrixStorage : int
    {
        /// <summary>
        /// Observation vectors are organized by rows. For example, 10 observations
        /// in dimension 3 will conform to a 10 row 3 column matrix
        /// </summary>
        [MklCode("Observation vectors are organized by rows")]
        VSL_SS_MATRIX_STORAGE_ROWS  =    0x00010000,
        
        /// <summary>
        /// Observation vectors are organized by columns. For example, 10 observations
        /// in dimension 3 will conform to a 3 row by 10 column matrix
        /// </summary>
        [MklCode("Observation vectors are organized by columns")]
        VSL_SS_MATRIX_STORAGE_COLS  =   0x00020000

    }
}