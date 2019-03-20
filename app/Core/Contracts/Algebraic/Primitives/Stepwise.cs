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
        public interface Decrementable<T> : TypeClass
        {
            T dec(T x);        
        }

        public interface Decrementable<H,T> : TypeClass<H>, Decrementable<T>
            where H : Decrementable<H,T>, new()
        {

        }

        public interface Incrementable<T> : TypeClass
        {
            T inc(T x);        
        }

        public interface Incrementable<H,T> : TypeClass<H>, Incrementable<T>
            where H : Incrementable<H,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a type that realizes both incrementing and decrementing operations
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        public interface Stepwise<T> : Incrementable<T>, Decrementable<T>
        {
            
        }

        /// <summary>
        /// Characterizes a type that realizes both incrementing and decrementing operations
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        public interface Stepwise<H,T> : TypeClass<H>, Stepwise<T>
            where H : Stepwise<H,T>, new()
        {
            
        }

    }

    partial class Struct
    {
        public interface Decrementable<S,T> : Structure<S,T>
            where S : Decrementable<S,T>, new()
        {
            S dec();
        }

        public interface Incrementable<S,T> : Structure<S,T>
            where S : Incrementable<S,T>, new()
        {
            S inc();        
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