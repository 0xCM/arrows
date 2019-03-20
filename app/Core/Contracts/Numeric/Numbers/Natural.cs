//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    
    partial class Class
    {

        public interface Natural<T> : Integer<T>, Unsigned<T>
        {
            
        }

        public interface Natural<H,T> : TypeClass<H>, Natural<T>
            where H : Natural<H,T>, new()
        {            

        }
    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes a natural number, i.e. one of {0,1,...} subject to the maximum
        /// value of the underlying primitive
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Natural<S,T> : Integer<S,T>, Unsigned<S,T>
            where S : Natural<S,T>, new()
            where T : new()
        {
            
        }

    }
}

