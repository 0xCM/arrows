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
        public static int iamax(Vector<float> X)        
            => (int)CBLAS.cblas_isamax(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amax(Vector<float> X)        
            => X[iamax(X)];

        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamax(Vector<double> X)        
            => (int)CBLAS.cblas_idamax(X.Length, ref head(X), 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amax(Vector<double> X)        
            => X[iamax(X)];


    }

}