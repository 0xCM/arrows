//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;

    /// <summary>
    /// Characterizes structural equality
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    public interface Equatable<S> : Hashable<S> 
        where S : Equatable<S>, new()
    {

        bool eq(S rhs);

        bool neq(S rhs);
    }
}