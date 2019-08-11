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
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy<N>(float a, Vector<N,float> X, Vector<N,float> Y, ref Vector<N,float> Z)
            where N : ITypeNat, new()
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_saxpy(nati<N>(), a, ref head(X), 1, ref head(Z), 1);
        }

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(float a, Vector<float> X, Vector<float> Y, ref Vector<float> Z)
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_saxpy(length(X,Y), a, ref head(X), 1, ref head(Z), 1);
        }

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(double a, Vector<double> X, Vector<double> Y, ref Vector<double> Z)
        {
            Y.CopyTo(ref Z);        
            CBLAS.cblas_daxpy(length(X,Y), a, ref head(X), 1, ref head(Z), 1);
        }


    }

}