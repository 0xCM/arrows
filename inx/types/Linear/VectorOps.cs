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
    }

}