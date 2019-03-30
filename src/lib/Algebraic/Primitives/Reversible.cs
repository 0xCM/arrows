//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Traits
    {
        /// <summary>
        /// Characterizes operational reversiblity
        /// </summary>
        /// <typeparam name="T">The type for which a reverse operator is defined</typeparam>
        public interface Reversible<T> 
        
        {
            T reverse(T src);
        }

        /// <summary>
        /// Characterizes a reversible structure
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface Reversible<S,T> : Reversible<S>
            where S : Reversible<S,T>//, new()
        {
            S reverse();
        }    


    }


}