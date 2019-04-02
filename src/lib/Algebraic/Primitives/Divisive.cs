//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {
        public interface Divisive<T>
        {
            T div(T lhs, T rhs);        

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);        

            T mod(T lhs, T rhs);
        }



    }

    partial class Structure
    {
        public interface Divisive<S> 
        {

            S div(S rhs);        

            S gcd(S rhs);

            Quorem<S> divrem(S rhs);        

            S mod(S rhs);
        }

        public interface Divisive<S,T> : Divisive<S>, Structural<S,T>
            where S : Divisive<S,T>, new()
        {

        }


    }
}