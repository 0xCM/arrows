//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;

    partial class Class
    {
        public interface Decrementable<T>
        {
            T dec(T x);        
        }

        public interface Decrementable<S,T> : Structure<S,T>
            where S : Decrementable<S,T>, new()
        {
            S dec();
        }

        public interface Incrementable<T>
        {
            T inc(T x);        
        }

        public interface Incrementable<S,T> : Structure<S,T>
            where S : Incrementable<S,T>, new()
        {
            S inc();        
        }


        /// <summary>
        /// Characterizes a type that realizes both incrementing and decrementing operations
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        public interface Stepwise<T> : Incrementable<T>, Decrementable<T>
        {
            
        }

       /// <summary>
        /// Characterizes a structure over which both incrementing and decrementing 
        /// operations are defined
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface Stepwise<S,T> : Incrementable<S,T>, Decrementable<S,T>
            where S : Stepwise<S,T>, new()
        {

        }

    }
}