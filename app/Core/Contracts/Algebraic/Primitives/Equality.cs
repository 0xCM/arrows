//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;


    public interface Equatable<T>
    {
        bool eq(T lhs, T rhs);

        bool neq(T lhs, T rhs);
    }

    public interface Equatable<S,T>
        where S : Equatable<S,T>, new()
    {
        bool eq(S rhs);

        bool neq(S rhs);
    }

}