//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a preorder, i.e. a reflexive and transitive
    /// binary relation over its domain
    /// </summary>
    /// <typeparam name="T">The preorder domain</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Preorder </remarks>
    public interface IPreorderOps<T> : IReflexiveOps<T>, ITransitiveOps<T>            
    {

    }        


    /// <summary>
    /// Characterizes a set equipped with a preorder
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Preorder </remarks>
    public interface IProsetOps<T> : IPreorderOps<T>
        where T : IEquatable<T>

    {

    }

}