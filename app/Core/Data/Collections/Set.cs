//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using Contracts;


    /// <summary>
    /// Represents the set that contains all potential values of a given type
    /// </summary>
    readonly struct FullSet<T> : Set<T>
    {
        internal static readonly FullSet<T> Inhabitant = default(FullSet<T>);

        public bool contains(T item) => true;
    }



    /// <summary>
    /// Represents the empty set for a given type
    /// </summary>
    public readonly struct EmptySet<X> : Set<X>
    {
        internal static readonly EmptySet<X> Singleton = default(EmptySet<X>);

        public bool contains(X item) => false;
    }

    public static class Set
    {
        public static EmptySet<X> empty<X>() => EmptySet<X>.Singleton;

    }



}