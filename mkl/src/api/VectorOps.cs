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

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> Add<N,T>(in BlockVector<N,T> x, in BlockVector<N,T> y, ref BlockVector<N,T> z)
            where N : ITypeNat, new()
            where T : struct    
        {
            if(typeof(T) == typeof(float))
            {
                var dst = z.As<float>();
                mkl.add(x.As<float>(), y.As<float>(), ref dst);
            }
            else if(typeof(T) == typeof(double))
            {
                var dst = z.As<double>();
                mkl.add(x.As<double>(), y.As<double>(), ref dst);
            }
            else
                throw unsupported<T>();

            return ref z;
        }


        [MethodImpl(Inline)]
        public static T Dot<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(mkl.dot(x.As<float>(), y.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(mkl.dot(x.As<double>(), y.As<double>()));
            else
                return mathspan.dot<T>(x.Unsized, y.Unsized);                
        }


        
    }

}