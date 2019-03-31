//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        /// <summary>
        /// Characterizes a type for which a multiplicative unit exists
        /// </summary>
        /// <typeparam name="T">The characterized type</typeparam>
        public interface Unital<T>
        {
            /// <summary>
            /// The unital value
            /// </summary>
            T one {get;}
        }


    }

    partial class Structure
    {
        public interface Unital<S>
        {
            S one {get;}
        }

        /// <summary>
        /// Characterizes a unital structure, that is, a structure
        /// that defines a unit as a particular instance of itself
        /// </summary>
        /// <typeparam name="T">The unit type</typeparam>
        public interface Unital<S,T> : Unital<S>, Structural<S,T>
            where S : Unital<S,T>, new()
        {

        }
    }

}