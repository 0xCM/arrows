//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        /// <summary>
        /// Characterizes a type that defines an additive unit
        /// </summary>
        /// <typeparam name="T">The unit type</typeparam>
        public interface Nullary<T> 
        {
            T zero {get;}

            /// <summary>
            /// Determines whether the source has some value other than 0
            /// </summary>
            bool nonzero(T x);

        }


    }

    partial class Structure
    {
        public interface Nullary<S> 
        {
            /// <summary>
            /// Specifies the zero value
            /// </summary>
            S zero {get;}
        
            /// <summary>
            /// Determines whether the source has some value other than 0
            /// </summary>
            bool nonzero();
        }

        /// <summary>
        /// Characterizes a nullary structure, that is, a structure
        /// that defines a zero that is an instance of itself
        /// </summary>
        /// <typeparam name="T">The unit type</typeparam>
        public interface Nullary<S,T> : Nullary<S>, Structural<S,T>
            where S : Nullary<S,T>, new()
        {

        }

    }

}