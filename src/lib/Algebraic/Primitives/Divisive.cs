//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Traits
    {
        public interface Divisive<T>
        {
            T div(T lhs, T rhs);        

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);        

            T mod(T lhs, T rhs);
        }

        public interface Divisive<S,T> : Structure<S,T>
            where S : Divisive<S,T>, new()
        {

            S div(S rhs);        

            S gcd(S rhs);

            Quorem<S> divrem(S rhs);        

            S mod(S rhs);
        }


        public interface Reciprocative<T>
        {
            /// <summary>
            /// Calculates the multiplicative inverse of a given element
            /// </summary>
            /// <param name="x">The individual for which an inverse will be calculated</param>
            T recip(T x);
            
        }

        public interface Reciprocative<S,T> : Structure<S,T>
            where S : Reciprocative<S,T>,new()
        {
            /// <summary>
            /// Calculates the multiplicative inverse of self
            /// </summary>
            S recip();
            
        }

    }
}