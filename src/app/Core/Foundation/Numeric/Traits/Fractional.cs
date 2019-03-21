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
        /// Characterizes fractional operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Fractional<T> : Number<T> 
        {
            T ceiling(T x);
            
            T floor(T x);

            
        }

        /// <summary>
        /// Characterizes a fractional structure
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