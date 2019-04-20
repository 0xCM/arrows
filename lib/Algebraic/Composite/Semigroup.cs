//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;


    /// <summary>
    /// Characterizes a structure which is, by definition,
    /// a reifiable abstraction
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface Structure<S> : Equatable<S>
        where S : Structure<S>, new()
    {


    }    


    partial class Operative
    {

        public interface Semigroup<T>
        {
            /// <summary>
            /// Adjudicates equality between semigroup members
            /// </summary>
            /// <param name="lhs">The first operand</param>
            /// <param name="rhs">The second operand</param>
            bool eq(T lhs, T rhs);

            /// <summary>
            /// Adjudicates negated equality between semigroup members
            /// </summary>
            /// <param name="lhs">The first operand</param>
            /// <param name="rhs">The second operand</param>
            bool neq(T lhs, T rhs);
            
        }


        public interface SemigroupA<T> : Semigroup<T>, Additive<T>
        {

        }


        public interface SemigroupM<T> : Semigroup<T>, Multiplicative<T>
        {

        }



    }

    partial class Structures
    {
        
        public interface Semigroup<S> : Equatable<S>
            where S : Semigroup<S>, new()
        {

        }

        public interface SemigroupM<S>: Semigroup<S>, Multiplicative<S>
            where S : SemigroupM<S>, new()
        {

        }            

        public interface SemigroupA<S>: Semigroup<S>, Additive<S>
            where S : SemigroupA<S>, new()
        {

        }            

        public interface Semigroup<S,T> : Semigroup<S>
            where S : Semigroup<S,T>, new()
        {
            
        }            

        public interface SemigroupA<S,T> : Semigroup<S,T>, SemigroupA<S>,  Additive<S>
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
        public readonly struct Semigroup<T> : Operative.Semigroup<T>
            where T : Structures.Semigroup<T>, new()
        {    

            public static Semigroup<T> Inhabitant = default;
            

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);
        }


        public readonly struct SemigroupM<T> : Operative.SemigroupM<T>
            where T : Structures.SemigroupM<T>, new()
        {    

            public static SemigroupM<T> Inhabitant = default;
            
            [MethodImpl(Inline)]
            public T mul(T lhs, T rhs)
                => lhs.mul(rhs);


            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);

        }

        public readonly struct SemigroupA<T> : Operative.SemigroupA<T>
            where T : Structures.SemigroupA<T>, new()
        {    
            
            [MethodImpl(Inline)]
            public T add(T lhs, T rhs) 
                => lhs.add(rhs);

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);


        }
    }
}    
