//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    public interface Divisive<T>
    {
        T mod(T lhs, T rhs);

        T div(T lhs, T rhs);        
    }

    public interface Divisive<S,T>
        where S : Divisive<S,T>, new()
    {

        S mod(S rhs);

        S div(S rhs);        
    }

    public interface IntDiv<T> : Divisive<T>
    {

        QR<T> divrem(T lhs, T rhs);        
    }

    public interface IntDiv<S,T> : Divisive<S,T>
        where S : IntDiv<S,T>, new()
    {
        QR<S> divrem(S rhs);        

    }

}