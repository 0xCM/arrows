//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;
    using static As;
    using Z0.Mkl;

    public static class VectorOps
    {             
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(ref Vector<N,T> x, in Vector<N,T> y)
            where N : ITypeNat, new()
            where T : struct    
        {
            ginx.add<T>(x,y,x);
            return ref x;
        }

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(in Vector<N,T> x, in Vector<N,T> y, ref Vector<N,T> z)
            where N : ITypeNat, new()
            where T : struct    
        {
            if(typeof(T) == typeof(float))
                mkl.add(float32(x.Unsized), float32(y.Unsized), float32(z.Unsized));
            else if(typeof(T) == typeof(double))
                mkl.add(float64(x.Unsized), float64(y.Unsized), float64(z.Unsized));
            else
                ginx.add<T>(x,y,z);
            return ref z;
        }


        [MethodImpl(Inline)]
        public static T Dot<N,T>(Vector<N,T> x, Vector<N,T> y)
            where N : ITypeNat, new()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(mkl.dot(float32(x.Unsized), float32(y.Unsized)));
            else if(typeof(T) == typeof(double))
                return generic<T>(mkl.dot(float64(x.Unsized), float64(y.Unsized)));
            else
                return gmath.dot<T>(x.Unsized, y.Unsized);                
        }


        [MethodImpl(Inline)]
        public static Covector<N,T> Add<N,T>(Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => lhs.Transpose().Add(rhs.Transpose()).Transpose();


    }

}