//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    partial class Class
    {
        public interface Semigroup<T> : BinaryOp<T>, Equatable<T>
        {
            
        }

        
        public interface SemigroupM<T> : Semigroup<T>, Multiplicative<T>
        {
           Func<T,T,T> multiplication {get;} 
        }

        public interface SemigroupA<T> : Semigroup<T>, Additive<T>
        {
           Func<T,T,T> addition {get;} 

        }

    }

    partial class Struct
    {

        public interface Semigroup<S,T> : Structure<S,T>,  Equatable<S,T>
            where S : Semigroup<S,T>, new()
        {
            
        }            

        public interface SemigroupM<S,T> : Semigroup<S,T>, Multiplicative<S,T>
                where S : SemigroupM<S,T>, new()
        {

        }            

        public interface SemigroupA<S,T> :  Semigroup<S,T>, Additive<S,T>
            where S : SemigroupA<S,T>, new()
        {

        }            

    }
}