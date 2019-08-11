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
    using static nfunc;

    partial class mkl
    {
        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(Vector<float> X)        
            => (int)CBLAS.cblas_isamin(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amin(Vector<float> X)        
            => X[iamin(X)];

        /// <summary>
        /// Returns the index of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(Vector<double> X)        
            => (int)CBLAS.cblas_idamin(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amin(Vector<double> X)        
            => X[iamin(X)];


    }

}