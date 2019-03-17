//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;



    /// <summary>
    /// Characterizes an operation provider for bounded floating point values
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface BoundFloat<T> : Bounded<T>, Floating<T>
        where T : new()
    {

    }

    /// <summary>
    /// Characterizes a structure for a bounded floating point number
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface BoundFloat<S,T> : Floating<S,T>, Bounded<S,T>
        where S : BoundFloat<S,T>, new()
        where T : new()

    {
    
    
    }

}