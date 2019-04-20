//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        public interface Reciprocative<T> : Unital<T>, Multiplicative<T>
        {
            /// <summary>
            /// Calculates the multiplicative inverse of a given element
            /// </summary>
            /// <param name="x">The individual for which an inverse will be calculated</param>
            T recip(T x);
            
        }

    }

    partial class Structures
    {
        
        /// <summary>
        /// Characterizes a multiplicative and unitial structure S such that
        /// s:S => s * recip(s) = 1
        /// </summary>
        /// <typeparam name="S"></typeparam>
        public interface Reciprocative<S> :  Unital<S>, Multiplicative<S>
            where S : Reciprocative<S>, new()
        {
            /// <summary>
            /// Calculates the structure's multiplicative inverse
            /// </summary>
            S recip();            
        }

    }

}