//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        /// <summary>
        /// Characterizes operations over a nullary type
        /// </summary>
        /// <typeparam name="T">The unit type</typeparam>
        /// <remarks>
        /// It is tempting to subclass Additive here, but there are cases where
        /// it makese sense for something have a zero element and yet not be
        /// additive, e.g. a string can be empty, and they can be added (via concatentation)
        /// but consider the set of singleton/atomic strings over some alphabet. In
        /// this case, there can be no (closed) concatenation operation and yet
        /// the concept of nothingness (the empty string) is still meaningful
        /// </remarks>
        public interface Nullary<T> 
        {
            T zero {get;}


        }


    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes an additve structure S for which there exists a
        /// distinguished element 0:S such that for every s:S, s + 0 = s
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <remarks>
        /// It is tempting to subclass Additive here, but there are cases where
        /// it makese sense for something have a zero element and yet not be
        /// additive, e.g. a string can be empty, and they can be added (via concatentation)
        /// but consider the set of singleton/atomic strings over some alphabet. In
        /// this case, there can be no (closed) concatenation operation and yet
        /// the concept of nothingness (the empty string) is still meaningful
        /// </remarks>
        public interface Nullary<S>
            where S : Nullary<S>, new()
        {
            /// <summary>
            /// Specifies the zero value
            /// </summary>
            S zero {get;}
        
        }


    }

}