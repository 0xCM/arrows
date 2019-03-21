//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {
        public interface Divisive<T> : TypeClass
        {
            T div(T lhs, T rhs);        
        }

        public interface Modular<T> : Divisive<T>, TypeClass
        {
            T mod(T lhs, T rhs);

        }


        public interface EuclideanDiv<T> : Modular<T>
        {    

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);        
        }


    }

    partial class Struct
    {
        public interface Divisive<S,T> : Structure<S,T>
            where S : Divisive<S,T>, new()
        {

            S div(S rhs);        
        }


        public interface Modular<S,T> : Divisive<S,T>
            where S : Modular<S,T>, new()
        {

            S mod(S rhs);

        }

        public interface EuclideanDiv<S,T> : Divisive<S,T>
            where S : EuclideanDiv<S,T>, new()
        {
            S gcd(S rhs);

            Quorem<S> divrem(S rhs);        
        }

    }
}