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
        public static Vector<N,T> Add<N,T>(Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            if(typeof(T) == typeof(float))
                mkl.add(float32(lhs.Unsized), float32(rhs.Unsized), float32(lhs.Unsized));
            else if(typeof(T) == typeof(double))
                mkl.add(float64(lhs.Unsized), float64(rhs.Unsized), float64(lhs.Unsized));
            else
                gmath.add(lhs.Unsized, rhs.Unsized);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> Add<N,T>(Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
            => lhs.Transpose().Add(rhs.Transpose()).Transpose();


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