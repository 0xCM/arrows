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

    ///<summary>            
    /// Some multivariate random number generators, e.g. GaussianMV, operate
    /// with matrix parameters. To optimize matrix parameters usage VSL offers
    /// following matrix storage schemes. (See VSL documentation for more details).
    ///</summary>
    public enum VslMatrixStorage
    {
        /// <summary>
        /// Whole matrix is stored
        /// </summary>
        [MklCode("Whole matrix is stored")]
        Full =   0,
        
        /// <summary>
        /// Lower/higher triangular matrix is packed in 1-dimensional array
        /// </summary>
        [MklCode("Lower/higher triangular matrix is packed in 1-dimensional array")]
        Packed = 1,

        /// <summary>
        /// Diagonal elements are packed in 1-dimensional array
        /// </summary>
        [MklCode("Diagonal elements are packed in 1-dimensional array")]
        Diagonal = 2

    }
}