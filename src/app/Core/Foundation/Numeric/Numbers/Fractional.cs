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
        /// <summary>
        /// Characterizes a fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Fractional<T> : Number<T> 
        {
            T ceiling(T x);
            
            T floor(T x);

            
        }

        public interface Fractional<H,T> : TypeClass<H>, Number<T> 
            where H : Fractional<H,T>, new()
        {

            
        }



    }

    partial class Struct
    {

        /// <summary>
        /// Characterizes a bounded, structured type that admits non-whole values
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Fractional<S,T> : Number<S,T> 
            where S : Fractional<S,T>, new()
            where T : new()
        {
            S ceiling();
            
            S floor();   

        }
    }




}