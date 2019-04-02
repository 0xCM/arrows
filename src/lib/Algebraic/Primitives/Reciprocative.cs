//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        public interface Reciprocative<T>
        {
            /// <summary>
            /// Calculates the multiplicative inverse of a given element
            /// </summary>
            /// <param name="x">The individual for which an inverse will be calculated</param>
            T recip(T x);
            
        }

    }

    partial class Structure
    {
        public interface Reciprocative<S>
        {
            /// <summary>
            /// Calculates the multiplicative inverse of self
            /// </summary>
            S recip();            
        }

        public interface Reciprocative<S,T> : Reciprocative<S>, Structural<S,T>
            where S : Reciprocative<S,T>,new()
        {
            
        }
    }

}