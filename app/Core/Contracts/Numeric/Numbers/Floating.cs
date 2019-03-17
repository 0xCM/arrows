//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Characterizes an operation provider for floating point values
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface Floating<T> : Fractional<T>,  Trigonmetric<T>
        where T : new()
    {
        IEnumerable<T> partition(T min, T max,T width = default(T)); 
    }


    /// <summary>
    /// Characterizes a structure for a floating point number
    /// </summary>
    /// <typeparam name="T">The underlying numeric type</typeparam>
    public interface Floating<S,T> : Fractional<S,T>, Signed<S,T>, Ordered<S,T>
        where S : Floating<S,T>, new()
        where T : new()

    {
    
    
    }

}