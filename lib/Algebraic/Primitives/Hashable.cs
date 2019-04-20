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
    /// Characterizes types whose hash codes can be obtained without
    /// a virtual function call
    /// </summary>
    /// <typeparam name="S"></typeparam>
    public interface Hashable<S> : IEquatable<S>
        where S : Hashable<S>, new()
    {
        /// <summary>
        /// Computes the hashcode for the instance
        /// </summary>
        int hash();
        
    }
}