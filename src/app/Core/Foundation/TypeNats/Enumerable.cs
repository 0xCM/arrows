//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Collections;


    /// <summary>
    /// Characterizes an enumerable with a known length as specified
    /// by a natural type parameter
    /// </summary>
    public interface Enumerable<N,I> : IEnumerable<I>
        where N : TypeNat
    {
        /// <summary>
        /// The value of the natural parameter
        /// </summary>
        int length {get;}
        
    }


}