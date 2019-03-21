//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;

    partial class Traits
    {

        /// <summary>
        /// Characterizes a type that supports integer operations
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface Integer<T> 
            : Number<T>, 
              Bitwise<T>,  
              Stepwise<T>,  
              Ordered<T>
        {
            
        }

        /// <summary>
        /// Characterizes a structure over an integral type
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Integer<S,T> 
            : Number<S,T>, 
              SemigroupA<S,T>, 
              SemigroupM<S,T>, 
              Bitwise<S,T>,  
              Stepwise<S,T>, 
              Ordered<S,T>
            where S : Integer<S,T>, new()
        {        
            

        } 
    }
}