//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    partial class Class
    {
        /// <summary>
        /// Characterizes an operation provider for bounded floating point values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<T> : Floating<T>, Finite<T> 
        {

        }

        public interface FiniteFloat<H,T> : TypeClass<H>, Floating<T>
            where H : FiniteFloat<H,T>, new()        
        {

        }
    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a structure for a bounded floating point number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface FiniteFloat<S,T> : Floating<S,T>, Finite<S,T>
            where S : FiniteFloat<S,T>, new()
            where T : new()

        {
        
        
        }


    }


}