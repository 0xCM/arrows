//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    partial class Operative
    {
        public interface Decrementable<T> : Ordered<T>
        {
            T dec(T x);        
        }

        public interface Incrementable<T> : Ordered<T>
        {
            T inc(T x);        
        }



        /// <summary>
        /// Characterizes a type that realizes both incrementing and decrementing operations
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        public interface Stepwise<T> : Incrementable<T>, Decrementable<T>
        {
            
        }

    }

    partial class Structures
    {
        public interface Decrementable<S> : Ordered<S>
            where S : Decrementable<S>, new()
        {
            S dec();
        }

        public interface Incrementable<S> : Ordered<S>
            where S : Incrementable<S>, new()
        {
            S inc();        
        }

        /// <summary>
        /// Characterizes a structure over which both incrementing and decrementing 
        /// operations are defined
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Stepwise<S> : Incrementable<S>, Decrementable<S>
            where S : Stepwise<S>, new()
        {

        }
        
    }
}