//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    /// <summary>
    /// Characterizes free moinoidial operations
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid 
    /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
    public interface IFreeMonoidOps<T> : IMonoidOps<T>, IConcatenableOps<T>
    {
        T empty {get;}

    }

    /// <summary>
    /// Characterizes a free monoidal structure
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public interface IFreeMonoid<S> :  IMonoid<S>, IConcatenable<S>, ILengthwise<S>, INullary<S>
        where S : IFreeMonoid<S>, new()
    {

    }


}