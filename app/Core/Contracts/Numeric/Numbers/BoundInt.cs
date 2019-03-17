//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;

    public interface BoundInt<T> : Integer<T>, Bounded<T>
        where T:new()
    {

    }


   /// <summary>
   /// Characterizes a structure over a bounded integral type
   /// </summary>
    public interface BoundInt<S,T> : Integer<S,T>, Bounded<S,T>
        where S : BoundInt<S,T>, new()
        where T : new()
    {

    }


}