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
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot<N>(Vector<N,float> x, Vector<N,float> y)
            where N : ITypeNat, new()
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors of natural length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot<N>(Vector<N,double> x, Vector<N,double> y)
            where N : ITypeNat, new()
                => dot(x.Unsized, y.Unsized);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static float dot(Vector<float> x, Vector<float> y)
            => dot(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Computes the scalar product between two vectors that are hopefully of the same length
        /// </summary>
        /// <param name="X">The left vector</param>
        /// <param name="Y">The right vector</param>
        [MethodImpl(Inline)]
        public static double dot(Vector<double> x, Vector<double> y)
            => dot(x.Unblocked, y.Unblocked);

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

        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Vector<float> X)        
            => CBLAS.cblas_sasum(X.Length, ref head(X), 1);
        
        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="X">A span containing the vector components</param>
        [MethodImpl(Inline)]
        public static double asum(Vector<double> X)        
            => CBLAS.cblas_dasum(X.Length, ref head(X), 1);


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

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float norm(Vector<float> X)        
            => CBLAS.cblas_snrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double norm(Vector<double> X)        
            => CBLAS.cblas_dnrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Scales a source vector in-place, X = aX
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scal(float a, Vector<float> X)        
            => CBLAS.cblas_sscal(X.Length, a, ref head(X), 1);

        /// <summary>
        /// Scales a source vector in-place, X = aX
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scal(double a, Vector<double> X)        
            => CBLAS.cblas_dscal(X.Length, a, ref head(X), 1);
    }

}