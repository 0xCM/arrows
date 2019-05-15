//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

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

    public interface ISemigroup<S>
        where S : ISemigroup<S>, new()
    {

    }

    public interface ISemigroupM<S>: ISemigroup<S>, IMultiplicative<S>
        where S : ISemigroupM<S>, new()
    {

    }            

    public interface ISemigroupA<S>: ISemigroup<S>, IAdditive<S>
        where S : ISemigroupA<S>, new()
    {

    }            

    public interface ISemigroup<S,T> : ISemigroup<S>
        where S : ISemigroup<S,T>, new()
    {
        
    }            

    public interface ISemigroupA<S,T> : ISemigroup<S,T>, ISemigroupA<S>,  IAdditive<S>
        where S : ISemigroupA<S,T>, new()
    {

    }            

    public interface ISemigroupM<S,T> : ISemigroupM<S>, ISemigroup<S,T>, IMultiplicative<S,T>
        where S : ISemigroupM<S,T>, new()
    {

    }            

    public interface IImplicitSemigroup<S,T> : 
        INullary<S>, 
        ISemigroup<S>, 
        INullaryOps<T>, 
        ISemigroupOps<T>
    where S : IImplicitSemigroup<S,T>, new()
    where T : struct
    
    {
        IEqualityComparer<T> comparer(Func<T,int> hasher = null);
    }


}    
