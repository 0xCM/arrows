//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        /// <summary>
        /// Characterizes operational reversiblity
        /// </summary>
        /// <typeparam name="T">The type for which a reverse operator is defined</typeparam>
        public interface Reversible<T> 
        
        {
            T reverse(T src);
        }


    }

    partial class Structures
    {

        /// <summary>
        /// Characterizes a reversible structure
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Reversible<S>
            where S : Reversible<S>, new()
        {
            S reverse();
        }    


    }


}