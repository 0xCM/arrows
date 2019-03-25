//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Traits
    {
        /// <summary>
        /// Characterizs operations over a type that has infinitely many refications
        /// </summary>
        /// <typeparam name="T">The type over which operations are defined</typeparam>
        public interface Infinite<T> 
        
        {
            
        }

        /// <summary>
        /// Characterizes a Unbounded structural number
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Infinite<S,T> : Structure<S,T>
            where S : Infinite<S,T>, new()
        {

        }    
    }


}