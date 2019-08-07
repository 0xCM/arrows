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

    public static partial class mkl
    {
        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot(Span<float> X, Span<float> Y)        
            => CBLAS.cblas_sdot(length(X,Y), ref X[0], 1, ref Y[0], 1);

        /// <summary>
        /// Computes the scalar product of the left and right operands
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot(Span<double> X, Span<double> Y)        
            => CBLAS.cblas_ddot(length(X,Y), ref X[0], 1, ref Y[0], 1);

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(float a, Span<float> X, Span<float> Y, Span<float> Z)
        {
            Y.CopyTo(Z);
            CBLAS.cblas_saxpy(length(X,Y), a, ref X[0], 1, ref Z[0], 1);
        }

        /// <summary>
        /// Computes the vector Z = aX + Y
        /// </summary>
        /// <param name="a">A scalar by which the components of X are multiplied</param>
        /// <param name="X">The vector to be scaled</param>
        /// <param name="Y">The vector to be added</param>
        /// <param name="Z">The target vector</param>        
        [MethodImpl(Inline)]
        public static void axpy(double a, Span<double> X, Span<double> Y, Span<double> Z)
        {
            Y.CopyTo(Z);
            CBLAS.cblas_daxpy(length(X,Y), a, ref X[0], 1, ref Z[0], 1);
        }

        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Span<float> X)        
            => CBLAS.cblas_sasum(X.Length, ref X[0], 1);
        
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Span<double> X)        
            => CBLAS.cblas_dasum(X.Length, ref X[0], 1);

        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamax(Span<float> src)        
            => (int)CBLAS.cblas_isamax(src.Length, ref src[0], 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amax(Span<float> X)        
            => X[iamax(X)];

        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamax(Span<double> X)        
            => (int)CBLAS.cblas_idamax(X.Length, ref X[0], 1);

        /// <summary>
        /// Returns the value of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amax(Span<double> X)        
            => X[iamax(X)];

        /// <summary>
        /// Returns the index of the component with maximal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(Span<float> X)        
            => (int)CBLAS.cblas_isamin(X.Length, ref X[0], 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float amin(Span<float> X)        
            => X[iamin(X)];

        /// <summary>
        /// Returns the index of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static int iamin(Span<double> X)        
            => (int)CBLAS.cblas_idamin(X.Length, ref X[0], 1);

        /// <summary>
        /// Returns the value of the component with minimal absolute value
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double amin(Span<double> X)        
            => X[iamin(X)];

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float norm(Span<float> X)        
            => CBLAS.cblas_snrm2(X.Length, ref X[0], 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double norm(Span<double> X)        
            => CBLAS.cblas_dnrm2(X.Length, ref X[0], 1);


        [MethodImpl(Inline)]
        public static float asum(Span<ComplexF32> x)        
            => CBLAS.cblas_scasum(x.Length, ref x[0], 1);

        [MethodImpl(Inline)]
        public static double asum(Span<ComplexF64> x)        
            => CBLAS.cblas_dzasum(x.Length, ref x[0], 1);



    }

}