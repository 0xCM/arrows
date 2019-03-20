//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    
    partial class Class
    {
        /// Characterizes operations over the natural numbers: N
        public interface InfiniteNatural<T> :  Infinite<T>, Integer<T>, Unsigned<T>
            where T : InfiniteNatural<T>, new()
        {
            
        }


    }

    partial class Struct
    {
        /// <summary>
        /// Characterizes structure over the natural numbers: N
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface InfiniteNatural<S,T> : Infinite<S,T>,  Integer<S,T>, Unsigned<S,T>
            where S : InfiniteNatural<S,T>, new()
            where T : new()
        {
            
        }


    }

}
