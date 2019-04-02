//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;
    
    partial class Operative
    {
        public interface Semigroup<T> :  Equality<T>
        {
            
        }


        public interface SemigroupA<T> : Semigroup<T>, Additive<T>
        {

        }


        public interface SemigroupM<T> : Semigroup<T>, Multiplicative<T>
        {

        }



    }

    partial class Structure
    {
        
        public interface Semigroup<S> : Equatable<S>
        {

        }

        public interface SemigroupM<S>: Semigroup<S>, Multiplicative<S>
        {

        }            

        public interface SemigroupA<S>: Semigroup<S>, Additive<S>
        {

        }            

        public interface Semigroup<S,T> : Semigroup<S>
            where S : Semigroup<S,T>, new()
        {
            
        }            

        public interface SemigroupA<S,T> : SemigroupA<S>, Semigroup<S,T>, Additive<S,T>
            where S : SemigroupA<S,T>, new()
        {

        }            

        public interface SemigroupM<S,T> : SemigroupM<S>, Semigroup<S,T>, Multiplicative<S,T>
            where S : SemigroupM<S,T>, new()
        {

        }            

    }

    partial class Reify
    {
        public readonly struct SemigroupM<T> : Operative.SemigroupM<T>
            where T : Operative.SemigroupM<T>, new()
        {    
            static readonly Operative.SemigroupM<T> Ops = new T();

            public static SemigroupM<T> Inhabitant = default;
            
            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Ops.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Ops.neq(lhs,rhs);


        }

        public readonly struct SemigroupA<T> : Operative.SemigroupA<T>
            where T : Operative.SemigroupA<T>, new()
        {    
            static readonly Operative.SemigroupA<T> Ops = new T();

            
            [MethodImpl(Inline)]
            public T add(T a, T b) 
                => Ops.add(a,b);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => Ops.neq(lhs,rhs);


        }
    }
}    
