//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{

    partial class Class
    {

        public interface Monoid<T> : Semigroup<T>
        {


        }


        public interface MonoidM<T> : Monoid<T>, SemigroupM<T>, Unital<T>
        {

        }


        public interface MonoidA<T> : Monoid<T>, SemigroupA<T>, Nullary<T>
        {
            

        }


    }   

    partial class Struct
    {

        public interface Monoid<S,T> : Semigroup<S,T>
            where S : Monoid<S,T>, new()
        {
            
        }            

        public interface MonoidM<S,T> : Monoid<S,T>, SemigroupM<S,T>
            where S : MonoidM<S,T>, new()
        {

        }            

        public interface MonoidA<S,T> :  Monoid<S,T>, SemigroupA<S,T>
            where S : MonoidA<S,T>, new()
        {

        }            

    }

}