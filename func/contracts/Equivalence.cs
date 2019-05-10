//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    /// <summary>
    ///  Characterizes a reflexive, symmetric and transitive binary relation over a set
    ///  that, consequently, effects a partition on said set
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
    public interface IEquivalenceOps<T> : IReflexiveOps<T>, ISymmetricOps<T>, ITransitiveOps<T> { }

    public interface IEquivalenceClass<T>
    {
        T representative {get;}
    }


    /// <summary>
    /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
    /// an equivalence relation
    /// </summary>
    /// <typeparam name="T">The classified type</typeparam>
    public interface IEquivalenceClass<S,T> : ISemigroup<S,T>, IEquivalenceClass<T>, INonempySet<S>
        where S : IEquivalenceClass<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a constructive equivalence class, i.e. an equivalence class 
    /// with enumerable content
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    public interface IDiscreteEqivalenceClass<S,T> : IEquivalenceClass<S,T>, IDiscreteSet<S,T> 
        where S : IDiscreteEqivalenceClass<S,T>, new() { }

    /// <summary>
    /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
    /// an equivalence relation
    /// </summary>
    /// <typeparam name="T">The classified type</typeparam>
    public interface IFiniteEquivalenceClass<S,T> : IDiscreteEqivalenceClass<S,T>//, FiniteSet<S,T> 
        where S : IFiniteEquivalenceClass<S,T>, new()
    { }


}