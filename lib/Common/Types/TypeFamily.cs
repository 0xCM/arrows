//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes any type family
    /// </summary>
    public interface ITypeFamily
    {

    }

    /// <summary>
    /// Characterizes a type family with domain A and codomain U. This models
    /// a collection of types indexed by A-values, typically denoted by
    /// B:A->U where B is understood to be a type that **depends** on a value
    /// of A.
    /// </summary>
    /// <typeparam name="A">The domain</typeparam>
    /// <typeparam name="U">The codomain</typeparam>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
    /// & https://en.wikipedia.org/wiki/Dependent_type
    /// </remarks>
    public interface ITypeFamily<in A, out U> : ITypeFamily, IRule<A,U>
        where U : IUniverse
    {

    }

    /// <summary>
    /// Characterizes a constant type family
    /// </summary>
    /// <typeparam name="A">The domain</typeparam>
    /// <typeparam name="B">A distinguished element of U</typeparam>
    /// <typeparam name="U">The universe containing B</typeparam>
    public interface ITypeFamily<in A, out B, U> : ITypeFamily<A,U>
        where U : IUniverse
    {


    }


    /// <summary>
    /// Characterizes a function that ranges over values of a type A ∈ 𝒰 and
    /// yields values (types) in 𝒰
    /// </summary>
    /// <typeparam name="A">The function domain type</typeparam>
    /// <typeparam name="U">The universal codomain</typeparam>
    /// <remarks>
    /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=37
    /// </remarks>
    public interface IDependentFunction<A,U> : IRule<A,U>
        where U : IUniverse
    {

        ITypeFamily<A,U> B {get;}
    }

}