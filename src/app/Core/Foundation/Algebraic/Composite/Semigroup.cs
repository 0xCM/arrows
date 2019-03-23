//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;
    using static Traits;

    partial class Traits
    {
        public interface Semigroup<T> :  BinaryOp<T>, Equatable<T>
        {
            
        }

        public interface Semigroup<S,T> : Equatable<S,T>
            where S : Semigroup<S,T>, new()
        {
            
        }            
        
        public interface SemigroupM<T> : Semigroup<T>, Multiplicative<T>
        {
           Multiplication<T> multiplication {get;} 
        }

        public interface SemigroupM<S,T> : Semigroup<S,T>, Multiplicative<S,T>
                where S : SemigroupM<S,T>, new()
        {

        }            

        public interface SemigroupA<T> : Semigroup<T>, Additive<T>
        {
           Addition<T> addition {get;} 

        }

        public interface SemigroupA<S,T> :  Semigroup<S,T>, Additive<S,T>
            where S : SemigroupA<S,T>, new()
        {

        }            

    }

   partial class Reify
    {
        public readonly struct SemigroupM<T> : Traits.SemigroupM<T>, Singleton<SemigroupM<T>>
            where T : Traits.SemigroupM<T>, new()
        {    
            static readonly Traits.SemigroupM<T> Ops = ops<T,SemigroupM<T>>();

            public static SemigroupM<T> Inhabitant = default;
            
            public SemigroupM<T> inhabitant 
                => Inhabitant;

            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => Ops.mul(lhs,rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs)
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs)
                => Ops.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs) 
                => mul(lhs,rhs);

            public Multiplication<T> multiplication
                => Multiplication.define(this);

        }

        public readonly struct SemigroupA<T> : Traits.SemigroupA<T>, Singleton<SemigroupA<T>>
            where T : Traits.SemigroupA<T>, new()
        {    
            static readonly Traits.SemigroupA<T> Ops = ops<T,SemigroupA<T>>();

            public static SemigroupA<T> Inhabitant = default;
            
            public SemigroupA<T> inhabitant 
                => Inhabitant;

            public Addition<T> addition 
                => Addition.define(this);

            [MethodImpl(Inline)]
            public T add(T a, T b) 
                => Ops.add(a,b);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => Ops.eq(lhs,rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => Ops.neq(lhs,rhs);

            [MethodImpl(Inline)]
            public T apply(T lhs, T rhs) 
                => add(lhs,rhs);

        }

    }    
}