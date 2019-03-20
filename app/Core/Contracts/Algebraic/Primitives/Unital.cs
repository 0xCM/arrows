//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {
        /// <summary>
        /// Characterizes a type for which a multiplicative unit exists
        /// </summary>
        /// <typeparam name="T">The characterized type</typeparam>
        public interface Unital<T> : TypeClass
        {
            /// <summary>
            /// The unital value
            /// </summary>
            T one {get;}
        }

        public interface Unital<H,T> : TypeClass<H>, Unital<T>
            where H : Unital<H,T>, new()
        {

        }

    }

    partial class Struct
    {

        /// <summary>
        /// Characterizes a unital structure, that is, a structure
        /// that defines a unit as a particular instance of itself
        /// </summary>
        /// <typeparam name="T">The unit type</typeparam>
        public interface Unital<S,T> : Structure<S,T>
            where S : Unital<S,T>, new()
        {
            S one {get;}
        }

    }

}