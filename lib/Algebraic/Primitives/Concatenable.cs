//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Operative;

    public interface IConcatenableOps<T>
    {
        T concat(T lhs, T rhs);
    }

    public interface IConcatenable<S> 
        where S : IConcatenable<S>, new()
    {
        S concat(S rhs);
    }

    public interface IConcatenable<S,T> : IConcatenable<S>
        where S : IConcatenable<S,T>, new()
    {

    }

}