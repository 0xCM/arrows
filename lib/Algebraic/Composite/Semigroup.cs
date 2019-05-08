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


    public interface ISemigroupOps<T>
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


    public interface ISemigroupAOps<T> : ISemigroupOps<T>, IAdditiveOps<T>
    {

    }


    public interface ISemigroupMOps<T> : ISemigroupOps<T>, IMultiplicativeOps<T>
    {

    }



    partial class Structures
    {
        
        public interface ISemigroup<S> : Equatable<S>
            where S : ISemigroup<S>, new()
        {

        }

        public interface SemigroupM<S>: ISemigroup<S>, IMultiplicative<S>
            where S : SemigroupM<S>, new()
        {

        }            

        public interface SemigroupA<S>: ISemigroup<S>, IAdditive<S>
            where S : SemigroupA<S>, new()
        {

        }            

        public interface ISemigroup<S,T> : ISemigroup<S>
            where S : ISemigroup<S,T>, new()
        {
            
        }            

        public interface ISemigroupA<S,T> : ISemigroup<S,T>, SemigroupA<S>,  IAdditive<S>
            where S : ISemigroupA<S,T>, new()
        {

        }            

        public interface ISemigroupM<S,T> : SemigroupM<S>, ISemigroup<S,T>, IMultiplicative<S,T>
            where S : ISemigroupM<S,T>, new()
        {

        }            

    }

    partial class Reify
    {
        public readonly struct Semigroup<T> : ISemigroupOps<T>
            where T : Structures.ISemigroup<T>, new()
        {    

            public static Semigroup<T> Inhabitant = default;
            

            [MethodImpl(Inline)]
            public bool eq(T lhs, T rhs) 
                => lhs.eq(rhs);

            [MethodImpl(Inline)]
            public bool neq(T lhs, T rhs) 
                => lhs.neq(rhs);
        }


        public readonly struct SemigroupM<T> : ISemigroupMOps<T>
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

        public readonly struct SemigroupA<T> : ISemigroupAOps<T>
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
