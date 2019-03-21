//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{   
    using System;
    using System.Runtime.CompilerServices;
    
    //using static Class;
    using static corefunc;
    using static Reify;

    public static class Vector
    {
       [MethodImpl(Inline)]
       public static Vector<N,T> add<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat => Slice.add(lhs.cells,rhs.cells);

       [MethodImpl(Inline)]
       public static Vector<N,T> mul<N,T>(Vector<N,T> lhs, Vector<N,T> rhs) 
            where N : TypeNat => Slice.mul(lhs.cells,rhs.cells);

       [MethodImpl(Inline)]
       public static T sum<N,T>(Vector<N,T> x) 
            where N : TypeNat => Slice.sum(x.cells);

    }
}