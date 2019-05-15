//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IListed<S> : INullary<S>, IReversible<S>, ILengthwise<S>
        where S : IListed<S>, new()
    {
        /// <summary>
        /// Returns the elements following the head, if any; otherwise, returns the zero element of S
        /// </summary>
        S tail();

    }

    public interface IListed<S,T> : IListed<S>
        where S : IListed<S,T>, new()
        where T : struct, IMonoidA<T>
    {
        /// <summary>
        /// Returns the first constituent if it exits; otherwise, the zero element of T
        /// </summary>
        T head();

        /// <summary>
        /// Returns the last constituent if it exits; otherwise, the zero element of T
        /// </summary>
        T last();

        /// <summary>
        /// Replaces the existing list with a new list with specified content
        /// </summary>
        /// <param name="src"></param>
        S redefine(IEnumerable<T> src);
    }
}