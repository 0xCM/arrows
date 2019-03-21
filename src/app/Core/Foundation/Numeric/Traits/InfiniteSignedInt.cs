//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Core
{

    partial class Traits
    {

        /// <summary>
        /// Characterizes operations over unbounded, signed ingegers: Z
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface InfiniteSignedInt<T> : InfiniteInt<T>, SignedInt<T>
        {

        }

        /// <summary>
        /// Characterizes structure over unbounded signed ingegers: Z
        /// </summary>
        public interface InfiniteSignedInt<S,T> : InfiniteInt<S,T>, SignedInt<S,T>
            where S : InfiniteSignedInt<S,T>, new()
            where T : new()
        {

        }


    }


}