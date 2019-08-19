//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public interface IConcatenableOps<T>
    {
        T Concat(T lhs, T rhs);
    }

    public interface IConcatenable<S> 
        where S : IConcatenable<S>, new()
    {
        S Concat(S rhs);
    }

    public interface IConcatenable<S,T> : IConcatenable<S>
        where S : IConcatenable<S,T>, new()
    {

    }

}