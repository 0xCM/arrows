//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Collections;


    /// <summary>
    /// Characterizes a structured enumerable
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="I">The individual type</typeparam>
    public interface Enumerable<S,I> : IEnumerable<I>
        where S:new()
    {
        S redefine(IEnumerable<I> src);
    }


}