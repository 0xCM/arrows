//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a fixed-lenth sequence of elements
    /// </summary>
    /// <typeparam name="N">The natural number type that indicates the slice length</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public interface Slice<N,T> : IReadOnlyList<T>
        where N : TypeNat
    {
        int length {get;}

    }
    
    public interface Vector<N,T> : Slice<N,T>
        where N : TypeNat
    {
        
    }

    public interface Covector<T,N> : Slice<N,T>
        where N : TypeNat
    {
        
    }



}