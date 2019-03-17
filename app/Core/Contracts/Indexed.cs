//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;

    /// <summary>
    /// Characterizes a set indexed by another set
    /// </summary>
    /// <typeparam name="I">The indexing set</typeparam>
    /// <typeparam name="X">The indexed set</typeparam>
    public interface Indexed<I,X> 
        where I : Set<I>
        where X : Set<X>
    {
        /// <summary>
        /// Retrives an indexed value
        /// </summary>
        /// <param name="index">The index value</param>
        /// <returns>The indexed value</returns>
        X item(I index);
    }


}