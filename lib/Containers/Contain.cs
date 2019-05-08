//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;


    /// <summary>
    /// Characterizes a reified container
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    public interface IContainer<S>
        where S : IContainer<S>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a reified container parametrized by the contained type
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IContainer<S,T> : IContainer<S>
        where S : IContainer<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface INonempySet<T> 
        where T : INonempySet<T>, new()
    {

    }

    /// <summary>
    /// Characterizes a set that contains at least one individual
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface NonempySet<S,T> : INonempySet<S>
        where S : NonempySet<S,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a set that, if nonempty, contains elements of unknown type
    /// </summary>
    public interface IMathSet
    {
        /// <summary>
        /// Specifies whether the set is void of elements
        /// </summary>
        /// <value></value>
        bool empty {get;}

        /// <summary>
        /// Specifies whether the set is finite
        /// </summary>
        bool finite {get;}

        /// <summary>
        /// Specifies whether the set is discrete
        /// </summary>
        bool discrete {get;}

        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member to check</param>
        bool member(object candidate);
    }

    /// <summary>
    /// Characterizes a set that, if nonempty, contains elements of specific type
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IMathSet<T> : IMathSet
    {
    }


    /// <summary>
    /// Characterizes a reified set
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IMathSet<S,T> : IMathSet<T>, IContainer<S,T>
        where S : IMathSet<S,T>, new()
    {
        /// <summary>
        /// Determines whether a supplied value is a member of the reified set
        /// </summary>
        /// <param name="candidate">The potential member to check</param>
        bool member(T candidate);
    
    }

    /// <summary>
    /// Characterizes a container that comprises discrete content
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface IDiscreteContainer<S,T> : IContainer<S,T>
        where S : IDiscreteContainer<S,T>, new()
    {
        IEnumerable<T> content {get;}
    }

    /// <summary>
    /// Characterizes a concatenable container with discrete content 
    /// </summary>
    /// <typeparam name="S">The container type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISeq<S,T> : IDiscreteContainer<S,T>, IConcatenable<S,T>
        where S : ISeq<S,T>, new()
    {
        
    }

    /// <summary>
    /// Characterizes a container of semigroup elements which is, itself, a semigroup
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The contained type</typeparam>
    public interface ISemiSeq<S,T> : ISeq<S,T>, Structures.ISemigroup<S>
        where S : ISemiSeq<S,T>, new()
        where T : Structures.ISemigroup<T>, new()
    {

    }

    public interface IFiniteContainer<S,T> : IDiscreteContainer<S,T>
        where S : IFiniteContainer<S,T>, new()
    {
        /// <summary>
        /// The count providing evidence that the content is finite
        /// </summary>
        uint count {get;}
    }

    /// <summary>
    /// Characterizes an enumerable with a known length as specified
    /// by a natural type parameter
    /// </summary>
    public interface IEnumerable<N,I> : IEnumerable<I>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// The value of the natural parameter
        /// </summary>
        uint length {get;}
    }

    public interface IArray<N,T> : IEnumerable<N,T>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// Specifies or retrieves an array value via an unchecked index
        /// </summary>
        ref T this[int ix] {get;}
    }

    /// <summary>
    /// Characterizes a set indexed by another set
    /// </summary>
    /// <typeparam name="I">The indexing set</typeparam>
    /// <typeparam name="X">The indexed set</typeparam>
    public interface IIndex<I,T> : IDiscreteContainer<I,KeyedValue<I,T>>
        where I : IIndex<I,T>, new()
    {
        /// <summary>
        /// Retrives an indexed value
        /// </summary>
        /// <param name="index">The index value</param>
        /// <returns>The indexed value</returns>
        T item(I index);

        /// <summary>
        /// Retrives an indexed value via an index operator
        /// </summary>
        /// <param name="index">The index value</param>
        /// <returns>The indexed value</returns>
        T  this[I ix] {get;}
    }

    /// <summary>
    /// Characteriizes a reified set for which there are a countable number of members
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<S,T> : IMathSet<S,T>, IDiscreteContainer<S,T>
        where S: IDiscreteSet<S,T>, new()
    {

    }

    /// <summary>
    /// Characterizes a type that represents an infinite number of values
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface IInfiniteSet<S>
        where S : IInfiniteSet<S>, new()
    {

    }

    /// <summary>
    /// Characterizes a type that represents an infinite number of values
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface IInfiniteSet<S,T> : IInfiniteSet<S>, IMathSet<S,T>
        where S : IInfiniteSet<S,T>, new()
    {

    }


    public interface IFixedContainer<S,T> : Structures.IImplicitSemigroup<S,T>
        where S : IFixedContainer<S,T>, new()
        where T : struct, IEquatable<T>
    {
        
    }
    
    public interface IFixedContainer<S,C,T> : IContainer<S>, IFixedContainer<S,T>
        where S : IFixedContainer<S,C,T>, new()
        where T : struct, IEquatable<T>
    {
        C release();
    }

}